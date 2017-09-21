using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using CHEXC.ClassInfo;
using System.Windows.Forms;
namespace CHEXC.GoodMenhod
{
    public class tb_CompanyMenthod
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;
               
        #region 添加
        public int tb_CompanyMenthodAdd(tb_Company Company)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "insert into tb_Company values( ";
              str_Add+="'"+Company.intCompanyID+"','"+Company.strCompanyName+"','"+Company.strCompanyDirector+"',";
               str_Add+="'"+Company.strCompanyPhone+"','"+Company.strCompanyFax+"','"+Company.strCompanyAddress+"',";
                              str_Add+="'"+Company.strCompanyRemark+"','"+Company.daReDateTime+"','"+Company.intEmpFalg+"')";
              getSqlConnection getConnection = new getSqlConnection();
              conn = getConnection.GetCon();
              cmd = new SqlCommand(str_Add,conn);
              intFalg = cmd.ExecuteNonQuery();
              conn.Dispose();
              return intFalg;

            
            }
            catch (Exception ee)
            {
                return intFalg;
                
            }

        }
        #endregion
        #region 修改
        public int tb_CompanyMenthodUpDate(tb_Company Company)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "update tb_Company  set ";
                str_Add += "CompanyName='" + Company.strCompanyName + "',CompanyDirector='" + Company.strCompanyDirector + "',";
                str_Add += "CompanyPhone='" + Company.strCompanyPhone + "',CompanyFax='" + Company.strCompanyFax + "',CompanyAddress='" + Company.strCompanyAddress + "',";
                str_Add += "CompanyRemark='" + Company.strCompanyRemark + "',ReDateTime='" + Company.daReDateTime + "',Falg='" + Company.intEmpFalg + "' where CompanyID ='" + Company.intCompanyID + "'";
               
              
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
        public int tb_CompanyMenthodDelete(tb_Company Company)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "update tb_Company  set ";
                str_Add += "Falg='" + Company.intEmpFalg + "' where CompanyID ='" + Company.intCompanyID + "'";


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
        public void tb_CompanyFind(string strObject, int intFalg, Object DataObject)
        {
            int intCount = 0;
            string strSecar = null;

            try
            {
                switch (intFalg)//判断条件
                {
                    case 1://"员工姓名":
                        strSecar = "select * from tb_Company  where CompanyName like  '%" + strObject + "%' and Falg= 0";
                        break;
                    case 2://员工性别

                        strSecar = "select * from tb_Company  where CompanyDirector like '%" + strObject + "%' and Falg= 0";
                        break;
                    case 3:
                        strSecar = "select * from tb_Company  where Falg= 0";
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
                        dv[1, i].Value = qlddr[1].ToString();
                        dv[2, i].Value = qlddr[2].ToString();
                        dv[3, i].Value = qlddr[3].ToString();
                        dv[4, i].Value = qlddr[5].ToString();
 
                        i++;

                    }
                    qlddr.Close();
                }
                else
                {
                    for (int i = 0; i < dv.RowCount; i++)
                    {
                        dv[0, i].Value = "";
                        dv[1, i].Value = "";
                        dv[2, i].Value = "";
                        dv[3, i].Value = "";
                        dv[4, i].Value = "";

                    }
                }



            }
            catch (Exception ee)
            {


            }

        }
        public SqlDataReader tb_CompanyFind(string strObject)
        {
           
            string strSecar = null;

            try
            {

                strSecar = "select * from tb_Company  where CompanyID =  '" + strObject + "' and Falg= 0";
              

                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);
                int ii = 0;
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
        public string tb_CustomerID()
        {
            int intYear= DateTime.Now.Day;
            int intMonth=DateTime.Now.Month;
            int intDate=DateTime.Now.Year;
            int intHour=DateTime.Now.Hour;
            int intSecond=DateTime.Now.Second;
           int intMinute=DateTime.Now.Minute;
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
            

            return ("KH-" + strTime);


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
