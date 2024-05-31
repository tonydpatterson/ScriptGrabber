namespace ScriptGrabber
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtProjectDescription;
        private Button btnAddFolder;
        private Button btnRemoveFolder;
        private Button btnClearFolders;
        private Button btnSaveLocations;
        private Button btnGenerateDocument;
        private ListBox lstFolders;
        private Label lblError;
        private Label lblSaveDestination;
        private Button btnOpenSaveLocation;
        private Button btnSaveProject;
        private Button btnLoadProject;
        private Button btnNewProject;
        private PictureBox pictureBoxLogo;
        private Label label1;
        private Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtProjectDescription = new TextBox();
            btnAddFolder = new Button();
            btnRemoveFolder = new Button();
            btnClearFolders = new Button();
            btnSaveLocations = new Button();
            btnGenerateDocument = new Button();
            lstFolders = new ListBox();
            lblError = new Label();
            lblSaveDestination = new Label();
            btnOpenSaveLocation = new Button();
            btnSaveProject = new Button();
            btnLoadProject = new Button();
            btnNewProject = new Button();
            pictureBoxLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tITLE = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtProjectDescription
            // 
            txtProjectDescription.Location = new Point(11, 338);
            txtProjectDescription.Multiline = true;
            txtProjectDescription.Name = "txtProjectDescription";
            txtProjectDescription.Size = new Size(396, 149);
            txtProjectDescription.TabIndex = 0;
            txtProjectDescription.TextChanged += txtProjectDescription_TextChanged;
            // 
            // btnAddFolder
            // 
            btnAddFolder.Location = new Point(39, 287);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Size = new Size(100, 23);
            btnAddFolder.TabIndex = 1;
            btnAddFolder.Text = "Add Folder";
            btnAddFolder.UseVisualStyleBackColor = true;
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // btnRemoveFolder
            // 
            btnRemoveFolder.Location = new Point(145, 287);
            btnRemoveFolder.Name = "btnRemoveFolder";
            btnRemoveFolder.Size = new Size(100, 23);
            btnRemoveFolder.TabIndex = 2;
            btnRemoveFolder.Text = "Remove Folder";
            btnRemoveFolder.UseVisualStyleBackColor = true;
            btnRemoveFolder.Click += btnRemoveFolder_Click;
            // 
            // btnClearFolders
            // 
            btnClearFolders.Location = new Point(251, 287);
            btnClearFolders.Name = "btnClearFolders";
            btnClearFolders.Size = new Size(100, 23);
            btnClearFolders.TabIndex = 3;
            btnClearFolders.Text = "Clear Folders";
            btnClearFolders.UseVisualStyleBackColor = true;
            btnClearFolders.Click += btnClearFolders_Click;
            // 
            // btnSaveLocations
            // 
            btnSaveLocations.Location = new Point(11, 508);
            btnSaveLocations.Name = "btnSaveLocations";
            btnSaveLocations.Size = new Size(128, 48);
            btnSaveLocations.TabIndex = 4;
            btnSaveLocations.Text = "Save Location";
            btnSaveLocations.UseVisualStyleBackColor = true;
            btnSaveLocations.Click += btnSaveLocations_Click;
            // 
            // btnGenerateDocument
            // 
            btnGenerateDocument.Location = new Point(145, 508);
            btnGenerateDocument.Name = "btnGenerateDocument";
            btnGenerateDocument.Size = new Size(128, 48);
            btnGenerateDocument.TabIndex = 5;
            btnGenerateDocument.Text = "Generate Document";
            btnGenerateDocument.UseVisualStyleBackColor = true;
            btnGenerateDocument.Click += btnGenerateDocument_Click;
            // 
            // lstFolders
            // 
            lstFolders.FormattingEnabled = true;
            lstFolders.ItemHeight = 17;
            lstFolders.Location = new Point(11, 127);
            lstFolders.Name = "lstFolders";
            lstFolders.Size = new Size(396, 140);
            lstFolders.TabIndex = 6;
            lstFolders.SelectedIndexChanged += lstFolders_SelectedIndexChanged;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(12, 271);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 19);
            lblError.TabIndex = 8;
            // 
            // lblSaveDestination
            // 
            lblSaveDestination.AutoSize = true;
            lblSaveDestination.Location = new Point(11, 490);
            lblSaveDestination.Name = "lblSaveDestination";
            lblSaveDestination.Size = new Size(172, 19);
            lblSaveDestination.TabIndex = 7;
            lblSaveDestination.Text = "Choose a Save Destination";
            // 
            // btnOpenSaveLocation
            // 
            btnOpenSaveLocation.Location = new Point(279, 508);
            btnOpenSaveLocation.Name = "btnOpenSaveLocation";
            btnOpenSaveLocation.Size = new Size(128, 48);
            btnOpenSaveLocation.TabIndex = 9;
            btnOpenSaveLocation.Text = "Open Save Location";
            btnOpenSaveLocation.UseVisualStyleBackColor = true;
            btnOpenSaveLocation.Visible = false;
            btnOpenSaveLocation.Click += btnOpenSaveLocation_Click;
            // 
            // btnSaveProject
            // 
            btnSaveProject.Location = new Point(11, 61);
            btnSaveProject.Name = "btnSaveProject";
            btnSaveProject.Size = new Size(128, 34);
            btnSaveProject.TabIndex = 10;
            btnSaveProject.Text = "Save Project";
            btnSaveProject.UseVisualStyleBackColor = true;
            btnSaveProject.Click += btnSaveProject_Click;
            // 
            // btnLoadProject
            // 
            btnLoadProject.Location = new Point(145, 61);
            btnLoadProject.Name = "btnLoadProject";
            btnLoadProject.Size = new Size(128, 34);
            btnLoadProject.TabIndex = 11;
            btnLoadProject.Text = "Load Project";
            btnLoadProject.UseVisualStyleBackColor = true;
            btnLoadProject.Click += btnLoadProject_Click;
            // 
            // btnNewProject
            // 
            btnNewProject.Location = new Point(279, 61);
            btnNewProject.Name = "btnNewProject";
            btnNewProject.Size = new Size(128, 34);
            btnNewProject.TabIndex = 12;
            btnNewProject.Text = "New Project";
            btnNewProject.UseVisualStyleBackColor = true;
            btnNewProject.Click += btnNewProject_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.dss_logo;
            pictureBoxLogo.Location = new Point(362, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(45, 45);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 13;
            pictureBoxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 320);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 14;
            label1.Text = "Project Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 109);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 15;
            label2.Text = "Script Folders";
            // 
            // tITLE
            // 
            tITLE.AutoSize = true;
            tITLE.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold, GraphicsUnit.Point);
            tITLE.Location = new Point(22, 9);
            tITLE.Name = "tITLE";
            tITLE.Size = new Size(237, 44);
            tITLE.TabIndex = 16;
            tITLE.Text = "Script Grabber";
            // 
            // MainForm
            // 
            AccessibleDescription = "An application to collect files into one Document.";
            AccessibleName = "Script Grabber";
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(419, 570);
            Controls.Add(tITLE);
            Controls.Add(pictureBoxLogo);
            Controls.Add(btnNewProject);
            Controls.Add(btnLoadProject);
            Controls.Add(btnSaveProject);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnOpenSaveLocation);
            Controls.Add(lblError);
            Controls.Add(lblSaveDestination);
            Controls.Add(lstFolders);
            Controls.Add(btnGenerateDocument);
            Controls.Add(btnSaveLocations);
            Controls.Add(btnClearFolders);
            Controls.Add(btnRemoveFolder);
            Controls.Add(btnAddFolder);
            Controls.Add(txtProjectDescription);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "ScriptGrabber";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label tITLE;
    }
}
