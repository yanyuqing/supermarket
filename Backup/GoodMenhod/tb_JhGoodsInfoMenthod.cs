using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using CHEXC.ClassInfo;
using System.Windows.Forms;
namespace CHEXC.GoodMenhod
{
   public class tb_JhGoodsInfoMenthod
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;
       #region 添加
       public int tb_JhGoodsInfoMenthodAdd(tb_JhGoodsInfo tbGood)
       {
           int intFalg = 0;
           try
           {
               //string str_Add = "insert into tb_JhGoodsInfo values( ";
               //str_Add += "'" + tbGood.strGoodsID + "','" + tbGood.strEmpId + "','" + tbGood.strJhCompName + "',";
               //str_Add += "'" + tbGood.strDepotName + "','" + tbGood.strGoodsName + "','" + tbGood.strGoodsNum + "',";
               //str_Add += "'" + tbGood.strGoodsUnit + "','" + tbGood.deGoodsJhPrice + "','" + tbGood.deGoodsSellPrice + "',";
               //str_Add += "'" + tbGood.deGoodsNeedPrice + "','" + tbGood.deGoodsNoPrice + "','" + tbGood.strGoodsRemark + "',";
               //str_Add += "'" + tbGood.Falg + "')";
               string str_Add = "insert into tb_JhGoodsInfo values( ";
               str_Add += "'" + tbGood.strGoodsID + "','" + tbGood.strEmpId + "','" + tbGood.strJhCompName + "',";
               str_Add += "'" + tbGood.strDepotName + "','" + tbGood.strGoodsName + "','" + tbGood.strGoodsNum + "',";
               str_Add += "'" + tbGood.strGoodsUnit + "'," + tbGood.deGoodsJhPrice + " ," + tbGood.deGoodsSellPrice + " ,";
               str_Add += "" + tbGood.deGoodsNeedPrice + "," + tbGood.deGoodsNoPrice + ",'" + tbGood.strGoodsRemark + "',";
               str_Add += "'" + tbGood.DaGoodTime + "'," + tbGood.Falg + ")";
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
       public int tb_JhGoodsInfoMenthodUpdate(tb_JhGoodsInfo tbGood)
       {
           int intFalg = 0;
           try
           {
               string str_Add = "update tb_JhGoodsInfo set ";
               str_Add += "EmpId='" + tbGood.strEmpId + "',JhCompName='" + tbGood.strJhCompName + "',";
               str_Add += "DepotName='" + tbGood.strDepotName + "',GoodsName='" + tbGood.strGoodsName + "',GoodsNum='" + tbGood.strGoodsNum + "',";
               str_Add += "GoodsUnit='" + tbGood.strGoodsUnit + "',GoodsJhPrice=" + tbGood.deGoodsJhPrice + " ,GoodsSellPrice=" + tbGood.deGoodsSellPrice + " ,";
               str_Add += "GoodsNeedPrice=" + tbGood.deGoodsNeedPrice + ",GoodsNoPrice=" + tbGood.deGoodsNoPrice + ",GoodsRemark='" + tbGood.strGoodsRemark + "',";
               str_Add += "GoodTime='" + tbGood.DaGoodTime + "',Falg='" + tbGood.Falg + "' where GoodsID ='" + tbGood.strGoodsID + "'";
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
       #region 删标记打标
       public int tb_JhGoodsInfoMenthodDelete(tb_JhGoodsInfo tbGood)
       {
           int intFalg = 0;
           try
           {
               string str_Add = "update tb_JhGoodsInfo set ";
 
               str_Add += "Falg=" + tbGood.Falg + " where GoodsID ='" + tbGood.strGoodsID + "'";
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
       public void tb_JhGoodsInfoFind(string strObject, int intFalg, Object DataObject)
       {
           int intCount = 0;
           string strSecar = null;

           try
           {
               switch (intFalg)//判断条件
               {
                   case 1://"商品编号":
                       strSecar = "select * from tb_JhGoodsInfo where GoodsID like  '%" + strObject + "%' and Falg=0";
                       break;
                   case 2://商品名称"

                       strSecar = "select  * from  tb_JhGoodsInfo  where GoodsName like '%" + strObject + "%' and Falg=0";
                       break;
                   case 3://所属部门"
                       strSecar = "select * from tb_JhGoodsInfo where JhCompName like '%" + strObject + "%' and alg=0";
                       break;
                   case 4://"员工职位":
                       strSecar = "select * from tb_JhGoodsInfo where DepotName like '%" + strObject + "%' and Falg=0";
                       break;
                   case 5://"员工职位":
                       strSecar = "select * from tb_JhGoodsInfo where Falg=0";
                       break;
               }
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
                       dv[2, i].Value = qlddr[2].ToString();
                       dv[3, i].Value = qlddr[3].ToString();
                       dv[4, i].Value = qlddr[5].ToString();
                       dv[5, i].Value = qlddr[7].ToString();
                       dv[6, i].Value = qlddr[8].ToString();
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
                           dv[6, i].Value = "";
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
       public SqlDataReader tb_JhGoodsInfoFind(string strObject, int intFalg)
       {
           int intCount = 0;
           string strSecar = null;

           try
           {
               switch (intFalg)//判断条件
               {
                   case 1://"编号查
                       strSecar = "select * from tb_JhGoodsInfo where GoodsID = '" + strObject + "' and Falg=0";
                       break;
                   case 2://全部果询
                       strSecar = "select  * from  tb_JhGoodsInfo  where Falg=0";
                       break;
               }
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
       #region //生成客户编号 例如：KH-20071118114255
       public string JhGoodsID()
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


           return ("SP-" + strTime);



       }// end if 
       #endregion
       #region //填冲商品类别信息 TrreView控件
       public void filltProd(object objTreeView, object obimage)
       {
           try
           {
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               string strSecar = "select * from tb_Company  where Falg=0";
               cmd = new SqlCommand(strSecar, conn);
               qlddr = cmd.ExecuteReader();
  
               if (objTreeView.GetType().ToString() == "System.Windows.Forms.TreeView")
               {
                   System.Windows.Forms.ImageList imlist = (System.Windows.Forms.ImageList)obimage;

                   System.Windows.Forms.TreeView TV = (System.Windows.Forms.TreeView)objTreeView;
                   TV.Nodes.Clear();

                   TV.ImageList = imlist;
                   System.Windows.Forms.TreeNode TN = new System.Windows.Forms.TreeNode("供应商名称", 0, 1);
                   while (qlddr.Read())
                   {
                       TN.Nodes.Add("", qlddr[1].ToString(), 0, 1);

                   }
                   TV.Nodes.Add(TN);
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
    }
}
