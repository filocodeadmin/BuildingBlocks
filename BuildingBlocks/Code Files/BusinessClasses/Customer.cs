using block_res.Code_Files.Entity;
using BuildingBlocks.Code_Files.Data;
using BuildingBlocks.Code_Files.Interfaces;

namespace BuildingBlocks.Code_Files.BusinessClasses {

    internal class Customer : CustomerBase, ICustomer {

        internal Customer() {
            //business logic can be here or in the base
        }

        bool ICustomer.UpdateCustomer() {
            //add a number of different checks to properties prior to update
            CleanCustomer();
            WildcardHandle();
            return new DataCaller().UpdateCustomerProfile(this);
        }

        List<ICustomer> ICustomer.GetCustomers(Int32 RowUID = -1) {
            return new DataCaller().GetCustomerList(RowUID);
        }
            
        bool ICustomer.DeleteCustomer(Int32 RowUID) {
            return new DataCaller().DeleteCustomerProfile(RowUID);
        }

    }

}
