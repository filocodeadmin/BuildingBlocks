using System.Reflection;

namespace block_res.Code_Files.SystemTools {

    internal class SystemTools {

        internal object CleanClassProperties(ref object TargetObject) {
            PropertyInfo[] Props = TargetObject.GetType().GetProperties();
            foreach (PropertyInfo prop in Props) {
                if (prop.GetType() == typeof(string)) {
                    prop.SetValue(TargetObject, prop.GetValue(prop).ToString().Trim());
                }
            }
            return TargetObject;
        }

    }

}
