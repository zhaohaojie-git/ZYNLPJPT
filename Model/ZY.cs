﻿/**  版本信息模板在安装目录下，可自行修改。
* ZY.cs
*
* 功 能： N/A
* 类 名： ZY
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:25   N/A    初版
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
	/// ZY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ZY
	{
		public ZY()
		{}
		#region Model
		private int _zybh;
		private int _xkbh;
		private string _zym;
		private string _zyfzr;
		/// <summary>
		/// 
		/// </summary>
		public int ZYBH
		{
			set{ _zybh=value;}
			get{return _zybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int XKBH
		{
			set{ _xkbh=value;}
			get{return _xkbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYM
		{
			set{ _zym=value;}
			get{return _zym;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYFZR
		{
			set{ _zyfzr=value;}
			get{return _zyfzr;}
		}
		#endregion Model

	}
}

