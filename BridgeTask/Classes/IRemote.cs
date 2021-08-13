using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTask.Classes
{
    interface IRemote
    {
        void Power(bool IsEnable);

        void VolumeDown();

        void VolumeUP();

        void ChannelDown();

        void ChannelUp();

        void Mute(bool IsMute);
    }
}
