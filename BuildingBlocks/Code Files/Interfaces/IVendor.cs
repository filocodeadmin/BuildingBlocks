﻿using block_res.Code_Files.Types;

namespace BuildingBlocks.Code_Files.Interfaces {

    internal interface IVendor {
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
        string BusinessName { get; set; }
        string ContactName { get; set; }
        string Phone1AccountsReceivable { get; set; }
        PhoneType Phone1AccountsReceivableType { get; set; }
        string CreatedBy { get; set; }
        bool UpdateEntity();
        List<IVendor> GetEntities(Int32 RowUID = -1);
        bool DeleteEntity(Int32 RowUID);
    }

}
