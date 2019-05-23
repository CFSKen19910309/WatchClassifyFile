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

namespace WatchClassifyFile
{
    public partial class InputIMEIForm : System.Windows.Forms.Form
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        public InputIMEIForm()
        {
            InitializeComponent();
            SetForegroundWindow(this.Handle);
            TextBox_IEMI.Focus();
            this.TopMost = true;
            this.TopLevel = true;
            this.Activate();
        }

        public string m_IMEI { get; set; }
       

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if(TextBox_IEMI.Text.Length != 4 )
            {
                return;
            }
            m_IMEI = TextBox_IEMI.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void TextBox_IEMI_KeyDown(object sender, KeyEventArgs e)
        {

            
            if(e.KeyData == Keys.Enter)
            {
                Button_OK_Click(sender, e);
            }
        }
    }
}
