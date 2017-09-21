using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using CHEXC.GoodMenhod;
namespace CHEXC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tb_EmpInfoMenthod tbEmp = new tb_EmpInfoMenthod();
            if (txtID.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            if (tbEmp.tb_EmpInfoFind(txtID.Text, txtPwd.Text, 2) == 1)
            {
                frmMain frm = new frmMain(txtID.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}