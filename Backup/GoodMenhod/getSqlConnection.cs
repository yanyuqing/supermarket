using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
namespace CHEXC.GoodMenhod
{
   public class getSqlConnection
    {
        #region   �������õ��ı���
       //edit by 51aspx
        string G_Str_ConnectionString = "Data Source=.\\SqlExpress;database=db_CSManage;uid=sa;pwd=sa";
        SqlConnection G_Con;  //�������Ӷ���
        #endregion

        #region  ���캯��
        /// <summary>
        /// ���캯��
        /// </summary>
       public getSqlConnection()
        {

        }
        #endregion

        #region   �������ݿ�
        /// <summary>
        /// �������ݿ�
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetCon()
        {
            G_Con = new SqlConnection(G_Str_ConnectionString);
            G_Con.Open();
            return G_Con;
        }
        #endregion
    }
}
