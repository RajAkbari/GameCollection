using GameCollection.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserBAL
/// </summary>
namespace GameCollection.BAL
{
    public class UserBAL:UserBALBase
    {
        #region SelectByUserNameAndPassword

        public DataTable SelectByUserNameAndPassword(SqlString UserName, SqlString Password)
        {
            UserDAL dalUser = new UserDAL();
            return dalUser.SelectByUserNamePassword(UserName, Password);
        }

        #endregion SelectByUserNameAndPassword
    }
}