using block_res.Code_Files.Types;
using System.ComponentModel.DataAnnotations;

namespace block_res.Code_Files.Entity {

    public abstract class EntityBase {

        public Int32 RowUID { get; set; } = -1;

        [Required, MinLength(2), MaxLength(50)]
        public string FirstName { get; set; } = "";

        [Required, MinLength(2), MaxLength(50)]
        public string LastName { get; set; } = "";

        [Required, MinLength(5), MaxLength(100)]
        public string Address1 { get; set; } = "";

        public string Address2 { get; set; } = "";

        [Required, MinLength(2), MaxLength(50)]
        public string City { get; set; } = "";

        [Required, MinLength(2), MaxLength(25)]
        public string State { get; set; } = "";

        [Required, MinLength(5), MaxLength(10)]
        public string PostalCode { get; set; } = "";

        [MinLength(10), MaxLength(50)]
        public string Phone1 { get; set; } = "";

        public PhoneType Phone1Type { get; set; } = PhoneType.NotSet;

    }

}
