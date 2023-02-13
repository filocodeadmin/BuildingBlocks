using block_res.Code_Files.Types;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace block_res.Code_Files.Data {

    public static class DataConn {
      
        public static object GetDataCaller(CommandType CommandType, string CommandString, DataReturnType ReturnType, ArrayList ParmList) {

        const string MSSQLConnStr = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WMS;Data Source=DESKTOP-PJ4CBH3\SQLEXPRESS";
        SqlConnection MSSQLConnection = new SqlConnection(MSSQLConnStr);
        SqlDataReader MSSQLDataReader = null;
        SqlCommand MSSQLCommand;
        object? Result = null;

            MSSQLConnection.ConnectionString = MSSQLConnStr;
            MSSQLConnection.Open();
            MSSQLCommand = new SqlCommand();
            MSSQLCommand.Connection = MSSQLConnection;
            MSSQLCommand.CommandType = CommandType;
            MSSQLCommand.CommandTimeout = 60;
            MSSQLCommand.CommandText = CommandString;
            for (int i = 0; i < ParmList.Count; ++i) {
                _ = MSSQLCommand.Parameters.Add((SqlParameter)ParmList[i]);
            }

            switch (ReturnType) {
                case DataReturnType.DataReader:
                    Result = MSSQLCommand.ExecuteReader();
                    break;
                case DataReturnType.DataScalar:
                    Result = MSSQLCommand.ExecuteScalar();
                    break;
                case DataReturnType.DataNonReader:
                    MSSQLCommand.ExecuteNonQuery();
                    break;
            }

            return Result;
        }
        

    }

}
