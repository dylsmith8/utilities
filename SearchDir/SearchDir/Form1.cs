using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchDir
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openDir_Click(object sender, EventArgs e)
        {
            string dir = GetSelectedPath();
            txtDir.Text = dir;
            HelperValues.SearchDirectory = dir;
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            HelperValues.FileExtension = txtBoxExtension.Text;

            List<string> results = new List<string>();

            try
            {
                txtResults.Text = "Searching...";
                btnSearch.Enabled = false;
                results = await SearchDirectory(HelperValues.SearchDirectory, txtSearchText.Text.ToLower(), txtBoxExtension.Text);
                OutputResults(results);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arguments invalid. Please try again.");
            }
            finally
            {
                btnSearch.Enabled = true;
            }
        }

        private static async Task<List<string>> SearchDirectory(string dir, string searchString, string extension)
        {
            string[] files = Directory.GetFiles(dir);
            return await SearchFiles(files, searchString, extension);
        }

        private static async Task<List<string>> SearchFiles(string[] files, string searchString, string extension)
        {
            List<string> filesThatContainText = new List<string>();
            foreach (string file in files)
            {
                if (file.ToLower().EndsWith(extension))
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        string text = await reader.ReadToEndAsync();

                        if (text.Contains(searchString))
                        {
                            filesThatContainText.Add(file);
                        }
                    }
                }
            }

            return filesThatContainText;
        }

        private void OutputResults(List<string> results)
        {
            if (results == null || results.Count == 0)
            {
                txtResults.Text = "Nothing found";
                return;
            }

            StringBuilder builder = new StringBuilder();
            foreach (string result in results)
            {
                builder.AppendLine(Path.GetFileName(result));
            }

            txtResults.Text = builder.ToString();
        }

        private string GetSelectedPath()
        {
            using (var browser = new FolderBrowserDialog())
            {
                DialogResult result = browser.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browser.SelectedPath))
                {
                    return browser.SelectedPath;
                }

                return string.Empty;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtResults.Text = string.Empty;
            txtSearchText.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
