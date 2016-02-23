using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Speech.Recognition;

namespace Trexis.House
{
    public class OS
    {
        Boolean isactive = false;
        Boolean ismute = false;
        Boolean islistening = false;
        SpeechRecognitionEngine recognizer;

        String passPhrase = "";

        public OS(String passPhrase)
        {

            this.passPhrase = passPhrase;

            recognizer = new SpeechRecognitionEngine(new CultureInfo("en-ZA"));
            Grammar dictationGrammar = new DictationGrammar();
            recognizer.LoadGrammar(dictationGrammar);

            recognizer.LoadGrammar(GetGrammar("HOUSE_ON", Phrases.HOUSE_ON + " " + passPhrase));
            recognizer.LoadGrammar(GetGrammar("HOUSE_OFF", Phrases.HOUSE_OFF));
            recognizer.LoadGrammar(GetGrammar("HOUSE_LISTEN", Phrases.HOUSE_LISTEN));
            recognizer.LoadGrammar(GetGrammar("HOUSE_STOP_LISTEN", Phrases.HOUSE_STOP_LISTEN));
            recognizer.LoadGrammar(GetGrammar("HOUSE_MUTE", Phrases.HOUSE_MUTE));
            recognizer.LoadGrammar(GetGrammar("HOUSE_UNMUTE", Phrases.HOUSE_UNMUTE));

            recognizer.SetInputToDefaultAudioDevice();

            recognizer.MaxAlternates = 1;

            this.Listen(false);

        }

        private Grammar GetGrammar(String name, String phrase)
        {
            Grammar grammar = new Grammar(new GrammarBuilder(phrase));
            grammar.Name = name;
            return grammar;
        }

        public void Activate(String passPhrase)
        {
            try
            {
                this.passPhrase = passPhrase;

                Speak.Announce(Phrases.SPEAK_PASSPHRASE);

                this.isactive = true;
                Announce(SpeakMessage.HouseActivated);
            }
            catch (Exception ex)
            {
                this.isactive = false;
                throw new Exception("Unable to active House OS", ex);
            }

        }

        public void Deactivate()
        {
            try
            {
                this.isactive = false;
                Announce(SpeakMessage.HouseDeactived);
            }
            catch (Exception ex)
            {
                this.isactive = false;
                throw new Exception("Unable to deactive House OS", ex);
            }
        }

        public void Announce(SpeakMessage speakMessage)
        {
            if (!this.ismute)
            {
                if (speakMessage.Equals(SpeakMessage.HouseActivated)) Speak.AnnounceAsync(Phrases.IS_ACTIVATED);
                if (speakMessage.Equals(SpeakMessage.HouseDeactived)) Speak.AnnounceAsync(Phrases.IS_DEACTIVATED);
                if (speakMessage.Equals(SpeakMessage.HouseUnMuted)) Speak.AnnounceAsync(Phrases.IS_UNMUTE);
                if (speakMessage.Equals(SpeakMessage.HouseListen)) Speak.AnnounceAsync(Phrases.IS_LISTEN);
                if (speakMessage.Equals(SpeakMessage.HouseStopListen)) Speak.AnnounceAsync(Phrases.IS_STOP_LISTEN);
            }
        }

        public void Mute()
        {
            try
            {
                this.ismute = true;
            }
            catch (Exception ex)
            {
                this.ismute = false;
                throw new Exception("Unable to mute House OS", ex);
            }
        }
        public void UnMute()
        {
            try
            {
                this.ismute = false;
                Announce(SpeakMessage.HouseUnMuted);
            }
            catch (Exception ex)
            {
                this.ismute = false;
                throw new Exception("Unable to unmute House OS", ex);
            }
        }

        public void Listen()
        {
            Listen(true);
        }

        public void Listen(Boolean announce)
        {
            try
            {
                if (!this.islistening)
                {
                    recognizer.RecognizeAsync(RecognizeMode.Multiple);
                    recognizer.SpeechRecognized += recognizer_SpeechRecognized;
                    this.islistening = true;
                    if (announce) Announce(SpeakMessage.HouseListen);
                }
                else
                {
                    if (announce) Announce(SpeakMessage.HouseListen);
                }
            }
            catch (Exception ex)
            {
                this.islistening = false;
                throw new Exception("Unable to listen House OS", ex);
            }
        }



        void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Action action = Listener.DetectAction(e.Result);
            switch (action)
            {
                case Action.HouseOn:
                    Activate(this.passPhrase);
                    break;
                case Action.HouseOff:
                    Deactivate();
                    break;
                case Action.HouseListen:
                    Listen();
                    break;
                case Action.HouseStopListen:
                    StopListen();
                    break;
                case Action.HouseMute:
                    Mute();
                    break;
                case Action.HouseUnmute:
                    UnMute();
                    break;
            }
            if (action != Action.None)
            {
                //cancel the bubbel of actions (house on house off trigger both on on)
            }

        }


        public void StopListen()
        {
            try
            {
                recognizer.RecognizeAsyncCancel();

                this.islistening = false;
                Announce(SpeakMessage.HouseStopListen);
            }
            catch (Exception ex)
            {
                this.islistening = false;
                throw new Exception("Unable to not listen House OS", ex);
            }
        }

        public Boolean IsActive
        {
            get { return this.isactive; }
        }
        public Boolean IsMute
        {
            get { return this.ismute; }
        }
        public Boolean IsListening
        {
            get { return this.islistening; }
        }
        public String PassPhrase 
        {
            set { this.passPhrase = value; }
        }
    }
}
