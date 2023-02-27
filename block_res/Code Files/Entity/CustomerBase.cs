using System.Reflection;
using block_res.Code_Files.Types;

namespace block_res.Code_Files.Entity {
    
    public class CustomerBase : EntityBase {
        
        public string EmergencyContact { get; set; } = "";
        public string EmergencyAddress1 { get; set; } = "";
        public string EmergencyAddress2 { get; set; } = "";
        public string EmergencyCity { get; set; } = "";
        public string EmergencyState { get; set; } = "";
        public string EmergencyPostalCode { get; set; } = "";
        public string EmergencyPhone1 { get; set; } = "";
        public PhoneType EmergencyPhone1Type { get; set; } = PhoneType.NotSet;

        public void CleanCustomer() {
            SystemTools.SystemTools CleanObject = new SystemTools.SystemTools();
            object ThisObject = this;
            CleanObject.CleanClassProperties(ref ThisObject);
        }

        public void WildcardHandle() {
            //if you need to convert a wild card DB search char
            string ValueCompare = "";
            PropertyInfo[] TypeProperties = this.GetType().GetProperties().ToArray();
            PropertyInfo PropertyValue;
            for (Int32 i = 0; i <= TypeProperties.Length - 1; ++i) {
                PropertyValue = this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .FirstOrDefault(x => x.Name.Equals(TypeProperties[i].Name, StringComparison.OrdinalIgnoreCase));
                ValueCompare = PropertyValue.GetValue(this, null).ToString();
                if (ValueCompare.Contains("*")) {
                    ValueCompare = ValueCompare.Replace("*", "%");
                    PropertyValue.SetValue(this, ValueCompare);
                }
            }
        }

    }

}
