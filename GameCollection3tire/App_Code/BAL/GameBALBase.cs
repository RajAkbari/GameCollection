using GameCollection.DAL;
using GameCollection.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GameBALBase
/// </summary>
namespace GameCollection.BAL
{
    public abstract class GameBALBase
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

        public Boolean Insert(GameENT entGame)
        {
            GameDAL GameDAL = new GameDAL();
            if (GameDAL.Insert(entGame))
            {
                return true;
            }
            else
            {
                this.Message = GameDAL.Message;
                return false;
            }
        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(GameENT entGame)
        {
            GameDAL GameDAL = new GameDAL();
            if (GameDAL.Update(entGame))
            {
                return true;
            }
            else
            {
                this.Message = GameDAL.Message;
                return false;
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 GameID)
        {
            GameDAL GameDAL = new GameDAL();
            if (GameDAL.Delete(GameID))
            {
                return true;
            }
            else
            {
                this.Message = GameDAL.Message;
                return false;
            }
        }

        #endregion Delete Operation


        #region Select Operations

        public DataTable SelectAll()
        {
            GameDAL dalGame = new GameDAL();
            return dalGame.SelectAll();
        }

        public GameENT SelectByPK(SqlInt32 GameID)
        {
            GameDAL dalGame = new GameDAL();
            return dalGame.SelectByPK(GameID);
        }

        public DataTable SelectDropDownList()
        {
            GameDAL dalGame = new GameDAL();
            return dalGame.SelectDropDownList();
        }

        #endregion Select Operations
    }
}