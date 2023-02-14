using BuildingBlocks.Code_Files.Interfaces;
using System.Data.SqlClient;
using block_res.Code_Files.Types;
using block_res.Code_Files.Data;
using System.Collections;
using System.Data;
using BuildingBlocks.Code_Files.BusinessClasses;
using block_res.Code_Files;

namespace BuildingBlocks.Code_Files.Data {
        
    internal class DataCaller {

        internal bool UpdateCustomerProfile(ICustomer CustomerProfile) {

            bool Result = false;
            ArrayList Parms = new ArrayList() { 
                new SqlParameter("intRowUID", CustomerProfile.RowUID),
                new SqlParameter("nvarFirstName", CustomerProfile.FirstName),
                new SqlParameter("nvarLastName", CustomerProfile.LastName),
                new SqlParameter("nvarCreatedBy", CustomerProfile.CreatedBy)
            };

            object Reader = (SqlDataReader)DataConn.GetDataCaller(CommandType.StoredProcedure, "UpdateCustomerSp", DataReturnType.DataReader, Parms);
            if ((SqlDataReader)Reader != null) {
                if (((SqlDataReader)Reader).RecordsAffected > 0) {
                    Result = true;
                }
            }

            return Result;
        }

        internal List<ICustomer> GetCustomerList(Int32 RowUID = -1) { 
        
            List<ICustomer> ResultList = new List<ICustomer>();
            ICustomer CustomerProfile;
            ArrayList Parms = new ArrayList() {
                new SqlParameter("intRowUID", RowUID)
            };

            using (SqlDataReader Reader = (SqlDataReader)DataConn.GetDataCaller(CommandType.StoredProcedure,
                    "GetCustomersSp", DataReturnType.DataReader, Parms)) {
                while (Reader.Read()) {
                    CustomerProfile = new Customer();
                    CustomerProfile.RowUID = Reader.GetValue(Reader.GetOrdinal("row_uid")) as Int32? ?? -1;
                    CustomerProfile.FirstName = Reader.GetValue(Reader.GetOrdinal("first_name")) as string ?? "";
                    CustomerProfile.LastName = Reader.GetValue(Reader.GetOrdinal("last_name")) as string ?? "";
                    CustomerProfile.UpdatedBy = Reader.GetValue(Reader.GetOrdinal("updated_by")) as string ?? "";
                    CustomerProfile.UpdatedStamp = Reader.GetValue(Reader.GetOrdinal("updated_date_time")) as DateTime? ?? default;
                    ResultList.Add(CustomerProfile);
                }
            }

            return ResultList;
        }

        internal bool DeleteCustomerProfile(Int32 RowUID) {

            bool Result = false;
            ArrayList Parms = new ArrayList() {
                new SqlParameter("intRowUID", RowUID)
            };

            object Reader = (SqlDataReader)DataConn.GetDataCaller(CommandType.StoredProcedure, "DeleteCustomerSp", DataReturnType.DataReader, Parms);
            if ((SqlDataReader)Reader != null) {
                if (((SqlDataReader)Reader).RecordsAffected > 0) {
                    Result = true;
                }
            }

            return Result;
        }

    }

}
