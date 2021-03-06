﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManufactureMonitor
{
    public partial class Menu : System.Web.UI.Page
    {
        //static string MachineGroupId;
        protected void Page_Load(object sender, EventArgs e)
        {
            //MachineGroupId = Request.QueryString["MachineGroup"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ActualState.aspx?MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ShiftHistroy1.aspx?MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/UserLogin.aspx?Source=ProjectAssignment&MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DisplayProject.aspx?MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DisplayStopProblems.aspx?MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DisplayShiftDefinition.aspx?Machine_Id=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DisplayParameters.aspx?MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserLogin.aspx?Source=ChangePassword&MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Scrap1.aspx?MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserLogin.aspx?Source=StopProblemSetting&MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StopTimes2.aspx?MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProblemAccumulation.aspx?MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserLogin.aspx?Source=ProjectSetting&MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserLogin.aspx?Source=M_off_setting&MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ORandMOR1.aspx?MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserLogin.aspx?Source=ParameterSetting&MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ProjectSummary.aspx?MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserLogin.aspx?Source=ShiftDefinitionSetting&MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TimeSequence1.aspx?MachineGroupId=" + Request.QueryString["MachineGroup"]);
        }

       

    }
}