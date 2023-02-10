using block_res.Code_Files.Types;

namespace BuildingBlocks.Code_Files.Interfaces {

    internal interface ICustomer {
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
        string EmergencyContact { get; set; }
        string EmergencyAddress1 { get; set; }
        string EmergencyAddress2 { get; set; }
        string EmergencyCity { get; set; }
        string EmergencyState { get; set; }
        string EmergencyPostalCode { get; set; }
        string EmergencyPhone1 { get; set; }
        string CreatedBy { get; set; }
        public PhoneType EmergencyPhone1Type { get; set; }
        bool UpdateCustomer();
        List<ICustomer> GetCustomers(Int32 RowUID = -1);
        bool DeleteCustomer(Int32 RowUID);
    }

}
