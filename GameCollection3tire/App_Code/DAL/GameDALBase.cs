using GameCollection.ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GameDALBase
/// </summary>
namespace GameCollection
{
    public abstract class GameDALBase : DatabaseConfig
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
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_Game_Insert";
                        objCmd.Parameters.AddWithValue("@GameName", entGame.GameName);
                        objCmd.Parameters.AddWithValue("@GameCategoryID", entGame.GameCategoryID);
                        objCmd.Parameters.AddWithValue("@GameDeviceID", entGame.GameDeviceID);
                        objCmd.Parameters.AddWithValue("@GameCreatorID", entGame.GameCreatorID);
                        objCmd.Parameters.AddWithValue("@ReleaseDate", entGame.ReleaseDate);
                        objCmd.Parameters.AddWithValue("@GameVersion", entGame.GameVersion);
                        objCmd.Parameters.AddWithValue("@GameDescription", entGame.GameDescription);
                        objCmd.Parameters.AddWithValue("@ImageUrl", entGame.ImageUrl);
                        objCmd.Parameters.AddWithValue("@UserID", entGame.UserID);

                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();

                        return true;
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        #endregion Insert Operation

        #region Update Operation

        public Boolean Update(GameENT entGame)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_Game_UpdateByPK";
                        objCmd.Parameters.AddWithValue("@GameID", entGame.GameID);
                        objCmd.Parameters.AddWithValue("@GameName", entGame.GameName);
                        objCmd.Parameters.AddWithValue("@GameCategoryID", entGame.GameCategoryID);
                        objCmd.Parameters.AddWithValue("@GameDeviceID", entGame.GameDeviceID);
                        objCmd.Parameters.AddWithValue("@GameCreatorID", entGame.GameCreatorID);
                        objCmd.Parameters.AddWithValue("@ReleaseDate", entGame.ReleaseDate);
                        objCmd.Parameters.AddWithValue("@GameVersion", entGame.GameVersion);
                        objCmd.Parameters.AddWithValue("@GameDescription", entGame.GameDescription);
                        objCmd.Parameters.AddWithValue("@ImageUrl", entGame.ImageUrl);
                        objCmd.Parameters.AddWithValue("@UserID", entGame.UserID);

                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();

                        return true;
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        #endregion Update Operation

        #region Delete Operation

        public Boolean Delete(SqlInt32 GameID)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_Game_DeleteByPK";
                        objCmd.Parameters.AddWithValue("@GameID", GameID);

                        #endregion Prepare Command

                        objCmd.ExecuteNonQuery();

                        return true;
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return false;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        #endregion Delete Operation

        #region Select Operations

        public DataTable SelectAll()
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_Game_SelectAll";

                        #endregion Prepare Command

                        #region ReadData and Set Controls

                        DataTable dt = new DataTable();
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            dt.Load(objSDR);
                        }
                        return dt;

                        #endregion ReadData and Set Controls
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        public GameENT SelectByPK(SqlInt32 GameID)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_Game_SelectByPK";
                        objCmd.Parameters.AddWithValue("@GameID", GameID);

                        #endregion Prepare Command

                        #region ReadData and Set Controls

                        GameENT entGame = new GameENT();

                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            while (objSDR.Read())
                            {
                                if (!objSDR["GameID"].Equals(DBNull.Value))
                                {
                                    entGame.GameID = Convert.ToInt32(objSDR["GameID"]);
                                }
                                if (!objSDR["GameName"].Equals(DBNull.Value))
                                {
                                    entGame.GameName = Convert.ToString(objSDR["GameName"]);
                                }
                                if (!objSDR["GameCategoryID"].Equals(DBNull.Value))
                                {
                                    entGame.GameCategoryID = Convert.ToInt32(objSDR["GameCategoryID"]);
                                }
                                if (!objSDR["GameDeviceID"].Equals(DBNull.Value))
                                {
                                    entGame.GameDeviceID = Convert.ToInt32(objSDR["GameDeviceID"]);
                                }
                                if (!objSDR["GameCreatorID"].Equals(DBNull.Value))
                                {
                                    entGame.GameCreatorID = Convert.ToInt32(objSDR["GameCreatorID"]);
                                }
                                if (!objSDR["ReleaseDate"].Equals(DBNull.Value))
                                {
                                    entGame.ReleaseDate = Convert.ToDateTime(objSDR["ReleaseDate"]);
                                }
                                if (!objSDR["GameVersion"].Equals(DBNull.Value))
                                {
                                    entGame.GameVersion = Convert.ToString(objSDR["GameVersion"]);
                                }
                                if (!objSDR["GameDescription"].Equals(DBNull.Value))
                                {
                                    entGame.GameDescription = Convert.ToString(objSDR["GameDescription"]);
                                }
                                if (!objSDR["ImageUrl"].Equals(DBNull.Value))
                                {
                                    entGame.ImageUrl = Convert.ToString(objSDR["ImageUrl"]);
                                }
                            }
                        }

                        return entGame;

                        #endregion ReadData and Set Controls
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        public DataTable SelectDropDownList()
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    try
                    {
                        #region Prepare Command

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "PR_Game_SelectDropDownList";

                        #endregion Prepare Command

                        #region ReadData and Set Controls

                        DataTable dt = new DataTable();
                        using (SqlDataReader objSDR = objCmd.ExecuteReader())
                        {
                            dt.Load(objSDR);
                        }
                        return dt;

                        #endregion ReadData and Set Controls
                    }
                    catch (SqlException sqlex)
                    {
                        Message = sqlex.InnerException.Message.ToString();
                        return null;
                    }
                    catch (Exception ex)
                    {
                        Message = ex.InnerException.Message.ToString();
                        return null;
                    }
                    finally
                    {
                        if (objConn.State == ConnectionState.Open)
                            objConn.Close();
                    }
                }
            }
        }

        #endregion Select Operations
    }
}