using block_res.Code_Files.Entity;
using BuildingBlocks.Code_Files.Data;
using BuildingBlocks.Code_Files.Interfaces;

namespace BuildingBlocks.Code_Files.BusinessClasses {

    internal class Customer : CustomerBase, IEntity {

        public string CreatedBy { get; set; } = "";
        public DateTime CreatedStamp { get; set; } = default;
        public string UpdatedBy { get; set; } = "";
        public DateTime UpdatedStamp { get; set; } = default;

        internal Customer() {
            //business logic can be here or in the base
        }

        bool IEntity.Update() {
            //add a number of different checks to properties prior to update
            CleanCustomer();
            WildcardHandle();
            return new DataCaller().UpdateCustomerProfile(this);
        }

        List<IEntity> IEntity.Get(int RowUID) {
            return new DataCaller().GetCustomerList(RowUID);
        }

        bool IEntity.Delete(int RowUID) {
            return new DataCaller().DeleteCustomerProfile(RowUID);
        }

    }

}
