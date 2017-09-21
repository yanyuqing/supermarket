using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
using CHEXC.ClassInfo;
using System.Windows.Forms;
namespace CHEXC.GoodMenhod
{
    public class tb_EmpInfoMenthod
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader qlddr = null;
       
        #region 添加
        public int tb_EmpInfoAdd(tb_EmpInfo Empinfo)
        {
            int intFalg = 0;
            try
            {
                string str_Add = "insert into tb_EmpInfo values( ";
                str_Add+=" '"+Empinfo.intEmpId+"','"+Empinfo.strEmpName+"','"+Empinfo.strEmpLoginName+"',";
               str_Add+=" '"+Empinfo.strEmpLoginPwd+"','"+Empinfo.intEmpSex+"','"+Empinfo.daEmpBirthday+"',";
               str_Add+=" '"+Empinfo.strEmpDept+"','"+Empinfo.strEmpPost+"','"+Empinfo.strEmpPhone+"',";
              str_Add+=" '"+Empinfo.strEmpPhoneM+"','"+Empinfo.strEmpAddress+"',";
              str_Add+=""+Empinfo.intEmpFalg+")";
              getSqlConnection getConnection = new getSqlConnection();
              conn = getConnection.GetCon();
              cmd = new SqlCommand(str_Add,conn);
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
        public int tb_EmpInfoUpdate(tb_EmpInfo Empinfo)
        {
            int intFalg = 0;
            try
            {

                string str_Update= "update tb_EmpInfo set ";
                str_Update += "EmpName='" + Empinfo.strEmpName + "',EmpLoginName='" + Empinfo.strEmpLoginName + "',";
                str_Update += "EmpLoginPwd='" + Empinfo.strEmpLoginPwd + "',EmpSex='" + Empinfo.intEmpSex + "',EmpBirthday='" + Empinfo.daEmpBirthday + "',";
                str_Update += "EmpDept= '" + Empinfo.strEmpDept + "',EmpPost='" + Empinfo.strEmpPost + "',EmpPhone='" + Empinfo.strEmpPhone + "',";
                str_Update += " EmpPhoneM='" + Empinfo.strEmpPhoneM + "',EmpAddress='" + Empinfo.strEmpAddress + "',";
                str_Update += "EmpFalg=" + Empinfo.intEmpFalg + " where  EmpId='" + Empinfo.intEmpId + "'";
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(str_Update, conn);
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
        public int tb_EmpInfoDelete(tb_EmpInfo Empinfo)
        {
            int intFalg = 0;
            try
            {

                string str_Update = "update tb_EmpInfo set ";
                str_Update += "EmpFalg='" + Empinfo.intEmpFalg + "' where  EmpId='" + Empinfo.intEmpId + "'";
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(str_Update, conn);
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
        #region 查询
        public void tb_EmpInfoFind(string strObject,int intFalg,Object DataObject)
        {
            int intCount=0;
            string strSecar=null;
            try
            {
                switch(intFalg)//判断条件
                {
                    case 1://"员工姓名":
                        strSecar = "select * from tb_EmpInfo where EmpName like  '%" + strObject + "%' and EmpFalg=0";
                        break;
                    case 2://员工性别

                        strSecar = "select  * from  tb_EmpInfo  where  EmpSex  = '" + strObject + "' and EmpFalg=0";
                        break;
                    case 3://所属部门"
                        strSecar = "select * from tb_EmpInfo where EmpDept like '%" + strObject + "%' and EmpFalg=0";
                        break;
                    case 4://"员工职位":
                        strSecar = "select * from tb_EmpInfo where EmpPost like '%" + strObject + "%' and EmpFalg=0";
                        break;
                    case 5:
                        strSecar = "select * from tb_EmpInfo where EmpFalg=0";
                        break;
                }
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar,conn);
                int ii = 0;
                qlddr = cmd.ExecuteReader();
                while(qlddr.Read())
                {
                    ii++;
                }
                qlddr.Close();
                System.Windows.Forms.DataGridView dv = (DataGridView)DataObject;
                if (ii!= 0)
                {
                    int i = 0;
                    dv.RowCount = ii;
                    qlddr = cmd.ExecuteReader();
                    while (qlddr.Read())
                    {
                        dv[0, i].Value = qlddr[0].ToString();
                        dv[1, i].Value = qlddr[1].ToString();
                        dv[2, i].Value = qlddr[4].ToString();
                        dv[3, i].Value = qlddr[6].ToString();
                        dv[4, i].Value = qlddr[7].ToString();
                        dv[5, i].Value = qlddr[9].ToString();
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
                        dv[5, i].Value = "";
                    }
                }
            }
            catch (Exception ee)
            {
            }
        }
        #endregion
        #region 查询
        public SqlDataReader tb_EmpInfoFind(string strObject,int intFalg)
        {
            int intCount = 0;
            string strSecar = null;

            try
            {
                switch (intFalg)
                { 
                    case 1:
                        strSecar = "select * from tb_EmpInfo where EmpId= '" + strObject + "' and EmpFalg=0";
                        break;
                    case 2:
                        strSecar = "select * from tb_EmpInfo where EmpFalg=0";
                        break;
                }
                strSecar = "select * from tb_EmpInfo where EmpId= '" + strObject + "' and EmpFalg=0";
  
                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);

                qlddr = cmd.ExecuteReader();


                return qlddr;


            }
            catch (Exception ee)
            {


                return qlddr;

            }

        }
            #endregion     
     
        #region 查询
        public int tb_EmpInfoFind(string strObject, string pwwd,int intFalg)
        {
            int intCount = 0;
            string strSecar = null;

            try
            {
                switch(intFalg)
                {
                    case 1:
                     strSecar = "select * from tb_EmpInfo where EmpLoginName= '" + strObject + "' and EmpFalg=0";
                     break;
                    case 2:
                        strSecar = "select * from tb_EmpInfo where EmpLoginName= '" + strObject + "' and EmpFalg=0 and EmpLoginPwd='" + pwwd + "'";
                        break;
                }

                getSqlConnection getConnection = new getSqlConnection();
                conn = getConnection.GetCon();
                cmd = new SqlCommand(strSecar, conn);

                qlddr = cmd.ExecuteReader();
                qlddr.Read();
                if (qlddr.HasRows)
                {
                    intCount = 1;
                }


                return intCount;


            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message.ToString());
                return intCount=2;

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


            return ("YG-" + strTime);



        }// end if 
        #endregion


    }
}
