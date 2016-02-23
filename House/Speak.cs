using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;


namespace Trexis.House
{
    internal static class Speak
    {
        internal static void Announce(String textToSay)
        {
            Prompt prompt = new Prompt(textToSay);
            Announce(prompt);
        }

        internal static void Announce(Prompt prompt)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(prompt);
        }

        internal static void AnnounceAsync(String textToSay)
        {
            Prompt prompt = new Prompt(textToSay);
            AnnounceAsync(prompt);
        }

        internal static void AnnounceAsync(Prompt prompt)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SpeakAsync(prompt);
        }
    }
}
