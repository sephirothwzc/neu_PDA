using System;
using System.Collections.Generic;
using System.Text;

namespace neu_PDA
{

    public class BCMoveResp
    {
        #region 物料凭证号

        private string _DOC_NO;

        /// <summary>
        /// 物料凭证号
        /// </summary>
        public string DOC_NO
        {
            get
            {
                if (String.IsNullOrEmpty(_DOC_NO))
                    return "";
                else
                    return _DOC_NO;
            }
            set { _DOC_NO = value; }
        }
        #endregion

        #region 移库是否成功

        private bool _MOVE_STORE_SUCCESS;

        /// <summary>
        /// 移库是否成功
        /// </summary>
        public bool MOVE_STORE_SUCCESS
        {
            get
            {
                return _MOVE_STORE_SUCCESS;
            }
            set { _MOVE_STORE_SUCCESS = value; }
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

        #region 异常类型

        private string _ERROR_TYPE;

        /// <summary>
        /// 异常类型
        /// </summary>
        public string ERROR_TYPE
        {
            get
            {
                if (String.IsNullOrEmpty(_ERROR_TYPE))
                    return "";
                else
                    return _ERROR_TYPE;
            }
            set { _ERROR_TYPE = value; }
        }
        #endregion

        #region DOC_NO_YEAR 物料凭证年度

        private string _DOC_NO_YEAR;

        /// <summary>
        /// _DOC_NO_YEAR 
        /// </summary>
        public string DOC_NO_YEAR
        {
            get { return _DOC_NO_YEAR; }
            set { _DOC_NO_YEAR = value; }
        }
        #endregion

        #region 检验批(单个)

        private string _INSP_LOT_NO;

        /// <summary>
        /// 检验批号
        /// </summary>
        public string INSP_LOT_NO
        {
            get
            {
                if (String.IsNullOrEmpty(_INSP_LOT_NO))
                    return "";
                else
                    return _INSP_LOT_NO;
            }
            set { _INSP_LOT_NO = value; }
        }
        #endregion

        #region 检验批集合

        //private List<BCInspLot> _LIST_INSP_LOT_NO;

        ///// <summary>
        ///// 检验批集合
        ///// </summary>
        //public List<BCInspLot> LIST_INSP_LOT_NO
        //{
        //    get
        //    {                
        //            return _LIST_INSP_LOT_NO;
        //    }
        //    set { _LIST_INSP_LOT_NO = value; }
        //}
        #endregion


    }
}
