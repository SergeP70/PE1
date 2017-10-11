using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ensures the PCL has access to this class. Must be defined outside of the namespace
[assembly: Xamarin.Forms.Dependency(typeof(B4.PE1.PilleS.UWP.Services.MessageServiceUWP))]

namespace B4.PE1.PilleS.UWP.Services
{
    public class MessageServiceUWP : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "UWP!";
        }
    }
}
