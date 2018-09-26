using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testfrom
{
    class Sql
    {
        public string server;
        public string database;
        public string uid;
        public string pwd;
        public string table;
        public string column;
        public string defalut;
        public string portname;
        public uint rate;
        public TextBox tbshow;
        public int ExecuteSql(string sql)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(String.Format("server={0};database={1};uid={2};pwd={3}", server, database, uid, pwd)))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        count = cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            return count;
        }
        private bool openflag = false;
        protected delegate void UpdateShowText(string str);
        protected  void updateControlText(string str)
        {
            this.tbshow.Text += str;
            return;
        }
        public  object Query(string sqlcmd, int ret_mode)
        {
            SqlConnection conn = new SqlConnection(String.Format("server={0};database={1};uid={2};pwd={3}", server, database, uid, pwd));
            SqlCommand cmd = new SqlCommand(sqlcmd, conn);
                
                    try
                    {
                        conn.Open();
                        if (ret_mode > 0)
                        {
                        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                            return dr;
                        }
                        else
                        {
                            SqlDataAdapter da = new SqlDataAdapter(sqlcmd, conn);
                            DataSet ds = new DataSet();
                            da.Fill(ds);
                            return ds;
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("数据库错误：请配置数据库");
                        return null;
                    }
                
                    
            
                

        }
        public void OpenListenTable() {
            openflag = true;
            Thread Thread_ServerListen = new Thread(ListenTable);
            Thread_ServerListen.IsBackground = true;
            Thread_ServerListen.Start();
        }
        private void ListenTable() {
            while(openflag){
                SqlDataReader dr = (SqlDataReader)Query(string.Format("select {0} from {1}",column,table),1);
                if (dr != null)
                {
                    if (dr.HasRows)
                    {
                        dr.Read();
                        if (dr[column].ToString() != defalut)
                        {
                            SendChange(dr[column].ToString());
                        }
                        dr.Close();
                    }
                }
                else {
                    break;
                }
                
                Thread.Sleep(200);
            }
            Thread.CurrentThread.Abort();
        }
        private void SendChange(string str) {
            UpdateShowText up = new UpdateShowText(updateControlText);
            StringBuilder pn = new StringBuilder(portname);
            StringBuilder comstr = new StringBuilder(str);
            if (indll.COM_Send(pn, rate, comstr)==0) {
                if (ExecuteSql(string.Format("update {0} set {1}={2}", table, column, defalut)) > 0) {
                    tbshow.Invoke(up,String.Format("数据改变为{0}后被发送到{1}\r\n",str,portname));
                }
            }

        }
        public void CloseListenTable()
        {
            openflag = false;
        }
    }
}
