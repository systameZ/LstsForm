using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testfrom
{
    public partial class sqlfrom : Form
    {
        public sqlfrom()
        {
            InitializeComponent();
            initInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConfigAppSettings.SetValue("ip",tbSerIp.Text);
            ConfigAppSettings.SetValue("data", tbData.Text);
            ConfigAppSettings.SetValue("uid", tbUid.Text);
            ConfigAppSettings.SetValue("pwd", tbPwd.Text);
            ConfigAppSettings.SetValue("tbname", tbTableName.Text);
            ConfigAppSettings.SetValue("clname", tbCloname.Text);
            MessageBox.Show("配置已保存");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCloname.Text = "";
            tbData.Text = "";
            tbUid.Text = "";
            tbSerIp.Text = "";
            tbTableName.Text = "";
            tbPwd.Text = "";
        }
        private void initInfo() {
           tbSerIp.Text= ConfigAppSettings.GetValue("ip" );
           tbData.Text= ConfigAppSettings.GetValue("data");
           tbUid.Text= ConfigAppSettings.GetValue("uid");
           tbPwd.Text= ConfigAppSettings.GetValue("pwd");
           tbTableName.Text= ConfigAppSettings.GetValue("tbname");
           tbCloname.Text= ConfigAppSettings.GetValue("clname");
        }
    }
}
