using System;
using System.Collections.Generic;
using System.Text;

namespace neu_PDA
{
    /// <summary>
    /// 描述:BC_HISTORY表简化实体，用于WebService
    /// </summary>
    public class FBCHistory
    {
        #region ROW_ID 表行号

        private string _ROW_ID;

        /// <summary>
        /// ROW_ID 表行号
        /// </summary>
        public string ROW_ID
        {
            get { return _ROW_ID; }
            set { _ROW_ID = value; }
        }
        #endregion

        #region ORDER_NO 源订单号

        private string _ORDER_NO;

        /// <summary>
        /// ORDER_NO 源订单号
        /// </summary>
        public string ORDER_NO
        {
            get { return _ORDER_NO; }
            set { _ORDER_NO = value; }
        }
        #endregion

        #region ORDE_TYPE 源单据类型，包装方案‘001’，计划变更单‘002’，销售发货拣货单‘003’

        private string _ORDE_TYPE;

        /// <summary>
        /// ORDE_TYPE 源单据类型，包装方案‘001’，计划变更单‘002’
        /// </summary>
        public string ORDE_TYPE
        {
            get { return _ORDE_TYPE; }
            set { _ORDE_TYPE = value; }
        }
        #endregion

        #region OPER_TYPE 操作类别，拣出‘O’，放入‘I’

        private string _OPER_TYPE;

        /// <summary>
        /// OPER_TYPE 操作类别，拣出‘O’，放入‘I’
        /// </summary>
        public string OPER_TYPE
        {
            get { return _OPER_TYPE; }
            set { _OPER_TYPE = value; }
        }
        #endregion

        #region PACK_NO 包装箱号

        private string _PACK_NO;

        /// <summary>
        /// PACK_NO 包装箱号
        /// </summary>
        public string PACK_NO
        {
            get { return _PACK_NO; }
            set { _PACK_NO = value; }
        }
        #endregion

        #region MATERIAL_NO 物料编码

        private string _MATERIAL_NO;

        /// <summary>
        /// MATERIAL_NO 物料编码
        /// </summary>
        public string MATERIAL_NO
        {
            get { return _MATERIAL_NO; }
            set { _MATERIAL_NO = value; }
        }
        #endregion

        #region BATCH_NO  批次号

        private string _BATCH_NO;

        /// <summary>
        /// BATCH_NO  批次号
        /// </summary>
        public string BATCH_NO
        {
            get { return _BATCH_NO; }
            set { _BATCH_NO = value; }
        }
        #endregion

        #region SERIAL_NO 序列号

        private string _SERIAL_NO;

        /// <summary>
        /// SERIAL_NO 序列号
        /// </summary>
        public string SERIAL_NO
        {
            get { return _SERIAL_NO; }
            set { _SERIAL_NO = value; }
        }
        #endregion

        #region QUANTITY 数量

        private string _QUANTITY;

        /// <summary>
        /// QUANTITY 数量
        /// </summary>
        public string QUANTITY
        {
            get { return _QUANTITY; }
            set { _QUANTITY = value; }
        }
        #endregion

        /// <summary>
        /// 创建人
        /// </summary>
        public string CREATEBY { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        public string LASTUPDATEBY { get; set; }

        /// <summary>
        /// 来源单据明细行编号
        /// </summary>
        public string ITEM_NO { get; set; }

        /// <summary>
        /// 库存地点编号
        /// </summary>
        public string LOCATION_NO { get; set; }

        /// <summary>
        /// 库存BIN位置编号
        /// </summary>
        public string BIN_NO { get; set; }

        /// <summary>
        /// POST数量
        /// </summary>
        public string POST_QTY { get; set; }

        /// <summary>
        /// 已经拣货，但未POST数量
        /// </summary>
        public string UNPOST_QTY { get; set; }
    }
}
