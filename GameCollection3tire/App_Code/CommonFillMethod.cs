using GameCollection.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for CommonFillMethods
/// </summary>
namespace GameCollection
{
    public class CommonFillMethod
    {
        #region FillDropDownList GameCategoryID

        public static void FillDropDownListGameCategoryID(DropDownList ddl)
        {
            GameCategoryBAL balGameCategory = new GameCategoryBAL();
            ddl.DataSource = balGameCategory.SelectDropDownList();
            ddl.DataTextField = "GameCategoryName";
            ddl.DataValueField = "GameCategoryID";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("Select Game Category", "-1"));
        }

        #endregion FillDropDownList GameCategoryID

        #region FillDropDownList GameCreatorID

        public static void FillDropDownListGameCreatorID(DropDownList ddl)
        {
            GameCreatorBAL balGameCreator = new GameCreatorBAL();
            ddl.DataSource = balGameCreator.SelectDropDownList();
            ddl.DataTextField = "GameCreatorName";
            ddl.DataValueField = "GameCreatorID";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("Select Game Creator", "-1"));
        }

        #endregion FillDropDownList GameCreatorID

        #region FillDropDownList GameDeviceID

        public static void FillDropDownListGameDeviceID(DropDownList ddl)
        {
            GameDeviceBAL balGameDevice = new GameDeviceBAL();
            ddl.DataSource = balGameDevice.SelectDropDownList();
            ddl.DataTextField = "GameDeviceName";
            ddl.DataValueField = "GameDeviceID";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("Select Game Device", "-1"));

        }

        #endregion FillDropDownList GameDeviceID
    }
}