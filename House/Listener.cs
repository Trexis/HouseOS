using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;

namespace Trexis.House
{
    internal static class Listener
    {
        internal static Action DetectAction(RecognitionResult result)
        {
            Action action = Action.None;

            if (result.Grammar.Name == "HOUSE_ON")  action = Action.HouseOn;
            if (result.Grammar.Name == "HOUSE_OFF") action = Action.HouseOff;
            if (result.Grammar.Name == "HOUSE_LISTEN") action = Action.HouseListen;
            if (result.Grammar.Name == "HOUSE_STOP_LISTEN") action = Action.HouseStopListen;
            if (result.Grammar.Name == "HOUSE_MUTE") action = Action.HouseMute;
            if (result.Grammar.Name == "HOUSE_UNMUTE") action = Action.HouseUnmute;

            return action;
        }
    }
}
