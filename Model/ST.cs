﻿/**  版本信息模板在安装目录下，可自行修改。
* ST.cs
*
* 功 能： N/A
* 类 名： ST
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:16   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// ST:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ST
	{
		public ST()
		{}
		#region Model
		private int _stbh;
		private int _kcbh;
		private DateTime _ctsj;
		private byte[] _tmnr;
		private byte[] _tmda;
		private string _ctr;
		private bool _sfzdyj;
		private bool _sfsc= false;
		/// <summary>
		/// 
		/// </summary>
		public int STBH
		{
			set{ _stbh=value;}
			get{return _stbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int KCBH
		{
			set{ _kcbh=value;}
			get{return _kcbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CTSJ
		{
			set{ _ctsj=value;}
			get{return _ctsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] TMNR
		{
			set{ _tmnr=value;}
			get{return _tmnr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] TMDA
		{
			set{ _tmda=value;}
			get{return _tmda;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CTR
		{
			set{ _ctr=value;}
			get{return _ctr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool SFZDYJ
		{
			set{ _sfzdyj=value;}
			get{return _sfzdyj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool SFSC
		{
			set{ _sfsc=value;}
			get{return _sfsc;}
		}
		#endregion Model

	}
}

