using GameCollection.DAL;
using GameCollection.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GameCategoryBALBase
/// </summary>
namespace GameCollection.BAL
{
    public abstract class GameCategoryBALBase
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

        #region Insert Operation

        public Boolean Insert(GameCategoryENT entGameCategory)
        {
            GameCategoryDAL GameCategoryDAL = new GameCategoryDAL();
            if (GameCategoryDAL.Insert(entGameCategory))
            {
                return true;
            }
            else
            {
                this.Message = GameCategoryDAL.Message;
                return false;
            }
        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(GameCategoryENT entGameCategory)
        {
            GameCategoryDAL GameCategoryDAL = new GameCategoryDAL();
            if (GameCategoryDAL.Update(entGameCategory))
            {
                return true;
            }
            else
            {
                this.Message = GameCategoryDAL.Message;
                return false;
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 GameCategoryID)
        {
            GameCategoryDAL GameCategoryDAL = new GameCategoryDAL();
            if (GameCategoryDAL.Delete(GameCategoryID))
            {
                return true;
            }
            else
            {
                this.Message = GameCategoryDAL.Message;
                return false;
            }
        }

        #endregion Delete Operation

        #region Select Operations

        public DataTable SelectAll()
        {
            GameCategoryDAL dalGameCategory = new GameCategoryDAL();
            return dalGameCategory.SelectAll();
        }

        public GameCategoryENT SelectByPK(SqlInt32 GameCategoryID)
        {
            GameCategoryDAL dalGameCategory = new GameCategoryDAL();
            return dalGameCategory.SelectByPK(GameCategoryID);
        }

        public DataTable SelectDropDownList()
        {
            GameCategoryDAL dalGameCategory = new GameCategoryDAL();
            return dalGameCategory.SelectDropDownList();
        }

        #endregion Select Operations
    }
}