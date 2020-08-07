using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GameCreatorENTBase
/// </summary>
namespace GameCollection.ENT
{
    public abstract class GameCreatorENTBase
    {
   
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

        protected SqlString _GameCreatorName;
        public SqlString GameCreatorName
        {
            get
            {
                return _GameCreatorName;
            }
            set
            {
                _GameCreatorName = value;
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