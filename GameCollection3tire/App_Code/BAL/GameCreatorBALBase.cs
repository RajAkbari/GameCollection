using GameCollection.DAL;
using GameCollection.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GameCreatorBALBase
/// </summary>
namespace GameCollection.BAL
{
    public abstract class GameCreatorBALBase
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

        public Boolean Insert(GameCreatorENT entGameCreator)
        {
            GameCreatorDAL GameCreatorDAL = new GameCreatorDAL();
            if (GameCreatorDAL.Insert(entGameCreator))
            {
                return true;
            }
            else
            {
                this.Message = GameCreatorDAL.Message;
                return false;
            }
        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(GameCreatorENT entGameCreator)
        {
            GameCreatorDAL GameCreatorDAL = new GameCreatorDAL();
            if (GameCreatorDAL.Update(entGameCreator))
            {
                return true;
            }
            else
            {
                this.Message = GameCreatorDAL.Message;
                return false;
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 GameCreatorID)
        {
            GameCreatorDAL GameCreatorDAL = new GameCreatorDAL();
            if (GameCreatorDAL.Delete(GameCreatorID))
            {
                return true;
            }
            else
            {
                this.Message = GameCreatorDAL.Message;
                return false;
            }
        }

        #endregion Delete Operation

        #region Select Operations

        public DataTable SelectAll()
        {
            GameCreatorDAL dalGameCreator = new GameCreatorDAL();
            return dalGameCreator.SelectAll();
        }

        public GameCreatorENT SelectByPK(SqlInt32 GameCreatorID)
        {
            GameCreatorDAL dalGameCreator = new GameCreatorDAL();
            return dalGameCreator.SelectByPK(GameCreatorID);
        }

        public DataTable SelectDropDownList()
        {
            GameCreatorDAL dalGameCreator = new GameCreatorDAL();
            return dalGameCreator.SelectDropDownList();
        }

        #endregion Select Operations
       
    }
}