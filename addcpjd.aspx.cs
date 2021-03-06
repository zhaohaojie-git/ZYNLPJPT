﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT
{
    public partial class addcpjd : System.Web.UI.Page
    {
        protected int xkbh;

        protected string[] zyms;

        protected string[] njNames;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm';</script>");
                this.Response.End();
            }
            else {
                YH yh = (YH)Session["yh"];
                xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                zyms = new ZY_DAL().getArrayByXkbh(xkbh);
                njNames = new NJ_DAL().getRecentyArray();
            }
        }
    }
}