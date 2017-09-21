using System;
using System.Collections.Generic;
using System.Text;

namespace CHEXC.ClassInfo
{
	public class tb_EmpInfo
	{
		 private string EmpId;
		 public string intEmpId
			 {
				 get{ return EmpId;}
				 set{ EmpId=value;}
			 }
		 private string EmpName;
		 public string strEmpName
			 {
				 get{ return EmpName;}
				 set{ EmpName=value;}
			 }
		 private string EmpLoginName;
		 public string strEmpLoginName
			 {
				 get{ return EmpLoginName;}
				 set{ EmpLoginName=value;}
			 }
		 private string EmpLoginPwd;
		 public string strEmpLoginPwd
			 {
				 get{ return EmpLoginPwd;}
				 set{ EmpLoginPwd=value;}
			 }
		 private string EmpSex;
		 public string intEmpSex
			 {
				 get{ return EmpSex;}
				 set{ EmpSex=value;}
			 }
		 private DateTime EmpBirthday;
		 public DateTime daEmpBirthday
			 {
				 get{ return EmpBirthday;}
				 set{ EmpBirthday=value;}
			 }
		 private string EmpDept;
		 public string strEmpDept
			 {
				 get{ return EmpDept;}
				 set{ EmpDept=value;}
			 }
		 private string EmpPost;
		 public string strEmpPost
			 {
				 get{ return EmpPost;}
				 set{ EmpPost=value;}
			 }
		 private string EmpPhone;
		 public string strEmpPhone
			 {
				 get{ return EmpPhone;}
				 set{ EmpPhone=value;}
			 }
		 private string EmpPhoneM;
		 public string strEmpPhoneM
			 {
				 get{ return EmpPhoneM;}
				 set{ EmpPhoneM=value;}
			 }
		 private string EmpAddress;
		 public string strEmpAddress
			 {
				 get{ return EmpAddress;}
				 set{ EmpAddress=value;}
			 }
		 private int EmpPopedomID;
		 public int intEmpPopedomID
			 {
				 get{ return EmpPopedomID;}
				 set{ EmpPopedomID=value;}
			 }
		 private int EmpFalg;
        public int intEmpFalg
			 {
                 get { return EmpFalg; }
                 set { EmpFalg = value; }
			 }
        private string EmpLoing;
        public string strEmpLoing
        {
            get { return EmpLoing; }
            set { EmpLoing = value; }
        }
        private string EmpPwd;
        public string strEmpPwd
        {
            get { return EmpPwd; }
            set { EmpPwd = value; }
        }
	} 
}