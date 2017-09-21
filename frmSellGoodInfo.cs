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
    public partial class frmSellGoodInfo : Form
    {
        public frmSellGoodInfo()
        {
            InitializeComponent();
        }

        tb_ThGoodsMenthod tbthGood = new tb_ThGoodsMenthod();
        private void frmSellGoodInfo_Load(object sender, EventArgs e)
        {

            tbthGood.filltProd(treeView1,imageList1);
        
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text != "商品销售信息")
            {
                if (treeView1.SelectedNode.Parent.Text == "商品销售信息")
                {
                
                    frmThGoodsInfo frmth=(frmThGoodsInfo)this.Owner;
                    tb_SellGoodsMenthod tbsell=new tb_SellGoodsMenthod();
                    SqlDataReader dr = tbsell.dtb_SellGoodsFind(treeView1.SelectedNode.Text);
                    dr.Read();
                    if (dr.HasRows)
                    {

                        frmth.txtSellID.Text = dr[0].ToString();
                        frmth.txtThGoodsName.Text = dr[4].ToString();
                        frmth.goodid = dr[2].ToString();
                        frmth.Kcid = dr[1].ToString();

                        frmth.txtDataTime.Text=dr[6].ToString();
                        frmth.txtPrice.Text = dr[7].ToString();
                        frmth.txtnum.Text = Convert.ToInt32(dr[5].ToString()).ToString();
                         this.Close();
                    
                    }
                    dr.Close();



                }
                else
                {
                    MessageBox.Show("选择商品销售编号！");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}