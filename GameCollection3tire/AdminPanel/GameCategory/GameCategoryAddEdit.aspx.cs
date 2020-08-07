using GameCollection.BAL;
using GameCollection.ENT;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_GameCategory_GameCategoryAddEdit : System.Web.UI.Page
{
    #region Load Event
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/Login/Login.aspx");
            }

            if (Request.QueryString["GameCategoryID"] != null)
            {
                LoadControls(Convert.ToInt32(Request.QueryString["GameCategoryID"]));
            }
        }
    }
    #endregion Load Event

    #region LoadControls
    private void LoadControls(SqlInt32 GameCategoryID)
    {
        {
            GameCategoryENT entGameCategory = new GameCategoryENT();
            GameCategoryBAL balGameCategory = new GameCategoryBAL();

            entGameCategory = balGameCategory.SelectByPK(GameCategoryID);

            if (!entGameCategory.GameCategoryName.IsNull)
                txtGameCategoryName.Text = entGameCategory.GameCategoryName.Value.ToString();
        }
    }

    #endregion LoadControls

    #region Button : Save
    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region Server Side Validation

        String strError = String.Empty;

        if (txtGameCategoryName.Text.Trim() == String.Empty)
            strError += "- Enter Game Category Name<br />";

        if (strError.Trim() != String.Empty)
        {
            lblMessage.Text = "Kindly Correct Following Error(s)<br />" + strError; ;
        }

        #endregion Server Side Validation
        {
            GameCategoryENT entGameCategory = new GameCategoryENT();
            GameCategoryBAL balGameCategory = new GameCategoryBAL();

            #region Gather Data

            if (txtGameCategoryName.Text.Trim() != String.Empty)
                entGameCategory.GameCategoryName = txtGameCategoryName.Text.Trim();

            entGameCategory.UserID = Convert.ToInt32(Session["UserID"]);
            //entGameCategory.CreationDate = DateTime.Now;

            if (Request.QueryString["GameCategoryID"] == null)
            {
                balGameCategory.Insert(entGameCategory);
                lblMessage.Text = "Data Inserted Successfully";
                ClearControls();
            }
            else
            {
                entGameCategory.GameCategoryID = Convert.ToInt32(Request.QueryString["GameCategoryID"]);
                balGameCategory.Update(entGameCategory);
                Response.Redirect("~/AdminPanel/GameCategory/GameCategoryList.aspx");
            }

            #endregion Gather Data
        }
    }
    #endregion Button : Save

    #region Button : Cancel
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
    #endregion Button : Cancel



    #region ClearControls

    private void ClearControls()
    {
        txtGameCategoryName.Text = "";

        txtGameCategoryName.Focus();
    }

    #endregion ClearControls
}