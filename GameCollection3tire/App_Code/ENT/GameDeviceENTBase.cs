using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GameDeviceENTBase
/// </summary>
namespace GameCollection.ENT
{
    public abstract class GameDeviceENTBase
    {
        protected SqlInt32 _GameDeviceID;
        public SqlInt32 GameDeviceID
        {
            get
            {
                return _GameDeviceID;
            }
            set
            {
                _GameDeviceID = value;
            }
        }

        protected SqlString _GameDeviceName;
        public SqlString GameDeviceName
        {
            get
            {
                return _GameDeviceName;
            }
            set
            {
                _GameDeviceName = value;
            }
        }

        protected SqlInt32 _UserID;
        public SqlInt32 UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }

        protected SqlDateTime _CreationDate;
        public SqlDateTime CreationDate
        {
            get
            {
                return _CreationDate;
            }
            set
            {
                _CreationDate = value;
            }
        }

    }
}