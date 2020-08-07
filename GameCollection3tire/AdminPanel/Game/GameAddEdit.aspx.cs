using GameCollection;
using GameCollection.BAL;
using GameCollection.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_Game_GameAddEdit : System.Web.UI.Page
{
    #region Load Event

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            FillDropDownList();

            if (Request.QueryString["GameID"] != null)
            {
                LoadControls(Convert.ToInt32(Request.QueryString["GameID"]));
            }
        }
    }

    #endregion Load Event

    #region LoadControls

    private void LoadControls(SqlInt32 GameID)
    {
        if (Session["UserID"] != null)
        {
            GameENT entGame = new GameENT();
            GameBAL balGame = new GameBAL();

            entGame = balGame.SelectByPK(GameID);

            if (!entGame.GameName.IsNull)
                txtGameName.Text = entGame.GameName.Value.ToString();

            if (!entGame.GameCategoryID.IsNull)
                ddlGameCategory.SelectedValue = entGame.GameCategoryID.Value.ToString();

            if (!entGame.GameCreatorID.IsNull)
                ddlGameCreator.SelectedValue = entGame.GameCreatorID.Value.ToString();

            if (!entGame.GameDeviceID.IsNull)
                ddlGameDevice.SelectedValue = entGame.GameDeviceID.Value.ToString();

            if (!entGame.ReleaseDate.IsNull)
                txtReleaseDate.Text = entGame.ReleaseDate.Value.ToString("yyyy-MM-dd");

            if (!entGame.GameVersion.IsNull)
                txtGameVersion.Text = entGame.GameVersion.Value.ToString();

            if (!entGame.GameDescription.IsNull)
                txtGameDescription.Text = entGame.GameDescription.Value.ToString();

            if (!entGame.ImageUrl.IsNull)
                imgGame.ImageUrl = entGame.ImageUrl.Value.ToString();
            imgGame.Visible = true;
        }
    }

    #endregion LoadControls

    #region Button : Save

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region Server Side Validation

        String strError = String.Empty;

        if (txtGameName.Text.Trim() == String.Empty)
            strError += "- Enter Game Name<br />";

        if (ddlGameCategory.SelectedIndex == 0)
            strError += "- Select Game Category<br />";

        if (ddlGameCreator.SelectedIndex == 0)
            strError += "- Select Game Creator<br />";

        if (ddlGameDevice.SelectedIndex == 0)
            strError += "- Select Game Device<br />";

        if (txtReleaseDate.Text.Trim() == String.Empty)
            strError += "- Enter Release Date<br />";

        if (txtGameDescription.Text.Trim() == String.Empty)
            strError += "- Enter Game Description<br />";

        if (txtGameVersion.Text.Trim() == String.Empty)
            strError += "- Enter Game Version<br />";

        if (imgGame.ImageUrl.Trim() == String.Empty)
            strError += "- Enter Game Image<br />";

        if (strError.Trim() != String.Empty)
        {
            lblMessage.Text = "Kindly Correct Following Error(s)<br />" + strError; ;
        }

        #endregion Server Side Validation

        if (Session["UserID"] != null)
        {
            GameENT entGame = new GameENT();
            GameBAL balGame = new GameBAL();

            #region Gather Data

            if (txtGameName.Text.Trim() != String.Empty)
                entGame.GameName = txtGameName.Text.Trim();

            if (ddlGameCategory.SelectedIndex > 0)
                entGame.GameCategoryID = Convert.ToInt32(ddlGameCategory.SelectedValue);

            if (ddlGameCreator.SelectedIndex > 0)
                entGame.GameCreatorID = Convert.ToInt32(ddlGameCreator.SelectedValue);

            if (ddlGameDevice.SelectedIndex > 0)
                entGame.GameDeviceID = Convert.ToInt32(ddlGameDevice.SelectedValue);

            if (txtGameDescription.Text.Trim() != "")
                entGame.GameDescription = txtGameDescription.Text.Trim();

            if (txtReleaseDate.Text.Trim() != "")
                entGame.ReleaseDate = DateTime.Parse(txtReleaseDate.Text.Trim());

            if (txtGameVersion.Text.Trim() != "")
                entGame.GameVersion = txtGameVersion.Text.Trim();

            entGame.UserID = Convert.ToInt32(Session["UserID"]);

            string strImagePath = "~/Content/img/Game/";
            if (fuImage.HasFile)
            {
                entGame.ImageUrl = strImagePath + fuImage.FileName;
            }
            else
            {
                entGame.ImageUrl = imgGame.ImageUrl;
            }

            #region Upload Image

            if (fuImage.HasFile)
            {
                if (CommonFunctions.IsValidPhoto(fuImage, fuImage.FileName) == String.Empty)
                {
                    if (!CommonFunctions.UploadDocument(fuImage, Server.MapPath(strImagePath), Server.MapPath(strImagePath + fuImage.FileName), Server.MapPath(strImagePath + fuImage.FileName)))
                    {
                        lblMessage.Text = "Kindly Select a Image to Upload";
                    }
                }
                else
                {
                    lblMessage.Text = CommonFunctions.IsValidPhoto(fuImage, fuImage.FileName);
                    return;
                }
            }

            #endregion Upload Image

            //entGame.UserID = 1;
            //entGame.CreationDate = DateTime.Now;

            if (Request.QueryString["GameID"] == null)
            {
                balGame.Insert(entGame);
                lblMessage.Text = "Data Inserted Successfully";
                ClearControls();
            }
            else
            {
                entGame.GameID = Convert.ToInt32(Request.QueryString["GameID"]);
                balGame.Update(entGame);
                Response.Redirect("~/AdminPanel/Game/GameList.aspx");
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

    #region FillDropDownList

    private void FillDropDownList()
    {
        CommonFillMethod.FillDropDownListGameCategoryID(ddlGameCategory);
        CommonFillMethod.FillDropDownListGameCreatorID(ddlGameCreator);
        CommonFillMethod.FillDropDownListGameDeviceID(ddlGameDevice);
    }

    #endregion FillDropDownList

    #region ClearControls

    private void ClearControls()
    {
        txtGameName.Text = "";
        ddlGameCategory.SelectedIndex = 0;
        ddlGameCreator.SelectedIndex = 0;
        ddlGameDevice.SelectedIndex = 0;
        txtGameDescription.Text = "";
        txtReleaseDate.Text = "";
        txtGameVersion.Text = "";
    }

    #endregion ClearControls
}