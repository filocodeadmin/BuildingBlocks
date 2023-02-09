using BuildingBlocks.Code_Files.BusinessClasses;
using BuildingBlocks.Code_Files.Interfaces;

namespace BuildingBlocks.Code_Files.Data {
        
    internal class DataCaller {

        internal bool UpdateCustomerProfile(ICustomer CustomerProfile) {

            bool Result = false;



            return Result;
        }

        internal List<ICustomer> GetCustomerList(Int32 RowUID = -1) { 
        
            List<ICustomer> ResultList = new List<ICustomer>();



            return ResultList;
        }

        internal bool DeleteCustomerProfile(Int32 RowUID) {

            bool Result = false;



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
