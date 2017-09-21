using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using CHEXC.ClassInfo;
using System.Windows.Forms;
namespace CHEXC.GoodMenhod
{
   public class tb_SellGoodsMenthod
    {


        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;

       #region 添加
       public int tb_SellGoodsAdd(tb_SellGoods tbChGood)
       {
           int intFalg = 0;
           try
           {
               string str_Add = "insert into tb_SellGoods values( ";
               str_Add+="'"+tbChGood.strSellID+"','"+tbChGood.strKcID+"','"+tbChGood.strGoodsID+"',";
               str_Add+="'"+tbChGood.strEmpId+"','"+tbChGood.strGoodsName+"',"+tbChGood.strSellGoodsNum+",";
               str_Add+="'"+tbChGood.daSellGoodsTime+"',"+tbChGood.deSellPrice+",";
               str_Add += "" + tbChGood.deSellNeedPay + "," + tbChGood.deSellHasPay + ",'" + tbChGood.strSellRemark + "'," + tbChGood.intSellFalg + ")";
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(str_Add, conn);
               intFalg = cmd.ExecuteNonQuery();
               conn.Dispose();
               return intFalg;
           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.ToString());
               return intFalg;

           }

       }
       #endregion
       #region 修改
       public int tb_SellGoodsUpdate(tb_SellGoods tbChGood)
       {
           int intFalg = 0;
           try
           {
               string str_Add = "update tb_SellGoods set ";
               str_Add += "KcID='" + tbChGood.strKcID + "',GoodsID='" + tbChGood.strGoodsID + "',";
               str_Add += "EmpId='" + tbChGood.strEmpId + "',GoodsName='" + tbChGood.strGoodsName + "',SellGoodsNum=" + tbChGood.strSellGoodsNum + ",";
               str_Add += "SellGoodsTime='" + tbChGood.daSellGoodsTime + "',SellPrice=" + tbChGood.deSellPrice + ",";
               str_Add += "SellNeedPay=" + tbChGood.deSellNeedPay + ",SellHasPay=" + tbChGood.deSellHasPay + ",SellRemark='" + tbChGood.strSellRemark + "',SellFalg=" + tbChGood.intSellFalg + "";
               str_Add += " where  SellID= '" + tbChGood.strSellID + "'";
               
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(str_Add, conn);
               intFalg = cmd.ExecuteNonQuery();
               conn.Dispose();
               return intFalg;
           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.ToString());
               return intFalg;

           }

       }
              #endregion
       #region 删除
       public int tb_SellGoodsDelete(tb_SellGoods tbChGood)
       {
           int intFalg = 0;
           try
           {
               string str_Add = "update tb_SellGoods set ";
       
               str_Add += "SellFalg=" + tbChGood.intSellFalg + "";
               str_Add += " where  SellID= '" + tbChGood.strSellID + "'";

               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(str_Add, conn);
               intFalg = cmd.ExecuteNonQuery();
               conn.Dispose();
               return intFalg;
           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.ToString());
               return intFalg;

           }

       }
              #endregion

       #region 查询
       public void tb_SellGoodsFind(Object DataObject)
       {
           int intCount = 0;
           string strSecar = null;

           try
           {

               strSecar = "select * from tb_SellGoods  where SellFalg=0";

               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(strSecar, conn);
               int ii = 0;
               qlddr = cmd.ExecuteReader();
               while (qlddr.Read())
               {
                   ii++;
               }
               qlddr.Close();


               System.Windows.Forms.DataGridView dv = (DataGridView)DataObject;

               if (ii != 0)
               {
                   int i = 0;
                   dv.RowCount = ii;
                   qlddr = cmd.ExecuteReader();
                   while (qlddr.Read())
                   {
                       dv[0, i].Value = qlddr[0].ToString();
                       dv[1, i].Value = qlddr[4].ToString();
                       dv[2, i].Value = qlddr[7].ToString();
                       dv[3, i].Value = qlddr[5].ToString();
                       dv[4, i].Value = qlddr[3].ToString();
                       dv[5, i].Value = qlddr[6].ToString();
                       i++;

                   }
                   qlddr.Close();
               }
               else
               {
                   if (dv.RowCount != 0)
                   {
                       int i = 0;
                       do
                       {
                           dv[0, i].Value = "";
                           dv[1, i].Value = "";
                           dv[2, i].Value = "";
                           dv[3, i].Value = "";
                           dv[4, i].Value = "";
                           dv[5, i].Value = "";
                           i++;
                       } while (i < dv.RowCount);
                   }
               }




           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.ToString());

           }

       }
       #endregion
       #region 查询
       public SqlDataReader dtb_SellGoodsFind(string DataObject)
       {
         
           string strSecar = null;

           try
           {

               strSecar = "select * from tb_SellGoods where SellID='"+DataObject+"'";

               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(strSecar, conn);
      
               qlddr = cmd.ExecuteReader();
               return qlddr;

           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.ToString());
               return qlddr;

           }

       }
              #endregion
       public string getSellID()
       {
           int intYear = DateTime.Now.Day;
           int intMonth = DateTime.Now.Month;
           int intDate = DateTime.Now.Year;
           int intHour = DateTime.Now.Hour;
           int intSecond = DateTime.Now.Second;
           int intMinute = DateTime.Now.Minute;
           string strTime = null;
           strTime = intYear.ToString();
           if (intMonth < 10)
           {
               strTime += "0" + intMonth.ToString();
           }
           else
           {
               strTime += intMonth.ToString();
           }
           if (intDate < 10)
           {
               strTime += "0" + intDate.ToString();
           }
           else
           {
               strTime += intDate.ToString();
           }
           if (intHour < 10)
           {
               strTime += "0" + intHour.ToString();
           }
           else
           {
               strTime += intHour.ToString();
           }
           if (intMinute < 10)
           {

               strTime += "0" + intMinute.ToString();
           }
           else
           {
               strTime += intMinute.ToString();
           }
           if (intSecond < 10)
           {

               strTime += "0" + intSecond.ToString();
           }
           else
           {
               strTime += intSecond.ToString();
           }


           return ("XS-" + strTime);

       }
       #region //填冲商品类别信息 TrreView控件
       public void filltProd(object objTreeView, object obimage)
       {
           try
           {
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               string strSecar = "select * from tb_JhGoodsInfo where Falg=0";
               cmd = new SqlCommand(strSecar, conn);
               qlddr = cmd.ExecuteReader();

               if (objTreeView.GetType().ToString() == "System.Windows.Forms.TreeView")
               {
                   System.Windows.Forms.ImageList imlist = (System.Windows.Forms.ImageList)obimage;

                   System.Windows.Forms.TreeView TV = (System.Windows.Forms.TreeView)objTreeView;
                   TV.Nodes.Clear();

                   TV.ImageList = imlist;
                   System.Windows.Forms.TreeNode TN = TV.Nodes.Add("A","商品名称", 0, 1);
            
                   while (qlddr.Read())
                   {
                       TreeNode newNode12 = new TreeNode(qlddr[0].ToString(), 0, 1);
                       newNode12.Nodes.Add("A",qlddr[4].ToString(), 0, 1);
                       TN.Nodes.Add(newNode12);
   
                   }


                   
              
                   qlddr.Close();
                   TV.ExpandAll();
               }
           }//
           catch (Exception ee)
           {
               MessageBox.Show(ee.ToString());
           }

       }// end fi
       #endregion 
       public string fillfrmKcGoods(string strID)
       {
           string SID = "";
           try
           {

               string strSecar = "select kcid from tb_KcGoods  where GoodsID ='" + strID + "'";

               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               cmd = new SqlCommand(strSecar, conn);
               qlddr = cmd.ExecuteReader();
               qlddr.Read();
               if (qlddr.HasRows)
               {
                   SID = qlddr[0].ToString();
               }
               qlddr.Close();
               return SID;
           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.Message.ToString());
               return SID;
           }
       }
    }
}
