using block_res.Code_Files.Entity;
using BuildingBlocks.Code_Files.Data;
using BuildingBlocks.Code_Files.Interfaces;

namespace BuildingBlocks.Code_Files.BusinessClasses {

    internal class Salesperson : SalespersonBase, ISalesperson {

        public string CreatedBy { get; set; } = "";

        internal Salesperson() {
            //business logic can be here or in the base
        }

        bool ISalesperson.UpdateEntity() {
            //add a number of different checks to properties prior to update
            CleanSalesperson();
            WildcardHandle();
            return new DataCaller().UpdateSalespersonProfile(this);
        }

        List<ISalesperson> ISalesperson.GetEntities(Int32 RowUID = -1) {
            return new DataCaller().GetSalespersonList(RowUID);
        }

        bool ISalesperson.DeleteEntity(Int32 RowUID) {
            return new DataCaller().DeleteSalespersonProfile(RowUID);
        }

    }

}
