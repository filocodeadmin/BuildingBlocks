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
                LoadDataDefaults();
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

        private void cmdUpdateCustomer_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            try {
                if (ValidateUpdateCustomer()) {
                    UpdateCustomer();
                }
            }
            catch (Exception EX) {
                MessageFunctions.ErrorMessage(EX, this.Name);
            }
            this.Cursor = Cursors.Default;
        }

        private bool ValidateUpdateCustomer() {

            //there are various ways to validate the controls
            //if statements and property attributes
            //you can use errorproviders or messages

            if (this.txtFirstName.Text == "") {
                return false;
            }

            if (this.txtLastName.Text == "") {
                return false;
            }

            return true;
        }

        private void UpdateCustomer() {

            ICustomer CustomerProfile = new Customer();
            bool Result = false;

            CustomerProfile.FirstName = this.txtFirstName.Text;
            CustomerProfile.LastName = this.txtLastName.Text;
            CustomerProfile.CreatedBy = "filocodeadmin";
            Result = CustomerProfile.UpdateCustomer();
            if (!Result) {
                //didn't save
            }

        }

        private void frmMain_Load(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            try {
                LoadDataDefaults();
            }
            catch (Exception EX) {
                MessageFunctions.ErrorMessage(EX, this.Name);
            }
            this.Cursor = Cursors.Default;
        }

        private void LoadDataDefaults() {

            ICustomer CustomerGet = new Customer();
            List<ICustomer> CustomerList = new List<ICustomer>();

            CustomerList = CustomerGet.GetCustomers();

            this.lstvwCustomerList.SuspendLayout();
            this.lstvwCustomerList.Items.Clear();
            foreach (Customer CustomerProfile in CustomerList) {
                this.lstvwCustomerList.Items.Add(CustomerProfile.RowUID.ToString());
                this.lstvwCustomerList.Items[this.lstvwCustomerList.Items.Count - 1].SubItems.Add(CustomerProfile.FirstName);
                this.lstvwCustomerList.Items[this.lstvwCustomerList.Items.Count - 1].SubItems.Add(CustomerProfile.LastName);
                this.lstvwCustomerList.Items[this.lstvwCustomerList.Items.Count - 1].SubItems.Add(CustomerProfile.UpdatedBy);
                this.lstvwCustomerList.Items[this.lstvwCustomerList.Items.Count - 1].SubItems.Add(CustomerProfile.UpdatedStamp.ToString());
            }
            this.lstvwCustomerList.ResumeLayout();

        }

        private void cmdDeleteCustomer_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            try {
                if (ValidateDeleteCustomer()) {
                    DeleteCustomer();
                }
            }
            catch (Exception EX) {
                MessageFunctions.ErrorMessage(EX, this.Name);
            }
            this.Cursor = Cursors.Default;
        }

        private bool ValidateDeleteCustomer() {

            if (this.lstvwCustomerList.SelectedItems.Count < 1) {
                //error message
                return false;
            }

            return true;
        }

        private void DeleteCustomer() {

            ICustomer CustomerProfile = new Customer();
            bool Result = false;
            Int32 SelectedRowUID = Int32.Parse(this.lstvwCustomerList.SelectedItems[0].Text);

            Result = CustomerProfile.DeleteCustomer(SelectedRowUID);
            if (!Result) {
                //didn't delete
            }
            else {
                this.lstvwCustomerList.SuspendLayout();
                this.lstvwCustomerList.SelectedItems[0].Remove();
                this.lstvwCustomerList.ResumeLayout();
            }

        }

    }

}