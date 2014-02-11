using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ClarionLiveDemo
{
    //This interface tells the compiler that we are defining a dispatch method
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IClarionLiveDemo
    {
        [DispId(301)]   // This id will be received on the clarion side 
        void SendTextToClarion(string TextToSend);
        
    }
}
