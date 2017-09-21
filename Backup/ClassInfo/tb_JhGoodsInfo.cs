using System;
using System.Collections.Generic;
using System.Text;

namespace CHEXC.ClassInfo
{
	 public class tb_JhGoodsInfo
	{
		 private string GoodsID;
		 public string strGoodsID
			 {
				 get{ return GoodsID;}
				 set{ GoodsID=value;}
			 }
		 private string EmpId;
		 public string strEmpId
			 {
				 get{ return EmpId;}
				 set{ EmpId=value;}
			 }
		 private string JhCompName;
		 public string strJhCompName
			 {
				 get{ return JhCompName;}
				 set{ JhCompName=value;}
			 }
		 private string DepotName;
		 public string strDepotName
			 {
				 get{ return DepotName;}
				 set{ DepotName=value;}
			 }
		 private string GoodsName;
		 public string strGoodsName
			 {
				 get{ return GoodsName;}
				 set{ GoodsName=value;}
			 }
		 private int  GoodsNum;
		 public int strGoodsNum
			 {
				 get{ return GoodsNum;}
				 set{ GoodsNum=value;}
			 }
		 private string GoodsUnit;
		 public string strGoodsUnit
			 {
				 get{ return GoodsUnit;}
				 set{ GoodsUnit=value;}
			 }
         private string GoodsJhPrice;
         public string deGoodsJhPrice
			 {
				 get{ return GoodsJhPrice;}
				 set{ GoodsJhPrice=value;}
			 }
         private string GoodsSellPrice;
         public string deGoodsSellPrice
			 {
				 get{ return GoodsSellPrice;}
				 set{ GoodsSellPrice=value;}
			 }
         private string GoodsNeedPrice;
         public string deGoodsNeedPrice
			 {
				 get{ return GoodsNeedPrice;}
				 set{ GoodsNeedPrice=value;}
			 }
         private string GoodsNoPrice;
         public string deGoodsNoPrice
			 {
				 get{ return GoodsNoPrice;}
				 set{ GoodsNoPrice=value;}
			 }
		 private string GoodsRemark;
		 public string strGoodsRemark
			 {
				 get{ return GoodsRemark;}
				 set{ GoodsRemark=value;}
			 }
         private string KcGoodsName;
         public string strKcGoodsName
         {
             get { return KcGoodsName; }
             set { KcGoodsName = value; }
         }
             private int EmpFalg;
             public int Falg
             {
                 get { return EmpFalg; }
                 set { EmpFalg = value; }
             }
         private DateTime GoodTime;
         public DateTime DaGoodTime
         { 
                 get { return GoodTime; }
                 set { GoodTime = value; }
         }
	} 
}