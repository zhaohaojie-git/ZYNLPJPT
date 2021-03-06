﻿/**  版本信息模板在安装目录下，可自行修改。
* XKNLZBView_DAL.cs
*
* 功 能： N/A
* 类 名： XKNLZBView_DAL
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/4/27 15:27:42   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ZYNLPJPT.Utility;//Please add references
namespace ZYNLPJPT.DAL
{
	/// <summary>
	/// 数据访问类:XKNLZBView_DAL
	/// </summary>
	public partial class XKNLZBView_DAL
	{
		public XKNLZBView_DAL()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(ZYNLPJPT.Model.XKNLZBView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into XKNLZBView(");
			strSql.Append("XKBH,XKMC,YJZBBH,YJZBMC,EJZBBH,EJZBMC)");
			strSql.Append(" values (");
			strSql.Append("@XKBH,@XKMC,@YJZBBH,@YJZBMC,@EJZBBH,@EJZBMC)");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@YJZBBH", SqlDbType.Int,4),
					new SqlParameter("@YJZBMC", SqlDbType.VarChar,50),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@EJZBMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.XKMC;
			parameters[2].Value = model.YJZBBH;
			parameters[3].Value = model.YJZBMC;
			parameters[4].Value = model.EJZBBH;
			parameters[5].Value = model.EJZBMC;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ZYNLPJPT.Model.XKNLZBView model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update XKNLZBView set ");
			strSql.Append("XKBH=@XKBH,");
			strSql.Append("XKMC=@XKMC,");
			strSql.Append("YJZBBH=@YJZBBH,");
			strSql.Append("YJZBMC=@YJZBMC,");
			strSql.Append("EJZBBH=@EJZBBH,");
			strSql.Append("EJZBMC=@EJZBMC");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@XKBH", SqlDbType.Int,4),
					new SqlParameter("@XKMC", SqlDbType.VarChar,50),
					new SqlParameter("@YJZBBH", SqlDbType.Int,4),
					new SqlParameter("@YJZBMC", SqlDbType.VarChar,50),
					new SqlParameter("@EJZBBH", SqlDbType.Int,4),
					new SqlParameter("@EJZBMC", SqlDbType.VarChar,50)};
			parameters[0].Value = model.XKBH;
			parameters[1].Value = model.XKMC;
			parameters[2].Value = model.YJZBBH;
			parameters[3].Value = model.YJZBMC;
			parameters[4].Value = model.EJZBBH;
			parameters[5].Value = model.EJZBMC;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from XKNLZBView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ZYNLPJPT.Model.XKNLZBView GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 XKBH,XKMC,YJZBBH,YJZBMC,EJZBBH,EJZBMC from XKNLZBView ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			ZYNLPJPT.Model.XKNLZBView model=new ZYNLPJPT.Model.XKNLZBView();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ZYNLPJPT.Model.XKNLZBView DataRowToModel(DataRow row)
		{
			ZYNLPJPT.Model.XKNLZBView model=new ZYNLPJPT.Model.XKNLZBView();
			if (row != null)
			{
				if(row["XKBH"]!=null && row["XKBH"].ToString()!="")
				{
					model.XKBH=int.Parse(row["XKBH"].ToString());
				}
				if(row["XKMC"]!=null)
				{
					model.XKMC=row["XKMC"].ToString();
				}
				if(row["YJZBBH"]!=null && row["YJZBBH"].ToString()!="")
				{
					model.YJZBBH=int.Parse(row["YJZBBH"].ToString());
				}
				if(row["YJZBMC"]!=null)
				{
					model.YJZBMC=row["YJZBMC"].ToString();
				}
				if(row["EJZBBH"]!=null && row["EJZBBH"].ToString()!="")
				{
					model.EJZBBH=int.Parse(row["EJZBBH"].ToString());
				}
				if(row["EJZBMC"]!=null)
				{
					model.EJZBMC=row["EJZBMC"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select XKBH,XKMC,YJZBBH,YJZBMC,EJZBBH,EJZBMC ");
			strSql.Append(" FROM XKNLZBView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" XKBH,XKMC,YJZBBH,YJZBMC,EJZBBH,EJZBMC ");
			strSql.Append(" FROM XKNLZBView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM XKNLZBView ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from XKNLZBView T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "XKNLZBView";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        
		#endregion  ExtensionMethod
	}
}

