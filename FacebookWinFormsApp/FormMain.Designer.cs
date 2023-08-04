namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControlApp = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureBoxSelectedContent = new System.Windows.Forms.PictureBox();
            this.labelViewTitle = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonFavoriteTeams = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPageFeatures = new System.Windows.Forms.TabPage();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelDescription = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControlApp.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(9, 9);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(117, 54);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControlApp
            // 
            this.tabControlApp.Controls.Add(this.tabPageProfile);
            this.tabControlApp.Controls.Add(this.tabPageFeatures);
            this.tabControlApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlApp.Location = new System.Drawing.Point(0, 0);
            this.tabControlApp.Multiline = true;
            this.tabControlApp.Name = "tabControlApp";
            this.tabControlApp.SelectedIndex = 0;
            this.tabControlApp.Size = new System.Drawing.Size(1146, 594);
            this.tabControlApp.TabIndex = 54;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.flowLayoutPanelDescription);
            this.tabPageProfile.Controls.Add(this.panel1);
            this.tabPageProfile.Controls.Add(this.panelSeparator);
            this.tabPageProfile.Controls.Add(this.labelGender);
            this.tabPageProfile.Controls.Add(this.labelCity);
            this.tabPageProfile.Controls.Add(this.labelBirthDay);
            this.tabPageProfile.Controls.Add(this.labelAge);
            this.tabPageProfile.Controls.Add(this.labelEmail);
            this.tabPageProfile.Controls.Add(this.labelViewTitle);
            this.tabPageProfile.Controls.Add(this.pictureBoxProfile);
            this.tabPageProfile.Controls.Add(this.listBoxContent);
            this.tabPageProfile.Controls.Add(this.flowLayoutPanel1);
            this.tabPageProfile.Controls.Add(this.labelName);
            this.tabPageProfile.Controls.Add(this.buttonLogout);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 35);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(1138, 555);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(659, 45);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(90, 26);
            this.labelGender.TabIndex = 67;
            this.labelGender.Text = "Gender:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(659, 9);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(56, 26);
            this.labelCity.TabIndex = 66;
            this.labelCity.Text = "City:";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Location = new System.Drawing.Point(659, 78);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(102, 26);
            this.labelBirthDay.TabIndex = 64;
            this.labelBirthDay.Text = "BirthDay:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(421, 78);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(57, 26);
            this.labelAge.TabIndex = 63;
            this.labelAge.Text = "Age:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(421, 45);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(80, 26);
            this.labelEmail.TabIndex = 62;
            this.labelEmail.Text = "Email: ";
            // 
            // pictureBoxSelectedContent
            // 
            this.pictureBoxSelectedContent.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSelectedContent.Name = "pictureBoxSelectedContent";
            this.pictureBoxSelectedContent.Size = new System.Drawing.Size(107, 109);
            this.pictureBoxSelectedContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedContent.TabIndex = 61;
            this.pictureBoxSelectedContent.TabStop = false;
            // 
            // labelViewTitle
            // 
            this.labelViewTitle.AutoSize = true;
            this.labelViewTitle.Location = new System.Drawing.Point(238, 149);
            this.labelViewTitle.Name = "labelViewTitle";
            this.labelViewTitle.Size = new System.Drawing.Size(73, 26);
            this.labelViewTitle.TabIndex = 60;
            this.labelViewTitle.Text = "Posts:";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(334, 9);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(81, 87);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // listBoxContent
            // 
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.ItemHeight = 26;
            this.listBoxContent.Location = new System.Drawing.Point(243, 178);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(346, 368);
            this.listBoxContent.TabIndex = 59;
            this.listBoxContent.SelectedIndexChanged += new System.EventHandler(this.listBoxContent_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.buttonPosts);
            this.flowLayoutPanel1.Controls.Add(this.buttonFriends);
            this.flowLayoutPanel1.Controls.Add(this.buttonAlbums);
            this.flowLayoutPanel1.Controls.Add(this.buttonGroups);
            this.flowLayoutPanel1.Controls.Add(this.buttonEvents);
            this.flowLayoutPanel1.Controls.Add(this.buttonFavoriteTeams);
            this.flowLayoutPanel1.Controls.Add(this.buttonLikedPages);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 455);
            this.flowLayoutPanel1.TabIndex = 58;
            // 
            // buttonPosts
            // 
            this.buttonPosts.Location = new System.Drawing.Point(3, 3);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Size = new System.Drawing.Size(197, 48);
            this.buttonPosts.TabIndex = 5;
            this.buttonPosts.Text = "Posts";
            this.buttonPosts.UseVisualStyleBackColor = true;
            this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.Location = new System.Drawing.Point(3, 111);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(197, 48);
            this.buttonAlbums.TabIndex = 0;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Location = new System.Drawing.Point(3, 165);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(197, 48);
            this.buttonGroups.TabIndex = 1;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(3, 219);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(197, 48);
            this.buttonEvents.TabIndex = 2;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonFavoriteTeams
            // 
            this.buttonFavoriteTeams.Location = new System.Drawing.Point(3, 273);
            this.buttonFavoriteTeams.Name = "buttonFavoriteTeams";
            this.buttonFavoriteTeams.Size = new System.Drawing.Size(197, 48);
            this.buttonFavoriteTeams.TabIndex = 3;
            this.buttonFavoriteTeams.Text = "Favorite Teams";
            this.buttonFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFavoriteTeams.Click += new System.EventHandler(this.buttonFavoriteTeams_Click);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Location = new System.Drawing.Point(3, 327);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(197, 48);
            this.buttonLikedPages.TabIndex = 4;
            this.buttonLikedPages.Text = "Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(421, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(219, 26);
            this.labelName.TabIndex = 57;
            this.labelName.Text = "FirstName LastName";
            // 
            // tabPageFeatures
            // 
            this.tabPageFeatures.Location = new System.Drawing.Point(4, 35);
            this.tabPageFeatures.Name = "tabPageFeatures";
            this.tabPageFeatures.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFeatures.Size = new System.Drawing.Size(1138, 555);
            this.tabPageFeatures.TabIndex = 1;
            this.tabPageFeatures.Text = "Extra Features";
            this.tabPageFeatures.UseVisualStyleBackColor = true;
            // 
            // buttonFriends
            // 
            this.buttonFriends.Location = new System.Drawing.Point(3, 57);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(197, 48);
            this.buttonFriends.TabIndex = 6;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = System.Drawing.Color.DimGray;
            this.panelSeparator.Location = new System.Drawing.Point(243, 119);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(895, 2);
            this.panelSeparator.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(215, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 538);
            this.panel1.TabIndex = 69;
            // 
            // flowLayoutPanelDescription
            // 
            this.flowLayoutPanelDescription.Controls.Add(this.pictureBoxSelectedContent);
            this.flowLayoutPanelDescription.Location = new System.Drawing.Point(601, 178);
            this.flowLayoutPanelDescription.Name = "flowLayoutPanelDescription";
            this.flowLayoutPanelDescription.Size = new System.Drawing.Size(529, 368);
            this.flowLayoutPanelDescription.TabIndex = 70;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 594);
            this.Controls.Add(this.tabControlApp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.tabControlApp.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanelDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl tabControlApp;
		private System.Windows.Forms.TabPage tabPageProfile;
		private System.Windows.Forms.TabPage tabPageFeatures;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonFavoriteTeams;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.ListBox listBoxContent;
        private System.Windows.Forms.Label labelViewTitle;
        private System.Windows.Forms.PictureBox pictureBoxSelectedContent;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSeparator;
    }
}

