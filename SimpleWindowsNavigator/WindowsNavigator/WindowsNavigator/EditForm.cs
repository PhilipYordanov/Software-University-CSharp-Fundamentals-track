namespace WindowsNavigator
{
    using System;
    using System.Windows.Forms;

    public partial class EditForm : Form
    {
        public EditForm()
        {
            this.InitializeComponent();
        }

        private Form mainForm;

        public EditForm(MainForm mainForm)
        {
            this.InitializeComponent();
            this.mainForm = mainForm;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            // @"Data Source = DESKTOP - 52UDVT7\SQLEXPRESS; Initial Catalog = WindowsNavigator; Integrated Security = True"
            // this.mainForm.Controls["SoftUni"].Text = this.ButtonsGridView.Rows[].Cells[].Value;
        }
    }
}
