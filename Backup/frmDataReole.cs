using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CHEXC.GoodMenhod;
namespace CHEXC
{
    public partial class frmDataReole : Form
    {
        public frmDataReole()
        {
            InitializeComponent();
        }

        private void bntOpent_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "txt files (*.bak)|*.bak|All files (*.*)|*.*";


            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textPaht.Text=openFileDialog1.FileName.ToString();
            }

        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            if (textPaht.Text != "")
            {
                getSqlConnection geCon = new getSqlConnection();
                SqlConnection con = geCon.GetCon();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                string DateStr = "Data Source=a\\a;Database=master;User id=sa;PWD=";
                SqlConnection conn = new SqlConnection(DateStr);
                conn.Open();

                //-------------------杀掉所有连接 db_CSManage 数据库的进程--------------
                string strSQL = "select spid from master..sysprocesses where dbid=db_id( 'db_CSManage') ";
                SqlDataAdapter Da = new SqlDataAdapter(strSQL, conn);

                DataTable spidTable = new DataTable();
                Da.Fill(spidTable);

                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.Connection = conn;

                for (int iRow = 0; iRow <= spidTable.Rows.Count - 1; iRow++)
                {
                    Cmd.CommandText = "kill " + spidTable.Rows[iRow][0].ToString();   //强行关闭用户进程 
                    Cmd.ExecuteNonQuery();
                }
                conn.Close();
                conn.Dispose();
                //--------------------------------------------------------------------

                SqlConnection sqlcon = new SqlConnection(DateStr);
                sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("backup log db_CSManage to disk='" + textPaht.Text.Trim() + "' restore database db_CSManage from disk='" + textPaht.Text.Trim() + "'", sqlcon);
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
                MessageBox.Show("数据还原成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("为了必免数据丢失，在数据库还原后将关闭整个系统。");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("请选择备份文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void frmDataReole_Load(object sender, EventArgs e)
        {

        }
    }
}