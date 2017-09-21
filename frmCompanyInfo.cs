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
    public partial class frmCompanyInfo : Form
    {
        public frmCompanyInfo()
        {
            InitializeComponent();
        }
        public frmCompanyInfo(int intResult)
        {
            InitializeComponent();
            intReturn = intResult;
        }
        public static int intReturn = 0;
        tb_Company Company = new tb_Company();
        tb_CompanyMenthod CompanyMenthod = new tb_CompanyMenthod();
        tb_JhGoodsInfoMenthod jhgood = new tb_JhGoodsInfoMenthod();
        public static int intFalg =0;
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.toolrefesh.Enabled = !this.toolrefesh.Enabled;
        }

        /// <summary>
        /// ���ؼ��ָ���ԭʼ״̬
        /// </summary>
        private void ClearControls()
        {

            txtCompanyDirector.Text = "";
            txtCompanyAddress.Text = "";
            txtCompanyFax.Text = "";
            txtCompanyName.Text = "";
            txtCompanyPhone.Text = "";
            txtCompanyRemark.Text = "";
           
        }

        /// ���ƿؼ�״̬
        /// </summary>

        public int GetCount()
        {
            int intReslult = 0;
            if (intFalg == 1 || intFalg == 2)
            {
                if (txtCompanyName.Text == "")
                {
                    MessageBox.Show("��Ӧ�����Ʋ���Ϊ�գ�", "��ʾ");
                    return intReslult;
                }
                if (txtCompanyPhone.Text == "")
                {
                    MessageBox.Show("��ϵ�绰����Ϊ�գ�", "��ʾ");
                    return intReslult;
                }
                if (txtCompanyDirector.Text == "")
                {
                    MessageBox.Show("��ַ����Ϊ�գ�", "��ʾ");
                    return intReslult;
                }
                if (intFalg != 2)
                {
                    Company.intCompanyID = CompanyMenthod.tb_CustomerID();
                }
                else
                {
                    Company.intCompanyID = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString();
                }
                Company.intEmpFalg = 0;
                Company.strCompanyAddress = txtCompanyAddress.Text;
                Company.strCompanyDirector = txtCompanyDirector.Text;
                Company.strCompanyFax = txtCompanyFax.Text;
                Company.strCompanyName = txtCompanyName.Text;
                Company.strCompanyPhone = txtCompanyPhone.Text;
                Company.strCompanyRemark = txtCompanyRemark.Text;
                Company.daReDateTime = DateTime.Now;
            }
            if (intFalg == 3)
            {
                if (txtCompanyName.Text == "")
                {
                    MessageBox.Show("��Ӧ�����Ʋ���Ϊ�գ���ѡ��Ҫɾ���ĵļ�¼", "��ʾ");
                    return intReslult;
                }
                Company.intEmpFalg =1;
                Company.intCompanyID = this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString();
            
            }
     
            intReslult=1;
            return intReslult;
        
        }

        private void frmCompanyInfo_Load(object sender, EventArgs e)
        {
            CompanyMenthod.tb_CompanyFind("", 3, dataGridView1);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (GetCount() == 1)
            {
                if (intFalg == 1)
                {
                    if (CompanyMenthod.tb_CompanyMenthodAdd(Company) == 1)
                    {
                        if (intReturn == 1)
                        {
                            frmGonYingShang frmCop= (frmGonYingShang)this.Owner;
                            jhgood.filltProd(frmCop.treeView1,frmCop.imageList1);
                            ClearControls();
                            ControlStatus();
                            intFalg = 0;
                            this.Close();
                            
                        
                        }
                        MessageBox.Show("��ӳɹ�");
                        intFalg = 0;
                        CompanyMenthod.tb_CompanyFind("", 3, dataGridView1);
                        ClearControls();
                        ControlStatus();
                        
                    }
                    else
                    {
                        MessageBox.Show("���ʧ��");
                        intFalg = 0;
                        CompanyMenthod.tb_CompanyFind("", 3, dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }

                }
                if (intFalg == 2)
                {
                    if (CompanyMenthod.tb_CompanyMenthodUpDate(Company) == 1)
                    {
                        MessageBox.Show("�޸ĳɹ�");
                        intFalg = 0;
                        CompanyMenthod.tb_CompanyFind("", 3, dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }
                    else
                    {
                        MessageBox.Show("�޸�ʧ��");
                        intFalg = 0;
                        CompanyMenthod.tb_CompanyFind("", 3, dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }

                }
                if (intFalg ==3)
                {
                    if (CompanyMenthod.tb_CompanyMenthodDelete(Company) == 1)
                    {
                        MessageBox.Show("ɾ���ɹ�");
                        intFalg = 0;
                        CompanyMenthod.tb_CompanyFind("", 3, dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }
                    else
                    {
                        MessageBox.Show("ɾ��ʧ��");
                        intFalg = 0;
                        CompanyMenthod.tb_CompanyFind("", 3, dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }

                }


            }//
        }
        private void FillControls()
        {
            try
            {
                SqlDataReader sqldr = CompanyMenthod.tb_CompanyFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString());

                sqldr.Read();
                if (sqldr.HasRows)
                {
                    txtCompanyName.Text = sqldr[1].ToString();
                    txtCompanyDirector.Text = sqldr[2].ToString();
                    txtCompanyPhone.Text = sqldr[3].ToString();
                    txtCompanyFax.Text = sqldr[4].ToString();
                    txtCompanyAddress.Text = sqldr[5].ToString();
                    txtCompanyRemark.Text = sqldr[6].ToString();

                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }
   
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
           ClearControls();
           ControlStatus();
            intFalg = 0;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            intFalg = 1;//��ӱ��
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            intFalg = 2;//�޸ļӱ��
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtOK_Click(object sender, EventArgs e)
        {

            string P_Str_cmdtxt = String.Empty;
            string P_Str_selectcondition = this.cbxCondition.Text;
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
                case "��Ӧ������":
                    CompanyMenthod.tb_CompanyFind(txtKeyWord.Text,1,dataGridView1);
                    break;
                case "����������":
                    CompanyMenthod.tb_CompanyFind(txtKeyWord.Text, 2, dataGridView1);
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (intFalg == 2 || intFalg == 3)
            {
                FillControls();
            }
        }

        private void toolrefesh_Click(object sender, EventArgs e)
        {
            ControlStatus();
            intFalg = 3;//�޸ļӱ��
        }
    }
}