using System;
using System.Collections.Generic;
using System.Text;

namespace CHEXC.ClassInfo
{
  public class tb_Company
	{
		 private string CompanyID;
		 public string intCompanyID
			 {
				 get{ return CompanyID;}
				 set{ CompanyID=value;}
			 }
		 private string CompanyName;
		 public string strCompanyName
			 {
				 get{ return CompanyName;}
				 set{ CompanyName=value;}
			 }
		 private string CompanyDirector;
		 public string strCompanyDirector
			 {
				 get{ return CompanyDirector;}
				 set{ CompanyDirector=value;}
			 }
		 private string CompanyPhone;
		 public string strCompanyPhone
			 {
				 get{ return CompanyPhone;}
				 set{ CompanyPhone=value;}
			 }
		 private string CompanyFax;
		 public string strCompanyFax
			 {
				 get{ return CompanyFax;}
				 set{ CompanyFax=value;}
			 }
		 private string CompanyAddress;
		 public string strCompanyAddress
			 {
				 get{ return CompanyAddress;}
				 set{ CompanyAddress=value;}
			 }
		 private string CompanyRemark;
		 public string strCompanyRemark
			 {
				 get{ return CompanyRemark;}
				 set{ CompanyRemark=value;}
			 }
		 private DateTime ReDateTime;
		 public DateTime daReDateTime
			 {
				 get{ return ReDateTime;}
				 set{ ReDateTime=value;}

			 }
             private int EmpFalg;
             public int intEmpFalg
             {
                 get { return EmpFalg; }
                 set { EmpFalg = value; }
             }
	} 
}