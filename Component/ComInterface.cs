using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace Component
{
    [Guid("46314565-AEAD-4A98-A6F7-36B021447A15")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface iInterface
    {
        [DispId(1)]
        void DisplayBrowser();
    }

    [Guid("46314565-AEAD-4A98-A6F7-36B021447A15")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("ComInterface")]
    public class ComInterface : iInterface
    {
        public void DisplayBrowser()
        {
            Form1 form= new Form1();
            form.ShowDialog();
        }
    }
}
