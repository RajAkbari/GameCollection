using GameCollection.BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_GameDevice_GameDeviceList : System.Web.UI.Page
{
    #region Load Event
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }
        if (!Page.IsPostBack)
        {
            FillGameDeviceGridView();
        }
    }
    #endregion Load Event

    #region FillGameDeviceGridView

    private void FillGameDeviceGridView()
    {
        if (Session["UserID"] != null)
        {
            GameDeviceBAL balGameDevice = new GameDeviceBAL();
            DataTable dtGameDevice = balGameDevice.SelectAll();
            if (dtGameDevice != null && dtGameDevice.Rows.Count > 0)
            {
                gvGameDeviceList.DataSource = dtGameDevice;
                gvGameDeviceList.DataBind();
                lblMessage.Text = "No of records : " + dtGameDevice.Rows.Count.ToString();
            }
            else
            {
                lblMessage.Text = "No Data Available";
            }
        }
    }

    #endregion FillGameDeviceGridView

    #region gvGameDevice_RowCommand
    protected void gvGameDevice_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            GameDeviceBAL balGameDevice = new GameDeviceBAL();
            if (balGameDevice.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillGameDeviceGridView();
            }
            else
            {
                lblMessage.Text = balGameDevice.Message;
            }
        }
    }

    #endregion gvGameDevice_RowCommand
}