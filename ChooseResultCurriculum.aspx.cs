﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT
{
    public partial class ChooseResultCurriculum : System.Web.UI.Page
    {
        public JDKCXSView[] jdkcxsviews = null;
        public int[] testNum_done;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();

            }
            else
            {
                YH yh = (YH)(Session["yh"]);
                //获取用户的阶段课程
                JDKCXSView_DAL jdkcxsview_dal = new JDKCXSView_DAL();
                jdkcxsviews = jdkcxsview_dal.getByXSBH(yh.YHBH, XS_Utility.getSemNum(yh.YHBH));
                //获取每门课程的历史测评次数
                int[] kcbhs = new int[jdkcxsviews.Length];
                for (int i = 0; i < jdkcxsviews.Length; i++)
                {
                    kcbhs[i] = jdkcxsviews[i].KCBH;
                }
                PCJL_DAL pcjl_dal = new PCJL_DAL();
                testNum_done = pcjl_dal.getPCJLNumByKCBH_Done(kcbhs);

            }
        }
    }
}