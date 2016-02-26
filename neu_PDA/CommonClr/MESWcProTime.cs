using System;
using System.Collections.Generic;
using System.Text;

namespace neu_PDA
{
	/// <summary>
	/// 描述:
	/// 创建者:Denver
	/// 创建时间:2014/10/23 16:07:40
	/// </summary>
	public class MESWcProTime
	{
		#region ROW_ID 
		private string _ROW_ID;
		public const string ColROW_ID = "ROW_ID";
		/// <summary>
		/// ROW_ID 
		/// </summary>
		public string ROW_ID
		{
			get { return _ROW_ID; }
			set { _ROW_ID = value; }
		}
		#endregion
		#region WCID 生产单元ID
		private string _WCID;
		public const string ColWCID = "WCID";
		/// <summary>
		/// WCID 生产单元ID
		/// </summary>
		public string WCID
		{
			get { return _WCID; }
			set { _WCID = value; }
		}
		#endregion
		#region GWT03 工序id(岗位编号)
		private string _GWT03;
		public const string ColGWT03 = "GWT03";
		/// <summary>
		/// GWT03 工序id(岗位编号)
		/// </summary>
		public string GWT03
		{
			get { return _GWT03; }
			set { _GWT03 = value; }
		}
		#endregion
		#region GWT04 制版方式（编号）
		private string _GWT04;
		public const string ColGWT04 = "GWT04";
		/// <summary>
		/// GWT04 制版方式（编号）
		/// </summary>
		public string GWT04
		{
			get { return _GWT04; }
			set { _GWT04 = value; }
		}
		#endregion
		#region GWT05 印版品种（名称）
		private string _GWT05;
		public const string ColGWT05 = "GWT05";
		/// <summary>
		/// GWT05 印版品种（名称）
		/// </summary>
		public string GWT05
		{
			get { return _GWT05; }
			set { _GWT05 = value; }
		}
		#endregion
		#region GWT06 版辊类别（名称）
		private string _GWT06;
		public const string ColGWT06 = "GWT06";
		/// <summary>
		/// GWT06 版辊类别（名称）
		/// </summary>
		public string GWT06
		{
			get { return _GWT06; }
			set { _GWT06 = value; }
		}
		#endregion
		#region GWT07 制袋类型（名称）
		private string _GWT07;
		public const string ColGWT07 = "GWT07";
		/// <summary>
		/// GWT07 制袋类型（名称）
		/// </summary>
		public string GWT07
		{
			get { return _GWT07; }
			set { _GWT07 = value; }
		}
		#endregion
		#region GWT08 做稿方式（编号）
		private string _GWT08;
		public const string ColGWT08 = "GWT08";
		/// <summary>
		/// GWT08 做稿方式（编号）
		/// </summary>
		public string GWT08
		{
			get { return _GWT08; }
			set { _GWT08 = value; }
		}
		#endregion
		#region GWT09 作图方式（编号）
		private string _GWT09;
		public const string ColGWT09 = "GWT09";
		/// <summary>
		/// GWT09 作图方式（编号）
		/// </summary>
		public string GWT09
		{
			get { return _GWT09; }
			set { _GWT09 = value; }
		}
		#endregion
		#region GWT10 多品种
		private string _GWT10;
		public const string ColGWT10 = "GWT10";
		/// <summary>
		/// GWT10 多品种
		/// </summary>
		public string GWT10
		{
			get { return _GWT10; }
			set { _GWT10 = value; }
		}
		#endregion
		#region GWT11 品种下限
		private string _GWT11;
		public const string ColGWT11 = "GWT11";
		/// <summary>
		/// GWT11 品种下限
		/// </summary>
		public string GWT11
		{
			get { return _GWT11; }
			set { _GWT11 = value; }
		}
		#endregion
		#region GWT12 品种上限
		private string _GWT12;
		public const string ColGWT12 = "GWT12";
		/// <summary>
		/// GWT12 品种上限
		/// </summary>
		public string GWT12
		{
			get { return _GWT12; }
			set { _GWT12 = value; }
		}
		#endregion
		#region GWT13 系列产品
		private string _GWT13;
		public const string ColGWT13 = "GWT13";
		/// <summary>
		/// GWT13 系列产品
		/// </summary>
		public string GWT13
		{
			get { return _GWT13; }
			set { _GWT13 = value; }
		}
		#endregion
		#region GWT14 系列套数下限
		private string _GWT14;
		public const string ColGWT14 = "GWT14";
		/// <summary>
		/// GWT14 系列套数下限
		/// </summary>
		public string GWT14
		{
			get { return _GWT14; }
			set { _GWT14 = value; }
		}
		#endregion
		#region GWT15 系列套数上限
		private string _GWT15;
		public const string ColGWT15 = "GWT15";
		/// <summary>
		/// GWT15 系列套数上限
		/// </summary>
		public string GWT15
		{
			get { return _GWT15; }
			set { _GWT15 = value; }
		}
		#endregion
		#region GWT16 图数量
		private string _GWT16;
		public const string ColGWT16 = "GWT16";
		/// <summary>
		/// GWT16 图数量
		/// </summary>
		public string GWT16
		{
			get { return _GWT16; }
			set { _GWT16 = value; }
		}
		#endregion
		#region GWT17 图下限
		private string _GWT17;
		public const string ColGWT17 = "GWT17";
		/// <summary>
		/// GWT17 图下限
		/// </summary>
		public string GWT17
		{
			get { return _GWT17; }
			set { _GWT17 = value; }
		}
		#endregion
		#region GWT18 图上限
		private string _GWT18;
		public const string ColGWT18 = "GWT18";
		/// <summary>
		/// GWT18 图上限
		/// </summary>
		public string GWT18
		{
			get { return _GWT18; }
			set { _GWT18 = value; }
		}
		#endregion
		#region GWT19 版辊结构（编号）
		private string _GWT19;
		public const string ColGWT19 = "GWT19";
		/// <summary>
		/// GWT19 版辊结构（编号）
		/// </summary>
		public string GWT19
		{
			get { return _GWT19; }
			set { _GWT19 = value; }
		}
		#endregion
		#region GWT20 键槽类型
		private string _GWT20;
		public const string ColGWT20 = "GWT20";
		/// <summary>
		/// GWT20 键槽类型
		/// </summary>
		public string GWT20
		{
			get { return _GWT20; }
			set { _GWT20 = value; }
		}
		#endregion
		#region GWT21 网线
		private string _GWT21;
		public const string ColGWT21 = "GWT21";
		/// <summary>
		/// GWT21 网线
		/// </summary>
		public string GWT21
		{
			get { return _GWT21; }
			set { _GWT21 = value; }
		}
		#endregion
		#region GWT22 网线下限
		private string _GWT22;
		public const string ColGWT22 = "GWT22";
		/// <summary>
		/// GWT22 网线下限
		/// </summary>
		public string GWT22
		{
			get { return _GWT22; }
			set { _GWT22 = value; }
		}
		#endregion
		#region GWT23 网线上限
		private string _GWT23;
		public const string ColGWT23 = "GWT23";
		/// <summary>
		/// GWT23 网线上限
		/// </summary>
		public string GWT23
		{
			get { return _GWT23; }
			set { _GWT23 = value; }
		}
		#endregion
		#region GWT24 网角
		private string _GWT24;
		public const string ColGWT24 = "GWT24";
		/// <summary>
		/// GWT24 网角
		/// </summary>
		public string GWT24
		{
			get { return _GWT24; }
			set { _GWT24 = value; }
		}
		#endregion
		#region GWT25 网角下限
		private string _GWT25;
		public const string ColGWT25 = "GWT25";
		/// <summary>
		/// GWT25 网角下限
		/// </summary>
		public string GWT25
		{
			get { return _GWT25; }
			set { _GWT25 = value; }
		}
		#endregion
		#region GWT26 网角上限
		private string _GWT26;
		public const string ColGWT26 = "GWT26";
		/// <summary>
		/// GWT26 网角上限
		/// </summary>
		public string GWT26
		{
			get { return _GWT26; }
			set { _GWT26 = value; }
		}
		#endregion
		#region GWT27 雕刻频率
		private string _GWT27;
		public const string ColGWT27 = "GWT27";
		/// <summary>
		/// GWT27 雕刻频率
		/// </summary>
		public string GWT27
		{
			get { return _GWT27; }
			set { _GWT27 = value; }
		}
		#endregion
		#region GWT28 频率下限
		private string _GWT28;
		public const string ColGWT28 = "GWT28";
		/// <summary>
		/// GWT28 频率下限
		/// </summary>
		public string GWT28
		{
			get { return _GWT28; }
			set { _GWT28 = value; }
		}
		#endregion
		#region GWT29 频率上限
		private string _GWT29;
		public const string ColGWT29 = "GWT29";
		/// <summary>
		/// GWT29 频率上限
		/// </summary>
		public string GWT29
		{
			get { return _GWT29; }
			set { _GWT29 = value; }
		}
		#endregion
		#region GWT30 版辊规格
		private string _GWT30;
		public const string ColGWT30 = "GWT30";
		/// <summary>
		/// GWT30 版辊规格
		/// </summary>
		public string GWT30
		{
			get { return _GWT30; }
			set { _GWT30 = value; }
		}
		#endregion
		#region GWT31 版长下限
		private string _GWT31;
		public const string ColGWT31 = "GWT31";
		/// <summary>
		/// GWT31 版长下限
		/// </summary>
		public string GWT31
		{
			get { return _GWT31; }
			set { _GWT31 = value; }
		}
		#endregion
		#region GWT32 版长上限
		private string _GWT32;
		public const string ColGWT32 = "GWT32";
		/// <summary>
		/// GWT32 版长上限
		/// </summary>
		public string GWT32
		{
			get { return _GWT32; }
			set { _GWT32 = value; }
		}
		#endregion
		#region GWT33 周长下限
		private string _GWT33;
		public const string ColGWT33 = "GWT33";
		/// <summary>
		/// GWT33 周长下限
		/// </summary>
		public string GWT33
		{
			get { return _GWT33; }
			set { _GWT33 = value; }
		}
		#endregion
		#region GWT34 周长上限
		private string _GWT34;
		public const string ColGWT34 = "GWT34";
		/// <summary>
		/// GWT34 周长上限
		/// </summary>
		public string GWT34
		{
			get { return _GWT34; }
			set { _GWT34 = value; }
		}
		#endregion
		#region GWT42 客户名称
		private string _GWT42;
		public const string ColGWT42 = "GWT42";
		/// <summary>
		/// GWT42 客户名称
		/// </summary>
		public string GWT42
		{
			get { return _GWT42; }
			set { _GWT42 = value; }
		}
		#endregion
		#region CFREE1 备用列
		private string _CFREE1;
		public const string ColCFREE1 = "CFREE1";
		/// <summary>
		/// CFREE1 备用列
		/// </summary>
		public string CFREE1
		{
			get { return _CFREE1; }
			set { _CFREE1 = value; }
		}
		#endregion
		#region CFREE2 备用列
		private string _CFREE2;
		public const string ColCFREE2 = "CFREE2";
		/// <summary>
		/// CFREE2 备用列
		/// </summary>
		public string CFREE2
		{
			get { return _CFREE2; }
			set { _CFREE2 = value; }
		}
		#endregion
		#region CFREE3 备用列
		private string _CFREE3;
		public const string ColCFREE3 = "CFREE3";
		/// <summary>
		/// CFREE3 备用列
		/// </summary>
		public string CFREE3
		{
			get { return _CFREE3; }
			set { _CFREE3 = value; }
		}
		#endregion
		#region CFREE4 备用列
		private string _CFREE4;
		public const string ColCFREE4 = "CFREE4";
		/// <summary>
		/// CFREE4 备用列
		/// </summary>
		public string CFREE4
		{
			get { return _CFREE4; }
			set { _CFREE4 = value; }
		}
		#endregion
		#region CFREE5 备用列
		private string _CFREE5;
		public const string ColCFREE5 = "CFREE5";
		/// <summary>
		/// CFREE5 备用列
		/// </summary>
		public string CFREE5
		{
			get { return _CFREE5; }
			set { _CFREE5 = value; }
		}
		#endregion
		#region COID 公司编码
		private string _COID;
		public const string ColCOID = "COID";
		/// <summary>
		/// COID 公司编码
		/// </summary>
		public string COID
		{
			get { return _COID; }
			set { _COID = value; }
		}
		#endregion
		#region FACTORYID 工厂编码
		private string _FACTORYID;
		public const string ColFACTORYID = "FACTORYID";
		/// <summary>
		/// FACTORYID 工厂编码
		/// </summary>
		public string FACTORYID
		{
			get { return _FACTORYID; }
			set { _FACTORYID = value; }
		}
		#endregion
		#region BUFFER1 
		private string _BUFFER1;
		public const string ColBUFFER1 = "BUFFER1";
		/// <summary>
		/// BUFFER1 
		/// </summary>
		public string BUFFER1
		{
			get { return _BUFFER1; }
			set { _BUFFER1 = value; }
		}
		#endregion
		#region BUFFER2 
		private string _BUFFER2;
		public const string ColBUFFER2 = "BUFFER2";
		/// <summary>
		/// BUFFER2 
		/// </summary>
		public string BUFFER2
		{
			get { return _BUFFER2; }
			set { _BUFFER2 = value; }
		}
		#endregion
		#region BUFFER3 
		private string _BUFFER3;
		public const string ColBUFFER3 = "BUFFER3";
		/// <summary>
		/// BUFFER3 
		/// </summary>
		public string BUFFER3
		{
			get { return _BUFFER3; }
			set { _BUFFER3 = value; }
		}
		#endregion
		#region BUFFER4 
		private string _BUFFER4;
		public const string ColBUFFER4 = "BUFFER4";
		/// <summary>
		/// BUFFER4 
		/// </summary>
		public string BUFFER4
		{
			get { return _BUFFER4; }
			set { _BUFFER4 = value; }
		}
		#endregion
		#region BUFFER5 
		private string _BUFFER5;
		public const string ColBUFFER5 = "BUFFER5";
		/// <summary>
		/// BUFFER5 
		/// </summary>
		public string BUFFER5
		{
			get { return _BUFFER5; }
			set { _BUFFER5 = value; }
		}
		#endregion
		#region BUFFER6 
		private string _BUFFER6;
		public const string ColBUFFER6 = "BUFFER6";
		/// <summary>
		/// BUFFER6 
		/// </summary>
		public string BUFFER6
		{
			get { return _BUFFER6; }
			set { _BUFFER6 = value; }
		}
		#endregion
		#region BUFFER7 
		private string _BUFFER7;
		public const string ColBUFFER7 = "BUFFER7";
		/// <summary>
		/// BUFFER7 
		/// </summary>
		public string BUFFER7
		{
			get { return _BUFFER7; }
			set { _BUFFER7 = value; }
		}
		#endregion
		#region BUFFER8 
		private string _BUFFER8;
		public const string ColBUFFER8 = "BUFFER8";
		/// <summary>
		/// BUFFER8 
		/// </summary>
		public string BUFFER8
		{
			get { return _BUFFER8; }
			set { _BUFFER8 = value; }
		}
		#endregion
		#region BUFFER9 
		private string _BUFFER9;
		public const string ColBUFFER9 = "BUFFER9";
		/// <summary>
		/// BUFFER9 
		/// </summary>
		public string BUFFER9
		{
			get { return _BUFFER9; }
			set { _BUFFER9 = value; }
		}
		#endregion
		#region BUFFER10 
		private string _BUFFER10;
		public const string ColBUFFER10 = "BUFFER10";
		/// <summary>
		/// BUFFER10 
		/// </summary>
		public string BUFFER10
		{
			get { return _BUFFER10; }
			set { _BUFFER10 = value; }
		}
		#endregion



	}
}
