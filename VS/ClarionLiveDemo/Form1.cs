using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClarionLiveDemo
{
    
    //This attribute tell the compiler the name of the Control and the Interface of methods that can be
    //passed back to the containing application
    [ProgId("ClarionLiveDemoControl"), ComSourceInterfaces(typeof(IClarionLiveDemo)),
     ClassInterface(ClassInterfaceType.AutoDispatch)]
    public partial class Form1 : UserControl
    {
        //This is the event and delegate declaration of the event we want to post to Clarion
        //See the interface IClarionLiveDemo for the definition of the method
        public event OnSendTextToClarion SendTextToClarion;
        public delegate void OnSendTextToClarion(string TextToSend);


        public Form1()
        {
            InitializeComponent();
        }


        //These two functions (ComRegister and ComUnregister) are important and are needed to get this 
        //to work
        [ComRegisterFunction]
        private static void ComRegister(Type t)
        {
            string keyName = @"CLSID\" + t.GUID.ToString("B");

            using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(keyName, true))
            {
                if (key == null)
                    return;


                if (key.CreateSubKey("Control") != null) key.CreateSubKey("Control").Close();

                using (RegistryKey subkey = key.CreateSubKey("MiscStatus"))
                {
                    if (subkey != null) subkey.SetValue("", "131457");
                }
                using (RegistryKey subkey = key.CreateSubKey("TypeLib"))
                {
                    Guid libid = Marshal.GetTypeLibGuidForAssembly(t.Assembly);
                    if (subkey != null) subkey.SetValue("", libid.ToString("B"));
                }
                using (RegistryKey subkey = key.CreateSubKey("Version"))
                {
                    Version ver = t.Assembly.GetName().Version;
                    string version = string.Format("{0}.{1}", ver.Major, ver.Minor);

                    if (String.Compare(version, "0.0", false) == 0)

                        version = "1.0";
                    if (subkey != null) subkey.SetValue("", version);
                }
            }
        }

        [ComUnregisterFunction]
        private static void ComUnregister(Type t)
        {
            Registry.ClassesRoot.DeleteSubKeyTree(@"CLSID\" + t.GUID.ToString("B"));
        }

        private void btnSendText_Click(object sender, EventArgs e)
        {
            if (txtToClarion.Text != "")
                SendTextToClarion(txtToClarion.Text);
        }

        private void btnPressForMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Clarion Live");
        }
        public void AddNameToList(string name)
        {
            lstNames.Items.Add(name);
        }
    }
}
