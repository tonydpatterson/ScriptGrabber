using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ScriptGrabber
{
    public partial class MainForm : Form
    {
        private List<string> scriptFolders = new List<string>();
        private string saveFilePath = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            lblError.Text = string.Empty;
            UpdateButtonStates();
            SetLogoImage();
        }

        private void SetLogoImage()
        {
            // Assuming your logo is named "logo.png" and added to the project
            // as an embedded resource.
            pictureBoxLogo.Image = Image.FromFile("dss_logo.jpg");
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    scriptFolders.Add(dialog.SelectedPath);
                    lstFolders.Items.Add(dialog.SelectedPath);
                    UpdateButtonStates();
                }
            }
        }

        private void btnRemoveFolder_Click(object sender, EventArgs e)
        {
            if (lstFolders.SelectedItem != null)
            {
                scriptFolders.Remove(lstFolders.SelectedItem.ToString());
                lstFolders.Items.Remove(lstFolders.SelectedItem);
                UpdateButtonStates();
            }
        }

        private void btnClearFolders_Click(object sender, EventArgs e)
        {
            scriptFolders.Clear();
            lstFolders.Items.Clear();
            UpdateButtonStates();
        }

        private void btnSaveLocations_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    saveFilePath = dialog.FileName;
                    lblSaveDestination.Text = $"Save Destination: {saveFilePath}";
                }
            }
        }

        private void btnGenerateDocument_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;

            if (scriptFolders.Count == 0)
            {
                lblError.Text = "No script locations have been selected.";
                return;
            }

            if (string.IsNullOrEmpty(saveFilePath))
            {
                lblError.Text = "No save location selected.";
                return;
            }

            try
            {
                GenerateDocument();
                MessageBox.Show("Document generated successfully.", "Success", MessageBoxButtons.OK);
                btnOpenSaveLocation.Visible = true;
            }
            catch (IOException ex)
            {
                lblError.Text = $"Error saving document: {ex.Message}";
            }
        }

        private void GenerateDocument()
        {
            StringBuilder documentContent = new StringBuilder();
            documentContent.AppendLine(txtProjectDescription.Text);
            documentContent.AppendLine();

            foreach (var folder in scriptFolders)
            {
                var files = Directory.GetFiles(folder, "*.cs", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    string className = Path.GetFileNameWithoutExtension(file);
                    string scriptContent = File.ReadAllText(file);

                    documentContent.AppendLine("------------ #StartOf" + className + "# ------------");
                    documentContent.AppendLine(scriptContent);
                    documentContent.AppendLine("------------ #EndOf" + className + "# ------------");
                    documentContent.AppendLine();
                }
            }

            File.WriteAllText(saveFilePath, documentContent.ToString());
        }

        private void btnOpenSaveLocation_Click(object sender, EventArgs e)
        {
            string folderPath = Path.GetDirectoryName(saveFilePath);
            if (!string.IsNullOrEmpty(folderPath))
            {
                System.Diagnostics.Process.Start("explorer.exe", folderPath);
            }
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            ProjectData projectData = new ProjectData
            {
                ScriptFolders = scriptFolders,
                ProjectDescription = txtProjectDescription.Text
            };

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "ScriptGrabber Project (*.sgproj)|*.sgproj";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string json = JsonConvert.SerializeObject(projectData, Formatting.Indented);
                    File.WriteAllText(dialog.FileName, json);
                }
            }
        }

        private void btnLoadProject_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "ScriptGrabber Project (*.sgproj)|*.sgproj";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string json = File.ReadAllText(dialog.FileName);
                    ProjectData projectData = JsonConvert.DeserializeObject<ProjectData>(json);

                    scriptFolders = projectData.ScriptFolders;
                    txtProjectDescription.Text = projectData.ProjectDescription;

                    lstFolders.Items.Clear();
                    foreach (var folder in scriptFolders)
                    {
                        lstFolders.Items.Add(folder);
                    }
                    UpdateButtonStates();
                }
            }
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            scriptFolders.Clear();
            txtProjectDescription.Clear();
            lstFolders.Items.Clear();
            lblSaveDestination.Text = "Choose a Save Destination";
            btnOpenSaveLocation.Visible = false;
            UpdateButtonStates();
        }

        private void txtProjectDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void lstFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            bool hasData = scriptFolders.Count > 0 || !string.IsNullOrEmpty(txtProjectDescription.Text);
            btnNewProject.Enabled = hasData;
            btnSaveProject.Enabled = hasData;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
