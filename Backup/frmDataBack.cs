using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CHEXC.GoodMenhod;
//��������x
namespace CHEXC
{
    public partial class frmDataBack : Form
    {
        public frmDataBack()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void frmDataBack_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPath.Text != "" && txtName122.Text != "")
                {
                    getSqlConnection geCon = new getSqlConnection();
                    SqlConnection con = geCon.GetCon();

                    string strBacl = "backup database db_CSManage to disk='" + txtPath.Text.Trim() + "\\" + txtName.Text.Trim() + ".bak'";
                    SqlCommand Cmd = new SqlCommand(strBacl, con);
                    if (Cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("���ݱ��ݳɹ���", "��ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("���ݱ���ʧ�ܣ�", "��ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("����д���ݵ���ȷλ�ü��ļ�����", "��ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }// end 
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }

          
        }
    }
}