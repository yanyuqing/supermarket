using System;
using System.Collections.Generic;
using System.Text;
        using System.Data.SqlClient;
using CHEXC.ClassInfo;
using System.Windows.Forms;
namespace CHEXC.GoodMenhod
{
     public  class tb_KcGoodsMenthod
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;
         #region Ìí¼Ó
         public int tb_KcGoodsAdd(tb_KcGoods kcGood)
         {
             int intFalg = 0;
             try
             {
                 string str_Add = "insert into tb_KcGoods values( ";
                 str_Add += "'"+kcGood.strGoodsID+"','"+kcGood.strJhCompName+"',";
                  str_Add += "'"+kcGood.strKcDeptName+"','"+kcGood.strKcGoodsName+"',"+kcGood.intKcNum+",";
                  str_Add += ""+kcGood.intKcAlarmNum+",'"+kcGood.intKcUnit+"','"+kcGood.daKcTime+"',";
                  str_Add += ""+kcGood.deKcGoodsPrice+","+kcGood.deKcSellPrice+",'"+kcGood.strKcEmp+"',";
                 str_Add+="'"+kcGood.strKcRemark+"')";
 
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
         #region ÐÞ¸Ä
         public int tb_KcGoodsUpdate(tb_KcGoods kcGood)
         {
             int intFalg = 0;
             try
             {
                 string str_Add = "update tb_KcGoods set  ";
                 str_Add += "KcDeptName='" + kcGood.strKcDeptName + "',KcNum=" + kcGood.intKcNum + ",";
                 str_Add += "KcAlarmNum=" + kcGood.intKcAlarmNum + ",KcTime='" + kcGood.daKcTime + "',";
                 str_Add += "KcGoodsPrice=" + kcGood.deKcGoodsPrice + ",KcSellPrice=" + kcGood.deKcSellPrice + ",KcEmp='" + kcGood.strKcEmp + "',";
                 str_Add += "KcRemark='" + kcGood.strKcRemark + "' where GoodsID ='" + kcGood.strGoodsID + "'";

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
         #region
         public int tb_KcGoodsUpdate(string kcGood,int striID)
         {
             int intFalg = 0;
             try
             {
                 string str_Add = "update tb_KcGoods set  ";
             
                 str_Add += "KcAlarmNum=" + striID + " ";
               
                 str_Add += " where GoodsID ='" + kcGood + "'";

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
         #region ²éÑ¯
         public void tb_ThGoodsFind(object DataObject, int intFalg, tb_KcGoods kcGood)
         {
             int intCount = 0;
             string strSecar = null;

             try
             {
                 switch(intFalg)
                 {
                     case 1:
                         strSecar = "select * from tb_KcGoods where GoodsID  like '%" + kcGood.strGoodsID + "%'";
                         break;
                     case 2:
                         strSecar = "select * from tb_KcGoods  where KcGoodsName like '%" + kcGood.strKcGoodsName + "%'";
                         break;
         
                     case 4:
                         strSecar = "select * from tb_KcGoods ";
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
                         dv[0, i].Value = qlddr[1].ToString();
                         dv[1, i].Value = qlddr[4].ToString();
                         dv[2, i].Value = qlddr[3].ToString();
                         dv[3, i].Value = qlddr[5].ToString();
                         dv[4, i].Value = qlddr[6].ToString();
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
         public SqlDataReader tb_ThGoodsFind(string DataObject)
         {
             
             string strSecar = null;

             try
             {

                 strSecar = "select * from tb_KcGoods  where GoodsID ='" + DataObject + "'";


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
    }
}
