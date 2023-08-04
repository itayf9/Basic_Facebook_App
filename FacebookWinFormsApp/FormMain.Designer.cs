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
            this.labelFriends = new System.Windows.Forms.Label();
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
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControlApp.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
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
            this.tabPageProfile.Controls.Add(this.labelGender);
            this.tabPageProfile.Controls.Add(this.labelCity);
            this.tabPageProfile.Controls.Add(this.labelFriends);
            this.tabPageProfile.Controls.Add(this.labelBirthDay);
            this.tabPageProfile.Controls.Add(this.labelAge);
            this.tabPageProfile.Controls.Add(this.labelEmail);
            this.tabPageProfile.Controls.Add(this.pictureBoxSelectedContent);
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
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(659, 45);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(61, 18);
            this.labelGender.TabIndex = 67;
            this.labelGender.Text = "Gender:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(659, 9);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(37, 18);
            this.labelCity.TabIndex = 66;
            this.labelCity.Text = "City:";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Location = new System.Drawing.Point(30, 193);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(61, 18);
            this.labelFriends.TabIndex = 65;
            this.labelFriends.Text = "Friends:";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Location = new System.Drawing.Point(659, 78);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(68, 18);
            this.labelBirthDay.TabIndex = 64;
            this.labelBirthDay.Text = "BirthDay:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(421, 78);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(37, 18);
            this.labelAge.TabIndex = 63;
            this.labelAge.Text = "Age:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(421, 45);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 18);
            this.labelEmail.TabIndex = 62;
            this.labelEmail.Text = "Email: ";
            // 
            // pictureBoxSelectedContent
            // 
            this.pictureBoxSelectedContent.Location = new System.Drawing.Point(800, 437);
            this.pictureBoxSelectedContent.Name = "pictureBoxSelectedContent";
            this.pictureBoxSelectedContent.Size = new System.Drawing.Size(107, 109);
            this.pictureBoxSelectedContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedContent.TabIndex = 61;
            this.pictureBoxSelectedContent.TabStop = false;
            // 
            // labelViewTitle
            // 
            this.labelViewTitle.AutoSize = true;
            this.labelViewTitle.Location = new System.Drawing.Point(331, 193);
            this.labelViewTitle.Name = "labelViewTitle";
            this.labelViewTitle.Size = new System.Drawing.Size(0, 18);
            this.labelViewTitle.TabIndex = 60;
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
            this.listBoxContent.ItemHeight = 18;
            this.listBoxContent.Location = new System.Drawing.Point(336, 225);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(590, 328);
            this.listBoxContent.TabIndex = 59;
            this.listBoxContent.SelectedIndexChanged += new System.EventHandler(this.listBoxContent_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.buttonPosts);
            this.flowLayoutPanel1.Controls.Add(this.buttonAlbums);
            this.flowLayoutPanel1.Controls.Add(this.buttonGroups);
            this.flowLayoutPanel1.Controls.Add(this.buttonEvents);
            this.flowLayoutPanel1.Controls.Add(this.buttonFavoriteTeams);
            this.flowLayoutPanel1.Controls.Add(this.buttonLikedPages);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(932, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 549);
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
            this.buttonAlbums.Location = new System.Drawing.Point(3, 57);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(197, 48);
            this.buttonAlbums.TabIndex = 0;
            this.buttonAlbums.Text = "Albums";
            this.buttonAlbums.UseVisualStyleBackColor = true;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Location = new System.Drawing.Point(3, 111);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(197, 48);
            this.buttonGroups.TabIndex = 1;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Location = new System.Drawing.Point(3, 165);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(197, 48);
            this.buttonEvents.TabIndex = 2;
            this.buttonEvents.Text = "Events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // buttonFavoriteTeams
            // 
            this.buttonFavoriteTeams.Location = new System.Drawing.Point(3, 219);
            this.buttonFavoriteTeams.Name = "buttonFavoriteTeams";
            this.buttonFavoriteTeams.Size = new System.Drawing.Size(197, 48);
            this.buttonFavoriteTeams.TabIndex = 3;
            this.buttonFavoriteTeams.Text = "Favorite Teams";
            this.buttonFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFavoriteTeams.Click += new System.EventHandler(this.buttonFavoriteTeams_Click);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Location = new System.Drawing.Point(3, 273);
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
            this.labelName.Size = new System.Drawing.Size(149, 18);
            this.labelName.TabIndex = 57;
            this.labelName.Text = "FirstName LastName";
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
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.button13);
            this.flowLayoutPanel4.Controls.Add(this.button14);
            this.flowLayoutPanel4.Controls.Add(this.button15);
            this.flowLayoutPanel4.Controls.Add(this.button16);
            this.flowLayoutPanel4.Controls.Add(this.button17);
            this.flowLayoutPanel4.Controls.Add(this.button18);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 0);
            this.flowLayoutPanel4.TabIndex = 59;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(3, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(197, 48);
            this.button13.TabIndex = 5;
            this.button13.Text = "Posts";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(3, 57);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(197, 48);
            this.button14.TabIndex = 0;
            this.button14.Text = "Albums";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(3, 111);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(197, 48);
            this.button15.TabIndex = 1;
            this.button15.Text = "Groups";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(3, 165);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(197, 48);
            this.button16.TabIndex = 2;
            this.button16.Text = "Events";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(3, 219);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(197, 48);
            this.button17.TabIndex = 3;
            this.button17.Text = "Favorite Teams";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(3, 273);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(197, 48);
            this.button18.TabIndex = 4;
            this.button18.Text = "Liked Pages";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
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
            this.flowLayoutPanel4.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelGender;
    }
}

