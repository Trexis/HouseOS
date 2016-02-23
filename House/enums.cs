using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trexis.House
{
    public enum SpeakMessage
    {
        HouseActivated,
        HouseDeactived,
        HouseMute,
        HouseUnMuted,
        HouseListen,
        HouseStopListen
    }

    public enum Action
    {
        None,
        HouseOn,
        HouseOff,
        HouseMute,
        HouseUnmute,
        HouseListen,
        HouseStopListen
    }
}
