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
    public partial class frmFindGood : Form
    {
        public frmFindGood()
        {
            InitializeComponent();
        }


        tb_JhGoodsInfoMenthod jhMenthod=new tb_JhGoodsInfoMenthod();

        private void button1_Click(object sender, EventArgs e)
        {
                    if(comboBox1.Text=="")
                    {
                        MessageBox.Show("��ѡ���ѯ������");
                        return;
                    }
                    if(comboBox1.Text!=""&&comboBox1.Text!="��ѯ������Ϣ"&& textBox1.Text=="")
                    {
                        MessageBox.Show("����������Ϣ");
                        return;
                    }
                    switch (comboBox1.Text)
                    {
                        case "��Ʒ���"://"��Ʒ���":
                            jhMenthod.tb_JhGoodsInfoFind(textBox1.Text,1,dataGridView1);
                            comboBox1.SelectedIndex = 0;
                            break;
                        case "��Ʒ����"://��Ʒ����"
                            jhMenthod.tb_JhGoodsInfoFind(textBox1.Text, 2, dataGridView1);
                            comboBox1.SelectedIndex = 0;
                            break;
                        case "��ѯ������Ϣ"://"������Ϣ":
                            jhMenthod.tb_JhGoodsInfoFind(textBox1.Text, 5, dataGridView1);
                            comboBox1.SelectedIndex = 0;
                            break;
                    }
        }

        private void frmFindGood_Load(object sender, EventArgs e)
        {

        }
    }
}