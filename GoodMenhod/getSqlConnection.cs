using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
namespace CHEXC.GoodMenhod
{
   public class getSqlConnection
    {
        #region   �������õ��ı���
      
       string G_Str_ConnectionString = "Data Source=PC-20160802OPVX;database=db_CSManage;uid=sa;pwd=20142925";
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
