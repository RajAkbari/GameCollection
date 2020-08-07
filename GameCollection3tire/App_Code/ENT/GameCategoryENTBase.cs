using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GameCategoryENTBase
/// </summary>
namespace GameCollection.ENT
{
    public abstract class GameCategoryENTBase
    {
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

        protected SqlString _GameCategoryName;
        public SqlString GameCategoryName
        {
            get
            {
                return _GameCategoryName;
            }
            set
            {
                _GameCategoryName = value;
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
        public SqlDateTime CreatonDate
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