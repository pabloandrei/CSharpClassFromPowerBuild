using System;
using System.Runtime.InteropServices;


namespace ClassToPowerBuilder
{
    [ComVisible(true)]
    [Guid("d68d32a9-89ff-490e-aa3a-096bfb27b69d")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IServices
    {
        string Method01(string input);
    }
}