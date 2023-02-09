
namespace block_res.Code_Files.Types {

    public static class SystemTypeFunctions {

        public static string GetSystemTitle(SystemTitle Title) {

            string Result = "";

            switch (Title) {
                case SystemTitle.SalesDashboard:
                    Result = "Sales Dashboard";
                    break;
            }

            return Result;
        }

    }

}
