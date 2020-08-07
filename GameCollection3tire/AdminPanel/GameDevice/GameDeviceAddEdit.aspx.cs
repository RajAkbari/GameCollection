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

public partial class AdminPanel_GameDevice_GameDeviceAddEdit : System.Web.UI.Page
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

            if (Request.QueryString["GameDeviceID"] != null)
            {
                LoadControls(Convert.ToInt32(Request.QueryString["GameDeviceID"]));
            }
        }
    }
    #endregion Load Event

    #region LoadControls
    private void LoadControls(SqlInt32 GameDeviceID)
    {
        if (Session["UserID"] != null)
        {
            GameDeviceENT entGameDevice = new GameDeviceENT();
            GameDeviceBAL balGameDevice = new GameDeviceBAL();

            entGameDevice = balGameDevice.SelectByPK(GameDeviceID);

            if (!entGameDevice.GameDeviceName.IsNull)
                txtGameDeviceName.Text = entGameDevice.GameDeviceName.Value.ToString();

        }
    }

    #endregion LoadControls

    #region Button : Save
    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region Server Side Validation

        String strError = String.Empty;

        if (txtGameDeviceName.Text.Trim() == String.Empty)
            strError += "- Enter GameDevice Name<br />";

        if (strError.Trim() != String.Empty)
        {
            lblMessage.Text = "Kindly Correct Following Error(s)<br />" + strError; ;
        }

        #endregion Server Side Validation
        if (Session["UserID"] != null)
        {

        GameDeviceENT entGameDevice = new GameDeviceENT();
        GameDeviceBAL balGameDevice = new GameDeviceBAL();

        #region Gather Data

        if (txtGameDeviceName.Text.Trim() != String.Empty)
            entGameDevice.GameDeviceName = txtGameDeviceName.Text.Trim();

        entGameDevice.UserID = Convert.ToInt32(Session["UserID"]);
        //entGameDevice.CreationDate = DateTime.Now;

        if (Request.QueryString["GameDeviceID"] == null)
        {
            balGameDevice.Insert(entGameDevice);
            lblMessage.Text = "Data Inserted Successfully";
            ClearControls();
        }
        else
        {
            entGameDevice.GameDeviceID = Convert.ToInt32(Request.QueryString["GameDeviceID"]);
            balGameDevice.Update(entGameDevice);
            Response.Redirect("~/AdminPanel/GameDevice/GameDeviceList.aspx");
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
        txtGameDeviceName.Text = "";

        txtGameDeviceName.Focus();
    }

    #endregion ClearControls
}