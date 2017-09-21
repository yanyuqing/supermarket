using System;
using System.Collections.Generic;
using System.Text;

namespace CHEXC.ClassInfo
{
	public class tb_SellGoods
	{
		 private string SellID;
		 public string strSellID
			 {
				 get{ return SellID;}
				 set{ SellID=value;}
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
		 private string EmpId;
		 public string strEmpId
			 {
				 get{ return EmpId;}
				 set{ EmpId=value;}
			 }
		 private string GoodsName;
		 public string strGoodsName
			 {
				 get{ return GoodsName;}
				 set{ GoodsName=value;}
			 }
		 private int  SellGoodsNum;
		 public int strSellGoodsNum
			 {
				 get{ return SellGoodsNum;}
				 set{ SellGoodsNum=value;}
			 }
		 private DateTime SellGoodsTime;
		 public DateTime daSellGoodsTime
			 {
				 get{ return SellGoodsTime;}
				 set{ SellGoodsTime=value;}
			 }
        private string GoodsJhPrice;
        public string deGoodsJhPrice
			 {
				 get{ return GoodsJhPrice;}
				 set{ GoodsJhPrice=value;}
			 }
        private string SellPrice;
        public string deSellPrice
			 {
				 get{ return SellPrice;}
				 set{ SellPrice=value;}
			 }
        private string SellNeedPay;
        public string deSellNeedPay
			 {
				 get{ return SellNeedPay;}
				 set{ SellNeedPay=value;}
			 }
        private string SellHasPay;
        public string deSellHasPay
			 {
				 get{ return SellHasPay;}
				 set{ SellHasPay=value;}
			 }
		 private string SellRemark;
		 public string strSellRemark
			 {
				 get{ return SellRemark;}
				 set{ SellRemark=value;}
			 }
        private int SellFalg;
        public int intSellFalg
        {
            get { return SellFalg; }
            set { SellFalg = value; }
        }
	} 
}