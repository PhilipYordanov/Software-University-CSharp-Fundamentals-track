namespace WindowsNavigator
{
    using System;
    using System.Diagnostics;
    using System.Net;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
        }

        public void SoftUni_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    var buttonOnePath = "https://softuni.bg/";

                    using (var stream = client.OpenRead(buttonOnePath))
                    {
                        Process.Start("chrome.exe", buttonOnePath);
                    }
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        public void Judge_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    var buttonTwoPath = "https://judge.softuni.bg/Contests/Compete/Index/232#0";

                    using (var stream = client.OpenRead(buttonTwoPath))
                    {
                        Process.Start("chrome.exe", buttonTwoPath);
                    }
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        public void VisualStudio2017_Click(object sender, EventArgs e)
        {
            ProcessStartInfo buttonThreePath = new ProcessStartInfo();
            buttonThreePath.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\devenv.exe";
            Process.Start(buttonThreePath);
        }

        public void HackerRank_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    var buttonFourPath = "https://www.hackerrank.com/dashboard";

                    using (var stream = client.OpenRead(buttonFourPath))
                    {
                        Process.Start("chrome.exe", buttonFourPath);
                    }
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        public void GitHub_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    var buttonFivePath = "https://github.com/PhilipYordanov";

                    using (var stream = client.OpenRead(buttonFivePath))
                    {
                        Process.Start("chrome.exe", buttonFivePath);
                    }
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        private static void ErrorMessage()
        {
            MessageBox.Show("There is no Internet connection", "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void JSButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                {
                    var buttonSixPath = "https://softuni.bg/trainings/1683/programming-basics-with-javascript-may-2017";

                    using (var stream = client.OpenRead(buttonSixPath))
                    {
                        Process.Start("chrome.exe", buttonSixPath);
                    }
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var editForm = new EditForm(this);
            editForm.ShowDialog();
        }
    }
}
