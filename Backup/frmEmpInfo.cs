using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHEXC.ClassInfo;
using CHEXC.GoodMenhod;
using System.Data.SqlClient;
namespace CHEXC
{
    public partial class frmEmpInfo : Form
    {
        public frmEmpInfo()
        {
            InitializeComponent();
        }
        tb_EmpInfo EmpClass = new tb_EmpInfo();
        tb_EmpInfoMenthod tbMenthod = new tb_EmpInfoMenthod();
        public static int intFalg = 0;//控件方法状态
        int G_Int_status;  //保存工具栏按钮操作状态
        public int getPan()
        {
            int intFalg1 = 0;

            if (intFalg != 3)
            {
                if (txtEmpName.Text == "")
                {
                    MessageBox.Show("员工姓名不能为空！", "提示");
                    txtEmpName.Focus();
                    return intFalg1;

                }
                if (txtEmpLoginName.Text == "")
                {
                    MessageBox.Show("登录名称不能为空！", "提示");
                    return intFalg1;

                }

                if (intFalg != 2)
                {
                    if (txtEmpLoginPwd.Text == "")
                    {
                        MessageBox.Show("登录密码不能为空！", "提示");
                        return intFalg1;

                    }
                }
                if (intFalg == 2)
                {
                    EmpClass.intEmpId = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString();
                }
                else
                {
                    EmpClass.intEmpId = tbMenthod.tb_EmpInfoID();
                }
            }
            else
            {
                if (txtEmpName.Text == "")
                {
                    MessageBox.Show("请在下面选择要删除的记录", "提示");
                    return intFalg1;

                }
                else
                {
                    EmpClass.intEmpId = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString(); EmpClass.intEmpId = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString();
                }
                
            
            }
            
        


            EmpClass.strEmpName = txtEmpName.Text;
            EmpClass.strEmpLoginName = txtEmpLoginName.Text;
            EmpClass.strEmpLoginPwd = txtEmpLoginPwd.Text;
            EmpClass.intEmpSex = comboBox2.Text;
            EmpClass.daEmpBirthday = daEmpBirthday.Value;
            EmpClass.strEmpDept = cmbEmpDept.Text;
            EmpClass.strEmpPost = cmbEmpPost.Text;
            EmpClass.strEmpPhone = txtEmpPhone.Text;
            EmpClass.strEmpPhoneM = txtEmpPhoneM.Text;
            EmpClass.strEmpAddress = txtEmpAddress.Text;
            if(intFalg!=3)
            {
            EmpClass.intEmpFalg = 0;
            }else
            {
            EmpClass.intEmpFalg = 1;
            }
            intFalg1 = 1;
            return intFalg1;
        
        }
        /// <summary>
        /// 控制控件状态
        /// </summary>
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.toolDelete.Enabled = !this.toolDelete.Enabled;
        }

        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {

            txtEmpAddress.Text = "";
            txtEmpLoginName.Text = "";
            txtEmpLoginPwd.Text = "";
            txtEmpName.Text = "";
            txtEmpPhone.Text = "";
            txtEmpPhoneM.Text = "";
            cmbEmpDept.SelectedIndex = 0;
            cmbEmpPost.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            this.daEmpBirthday.Value = DateTime.Now;
        }

        private void frmEmpInfo_Load(object sender, EventArgs e)
        {
            tbMenthod.tb_EmpInfoFind("",5,dataGridView1);
      
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ClearControls();//清空控件内容
            ControlStatus();//控件控年状态
            intFalg = 1;//添加标
        }
   

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            intFalg = 2;//修改标记

        }

        private void toolrefesh_Click(object sender, EventArgs e)
        {
            ClearControls();//刷新
            ControlStatus();
        }

        //查询
        private void txtOK_Click(object sender, EventArgs e)
        {

            string P_Str_selectcondition = this.cbxCondition.Text;
                //Items[this.cbxCondition.SelectedIndex].ToString();
            if (P_Str_selectcondition == null)
            {
                MessageBox.Show("请选择查询条件！");
                return;
            }
            if (this.txtKeyWord.Text == "")
            {
                MessageBox.Show("输入查询条件！");
                return;
            }
            switch (P_Str_selectcondition)
            {
                case "员工姓名":
                    tbMenthod.tb_EmpInfoFind(txtKeyWord.Text,1,dataGridView1);
                    break;
                case "员工性别":
                    tbMenthod.tb_EmpInfoFind(txtKeyWord.Text, 2, dataGridView1);
                    break;
                case "所属部门":
                    tbMenthod.tb_EmpInfoFind(txtKeyWord.Text, 3, dataGridView1);
                    break;
                case "员工职位":
                    tbMenthod.tb_EmpInfoFind(txtKeyWord.Text, 4, dataGridView1);
                    break;
                default:
                    break;
            }

        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (getPan() == 1)
            {

                if (intFalg == 1)
                {
                    if (tbMenthod.tb_EmpInfoFind(txtEmpLoginName.Text,"",1) == 1)
                    {
                        MessageBox.Show("登录名称已被占用!！");
                        txtEmpLoginName.Text = "";
                        txtEmpLoginName.Focus();
                        return;
                    }
                    
                    if (tbMenthod.tb_EmpInfoAdd(EmpClass) == 1)
                    {
                        MessageBox.Show("添加成功");
                        intFalg = 0;
                        tbMenthod.tb_EmpInfoFind("", 5, dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }
                    else
                    {
                        MessageBox.Show("添加成失败");
                        intFalg = 0;
                        //tbMenthod.tb_EmpInfoFind("2",dataGridView1);
                        ClearControls();
                        ControlStatus();
                        
                    }
                
                }
                if (intFalg == 2)
                {
                    if (tbMenthod.tb_EmpInfoUpdate(EmpClass)==1)
                    {
                        MessageBox.Show("修改成功");
                        intFalg = 0;
                        tbMenthod.tb_EmpInfoFind("", 5, dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }
                    else
                    {
                        MessageBox.Show("修改成失败");
                        intFalg = 0;
                        //tbMenthod.tb_EmpInfoFind("2",dataGridView1);
                        ClearControls();
                        ControlStatus();

                    }
                
                }
                if (intFalg == 3)
                {
                    if (tbMenthod.tb_EmpInfoDelete(EmpClass) == 1)
                    {
                        MessageBox.Show("删除成功");
                        intFalg = 0;
                        tbMenthod.tb_EmpInfoFind("", 5, dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                        intFalg = 0;
                        ClearControls();
                        ControlStatus();



                    }
                }
            
            }//end

        }
        private void FillControls()
        {
            try
            {
                SqlDataReader sqldr = tbMenthod.tb_EmpInfoFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString(),1);
                sqldr.Read();
                if (sqldr.HasRows)
                {
                    txtEmpLoginName.Text = sqldr[2].ToString();
                    txtEmpName.Text = sqldr[1].ToString();
                    comboBox2.Text =sqldr[4].ToString();
                    daEmpBirthday.Value = Convert.ToDateTime(sqldr[5].ToString());
                    cmbEmpDept.Text =sqldr[6].ToString();
                    cmbEmpPost.Text = sqldr[7].ToString();
                    txtEmpPhone.Text = sqldr[8].ToString();
                    txtEmpPhoneM.Text = sqldr[9].ToString();
                    txtEmpAddress.Text = sqldr[10].ToString();

                
                }


            }
            catch(Exception ee) 
            {
                MessageBox.Show(ee.ToString());
            
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (intFalg == 2 || intFalg == 3)
            {
                FillControls();
            }
      
            
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
      
            ControlStatus();//控件控年状态
            intFalg = 3;//删除标记
        }


    }
}