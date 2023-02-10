using BuildingBlocks.Code_Files.Interfaces;
using System.Data.SqlClient;
using block_res.Code_Files.Types;
using block_res.Code_Files.Data;
using System.Collections;
using System.Data;
using BuildingBlocks.Code_Files.BusinessClasses;

namespace BuildingBlocks.Code_Files.Data {
        
    internal class DataCaller {

        internal bool UpdateCustomerProfile(ICustomer CustomerProfile) {

            bool Result = false;
            ArrayList Parms = new ArrayList() { 
                new SqlParameter("intRowUID", CustomerProfile.RowUID),
                new SqlParameter("nvarFirstName", CustomerProfile.FirstName)
            };

            object Reader = DataConn.GetDataCaller(CommandType.StoredProcedure, "UpdateCustomerSp", DataReturnType.DataReader, Parms);


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
                    CustomerProfile.FirstName = Reader.GetValue(Reader.GetOrdinal("first_name")) as string ?? "";
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

            object Reader = DataConn.GetDataCaller(CommandType.StoredProcedure, "DeleteCustomerSp", DataReturnType.DataReader, Parms);


            return Result;
        }

        internal bool UpdateVendorProfile(IVendor VendorProfile) {

            bool Result = false;



            return Result;
        }

        internal List<IVendor> GetVendorList(Int32 RowUID = -1) {

            List<IVendor> ResultList = new List<IVendor>();



            return ResultList;
        }

        internal bool DeleteVendorProfile(Int32 RowUID) {

            bool Result = false;



            return Result;
        }

        internal bool UpdateSalespersonProfile(ISalesperson SalespersonProfile) {

            bool Result = false;



            return Result;
        }

        internal List<ISalesperson> GetSalespersonList(Int32 RowUID = -1) {

            List<ISalesperson> ResultList = new List<ISalesperson>();



            return ResultList;
        }

        internal bool DeleteSalespersonProfile(Int32 RowUID) {

            bool Result = false;



            return Result;
        }

    }

}
