using GameCollection;
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

public partial class AdminPanel_Game_GameList : System.Web.UI.Page
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
            FillGameGridView();
        }
    }
    #endregion Load Event

    #region FillGameGridView

    private void FillGameGridView()
    {
        if (Session["UserID"] != null)
        {
            GameBAL balGame = new GameBAL();
            DataTable dtGame = balGame.SelectAll();
            if (dtGame != null && dtGame.Rows.Count > 0)
            {
                gvGameList.DataSource = dtGame;
                gvGameList.DataBind();
                lblMessage.Text = "No of records :" + dtGame.Rows.Count.ToString();
            }
            else
            {
                lblMessage.Text = "No Data Available";
            }
        }
    }

    #endregion FillGameGridView

    #region gvGame_RowCommand
    protected void gvGame_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            GameBAL balGame = new GameBAL();
            if (balGame.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillGameGridView();
            }
            else
            {
                lblMessage.Text = balGame.Message;
            }
        }
    }

    #endregion gvGame_RowCommand
}
