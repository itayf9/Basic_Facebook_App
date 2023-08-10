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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControlApp = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.labelBirthDayIcon = new System.Windows.Forms.Label();
            this.labelGenderIcon = new System.Windows.Forms.Label();
            this.labelCityIcon = new System.Windows.Forms.Label();
            this.labelAgeIcon = new System.Windows.Forms.Label();
            this.labelEmailIcon = new System.Windows.Forms.Label();
            this.labelNameIcon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelViewTitle = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonFavoriteTeams = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPageFeatures = new System.Windows.Forms.TabPage();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.tabControlApp.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.tabPageProfile.Controls.Add(this.labelBirthDayIcon);
            this.tabPageProfile.Controls.Add(this.labelGenderIcon);
            this.tabPageProfile.Controls.Add(this.labelCityIcon);
            this.tabPageProfile.Controls.Add(this.labelAgeIcon);
            this.tabPageProfile.Controls.Add(this.labelEmailIcon);
            this.tabPageProfile.Controls.Add(this.labelNameIcon);
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
            this.tabPageProfile.Location = new System.Drawing.Point(4, 27);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(1138, 563);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // labelBirthDayIcon
            // 
            this.labelBirthDayIcon.Image = global::BasicFacebookFeatures.Properties.Resources.cake_candles_solid;
            this.labelBirthDayIcon.Location = new System.Drawing.Point(640, 74);
            this.labelBirthDayIcon.Name = "labelBirthDayIcon";
            this.labelBirthDayIcon.Size = new System.Drawing.Size(37, 37);
            this.labelBirthDayIcon.TabIndex = 75;
            // 
            // labelGenderIcon
            // 
            this.labelGenderIcon.Image = global::BasicFacebookFeatures.Properties.Resources.person_half_dress_solid;
            this.labelGenderIcon.Location = new System.Drawing.Point(640, 37);
            this.labelGenderIcon.Name = "labelGenderIcon";
            this.labelGenderIcon.Size = new System.Drawing.Size(37, 37);
            this.labelGenderIcon.TabIndex = 74;
            // 
            // labelCityIcon
            // 
            this.labelCityIcon.Image = global::BasicFacebookFeatures.Properties.Resources.city_solid;
            this.labelCityIcon.Location = new System.Drawing.Point(640, 3);
            this.labelCityIcon.Name = "labelCityIcon";
            this.labelCityIcon.Size = new System.Drawing.Size(37, 34);
            this.labelCityIcon.TabIndex = 73;
            // 
            // labelAgeIcon
            // 
            this.labelAgeIcon.Image = global::BasicFacebookFeatures.Properties.Resources.calendar_days_regular;
            this.labelAgeIcon.Location = new System.Drawing.Point(383, 74);
            this.labelAgeIcon.Name = "labelAgeIcon";
            this.labelAgeIcon.Size = new System.Drawing.Size(37, 37);
            this.labelAgeIcon.TabIndex = 72;
            // 
            // labelEmailIcon
            // 
            this.labelEmailIcon.Image = global::BasicFacebookFeatures.Properties.Resources.envelope_solid;
            this.labelEmailIcon.Location = new System.Drawing.Point(382, 37);
            this.labelEmailIcon.Name = "labelEmailIcon";
            this.labelEmailIcon.Size = new System.Drawing.Size(37, 37);
            this.labelEmailIcon.TabIndex = 71;
            // 
            // labelNameIcon
            // 
            this.labelNameIcon.Image = global::BasicFacebookFeatures.Properties.Resources.user_solid;
            this.labelNameIcon.Location = new System.Drawing.Point(380, 0);
            this.labelNameIcon.Name = "labelNameIcon";
            this.labelNameIcon.Size = new System.Drawing.Size(37, 37);
            this.labelNameIcon.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(215, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 538);
            this.panel1.TabIndex = 69;
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = System.Drawing.Color.DimGray;
            this.panelSeparator.Location = new System.Drawing.Point(243, 118);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(878, 2);
            this.panelSeparator.TabIndex = 68;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(694, 47);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(61, 18);
            this.labelGender.TabIndex = 67;
            this.labelGender.Text = "Gender:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCity.Location = new System.Drawing.Point(694, 11);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(37, 18);
            this.labelCity.TabIndex = 66;
            this.labelCity.Text = "City:";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBirthDay.Location = new System.Drawing.Point(694, 84);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(68, 18);
            this.labelBirthDay.TabIndex = 64;
            this.labelBirthDay.Text = "BirthDay:";
            this.labelBirthDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(421, 84);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(37, 18);
            this.labelAge.TabIndex = 63;
            this.labelAge.Text = "Age:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEmail.Location = new System.Drawing.Point(425, 47);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 18);
            this.labelEmail.TabIndex = 62;
            this.labelEmail.Text = "Email:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelViewTitle
            // 
            this.labelViewTitle.AutoSize = true;
            this.labelViewTitle.Location = new System.Drawing.Point(238, 149);
            this.labelViewTitle.Name = "labelViewTitle";
            this.labelViewTitle.Size = new System.Drawing.Size(51, 18);
            this.labelViewTitle.TabIndex = 60;
            this.labelViewTitle.Text = "Posts:";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(243, 9);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(81, 87);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // listBoxContent
            // 
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.ItemHeight = 18;
            this.listBoxContent.Location = new System.Drawing.Point(243, 178);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(346, 274);
            this.listBoxContent.TabIndex = 59;
            this.listBoxContent.SelectedIndexChanged += new System.EventHandler(this.listBoxContent_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.buttonPosts);
            this.flowLayoutPanel1.Controls.Add(this.buttonFriends);
            this.flowLayoutPanel1.Controls.Add(this.buttonAlbums);
            this.flowLayoutPanel1.Controls.Add(this.buttonGroups);
            this.flowLayoutPanel1.Controls.Add(this.buttonEvents);
            this.flowLayoutPanel1.Controls.Add(this.buttonFavoriteTeams);
            this.flowLayoutPanel1.Controls.Add(this.buttonLikedPages);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 415);
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
            this.labelName.Location = new System.Drawing.Point(425, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 18);
            this.labelName.TabIndex = 57;
            this.labelName.Text = "Full Name";
            // 
            // tabPageFeatures
            // 
            this.tabPageFeatures.Location = new System.Drawing.Point(4, 27);
            this.tabPageFeatures.Name = "tabPageFeatures";
            this.tabPageFeatures.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFeatures.Size = new System.Drawing.Size(1138, 563);
            this.tabPageFeatures.TabIndex = 1;
            this.tabPageFeatures.Text = "Extra Features";
            this.tabPageFeatures.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 594);
            this.Controls.Add(this.tabControlApp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.tabControlApp.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.Label labelNameIcon;
        private System.Windows.Forms.Label labelCityIcon;
        private System.Windows.Forms.Label labelAgeIcon;
        private System.Windows.Forms.Label labelEmailIcon;
        private System.Windows.Forms.Label labelBirthDayIcon;
        private System.Windows.Forms.Label labelGenderIcon;
    }
}

