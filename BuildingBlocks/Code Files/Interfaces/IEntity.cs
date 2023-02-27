using block_res.Code_Files.Types;

namespace BuildingBlocks.Code_Files.Interfaces {

    public interface IEntity {
        Int32 RowUID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        string State { get; set; }
        string PostalCode { get; set; }
        string Phone1 { get; set; }
        PhoneType Phone1Type { get; set; }
        bool Update();
        List<IEntity> Get(Int32 RowUID = -1);
        bool Delete(Int32 RowUID);
    }

}
