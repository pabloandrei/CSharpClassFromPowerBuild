using System;
using System.Runtime.InteropServices;

namespace ClassToPowerBuilder
{
    public class Services: IServices
    {
        public string Method01(string input)
        {
            return "Pong:"+input;
        }
    }
}
