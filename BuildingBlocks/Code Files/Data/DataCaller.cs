using BuildingBlocks.Code_Files.Interfaces;
using System.Data.SqlClient;
using block_res.Code_Files.Types;
using block_res.Code_Files.Data;
using System.Collections;
using System.Data;
using BuildingBlocks.Code_Files.BusinessClasses;

namespace BuildingBlocks.Code_Files.Data {
        
    internal class DataCaller {

        internal bool UpdateCustomerProfile(IEntity CustomerProfile) {

            bool Result = false;
            ArrayList Parms = new ArrayList() { 
                new SqlParameter("intRowUID", CustomerProfile.RowUID),
                new SqlParameter("nvarFirstName", CustomerProfile.FirstName),
                new SqlParameter("nvarLastName", CustomerProfile.LastName),
                new SqlParameter("nvarCreatedBy", ((Customer)CustomerProfile).CreatedBy)
            };

            object Reader = (SqlDataReader)DataConn.GetDataCaller(CommandType.StoredProcedure, "UpdateCustomerSp", DataReturnType.DataReader, Parms);
            if ((SqlDataReader)Reader != null) {
                if (((SqlDataReader)Reader).RecordsAffected > 0) {
                    Result = true;
                }
            }

            return Result;
        }

        internal List<IEntity> GetCustomerList(Int32 RowUID = -1) { 
        
            List<IEntity> ResultList = new List<IEntity>();
            IEntity CustomerProfile;
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
                    ((Customer)CustomerProfile).UpdatedBy = Reader.GetValue(Reader.GetOrdinal("updated_by")) as string ?? "";
                    ((Customer)CustomerProfile).UpdatedStamp = Reader.GetValue(Reader.GetOrdinal("updated_date_time")) as DateTime? ?? default;
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

        internal bool UpdateSalespersonProfile(IEntity SalespersonProfile) {

            return true;
        }

        internal List<IEntity> GetSalespersonList(Int32 RowUID = -1) {

            List<IEntity> ResultList = new List<IEntity>();
            IEntity SalespersonProfile;
            ArrayList Parms = new ArrayList() {
                new SqlParameter("intRowUID", RowUID)
            };

            return ResultList;
        }

        internal bool DeleteSalespersonProfile(Int32 RowUID) {

            bool Result = false;
            ArrayList Parms = new ArrayList() {
                new SqlParameter("intRowUID", RowUID)
            };

            return Result;
        }

        internal bool UpdateVendorProfile(IEntity VendorProfile) {

            return true;
        }

        internal List<IEntity> GetVendorList(Int32 RowUID = -1) {

            List<IEntity> ResultList = new List<IEntity>();
            IEntity VendorProfile;
            ArrayList Parms = new ArrayList() {
                new SqlParameter("intRowUID", RowUID)
            };

            return ResultList;
        }

        internal bool DeleteVendorProfile(Int32 RowUID) {

            bool Result = false;
            ArrayList Parms = new ArrayList() {
                new SqlParameter("intRowUID", RowUID)
            };

            return Result;
        }

    }

}
