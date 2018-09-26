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
namespace testfrom
{
    public partial class Form1 : Form
    {
        socket_server ss = new socket_server();
        Sql sq = new Sql();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConSer();
            ConSql();
            btn_hide();
        }
        private void ConSer() {
            ss.lbshow = lbClient;
            ss.tbshow = txtShowData;
            ss.OpenServer(int.Parse(tbPort.Text));
        }
        private void ConSql() {
            sq.server= ConfigAppSettings.GetValue("ip");
            sq.database= ConfigAppSettings.GetValue("data");
            sq.uid= ConfigAppSettings.GetValue("uid");
            sq.pwd= ConfigAppSettings.GetValue("pwd");
            sq.tbshow = txtShowData;
            sq.portname = tbSeri.Text;
            sq.rate = uint.Parse(tbRate.Text);
            sq.table = ConfigAppSettings.GetValue("tbname");
            sq.column = ConfigAppSettings.GetValue("clname");
            sq.defalut = tbDefault.Text;
            sq.OpenListenTable();
        }
        private void btn_hide() {
            if (btnOpen.Enabled)
            {
                btnOpen.Enabled = false;
                btnOpen.Visible = false;
                btnClose.Enabled = true;
                btnClose.Visible = true;
            }
            else {
                btnOpen.Enabled = true;
                btnOpen.Visible = true;
                btnClose.Enabled = false;
                btnClose.Visible = false;
            }            
        }
        protected delegate void UpdateShowText(string str);
        protected void updateControlText(string str)
        {
            this.txtShowData.Text += str;
            return;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ss.CloseServer();
            sq.CloseListenTable();
            lbClient.DataSource = null;
            lbClient.Items.Clear();
            txtShowData.Text = "";
            btn_hide();
        }

        private void tbPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbSeri_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tbRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSqlInfo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["sqlfrom"] == null)
            {
                sqlfrom frmadd = new sqlfrom();
                frmadd.Show();
            }
            else
            {
                Application.OpenForms["sqlfrom"].Show();
            }
        }
    }
}

