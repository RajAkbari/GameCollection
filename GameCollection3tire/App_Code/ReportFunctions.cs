using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using GameCollection;

public class ReportFunctions : DatabaseConfig
{
//    #region Properties

//    private string _Message;
//    public string Message
//    {
//        get
//        {
//            return _Message;
//        }
//        set
//        {
//            _Message = value;
//        }
//    }

//    #endregion Properties

//    #region constructor
//    public ReportFunctions()
//    {
//        //
//        // TODO: Add constructor logic here
//        //
//    }

//    #endregion constructor

//    #region DFR Report
//    public DataTable DFR_FieldDetail_SelectStatisticsForDFRDashBoard(SqlInt32 FieldDetailID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DFR_FieldDetail_SelectForDFRDashBoard");

//            sqlDB.AddInParameter(dbCMD, "@FieldDetailID", SqlDbType.Int, FieldDetailID);

//            DataTable dtDFR_Visitor = new DataTable("PR_DFR_FieldDetail_SelectForDFRDashBoard");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_Visitor);

//            return dtDFR_Visitor;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    public DataTable DFR_DailyWork_SelectForDashBoardByFieldDetailID(SqlInt32 FieldDetailID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DFR_DailyWork_SelectForDashBoardByFieldDetailID");

//            sqlDB.AddInParameter(dbCMD, "@FieldDetailID", SqlDbType.Int, FieldDetailID);

//            DataTable dtDFR_Visitor = new DataTable("PR_DFR_DailyWork_SelectForDashBoardByFieldDetailID");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_Visitor);

//            return dtDFR_Visitor;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    public DataTable DFR_EquipmentUsed_SelectForDashBoardByFieldDetailID(SqlInt32 FieldDetailID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DFR_EquipmentUsed_SelectForDashBoardByFieldDetailID");

//            sqlDB.AddInParameter(dbCMD, "@FieldDetailID", SqlDbType.Int, FieldDetailID);

//            DataTable dtDFR_Visitor = new DataTable("PR_DFR_EquipmentUsed_SelectForDashBoardByFieldDetailID");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_Visitor);

//            return dtDFR_Visitor;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    public DataTable DFR_PersonUsed_SelectForDashBoardByFieldDetailID(SqlInt32 FieldDetailID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DFR_PersonUsed_SelectForDashBoardByFieldDetailID");

//            sqlDB.AddInParameter(dbCMD, "@FieldDetailID", SqlDbType.Int, FieldDetailID);

//            DataTable dtDFR_Visitor = new DataTable("PR_DFR_PersonUsed_SelectForDashBoardByFieldDetailID");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_Visitor);

//            return dtDFR_Visitor;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    public DataTable DFR_MaterialIssued_SelectForDashBoardByFieldDetailID(SqlInt32 FieldDetailID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DFR_MaterialIssued_SelectForDashBoardByFieldDetailID");

//            sqlDB.AddInParameter(dbCMD, "@FieldDetailID", SqlDbType.Int, FieldDetailID);

//            DataTable dtDFR_Visitor = new DataTable("PR_DFR_MaterialIssued_SelectForDashBoardByFieldDetailID");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_Visitor);

//            return dtDFR_Visitor;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    public DataTable DFR_MaterialReceived_SelectForDashBoardByFieldDetailID(SqlInt32 FieldDetailID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DFR_MaterialReceived_SelectForDashBoardByFieldDetailID");

//            sqlDB.AddInParameter(dbCMD, "@FieldDetailID", SqlDbType.Int, FieldDetailID);

//            DataTable dtDFR_Visitor = new DataTable("PR_DFR_MaterialReceived_SelectForDashBoardByFieldDetailID");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_Visitor);

//            return dtDFR_Visitor;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    public DataTable DFR_Visitor_SelectForDashBoardByFieldDetailID(SqlInt32 FieldDetailID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_DFR_Visitor_SelectForDashBoardByFieldDetailID");

//            sqlDB.AddInParameter(dbCMD, "@FieldDetailID", SqlDbType.Int, FieldDetailID);

//            DataTable dtDFR_Visitor = new DataTable("PR_DFR_Visitor_SelectForDashBoardByFieldDetailID");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_Visitor);

//            return dtDFR_Visitor;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    public DataTable DFR_FieldDetail_SelectForPrint(SqlInt32 FieldDetailID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PP_DFR_FieldDetail_SelectForPrintByFieldDetailID");

//            sqlDB.AddInParameter(dbCMD, "@FieldDetailID", SqlDbType.Int, FieldDetailID);

//            DataTable dtDFR_Visitor = new DataTable("PP_DFR_FieldDetail_SelectForPrintByFieldDetailID");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_Visitor);

//            return dtDFR_Visitor;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    #endregion DFR Report

//    #region DailyWork Report
//    public DataTable RPT_DFR_DailyWork_SelectForPrint(SqlInt32 CompanyID, SqlInt32 ProjectID, SqlDateTime FromDate, SqlDateTime ToDate, SqlInt32 DisciplineID, SqlInt32 ActivityID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PP_DFR_DailyWork_SelectForPrint");

//            sqlDB.AddInParameter(dbCMD, "@CompanyID", SqlDbType.Int, CompanyID);
//            sqlDB.AddInParameter(dbCMD, "@ProjectID", SqlDbType.Int, ProjectID);
//            sqlDB.AddInParameter(dbCMD, "@FromDate", SqlDbType.DateTime, FromDate);
//            sqlDB.AddInParameter(dbCMD, "@ToDate", SqlDbType.DateTime, ToDate);
//            sqlDB.AddInParameter(dbCMD, "@DisciplineID", SqlDbType.Int, DisciplineID);
//            sqlDB.AddInParameter(dbCMD, "@ActivityID", SqlDbType.Int, ActivityID);

//            DataTable dtDFR_DailyWork = new DataTable("PP_DFR_DailyWork_SelectForPrint");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_DailyWork);

//            return dtDFR_DailyWork;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    #endregion DailyWork Report

//    #region DFR_Visitor
//    public DataTable RPT_DFR_Visitor_SelectForPrint(SqlInt32 CompanyID, SqlInt32 ProjectID, SqlDateTime FromDate, SqlDateTime ToDate, SqlInt32 VisitorCategoryID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PP_DFR_Visitor_SelectForPrint");

//            sqlDB.AddInParameter(dbCMD, "@CompanyID", SqlDbType.Int, CompanyID);
//            sqlDB.AddInParameter(dbCMD, "@ProjectID", SqlDbType.Int, ProjectID);
//            sqlDB.AddInParameter(dbCMD, "@FromDate", SqlDbType.DateTime, FromDate);
//            sqlDB.AddInParameter(dbCMD, "@ToDate", SqlDbType.DateTime, ToDate);
//            sqlDB.AddInParameter(dbCMD, "@VisitorCategoryID", SqlDbType.Int, VisitorCategoryID);

//            DataTable dtDFR_Visitor = new DataTable("PP_DFR_Visitor_SelectForPrint");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_Visitor);

//            return dtDFR_Visitor;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    #endregion DFR_Visitor

//    #region DFR_PersonUsed
//    public DataTable RPT_DFR_PersonUsed_SelectForPrint(SqlInt32 CompanyID, SqlInt32 ProjectID, SqlDateTime FromDate, SqlDateTime ToDate, SqlInt32 ContractCompanyID, SqlInt32 ResourceCategoryID, SqlInt32 DisciplineID, SqlInt32 ActivityID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PP_DFR_PersonUsed_SelectForPrint");

//            sqlDB.AddInParameter(dbCMD, "@CompanyID", SqlDbType.Int, CompanyID);
//            sqlDB.AddInParameter(dbCMD, "@ProjectID", SqlDbType.Int, ProjectID);
//            sqlDB.AddInParameter(dbCMD, "@FromDate", SqlDbType.DateTime, FromDate);
//            sqlDB.AddInParameter(dbCMD, "@ToDate", SqlDbType.DateTime, ToDate);
//            sqlDB.AddInParameter(dbCMD, "@ContractCompanyID", SqlDbType.Int, ContractCompanyID);
//            sqlDB.AddInParameter(dbCMD, "@ResourceCategoryID", SqlDbType.Int, ResourceCategoryID);
//            sqlDB.AddInParameter(dbCMD, "@DisciplineID", SqlDbType.Int, DisciplineID);
//            sqlDB.AddInParameter(dbCMD, "@ActivityID", SqlDbType.Int, ActivityID);

//            DataTable dtDFR_PersonUsed = new DataTable("PP_DFR_PersonUsed_SelectForPrint");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_PersonUsed);

//            return dtDFR_PersonUsed;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    #endregion DFR_PersonUsed

//    #region DFR_EquipmentUsed
//    public DataTable RPT_DFR_EquipmentUsed_SelectForPrint(SqlInt32 CompanyID, SqlInt32 ProjectID, SqlDateTime FromDate, SqlDateTime ToDate, SqlInt32 ResourceCategoryID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PP_DFR_EquipmentUsed_SelectForPrint");

//            sqlDB.AddInParameter(dbCMD, "@CompanyID", SqlDbType.Int, CompanyID);
//            sqlDB.AddInParameter(dbCMD, "@ProjectID", SqlDbType.Int, ProjectID);
//            sqlDB.AddInParameter(dbCMD, "@FromDate", SqlDbType.DateTime, FromDate);
//            sqlDB.AddInParameter(dbCMD, "@ToDate", SqlDbType.DateTime, ToDate);
//            sqlDB.AddInParameter(dbCMD, "@ResourceCategoryID", SqlDbType.Int, ResourceCategoryID);

//            DataTable dtDFR_PersonUsed = new DataTable("PP_DFR_EquipmentUsed_SelectForPrint");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_PersonUsed);

//            return dtDFR_PersonUsed;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    #endregion DFR_EquipmentUsed

//    #region DFR_MaterialReceived
//    public DataTable RPT_DFR_MaterialReceived_SelectForPrint(SqlInt32 CompanyID, SqlInt32 ProjectID, SqlDateTime FromDate, SqlDateTime ToDate, SqlInt32 SupplierID, SqlInt32 MaterialID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PP_DFR_MaterialReceived_SelectForPrint");

//            sqlDB.AddInParameter(dbCMD, "@CompanyID", SqlDbType.Int, CompanyID);
//            sqlDB.AddInParameter(dbCMD, "@ProjectID", SqlDbType.Int, ProjectID);
//            sqlDB.AddInParameter(dbCMD, "@FromDate", SqlDbType.DateTime, FromDate);
//            sqlDB.AddInParameter(dbCMD, "@ToDate", SqlDbType.DateTime, ToDate);
//            sqlDB.AddInParameter(dbCMD, "@SupplierID", SqlDbType.Int, SupplierID);
//            sqlDB.AddInParameter(dbCMD, "@MaterialID", SqlDbType.Int, MaterialID);

//            DataTable dtDFR_PersonUsed = new DataTable("PP_DFR_MaterialReceived_SelectForPrint");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_PersonUsed);

//            return dtDFR_PersonUsed;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }

//    #endregion DFR_MaterialReceived

//    public DataTable RPT_DFR_MaterialIssued_SelectForPrint(SqlInt32 CompanyID, SqlInt32 ProjectID, SqlDateTime FromDate, SqlDateTime ToDate, SqlInt32 MaterialID, SqlInt32 UnitID)
//    {
//        try
//        {
//            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
//            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PP_DFR_MaterialIssued_SelectForPrint");

//            sqlDB.AddInParameter(dbCMD, "@CompanyID", SqlDbType.Int, CompanyID);
//            sqlDB.AddInParameter(dbCMD, "@ProjectID", SqlDbType.Int, ProjectID);
//            sqlDB.AddInParameter(dbCMD, "@FromDate", SqlDbType.DateTime, FromDate);
//            sqlDB.AddInParameter(dbCMD, "@ToDate", SqlDbType.DateTime, ToDate);
//            sqlDB.AddInParameter(dbCMD, "@MaterialID", SqlDbType.Int, MaterialID);
//            sqlDB.AddInParameter(dbCMD, "@UnitID", SqlDbType.Int, UnitID);

//            DataTable dtDFR_PersonUsed = new DataTable("PP_DFR_MaterialIssued_SelectForPrint");

//            DataBaseHelper DBH = new DataBaseHelper();
//            DBH.LoadDataTable(sqlDB, dbCMD, dtDFR_PersonUsed);

//            return dtDFR_PersonUsed;
//        }
//        catch (SqlException sqlex)
//        {
//            Message = SQLDataExceptionMessage(sqlex);
//            if (SQLDataExceptionHandler(sqlex))
//                throw;
//            return null;
//        }
//        catch (Exception ex)
//        {
//            Message = ExceptionMessage(ex);
//            if (ExceptionHandler(ex))
//                throw;
//            return null;
//        }
//    }
}