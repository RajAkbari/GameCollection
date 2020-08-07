using GameCollection.DAL;
using GameCollection.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserBALBase
/// </summary>
namespace GameCollection.BAL
{
    public abstract class UserBALBase
    {
        #region Local Variables
        protected string _Message;

        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        #endregion Local Variables

        #region InsertOperation

        public Boolean Insert(UserENT entUser)
        {
            UserDAL dalUser = new UserDAL();
            if (dalUser.Insert(entUser))
            {
                return true;
            }
            else
            {
                this.Message = dalUser.Message;
                return false;
            }
        }

        #endregion InsertOperation

        #region UpdateOperation

        public Boolean Update(UserENT entrUser)
        {
            UserDAL dalUser = new UserDAL();
            if (dalUser.Update(entrUser))
            {
                return true;
            }
            else
            {
                this.Message = dalUser.Message;
                return false;
            }
        }

        #endregion UpdateOperation

        #region DeleteOperation

        public Boolean Delete(SqlInt32 UserID)
        {
            UserDAL dalUser = new UserDAL();
            if (dalUser.Delete(UserID))
            {
                return true;
            }
            else
            {
                this.Message = dalUser.Message;
                return false;
            }
        }

        #endregion DeleteOperation

        #region SelectOperation

        public UserENT SelectPK(SqlInt32 UserID)
        {
            UserDAL dalUser = new UserDAL();
            return dalUser.SelectByPK(UserID);
        }
        
        public DataTable SelectAll()
        {
            UserDAL dalUser = new UserDAL();
            return dalUser.SelectAll();
        }

        #endregion SelectOperation
        
    }
}