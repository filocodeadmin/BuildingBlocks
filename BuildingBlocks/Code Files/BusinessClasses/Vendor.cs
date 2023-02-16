using block_res.Code_Files.Entity;
using BuildingBlocks.Code_Files.Data;
using BuildingBlocks.Code_Files.Interfaces;

namespace BuildingBlocks.Code_Files.BusinessClasses {

    internal class Vendor : VendorBase , IEntity {

        public string CreatedBy { get; set; } = "";
        public DateTime CreatedStamp { get; set; } = default;
        public string UpdatedBy { get; set; } = "";
        public DateTime UpdatedStamp { get; set; } = default;

        internal Vendor() {
            //business logic can be here or in the base
        }

        bool IEntity.Update() {
            //add a number of different checks to properties prior to update
            CleanVendor();
            WildcardHandle();
            return new DataCaller().UpdateVendorProfile(this);
        }

        List<IEntity> IEntity.Get(int RowUID) {
            return new DataCaller().GetVendorList(RowUID);
        }

        bool IEntity.Delete(int RowUID) {
            return new DataCaller().DeleteVendorProfile(RowUID);
        }

    }

}
