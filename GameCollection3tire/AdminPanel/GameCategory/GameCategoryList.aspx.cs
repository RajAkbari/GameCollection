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

public partial class AdminPanel_GameCategory_GameCategoryList : System.Web.UI.Page
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
            FillGameCategoryGridView();
        }
    }
    #endregion Load Event

    #region FillGameCategoryGridView

    private void FillGameCategoryGridView()
    {
        if (Session["UserID"] != null)
        {
            GameCategoryBAL balGameCategory = new GameCategoryBAL();
            DataTable dtGameCategory = balGameCategory.SelectAll();
            if (dtGameCategory != null && dtGameCategory.Rows.Count > 0)
            {
                gvGameCategoryList.DataSource = dtGameCategory;
                gvGameCategoryList.DataBind();
                lblMessage.Text = "No of records : " + dtGameCategory.Rows.Count.ToString();
            }
            else
            {
                lblMessage.Text = "No Data Available";
            }
        }
    }

    #endregion FillGameCategoryGridView

    #region gvGameCategory_RowCommand
    protected void gvGameCategory_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord" && e.CommandArgument != null)
        {
            GameCategoryBAL balGameCategory = new GameCategoryBAL();
            if (balGameCategory.Delete(Convert.ToInt32(e.CommandArgument)))
            {
                FillGameCategoryGridView();
            }
            else
            {
                lblMessage.Text = balGameCategory.Message;
            }
        }
    }

    #endregion gvGameCategory_RowCommand
}
    
