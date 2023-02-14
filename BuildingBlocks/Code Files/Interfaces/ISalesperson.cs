
namespace BuildingBlocks.Code_Files.Interfaces {

    internal interface ISalesperson {
        Int32 RowUID { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedStamp { get; set; }
        string UpdatedBy { get; set; }
        DateTime UpdatedStamp { get; set; }
        bool UpdateEntity();
        List<ISalesperson> GetEntities(Int32 RowUID = -1);
        bool DeleteEntity(Int32 RowUID);
    }

}
