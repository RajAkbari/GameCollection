using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GameENTBase
/// </summary>
namespace GameCollection.ENT
{
    public abstract class GameENTBase
    {
        protected SqlInt32 _GameID;
        public SqlInt32 GameID
        {
            get
            {
                return _GameID;
            }
            set
            {
                _GameID = value;
            }
        }

        protected SqlString _GameName;
        public SqlString GameName
        {
            get
            {
                return _GameName;
            }
            set
            {
                _GameName = value;
            }
        }

        protected SqlInt32 _GameCategoryID;
        public SqlInt32 GameCategoryID
        {
            get
            {
                return _GameCategoryID;
            }
            set
            {
                _GameCategoryID = value;
            }
        }

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

        protected SqlInt32 _GameCreatorID;
        public SqlInt32 GameCreatorID
        {
            get
            {
                return _GameCreatorID;
            }
            set
            {
                _GameCreatorID = value;
            }
        }

        protected SqlString _GameVersion;
        public SqlString GameVersion
        {
            get
            {
                return _GameVersion;
            }
            set
            {
                _GameVersion = value;
            }
        }

        protected SqlString _GameDescription;
        public SqlString GameDescription
        {
            get
            {
                return _GameDescription;
            }
            set
            {
                _GameDescription = value;
            }
        }

        protected SqlString _ImageUrl;
        public SqlString ImageUrl
        {
            get
            {
                return _ImageUrl;
            }
            set
            {
                _ImageUrl = value;
            }
        }

        protected SqlDateTime _ReleaseDate;
        public SqlDateTime ReleaseDate
        {
            get
            {
                return _ReleaseDate;
            }
            set
            {
                _ReleaseDate = value;
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