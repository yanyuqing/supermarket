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
        public static int intFalg = 0;//�ؼ�����״̬
        int G_Int_status;  //���湤������ť����״̬
        public int getPan()
        {
            int intFalg1 = 0;

            if (intFalg != 3)
            {
                if (txtEmpName.Text == "")
                {
                    MessageBox.Show("Ա����������Ϊ�գ�", "��ʾ");
                    txtEmpName.Focus();
                    return intFalg1;

                }
                if (txtEmpLoginName.Text == "")
                {
                    MessageBox.Show("��¼���Ʋ���Ϊ�գ�", "��ʾ");
                    return intFalg1;

                }

                if (intFalg != 2)
                {
                    if (txtEmpLoginPwd.Text == "")
                    {
                        MessageBox.Show("��¼���벻��Ϊ�գ�", "��ʾ");
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
                    MessageBox.Show("��������ѡ��Ҫɾ���ļ�¼", "��ʾ");
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
        /// ���ƿؼ�״̬
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
        /// ���ؼ��ָ���ԭʼ״̬
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
            ClearControls();//��տؼ�����
            ControlStatus();//�ؼ�����״̬
            intFalg = 1;//��ӱ�
        }
   

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            intFalg = 2;//�޸ı��

        }

        private void toolrefesh_Click(object sender, EventArgs e)
        {
            ClearControls();//ˢ��
            ControlStatus();
        }

        //��ѯ
        private void txtOK_Click(object sender, EventArgs e)
        {

            string P_Str_selectcondition = this.cbxCondition.Text;
                //Items[this.cbxCondition.SelectedIndex].ToString();
            if (P_Str_selectcondition == null)
            {
                MessageBox.Show("��ѡ���ѯ������");
                return;
            }
            if (this.txtKeyWord.Text == "")
            {
                MessageBox.Show("�����ѯ������");
                return;
            }
            switch (P_Str_selectcondition)
            {
                case "Ա������":
                    tbMenthod.tb_EmpInfoFind(txtKeyWord.Text,1,dataGridView1);
                    break;
                case "Ա���Ա�":
                    tbMenthod.tb_EmpInfoFind(txtKeyWord.Text, 2, dataGridView1);
                    break;
                case "��������":
                    tbMenthod.tb_EmpInfoFind(txtKeyWord.Text, 3, dataGridView1);
                    break;
                case "Ա��ְλ":
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
                        MessageBox.Show("��¼�����ѱ�ռ��!��");
                        txtEmpLoginName.Text = "";
                        txtEmpLoginName.Focus();
                        return;
                    }
                    
                    if (tbMenthod.tb_EmpInfoAdd(EmpClass) == 1)
                    {
                        MessageBox.Show("��ӳɹ�");
                        intFalg = 0;
                        tbMenthod.tb_EmpInfoFind("", 5, dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }
                    else
                    {
                        MessageBox.Show("��ӳ�ʧ��");
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
                        MessageBox.Show("�޸ĳɹ�");
                        intFalg = 0;
                        tbMenthod.tb_EmpInfoFind("", 5, dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }
                    else
                    {
                        MessageBox.Show("�޸ĳ�ʧ��");
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
                        MessageBox.Show("ɾ���ɹ�");
                        intFalg = 0;
                        tbMenthod.tb_EmpInfoFind("", 5, dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }
                    else
                    {
                        MessageBox.Show("ɾ��ʧ��");
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
      
            ControlStatus();//�ؼ�����״̬
            intFalg = 3;//ɾ�����
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


    }
}