using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(Object sender, EventArgs e)
        {
            ShowMessage(
                Handle,
                "Hello from MessageBox function",
                "Hello",
                MBType.MB_ABORTRETRYIGNORE);
        }

        [Flags]
        private enum MBType : uint
        {
            MB_ABORTRETRYIGNORE = 0x00000002,
            MB_YESNO = 0x00000004
        }

        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        private static extern Int32 ShowMessage(
            IntPtr hWnd,
            string lpText,
            string lpCaption,
            MBType uType);

    }
}
