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

public partial class AdminPanel_GameCreator_GameCreatorList : System.Web.UI.Page
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
            FillGameCreatorGridView();
        }
    }
    #endregion Load Event

    #region FillGameCreatorGridView

    private void FillGameCreatorGridView()
    {
        {
            GameCreatorBAL balGameCreator = new GameCreatorBAL();
            DataTable dtGameCreator = balGameCreator.SelectAll();
            if (dtGameCreator != null && dtGameCreator.Rows.Count > 0)
            {
                gvGameCreatorList.DataSource = dtGameCreator;
                gvGameCreatorList.DataBind();
                lblMessage.Text = "No of records : " + dtGameCreator.Rows.Count.ToString();
            }
            else
            {
                lblMessage.Text = "No Data Available";
            }
        }
    }

    #endregion FillGameCreatorGridView

    #region gvGameCreator_RowCommand
    protected void gvGameCreator_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            GameCreatorBAL balGameCreator = new GameCreatorBAL();
            if (balGameCreator.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillGameCreatorGridView();
            }
            else
            {
                lblMessage.Text = balGameCreator.Message;
            }
        }
    }

    #endregion gvGameCreator_RowCommand
}