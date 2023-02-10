﻿using block_res.Code_Files.Types;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace block_res.Code_Files.Data {

    public static class DataConn {

        private const string m_MSSQLConnStr = @"User ID=DESKTOP-PJ4CBH3\cferreira;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WMS;Data Source=DESKTOP-PJ4CBH3\SQLEXPRESS";
        private static SqlConnection m_MSSQLConnection = new SqlConnection(m_MSSQLConnStr);
        private static SqlDataReader m_MSSQLDataReader;
        private static SqlCommand m_MSSQLCommand;
        
        public static object GetDataCaller(CommandType CommandType, string CommandString, DataReturnType ReturnType, ArrayList ParmList) {

            object? Result = null;

            m_MSSQLConnection.ConnectionString = CommandString;
            m_MSSQLConnection.Open();
            m_MSSQLCommand = new SqlCommand();
            m_MSSQLCommand.Connection = m_MSSQLConnection;
            m_MSSQLCommand.CommandType = CommandType;
            m_MSSQLCommand.CommandTimeout = 60;
            for (int i = 0; i < ParmList.Count; ++i) {
                _ = m_MSSQLCommand.Parameters.Add((SqlParameter)ParmList[i]);
            }

            switch (ReturnType) {
                case DataReturnType.DataReader:
                    Result = m_MSSQLCommand.ExecuteReader();
                    break;
                case DataReturnType.DataScalar:
                    Result = m_MSSQLCommand.ExecuteScalar();
                    break;
                case DataReturnType.DataNonReader:
                    m_MSSQLCommand.ExecuteNonQuery();
                    break;
            }

            return m_MSSQLDataReader;
        }
        

    }

}