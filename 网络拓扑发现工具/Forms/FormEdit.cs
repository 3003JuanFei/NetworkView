using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 网络拓扑发现工具.Forms
{
    public partial class FormEdit : Form
    {

        public FormEdit(string mac, string devicetypename, string pchostname)
        {
            InitializeComponent();

            txt_mac.Text = mac;
            txt_devicetype.Text = devicetypename;
            txt_hostname.Text = pchostname;
        }

        public delegate void SaveCallBack(string mac,string devicetypename,string pchostname);
        public SaveCallBack saveCallBack;
        private void btn_save_Click(object sender, EventArgs e)
        {
            saveCallBack(txt_mac.Text,txt_devicetype.Text,txt_hostname.Text);
            this.Close();
        }
    }
}
