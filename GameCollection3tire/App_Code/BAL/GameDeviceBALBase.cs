using GameCollection.DAL;
using GameCollection.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GameDeviceBALBase
/// </summary>
namespace GameCollection.BAL
{
    public abstract class GameDeviceBALBase
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

        public Boolean Insert(GameDeviceENT entGameDevice)
        {
            GameDeviceDAL GameDeviceDAL = new GameDeviceDAL();
            if (GameDeviceDAL.Insert(entGameDevice))
            {
                return true;
            }
            else
            {
                this.Message = GameDeviceDAL.Message;
                return false;
            }
        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(GameDeviceENT entGameDevice)
        {
            GameDeviceDAL GameDeviceDAL = new GameDeviceDAL();
            if (GameDeviceDAL.Update(entGameDevice))
            {
                return true;
            }
            else
            {
                this.Message = GameDeviceDAL.Message;
                return false;
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 GameDeviceID)
        {
            GameDeviceDAL GameDeviceDAL = new GameDeviceDAL();
            if (GameDeviceDAL.Delete(GameDeviceID))
            {
                return true;
            }
            else
            {
                this.Message = GameDeviceDAL.Message;
                return false;
            }
        }

        #endregion Delete Operation

        #region Select Operations

        public DataTable SelectAll()
        {
            GameDeviceDAL dalGameDevice = new GameDeviceDAL();
            return dalGameDevice.SelectAll();
        }

        public GameDeviceENT SelectByPK(SqlInt32 GameDeviceID)
        {
            GameDeviceDAL dalGameDevice = new GameDeviceDAL();
            return dalGameDevice.SelectByPK(GameDeviceID);
        }

        public DataTable SelectDropDownList()
        {
            GameDeviceDAL dalGameDevice = new GameDeviceDAL();
            return dalGameDevice.SelectDropDownList();
        }

        #endregion Select Operations
    }
}