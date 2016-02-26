using System;
using System.Collections.Generic;
using System.Text;

namespace neu_PDA
{
    /// <summary>
    /// 交互用BC_GRITEM表实体
    /// </summary>
    public class FBCGRItem
    {
		#region ROW_ID 

		private string _ROW_ID;

		/// <summary>
		/// ROW_ID 
		/// </summary>
		public string ROW_ID
		{
			get { return _ROW_ID; }
			set { _ROW_ID = value; }
		}
		#endregion

		#region PLANT_NO 工厂号

		private string _PLANT_NO;

		/// <summary>
		/// PLANT_NO 工厂号
		/// </summary>
		public string PLANT_NO
		{
			get { return _PLANT_NO; }
			set { _PLANT_NO = value; }
		}
		#endregion

		#region PO PO号

		private string _PO;

		/// <summary>
		/// PO PO号
		/// </summary>
		public string PO
		{
			get { return _PO; }
			set { _PO = value; }
		}
		#endregion

		#region ITME_NO 项目号

		private string _ITME_NO;

		/// <summary>
		/// ITME_NO 项目号
		/// </summary>
		public string ITME_NO
		{
			get { return _ITME_NO; }
			set { _ITME_NO = value; }
		}
		#endregion

		#region ASN_NO 到货通知单（ASN）

		private string _ASN_NO;

		/// <summary>
		/// ASN_NO 到货通知单（ASN）
		/// </summary>
		public string ASN_NO
		{
			get { return _ASN_NO; }
			set { _ASN_NO = value; }
		}
		#endregion

		#region ASN_ITEM 到货通知单（ASN）行项目号

		private string _ASN_ITEM;

		/// <summary>
		/// ASN_ITEM 到货通知单（ASN）行项目号
		/// </summary>
		public string ASN_ITEM
		{
			get { return _ASN_ITEM; }
			set { _ASN_ITEM = value; }
		}
		#endregion

		#region MATERIAL_NO 物料号

		private string _MATERIAL_NO;

		/// <summary>
		/// MATERIAL_NO 物料号
		/// </summary>
		public string MATERIAL_NO
		{
			get { return _MATERIAL_NO; }
			set { _MATERIAL_NO = value; }
		}
		#endregion

		#region QTY 数量

		private string _QTY;

		/// <summary>
		/// QTY 数量
		/// </summary>
		public string QTY
		{
			get { return _QTY; }
			set { _QTY = value; }
		}
		#endregion

		#region UNIT 单位

		private string _UNIT;

		/// <summary>
		/// UNIT 单位
		/// </summary>
		public string UNIT
		{
			get { return _UNIT; }
			set { _UNIT = value; }
		}
		#endregion

		#region FIGURE_NO 图号

		private string _FIGURE_NO;

		/// <summary>
		/// FIGURE_NO 图号
		/// </summary>
		public string FIGURE_NO
		{
			get { return _FIGURE_NO; }
			set { _FIGURE_NO = value; }
		}
		#endregion

		#region VENDOR_CODE 供应商代码

		private string _VENDOR_CODE;

		/// <summary>
		/// VENDOR_CODE 供应商代码
		/// </summary>
		public string VENDOR_CODE
		{
			get { return _VENDOR_CODE; }
			set { _VENDOR_CODE = value; }
		}
		#endregion

		#region VENDOR_NAME 供应商名称

		private string _VENDOR_NAME;

		/// <summary>
		/// VENDOR_NAME 供应商名称
		/// </summary>
		public string VENDOR_NAME
		{
			get { return _VENDOR_NAME; }
			set { _VENDOR_NAME = value; }
		}
		#endregion

		#region ITEM_TYPE 行项目类别

		private string _ITEM_TYPE;

		/// <summary>
		/// ITEM_TYPE 行项目类别
		/// </summary>
		public string ITEM_TYPE
		{
			get { return _ITEM_TYPE; }
			set { _ITEM_TYPE = value; }
		}
		#endregion

		#region ACC_ITEM 科目类别

		private string _ACC_ITEM;

		/// <summary>
		/// ACC_ITEM 科目类别
		/// </summary>
		public string ACC_ITEM
		{
			get { return _ACC_ITEM; }
			set { _ACC_ITEM = value; }
		}
		#endregion

		#region WBS_NO WBS号

		private string _WBS_NO;

		/// <summary>
		/// WBS_NO WBS号
		/// </summary>
		public string WBS_NO
		{
			get { return _WBS_NO; }
			set { _WBS_NO = value; }
		}
		#endregion

		#region COST_CENTER 成本中心

		private string _COST_CENTER;

		/// <summary>
		/// COST_CENTER 成本中心
		/// </summary>
		public string COST_CENTER
		{
			get { return _COST_CENTER; }
			set { _COST_CENTER = value; }
		}
		#endregion

		#region PRODUCT_NO 生产订单号

		private string _PRODUCT_NO;

		/// <summary>
		/// PRODUCT_NO 生产订单号
		/// </summary>
		public string PRODUCT_NO
		{
			get { return _PRODUCT_NO; }
			set { _PRODUCT_NO = value; }
		}
		#endregion

		#region SI SI 特殊适配符（空:普通库存，K:寄售库存，Q:项目库存）

		private string _SI;

		/// <summary>
		/// SI SI 特殊适配符（空:普通库存，K:寄售库存，Q:项目库存）
		/// </summary>
		public string SI
		{
			get { return _SI; }
			set { _SI = value; }
		}
		#endregion

		#region SIV SIV 特殊适配值

		private string _SIV;

		/// <summary>
		/// SIV SIV 特殊适配值
		/// </summary>
		public string SIV
		{
			get { return _SIV; }
			set { _SIV = value; }
		}
		#endregion

		#region EXT_ID 外键ID

		private string _EXT_ID;

		/// <summary>
		/// EXT_ID 外键ID
		/// </summary>
		public string EXT_ID
		{
			get { return _EXT_ID; }
			set { _EXT_ID = value; }
		}
		#endregion

		#region DOCUMENT_NO 物料凭证号

		private string _DOCUMENT_NO;

		/// <summary>
		/// DOCUMENT_NO 物料凭证号
		/// </summary>
		public string DOCUMENT_NO
		{
			get { return _DOCUMENT_NO; }
			set { _DOCUMENT_NO = value; }
		}
		#endregion

		#region DOCUMENT_NO_YEAR 物料凭证年度

		private string _DOCUMENT_NO_YEAR;

		/// <summary>
		/// DOCUMENT_NO_YEAR 物料凭证年度
		/// </summary>
		public string DOCUMENT_NO_YEAR
		{
			get { return _DOCUMENT_NO_YEAR; }
			set { _DOCUMENT_NO_YEAR = value; }
		}
		#endregion

		#region STATUS 状态，创建：Create；Post成功：Posted；Post失败：PostError

		private string _STATUS;

		/// <summary>
		/// STATUS 状态，创建：Create；Post成功：Posted；Post失败：PostError
		/// </summary>
		public string STATUS
		{
			get { return _STATUS; }
			set { _STATUS = value; }
		}
		#endregion

		#region INSPEC_TAG 是否免检（Y：免检，N：质检）

		private string _INSPEC_TAG;

		/// <summary>
		/// INSPEC_TAG 是否免检（Y：免检，N：质检）
		/// </summary>
		public string INSPEC_TAG
		{
			get { return _INSPEC_TAG; }
			set { _INSPEC_TAG = value; }
		}
		#endregion

		#region INSPEC_NAME 检验名称

		private string _INSPEC_NAME;

		/// <summary>
		/// INSPEC_NAME 检验名称
		/// </summary>
		public string INSPEC_NAME
		{
			get { return _INSPEC_NAME; }
			set { _INSPEC_NAME = value; }
		}
		#endregion

        #region INSPEC_BATCH 检验批次

        public string INSPEC_BATCH { get; set; }

        #endregion

		#region RECEIVE_LOCATION 收货仓库

		private string _RECEIVE_LOCATION;

		/// <summary>
		/// RECEIVE_LOCATION 收货仓库
		/// </summary>
		public string RECEIVE_LOCATION
		{
			get { return _RECEIVE_LOCATION; }
			set { _RECEIVE_LOCATION = value; }
		}
		#endregion

		#region RECEIVE_BIN 收货库位

		private string _RECEIVE_BIN;

		/// <summary>
		/// RECEIVE_BIN 收货库位
		/// </summary>
		public string RECEIVE_BIN
		{
			get { return _RECEIVE_BIN; }
			set { _RECEIVE_BIN = value; }
		}
		#endregion

		#region OPEN_QTY 可收货数量

		private string _OPEN_QTY;

		/// <summary>
		/// OPEN_QTY 可收货数量
		/// </summary>
		public string OPEN_QTY
		{
			get { return _OPEN_QTY; }
			set { _OPEN_QTY = value; }
		}
		#endregion

		#region RECEIVE_QTY 收货数量

		private string _RECEIVE_QTY;

		/// <summary>
		/// RECEIVE_QTY 收货数量
		/// </summary>
		public string RECEIVE_QTY
		{
			get { return _RECEIVE_QTY; }
			set { _RECEIVE_QTY = value; }
		}
		#endregion

		#region MRP_CONTROLER MRP Controler

		private string _MRP_CONTROLER;

		/// <summary>
		/// MRP_CONTROLER MRP Controler
		/// </summary>
		public string MRP_CONTROLER
		{
			get { return _MRP_CONTROLER; }
			set { _MRP_CONTROLER = value; }
		}
		#endregion

		#region GR_TYPE 收货类型 （GR_PO:PO收货；GR_ASN：ASN收货；GR_NULL_PO：无采购收货）

		private string _GR_TYPE;

		/// <summary>
		/// GR_TYPE 收货类型 （GR_PO:PO收货；GR_ASN：ASN收货；GR_NULL_PO：无采购收货）
		/// </summary>
		public string GR_TYPE
		{
			get { return _GR_TYPE; }
			set { _GR_TYPE = value; }
		}
		#endregion

		#region POST_DATE post时间

		private string _POST_DATE;

		/// <summary>
		/// POST_DATE post时间
		/// </summary>
		public string POST_DATE
		{
			get { return _POST_DATE; }
			set { _POST_DATE = value; }
		}
		#endregion

		#region KANBAN_NO 看板号

		private string _KANBAN_NO;

		/// <summary>
		/// KANBAN_NO 看板号
		/// </summary>
		public string KANBAN_NO
		{
			get { return _KANBAN_NO; }
			set { _KANBAN_NO = value; }
		}
		#endregion

		#region KEY_MATERIAL 是否关键件（Y：是关键件，N：不是关键件）

		private string _KEY_MATERIAL;

		/// <summary>
		/// KEY_MATERIAL 是否关键件（Y：是关键件，N：不是关键件）
		/// </summary>
		public string KEY_MATERIAL
		{
			get { return _KEY_MATERIAL; }
			set { _KEY_MATERIAL = value; }
		}
		#endregion

		#region CREATE_NAME 创建人

		private string _CREATE_NAME;

		/// <summary>
		/// CREATE_NAME 创建人
		/// </summary>
		public string CREATE_NAME
		{
			get { return _CREATE_NAME; }
			set { _CREATE_NAME = value; }
		}
		#endregion

		#region BATCH_MGNT 是否批次管理（Y：批次管理，N：不启用批次管理）

		private string _BATCH_MGNT;

		/// <summary>
		/// BATCH_MGNT 是否批次管理（Y：批次管理，N：不启用批次管理）
		/// </summary>
		public string BATCH_MGNT
		{
			get { return _BATCH_MGNT; }
			set { _BATCH_MGNT = value; }
		}
		#endregion

		#region SERIAL_MGNT 是否序列号管理（Y：序列号管理，N：不启用序列号管理）

		private string _SERIAL_MGNT;

		/// <summary>
		/// SERIAL_MGNT 是否序列号管理（Y：序列号管理，N：不启用序列号管理）
		/// </summary>
		public string SERIAL_MGNT
		{
			get { return _SERIAL_MGNT; }
			set { _SERIAL_MGNT = value; }
		}
		#endregion  

        #region VD_BATCH 供应商批次号
        /// <summary>
        /// 供应商批次号
        /// </summary>
        public string VD_BATCH { get; set; }
        #endregion

        #region KN_BATCH 康尼批次号
        /// <summary>
        /// 康尼批次号
        /// </summary>
        public string KN_BATCH { get; set; }
        #endregion

        #region PR_DATE 生产日期
        /// <summary>
        /// 生产日期
        /// </summary>
        public string PR_DATE { get; set; }
        #endregion

        #region BUFFER1 每箱包装数
        private string _BUFFER1;
        /// <summary>
        /// 每箱包装数
        /// </summary>
        public string BUFFER1
        {
            get { return _BUFFER1; }
            set { _BUFFER1 = value; }
        }
        #endregion

        #region BUFFER2 箱数
        private string _BUFFER2;
        /// <summary>
        /// 箱数
        /// </summary>
        public string BUFFER2
        {
            get { return _BUFFER2; }
            set { _BUFFER2 = value; }
        }
        #endregion

        #region BUFFER3 无采购收货类型
        private string _BUFFER3;
        /// <summary>
        /// 无采购收货类型
        /// </summary>
        public string BUFFER3
        {
            get { return _BUFFER3; }
            set { _BUFFER3 = value; }
        }
        #endregion

        #region BUFFER4 康尼老PO号
        private string _BUFFER4;
        /// <summary>
        /// 康尼老PO号
        /// </summary>
        public string BUFFER4
        {
            get { return _BUFFER4; }
            set { _BUFFER4 = value; }
        }
        #endregion

        #region BUFFER5 成批提交任务号
        private string _BUFFER5;
        /// <summary>
        /// 成批提交任务号
        /// </summary>
        public string BUFFER5
        {
            get { return _BUFFER5; }
            set { _BUFFER5 = value; }
        }
        #endregion

        #region added by ldb on 20131204 查询用

        #region MATERIAL_NAME 物料名称
        private string _MATERIAL_NAME;
        /// <summary>
        /// DRAWING_NO 物料规格
        /// </summary>
        public string MATERIAL_NAME
        {
            get { return _MATERIAL_NAME; }
            set { _MATERIAL_NAME = value; }
        }
        #endregion

        #region DRAWING_NO 物料图号
        private string _DRAWING_NO;
        /// <summary>
        /// DRAWING_NO 物料图号
        /// </summary>
        public string DRAWING_NO
        {
            get { return _DRAWING_NO; }
            set { _DRAWING_NO = value; }
        }
        #endregion

        #region PDA用户名称
        /// <summary>
        /// 批次号
        /// </summary>
        public string PDA_USERNAME { get; set; }
        #endregion

        #endregion

    }
}
