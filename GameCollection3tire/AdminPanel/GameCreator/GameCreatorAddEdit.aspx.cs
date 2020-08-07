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

public partial class AdminPanel_GameCreator_GameCreatorAddEdit : System.Web.UI.Page
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

            if (Request.QueryString["GameCreatorID"] != null)
            {
                LoadControls(Convert.ToInt32(Request.QueryString["GameCreatorID"]));
            }
        }
    }
    #endregion Load Event

    #region LoadControls
    private void LoadControls(SqlInt32 GameCreatorID)
    {
        if (Session["UserID"] != null)
        {
            GameCreatorENT entGameCreator = new GameCreatorENT();
            GameCreatorBAL balGameCreator = new GameCreatorBAL();

            entGameCreator = balGameCreator.SelectByPK(GameCreatorID);

            if (!entGameCreator.GameCreatorName.IsNull)
                txtGameCreatorName.Text = entGameCreator.GameCreatorName.Value.ToString();
        }
    }

    #endregion LoadControls

    #region Button : Save
    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region Server Side Validation

        String strError = String.Empty;

        if (txtGameCreatorName.Text.Trim() == String.Empty)
            strError += "- Enter GameCreator Name<br />";

        if (strError.Trim() != String.Empty)
        {
            lblMessage.Text = "Kindly Correct Following Error(s)<br />" + strError; ;
        }

        #endregion Server Side Validation
        if (Session["UserID"] != null)
        {
            GameCreatorENT entGameCreator = new GameCreatorENT();
            GameCreatorBAL balGameCreator = new GameCreatorBAL();

            #region Gather Data

            if (txtGameCreatorName.Text.Trim() != String.Empty)
                entGameCreator.GameCreatorName = txtGameCreatorName.Text.Trim();

            entGameCreator.UserID = Convert.ToInt32(Session["UserID"]);
            //entGameCreator.CreationDate = DateTime.Now;

            if (Request.QueryString["GameCreatorID"] == null)
            {
                balGameCreator.Insert(entGameCreator);
                lblMessage.Text = "Data Inserted Successfully";
                ClearControls();
            }
            else
            {
                entGameCreator.GameCreatorID = Convert.ToInt32(Request.QueryString["GameCreatorID"]);
                balGameCreator.Update(entGameCreator);
                Response.Redirect("~/AdminPanel/GameCreator/GameCreatorList.aspx");
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
        txtGameCreatorName.Text = "";

        txtGameCreatorName.Focus();
    }

    #endregion ClearControls
}
