using block_res.Code_Files.Types;
using System.Reflection;

namespace block_res.Code_Files.Entity {

    public class VendorBase : EntityBase {

        public string BusinessName { get; set; } = "";
        public string ContactName { get; set; } = "";
        public string Phone1AccountsReceivable { get; set; } = "";
        public PhoneType Phone1AccountsReceivableType { get; set; } = PhoneType.NotSet;

        public void CleanVendor() {
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
