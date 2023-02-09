using block_res.Code_Files.Types;

namespace BuildingBlocks.Code_Files.SystemTools {

    internal class MessageFunctions {

        internal static void ErrorMessage(Exception EX, string FormName, string MessageOverride = "") {
            if (MessageOverride == "") {
                MessageBox.Show(EX.Message, SystemTypeFunctions.GetSystemTitle(SystemTitle.SalesDashboard),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show(MessageOverride, SystemTypeFunctions.GetSystemTitle(SystemTitle.SalesDashboard),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
