using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using CHEXC.ClassInfo;
using System.Windows.Forms;
namespace CHEXC.GoodMenhod
{
    class tb_ThGoodsMenthod
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;

        #region 添加
        public int tb_ThGoodsAdd(tb_ThGoodsInfo tbChGood)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "insert into tb_ThGoodsInfo values( ";
               str_Add+="'"+tbChGood.strThGoodsID+"','"+tbChGood.strKcID+"','"+tbChGood.strGoodsID+"',";
                str_Add+="'"+tbChGood.strSellID+"','"+tbChGood.intEmpId+"','"+tbChGood.strThGoodsName+"',";
                str_Add+=""+tbChGood.intThGoodsNum+",'"+tbChGood.daThGoodsTime+"',"+tbChGood.deThGoodsPrice+",";
                str_Add+=""+tbChGood.deThHasPay+","+tbChGood.deThNeedPay+",'"+tbChGood.deThGoodsResult+"')";
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
        public int tb_ThGoodsUpdate(tb_ThGoodsInfo tbChGood)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "update tb_ThGoodsInfo set ";
                str_Add += "KcID='" + tbChGood.strKcID + "',GoodsID='" + tbChGood.strGoodsID + "',";
                str_Add += "SellID='" + tbChGood.strSellID + "',EmpId='" + tbChGood.intEmpId + "',ThGoodsName='" + tbChGood.strThGoodsName + "',";
                str_Add += "ThGoodsNum=" + tbChGood.intThGoodsNum + ",ThGoodsTime='" + tbChGood.daThGoodsTime + "',ThGoodsPrice=" + tbChGood.deThGoodsPrice + ",";
                str_Add += "ThHasPay=" + tbChGood.deThHasPay + ",ThNeedPay=" + tbChGood.deThNeedPay + ",ThGoodsResult='" + tbChGood.deThGoodsResult + "' where  ThGoodsID='" + tbChGood.strThGoodsID + "'";
                
               
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
    #region //生成商品编号 例如：TH-20071118114255
       public string tb_ThGoodsID()
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


           return ("TH-" + strTime);



       }// end if 
       #endregion
       #region 查询
 public void tb_ThGoodsFind(Object DataObject)
{
    int intCount = 0;
    string strSecar = null;
    try
    {
        strSecar = "select * from tb_ThGoodsInfo ";
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
                dv[1, i].Value = qlddr[3].ToString();
                dv[2, i].Value = qlddr[5].ToString();
                dv[3, i].Value = qlddr[8].ToString();
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
       public SqlDataReader tb_JhGoodsInfoFind(string strObject)
       {
           int intCount = 0;
           string strSecar = null;

           try
           {

               strSecar = "select * from tb_thgoodsinfo  where thGoodsid= '" + strObject + "'";
            
  
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
       #region //填冲商品类别信息 TrreView控件
       public void filltProd(object objTreeView, object obimage)
       {
           try
           {
               getSqlConnection getConnection = new getSqlConnection();
               conn = getConnection.GetCon();
               string strSecar = "select * from tb_SellGoods ";
               cmd = new SqlCommand(strSecar, conn);
               qlddr = cmd.ExecuteReader();

               if (objTreeView.GetType().ToString() == "System.Windows.Forms.TreeView")
               {
                   System.Windows.Forms.ImageList imlist = (System.Windows.Forms.ImageList)obimage;

                   System.Windows.Forms.TreeView TV = (System.Windows.Forms.TreeView)objTreeView;
                   TV.Nodes.Clear();

                   TV.ImageList = imlist;
                   System.Windows.Forms.TreeNode TN = TV.Nodes.Add("A", "商品销售信息", 0, 1);

                   while (qlddr.Read())
                   {
                       TreeNode newNode12 = new TreeNode(qlddr[0].ToString(), 0, 1);
                       newNode12.Nodes.Add("A", qlddr[4].ToString(), 0, 1);
                       TN.Nodes.Add(newNode12);
                   }
                   qlddr.Close();
                   TV.ExpandAll();
               }
           }
           catch (Exception ee)
           {
               MessageBox.Show(ee.ToString());
           }

       }
           #endregion 
       #region //生成客户编号 例如：KH-20071118114255
       public string tb_EmpInfoID()
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
           return ("THGOOD-" + strTime);

       }// end if 
       #endregion
        #region 删除
        public int tb_ThGoodsDelete(string striThid)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "delete from tb_thgoodsinfo  where ThGoodsID='" + striThid + "'";
               


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

    }
}
