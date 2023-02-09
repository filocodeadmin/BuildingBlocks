using block_res.Code_Files.Entity;
using BuildingBlocks.Code_Files.Data;
using BuildingBlocks.Code_Files.Interfaces;

namespace BuildingBlocks.Code_Files.BusinessClasses {

    internal class Vendor : VendorBase, IVendor {

        internal Vendor() {
            //business logic can be here or in the base
        }

        bool IVendor.UpdateEntity() {
            //add a number of different checks to properties prior to update
            CleanVendor();
            WildcardHandle();
            return new DataCaller().UpdateVendorProfile(this);
        }

        List<IVendor> IVendor.GetEntities(Int32 RowUID = -1) {
            return new DataCaller().GetVendorList(RowUID);
        }

        bool IVendor.DeleteEntity(Int32 RowUID) {
            return new DataCaller().DeleteVendorProfile(RowUID);
        }

    }

}
