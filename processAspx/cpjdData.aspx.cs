﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.processAspx
{
    public partial class cpjdData : System.Web.UI.Page
    {
        protected int jdbh;

        protected int njbh;

        protected int zybh;

        protected string tips;

        protected ZYKCView[] zykcViews;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                Response.Redirect("../Default.htm");
            }
            else
            {
                zybh = int.Parse(Request["zybh"].ToString());
                tips = "请选择课程是否为  " + Request["jdmc"].ToString() + "  阶段设课程的出题人。\n 打钩表示为下设课程，反之则不是。";
                jdbh = int.Parse(Request["jdbh"].ToString());
                njbh = int.Parse(Request["njbh"].ToString());
                string queryZym = Request["zym"].ToString();
                int xkbh = int.Parse(Request["xkbh"].ToString());
                zykcViews = new ZYKCView_DAL().GetArray("xkbh=" + xkbh + " and zym='" + queryZym.Trim() + "'");
            }
        }
    }
}