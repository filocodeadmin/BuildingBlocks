
namespace BuildingBlocks.Code_Files.Interfaces {

    internal interface ISalesperson {
        bool UpdateEntity();
        List<ISalesperson> GetEntities(Int32 RowUID = -1);
        bool DeleteEntity(Int32 RowUID);
    }

}
