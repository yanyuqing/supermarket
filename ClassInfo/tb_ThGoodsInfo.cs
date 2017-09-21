using System;
using System.Collections.Generic;
using System.Text;
namespace CHEXC.ClassInfo
{
	public class tb_ThGoodsInfo
	{
        /// <summary>
        /// 
        /// </summary>
        //ÍË»õ±àºÅ
		 private string ThGoodsID;
		 public string strThGoodsID
			 {
				 get{ return ThGoodsID;}
				 set{ ThGoodsID=value;}
			 }
		 private string KcID;
		 public string strKcID
			 {
				 get{ return KcID;}
				 set{ KcID=value;}
			 }
		 private string GoodsID;
		 public string strGoodsID
			 {
				 get{ return GoodsID;}
				 set{ GoodsID=value;}
			 }
		 private string SellID;
		 public string strSellID
			 {
				 get{ return SellID;}
				 set{ SellID=value;}
			 }
		 private string EmpId;
		 public string intEmpId
			 {
				 get{ return EmpId;}
				 set{ EmpId=value;}
			 }
		 private string ThGoodsName;
		 public string strThGoodsName
			 {
				 get{ return ThGoodsName;}
				 set{ ThGoodsName=value;}
			 }
		 private int ThGoodsNum;
		 public int intThGoodsNum
			 {
				 get{ return ThGoodsNum;}
				 set{ ThGoodsNum=value;}
			 }
		 private DateTime ThGoodsTime;
		 public DateTime daThGoodsTime
			 {
				 get{ return ThGoodsTime;}
				 set{ ThGoodsTime=value;}
			 }
        private string ThGoodsPrice;
        public string deThGoodsPrice
			 {
				 get{ return ThGoodsPrice;}
				 set{ ThGoodsPrice=value;}
			 }
        private string ThNeedPay;
        public string deThNeedPay
			 {
				 get{ return ThNeedPay;}
				 set{ ThNeedPay=value;}
			 }
        private string ThHasPay;
        public string deThHasPay
			 {
				 get{ return ThHasPay;}
				 set{ ThHasPay=value;}
			 }
		 private string ThGoodsResult;
		 public string deThGoodsResult
			 {
				 get{ return ThGoodsResult;}
				 set{ ThGoodsResult=value;}
			 }
	} 
}