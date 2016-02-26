using System;
using System.Collections.Generic;
using System.Text;

namespace neu_PDA
{
    public class POEntity
    {
        #region 工厂号

        private string _PLANT_NO;

        /// <summary>
        /// 工厂号
        /// </summary>
        public string PLANT_NO
        {
            get
            {
                if (String.IsNullOrEmpty(_PLANT_NO))
                    return "";
                else
                    return _PLANT_NO;
            }
            set { _PLANT_NO = value; }
        }
        #endregion

        #region 到货通知单（ASN）

        private string _ASN_NO;

        /// <summary>
        /// 到货通知单（ASN）
        /// </summary>
        public string ASN_NO
        {
            get
            {
                if (String.IsNullOrEmpty(_ASN_NO))
                    return "";
                else
                    return _ASN_NO;
            }
            set { _ASN_NO = value; }
        }
        #endregion

        #region  到货通知单（ASN）行号

        private string _ASN_ITEM_NO;

        /// <summary>
        /// 到货通知单（ASN）行号
        /// </summary>
        public string ASN_ITEM_NO
        {
            get
            {
                if (String.IsNullOrEmpty(_ASN_ITEM_NO))
                    return "";
                else
                    return _ASN_ITEM_NO;
            }
            set { _ASN_ITEM_NO = value; }
        }
        #endregion

        #region 采购订单号

        private string _PO;

        /// <summary>
        /// 采购订单号
        /// </summary>
        public string PO
        {
            get
            {
                if (String.IsNullOrEmpty(_PO))
                    return "";
                else
                    return _PO;
            }
            set { _PO = value; }
        }
        #endregion

        #region 采购订单行号

        private string _PO_ITEM_NO;

        /// <summary>
        /// 采购订单行号
        /// </summary>
        public string PO_ITEM_NO
        {
            get
            {
                if (String.IsNullOrEmpty(_PO_ITEM_NO))
                    return "";
                else
                    return _PO_ITEM_NO;
            }
            set { _PO_ITEM_NO = value; }
        }
        #endregion

        #region 物料号

        private string _MATERIAL_NO;

        /// <summary>
        /// 物料号
        /// </summary>
        public string MATERIAL_NO
        {
            get
            {
                if (String.IsNullOrEmpty(_MATERIAL_NO))
                    return "";
                else
                    return _MATERIAL_NO;
            }
            set { _MATERIAL_NO = value; }
        }
        #endregion

        #region 可收货数量

        private string _QTY;

        /// <summary>
        /// 可收货数量
        /// </summary>
        public string QTY
        {
            get
            {
                if (String.IsNullOrEmpty(_QTY))
                    return "";
                else
                    return _QTY;
            }
            set { _QTY = value; }
        }
        #endregion

        #region 供应商代码

        private string _VENDOR_CODE;

        /// <summary>
        /// 供应商代码
        /// </summary>
        public string VENDOR_CODE
        {
            get
            {
                if (String.IsNullOrEmpty(_VENDOR_CODE))
                    return "";
                else
                    return _VENDOR_CODE;
            }
            set { _VENDOR_CODE = value; }
        }
        #endregion

        #region 供应商名称

        private string _VENDOR_NAME;

        /// <summary>
        /// 供应商名称
        /// </summary>
        public string VENDOR_NAME
        {
            get
            {
                if (String.IsNullOrEmpty(_VENDOR_NAME))
                    return "";
                else
                    return _VENDOR_NAME;
            }
            set { _VENDOR_NAME = value; }
        }
        #endregion

        #region 行项目类别

        private string _ITEM_TYPE;

        /// <summary>
        /// 行项目类别
        /// </summary>
        public string ITEM_TYPE
        {
            get
            {
                if (String.IsNullOrEmpty(_ITEM_TYPE))
                    return "";
                else
                    return _ITEM_TYPE;
            }
            set { _ITEM_TYPE = value; }
        }
        #endregion

        #region 科目类别

        private string _ACC_ITEM;

        /// <summary>
        /// 科目类别
        /// </summary>
        public string ACC_ITEM
        {
            get
            {
                if (String.IsNullOrEmpty(_ACC_ITEM))
                    return "";
                else
                    return _ACC_ITEM;
            }
            set { _ACC_ITEM = value; }
        }
        #endregion
        
        #region 单位

        private string _UNIT;

        /// <summary>
        /// 单位
        /// </summary>
        public string UNIT
        {
            get
            {
                if (String.IsNullOrEmpty(_UNIT))
                    return "";
                else
                    return _UNIT;
            }
            set { _UNIT = value; }
        }
        #endregion

        #region WBS号

        private string _WBS_NO;

        /// <summary>
        /// WBS号
        /// </summary>
        public string WBS_NO
        {
            get
            {
                if (String.IsNullOrEmpty(_WBS_NO))
                    return "";
                else
                    return _WBS_NO;
            }
            set { _WBS_NO = value; }
        }
        #endregion

        #region 成本中心

        private string _COST_CENTER;

        /// <summary>
        /// 成本中心
        /// </summary>
        public string COST_CENTER
        {
            get
            {
                if (String.IsNullOrEmpty(_COST_CENTER))
                    return "";
                else
                    return _COST_CENTER;
            }
            set { _COST_CENTER = value; }
        }
        #endregion

        #region 生产订单号

        private string _PRODUCT_NO;

        /// <summary>
        /// 生产订单号
        /// </summary>
        public string PRODUCT_NO
        {
            get
            {
                if (String.IsNullOrEmpty(_PRODUCT_NO))
                    return "";
                else
                    return _PRODUCT_NO;
            }
            set { _PRODUCT_NO = value; }
        }
        #endregion

        #region SI 特殊适配符（空 普通库存，K寄售库存,Q项目库存）

        private string _SI;

        /// <summary>
        /// SI 特殊适配符（空 普通库存，K寄售库存,Q项目库存）
        /// </summary>
        public string SI
        {
            get
            {
                if (String.IsNullOrEmpty(_SI))
                    return "";
                else
                    return _SI;
            }
            set { _SI = value; }
        }
        #endregion

        #region SIV 特殊适配值

        private string _SIV;

        /// <summary>
        /// SIV 特殊适配值
        /// </summary>
        public string SIV
        {
            get
            {
                if (String.IsNullOrEmpty(_SIV))
                    return "";
                else
                    return _SIV;
            }
            set { _SIV = value; }
        }
        #endregion

        #region 是否关键件（Y：是关键件，N：不是关键件）

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

        #region 是否批次管理（Y：批次管理，N：不启用批次管理）

        private string _BATCH_MGNT;

        /// <summary>
        /// 是否批次管理（Y：批次管理，N：不启用批次管理） 
        /// </summary>
        public string BATCH_MGNT
        {
            get { return _BATCH_MGNT; }
            set { _BATCH_MGNT = value; }
        }
        #endregion

        #region 是否序列号管理（Y：序列号管理，N：不启用序列号管理）

        private string _SERIAL_MGNT;

        /// <summary>
        /// 是否序列号管理（Y：序列号管理，N：不启用序列号管理） 
        /// </summary>
        public string SERIAL_MGNT
        {
            get { return _SERIAL_MGNT; }
            set { _SERIAL_MGNT = value; }
        }
        #endregion

        #region 是否免检，Y：免检，N：质检，空：非质检

        private string _INSPEC_TAG;

        /// <summary>
        /// 是否免检，Y：免检，N：质检，空：非质检
        /// </summary>
        public string INSPEC_TAG
        {
            get
            {
                if (String.IsNullOrEmpty(_INSPEC_TAG))
                    return "";
                else
                    return _INSPEC_TAG;
            }
            set { _INSPEC_TAG = value; }
        }
        #endregion

        #region 外键ID

        private string _EXT_ID;

        /// <summary>
        /// 外键ID
        /// </summary>
        public string EXT_ID
        {
            get
            {
                if (String.IsNullOrEmpty(_EXT_ID))
                    return "";
                else
                    return _EXT_ID;
            }
            set { _EXT_ID = value; }
        }
        #endregion

        #region 行号（从1开始）

        private string _LINE;

        /// <summary>
        /// 行号（从1开始）
        /// </summary>
        public string LINE
        {
            get
            {
                if (String.IsNullOrEmpty(_LINE))
                    return "";
                else
                    return _LINE;
            }
            set { _LINE = value; }
        }
        #endregion

        #region 来源库位

        private string _FROM_LOCATION;

        /// <summary>
        /// 来源库位
        /// </summary>
        public string FROM_LOCATION
        {
            get
            {
                if (String.IsNullOrEmpty(_FROM_LOCATION))
                    return "";
                else
                    return _FROM_LOCATION;
            }
            set { _FROM_LOCATION = value; }
        }
        #endregion

        #region 来源Bin位

        private string _FROM_BIN;

        /// <summary>
        /// 来源Bin位
        /// </summary>
        public string FROM_BIN
        {
            get
            {
                if (String.IsNullOrEmpty(_FROM_BIN))
                    return "";
                else
                    return _FROM_BIN;
            }
            set { _FROM_BIN = value; }
        }
        #endregion

        #region 移库数量

        private string _MOVE_QTY;

        /// <summary>
        /// 移库数量
        /// </summary>
        public string MOVE_QTY
        {
            get
            {
                if (String.IsNullOrEmpty(_MOVE_QTY))
                    return "";
                else
                    return _MOVE_QTY;
            }
            set { _MOVE_QTY = value; }
        }
        #endregion

        #region 获取数据是否成功

        private bool _IS_SUCCESS;

        /// <summary>
        /// 获取数据是否成功
        /// </summary>
        public bool IS_SUCCESS
        {
            get
            {
                return _IS_SUCCESS;
            }
            set { _IS_SUCCESS = value; }
        }
        #endregion

        #region 错误信息

        private string _ERROR_MSG;

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ERROR_MSG
        {
            get
            {
                if (String.IsNullOrEmpty(_ERROR_MSG))
                    return "";
                else
                    return _ERROR_MSG;
            }
            set { _ERROR_MSG = value; }
        }
        #endregion

        #region UP_LOCATION 默认仓库

        private string _UP_LOCATION;

        /// <summary>
        /// UP_LOCATION 默认仓库
        /// </summary>
        public string UP_LOCATION
        {
            get
            {
                if (String.IsNullOrEmpty(_UP_LOCATION))
                    return "";
                else
                    return _UP_LOCATION;
            }
            set { _UP_LOCATION = value; }
        }
        #endregion

        #region UP_BIN 默认仓位（Bin）

        private string _UP_BIN;

        /// <summary>
        /// UP_BIN 默认仓位（Bin）
        /// </summary>
        public string UP_BIN
        {
            get
            {
                if (String.IsNullOrEmpty(_UP_BIN))
                    return "";
                else
                    return _UP_BIN;
            }
            set { _UP_BIN = value; }
        }
        #endregion

        #region MATERIAL_NAME 物料主数据名称

        private string _MATERIAL_NAME;

        /// <summary>
        /// MATERIAL_NAME 物料主数据名称
        /// </summary>
        public string MATERIAL_NAME
        {
            get
            {
                if (String.IsNullOrEmpty(_MATERIAL_NAME))
                    return "";
                else
                    return _MATERIAL_NAME;
            }
            set { _MATERIAL_NAME = value; }
        }
        #endregion

        #region 图号

        private string _DRAWING_NO;

        /// <summary>
        /// 图号
        /// </summary>
        public string DRAWING_NO
        {
            get
            {
                if (String.IsNullOrEmpty(_DRAWING_NO))
                    return "";
                else
                    return _DRAWING_NO;
            }
            set { _DRAWING_NO = value; }
        }
        #endregion

        #region 物料规格

        private string _SPECIFICATION;

        /// <summary>
        /// 物料规格
        /// </summary>
        public string SPECIFICATION
        {
            get
            {
                if (String.IsNullOrEmpty(_SPECIFICATION))
                    return "";
                else
                    return _SPECIFICATION;
            }
            set { _SPECIFICATION = value; }
        }
        #endregion

        #region PR_DATE 生产日期
        /// <summary>
        /// 生产日期
        /// </summary>
        public string PR_DATE { get; set; }
        #endregion

        #region POST_DATE 过账日期
        /// <summary>
        /// 生产日期
        /// </summary>
        public string POST_DATE { get; set; }
        #endregion

        #region 批次号
        /// <summary>
        /// 批次号
        /// </summary>
        public string BATCH_NO { get; set; }
        #endregion

        #region PDA用户名称
        /// <summary>
        /// 批次号
        /// </summary>
        public string PDA_USERNAME { get; set; }
        #endregion

        #region
        private string _CUSTOMER_CODE;
        public string CUSTOMER_CODE
        {
            set { _CUSTOMER_CODE = value; }
            get { return _CUSTOMER_CODE; }
        }
        #endregion

        #region ALLOW_DAYS 允许提前收货天数
        /// <summary>
        /// 允许提前收货天数
        /// </summary>
        public int ALLOW_DAYS { get; set; }
        #endregion

        #region DELIVERY_DATE 交货日期
        /// <summary>
        /// 交货日期
        /// </summary>
        public string DELIVERY_DATE { get; set; }
        #endregion

        #region EXP1 扩展字段1
        /// <summary>
        /// 扩展字段1
        /// </summary>
        public string EXP1 { get; set; }
        #endregion

        #region EXP2 扩展字段2
        /// <summary>
        /// 扩展字段2
        /// </summary>
        public string EXP2 { get; set; }
        #endregion

        #region EXP3 扩展字段3
        /// <summary>
        /// 扩展字段3
        /// </summary>
        public string EXP3 { get; set; }
        #endregion

    }
}
