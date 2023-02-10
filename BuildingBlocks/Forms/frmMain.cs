using BuildingBlocks.Code_Files.BusinessClasses;
using BuildingBlocks.Code_Files.Interfaces;
using BuildingBlocks.Code_Files.SystemTools;

namespace BuildingBlocks {

    public partial class frmMain : Form {

        public frmMain() {
            InitializeComponent();
        }

        private void cmdGetCustomer_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            try {
                if (ValidateGetCustomer()) {
                    GetCustomer();
                }
            }
            catch (Exception EX) {
                MessageFunctions.ErrorMessage(EX, this.Name);
            }
            this.Cursor = Cursors.Default;
        }

        private bool ValidateGetCustomer() {

            //there are various ways to validate the controls
            //if statements and property attributes
            //you can use errorproviders or messages

            return true;
        }

        private void GetCustomer() {

            ICustomer CustomerProfile = new Customer();

            

        }

        private void UpdateCustomer() {

            ICustomer CustomerProfile = new Customer();
            bool Result = false;


            Result = CustomerProfile.UpdateCustomer();
            if (!Result) {
                //didn't save
            }

        }

    }

}