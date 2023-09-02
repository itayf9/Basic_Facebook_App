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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControlApp = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.labelLoading = new System.Windows.Forms.Label();
            this.labelBirthDayIcon = new System.Windows.Forms.Label();
            this.labelGenderIcon = new System.Windows.Forms.Label();
            this.labelCityIcon = new System.Windows.Forms.Label();
            this.labelAgeIcon = new System.Windows.Forms.Label();
            this.labelEmailIcon = new System.Windows.Forms.Label();
            this.labelNameIcon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.labelViewTitle = new System.Windows.Forms.Label();
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.buttonFavoriteTeams = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.tabPageNostalgia = new System.Windows.Forms.TabPage();
            this.labelNostaldiaExplaination = new System.Windows.Forms.Label();
            this.textBoxUploadDate = new System.Windows.Forms.TextBox();
            this.buttonNostalgia = new System.Windows.Forms.Button();
            this.comboBoxMediaType = new System.Windows.Forms.ComboBox();
            this.tabPageCommentGenerator = new System.Windows.Forms.TabPage();
            this.labelCommentOutputExplainationCommentGenerator = new System.Windows.Forms.Label();
            this.labelExplainationCommentGenerator = new System.Windows.Forms.Label();
            this.flowLayoutPanelOptionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAnswer1_1 = new System.Windows.Forms.Button();
            this.buttonAnswer1_2 = new System.Windows.Forms.Button();
            this.buttonPostComment = new System.Windows.Forms.Button();
            this.textBoxCommentOutput = new System.Windows.Forms.TextBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelWelcomeCommentGenerator = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.tabControlApp.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPageNostalgia.SuspendLayout();
            this.tabPageCommentGenerator.SuspendLayout();
            this.flowLayoutPanelOptionButtons.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
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
            this.tabControlApp.Controls.Add(this.tabPageNostalgia);
            this.tabControlApp.Controls.Add(this.tabPageCommentGenerator);
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
            this.tabPageProfile.Controls.Add(this.panelProfile);
            this.tabPageProfile.Controls.Add(this.buttonEditProfile);
            this.tabPageProfile.Controls.Add(this.labelLoading);
            this.tabPageProfile.Controls.Add(this.panel1);
            this.tabPageProfile.Controls.Add(this.panelSeparator);
            this.tabPageProfile.Controls.Add(this.labelViewTitle);
            this.tabPageProfile.Controls.Add(this.listBoxContent);
            this.tabPageProfile.Controls.Add(this.flowLayoutPanel1);
            this.tabPageProfile.Controls.Add(this.buttonLogout);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 27);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(1138, 563);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(987, 138);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(134, 31);
            this.labelLoading.TabIndex = 76;
            this.labelLoading.Text = "Loading...";
            this.labelLoading.Visible = false;
            // 
            // labelBirthDayIcon
            // 
            this.labelBirthDayIcon.Image = global::BasicFacebookFeatures.Properties.Resources.cake_candles_solid;
            this.labelBirthDayIcon.Location = new System.Drawing.Point(442, 74);
            this.labelBirthDayIcon.Name = "labelBirthDayIcon";
            this.labelBirthDayIcon.Size = new System.Drawing.Size(37, 37);
            this.labelBirthDayIcon.TabIndex = 75;
            // 
            // labelGenderIcon
            // 
            this.labelGenderIcon.Image = global::BasicFacebookFeatures.Properties.Resources.person_half_dress_solid;
            this.labelGenderIcon.Location = new System.Drawing.Point(442, 37);
            this.labelGenderIcon.Name = "labelGenderIcon";
            this.labelGenderIcon.Size = new System.Drawing.Size(37, 37);
            this.labelGenderIcon.TabIndex = 74;
            // 
            // labelCityIcon
            // 
            this.labelCityIcon.Image = global::BasicFacebookFeatures.Properties.Resources.city_solid;
            this.labelCityIcon.Location = new System.Drawing.Point(442, 3);
            this.labelCityIcon.Name = "labelCityIcon";
            this.labelCityIcon.Size = new System.Drawing.Size(37, 34);
            this.labelCityIcon.TabIndex = 73;
            // 
            // labelAgeIcon
            // 
            this.labelAgeIcon.Image = global::BasicFacebookFeatures.Properties.Resources.calendar_days_regular;
            this.labelAgeIcon.Location = new System.Drawing.Point(167, 74);
            this.labelAgeIcon.Name = "labelAgeIcon";
            this.labelAgeIcon.Size = new System.Drawing.Size(37, 37);
            this.labelAgeIcon.TabIndex = 72;
            // 
            // labelEmailIcon
            // 
            this.labelEmailIcon.Image = global::BasicFacebookFeatures.Properties.Resources.envelope_solid;
            this.labelEmailIcon.Location = new System.Drawing.Point(167, 40);
            this.labelEmailIcon.Name = "labelEmailIcon";
            this.labelEmailIcon.Size = new System.Drawing.Size(37, 37);
            this.labelEmailIcon.TabIndex = 71;
            // 
            // labelNameIcon
            // 
            this.labelNameIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelNameIcon.Image = global::BasicFacebookFeatures.Properties.Resources.user_solid;
            this.labelNameIcon.Location = new System.Drawing.Point(167, 3);
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
            // labelViewTitle
            // 
            this.labelViewTitle.AutoSize = true;
            this.labelViewTitle.Location = new System.Drawing.Point(238, 149);
            this.labelViewTitle.Name = "labelViewTitle";
            this.labelViewTitle.Size = new System.Drawing.Size(51, 18);
            this.labelViewTitle.TabIndex = 60;
            this.labelViewTitle.Text = "Posts:";
            // 
            // listBoxContent
            // 
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.ItemHeight = 18;
            this.listBoxContent.Location = new System.Drawing.Point(243, 178);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(346, 238);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 423);
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
            // tabPageNostalgia
            // 
            this.tabPageNostalgia.Controls.Add(this.labelNostaldiaExplaination);
            this.tabPageNostalgia.Controls.Add(this.textBoxUploadDate);
            this.tabPageNostalgia.Controls.Add(this.buttonNostalgia);
            this.tabPageNostalgia.Controls.Add(this.comboBoxMediaType);
            this.tabPageNostalgia.Location = new System.Drawing.Point(4, 27);
            this.tabPageNostalgia.Name = "tabPageNostalgia";
            this.tabPageNostalgia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNostalgia.Size = new System.Drawing.Size(1138, 563);
            this.tabPageNostalgia.TabIndex = 1;
            this.tabPageNostalgia.Text = "Nostalgia";
            this.tabPageNostalgia.UseVisualStyleBackColor = true;
            // 
            // labelNostaldiaExplaination
            // 
            this.labelNostaldiaExplaination.AutoSize = true;
            this.labelNostaldiaExplaination.Location = new System.Drawing.Point(6, 7);
            this.labelNostaldiaExplaination.Name = "labelNostaldiaExplaination";
            this.labelNostaldiaExplaination.Size = new System.Drawing.Size(483, 18);
            this.labelNostaldiaExplaination.TabIndex = 4;
            this.labelNostaldiaExplaination.Text = "Select the kind of nostalgia that you want and click the \"nostalgia\" button.";
            // 
            // textBoxUploadDate
            // 
            this.textBoxUploadDate.Location = new System.Drawing.Point(344, 58);
            this.textBoxUploadDate.Name = "textBoxUploadDate";
            this.textBoxUploadDate.ReadOnly = true;
            this.textBoxUploadDate.Size = new System.Drawing.Size(323, 24);
            this.textBoxUploadDate.TabIndex = 3;
            this.textBoxUploadDate.Visible = false;
            // 
            // buttonNostalgia
            // 
            this.buttonNostalgia.Location = new System.Drawing.Point(6, 85);
            this.buttonNostalgia.Name = "buttonNostalgia";
            this.buttonNostalgia.Size = new System.Drawing.Size(242, 43);
            this.buttonNostalgia.TabIndex = 1;
            this.buttonNostalgia.Text = "Nostalgia!";
            this.buttonNostalgia.UseVisualStyleBackColor = true;
            this.buttonNostalgia.Click += new System.EventHandler(this.buttonNostalgia_Click);
            // 
            // comboBoxMediaType
            // 
            this.comboBoxMediaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMediaType.FormattingEnabled = true;
            this.comboBoxMediaType.Items.AddRange(new object[] {
            "Photos",
            "Posts"});
            this.comboBoxMediaType.Location = new System.Drawing.Point(8, 36);
            this.comboBoxMediaType.Name = "comboBoxMediaType";
            this.comboBoxMediaType.Size = new System.Drawing.Size(121, 26);
            this.comboBoxMediaType.TabIndex = 0;
            // 
            // tabPageCommentGenerator
            // 
            this.tabPageCommentGenerator.Controls.Add(this.labelCommentOutputExplainationCommentGenerator);
            this.tabPageCommentGenerator.Controls.Add(this.labelExplainationCommentGenerator);
            this.tabPageCommentGenerator.Controls.Add(this.flowLayoutPanelOptionButtons);
            this.tabPageCommentGenerator.Controls.Add(this.buttonPostComment);
            this.tabPageCommentGenerator.Controls.Add(this.textBoxCommentOutput);
            this.tabPageCommentGenerator.Controls.Add(this.textBoxQuestion);
            this.tabPageCommentGenerator.Controls.Add(this.buttonStart);
            this.tabPageCommentGenerator.Controls.Add(this.labelWelcomeCommentGenerator);
            this.tabPageCommentGenerator.Location = new System.Drawing.Point(4, 27);
            this.tabPageCommentGenerator.Name = "tabPageCommentGenerator";
            this.tabPageCommentGenerator.Size = new System.Drawing.Size(1138, 563);
            this.tabPageCommentGenerator.TabIndex = 2;
            this.tabPageCommentGenerator.Text = "Comment Generator";
            this.tabPageCommentGenerator.UseVisualStyleBackColor = true;
            // 
            // labelCommentOutputExplainationCommentGenerator
            // 
            this.labelCommentOutputExplainationCommentGenerator.AutoSize = true;
            this.labelCommentOutputExplainationCommentGenerator.Location = new System.Drawing.Point(8, 437);
            this.labelCommentOutputExplainationCommentGenerator.Name = "labelCommentOutputExplainationCommentGenerator";
            this.labelCommentOutputExplainationCommentGenerator.Size = new System.Drawing.Size(107, 18);
            this.labelCommentOutputExplainationCommentGenerator.TabIndex = 10;
            this.labelCommentOutputExplainationCommentGenerator.Text = "The final result:";
            this.labelCommentOutputExplainationCommentGenerator.Visible = false;
            // 
            // labelExplainationCommentGenerator
            // 
            this.labelExplainationCommentGenerator.AutoSize = true;
            this.labelExplainationCommentGenerator.Location = new System.Drawing.Point(3, 44);
            this.labelExplainationCommentGenerator.Name = "labelExplainationCommentGenerator";
            this.labelExplainationCommentGenerator.Size = new System.Drawing.Size(681, 18);
            this.labelExplainationCommentGenerator.TabIndex = 9;
            this.labelExplainationCommentGenerator.Text = "Click on \"Start\", answer some questions and recieve a dedicated message you can p" +
    "ost on Facebook.";
            // 
            // flowLayoutPanelOptionButtons
            // 
            this.flowLayoutPanelOptionButtons.AutoScroll = true;
            this.flowLayoutPanelOptionButtons.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelOptionButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelOptionButtons.Controls.Add(this.buttonAnswer1_1);
            this.flowLayoutPanelOptionButtons.Controls.Add(this.buttonAnswer1_2);
            this.flowLayoutPanelOptionButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelOptionButtons.Location = new System.Drawing.Point(219, 277);
            this.flowLayoutPanelOptionButtons.Name = "flowLayoutPanelOptionButtons";
            this.flowLayoutPanelOptionButtons.Size = new System.Drawing.Size(712, 78);
            this.flowLayoutPanelOptionButtons.TabIndex = 8;
            this.flowLayoutPanelOptionButtons.Visible = false;
            // 
            // buttonAnswer1_1
            // 
            this.buttonAnswer1_1.Location = new System.Drawing.Point(3, 3);
            this.buttonAnswer1_1.Name = "buttonAnswer1_1";
            this.buttonAnswer1_1.Size = new System.Drawing.Size(118, 36);
            this.buttonAnswer1_1.TabIndex = 1;
            this.buttonAnswer1_1.Text = "I\'m happy";
            this.buttonAnswer1_1.UseVisualStyleBackColor = true;
            // 
            // buttonAnswer1_2
            // 
            this.buttonAnswer1_2.Location = new System.Drawing.Point(127, 3);
            this.buttonAnswer1_2.Name = "buttonAnswer1_2";
            this.buttonAnswer1_2.Size = new System.Drawing.Size(130, 36);
            this.buttonAnswer1_2.TabIndex = 7;
            this.buttonAnswer1_2.Text = "I\'m sad";
            this.buttonAnswer1_2.UseVisualStyleBackColor = true;
            // 
            // buttonPostComment
            // 
            this.buttonPostComment.Enabled = false;
            this.buttonPostComment.Location = new System.Drawing.Point(979, 466);
            this.buttonPostComment.Name = "buttonPostComment";
            this.buttonPostComment.Size = new System.Drawing.Size(156, 81);
            this.buttonPostComment.TabIndex = 7;
            this.buttonPostComment.Text = "Post to Facebook";
            this.buttonPostComment.UseVisualStyleBackColor = true;
            this.buttonPostComment.Click += new System.EventHandler(this.buttonPostComment_Click);
            // 
            // textBoxCommentOutput
            // 
            this.textBoxCommentOutput.Enabled = false;
            this.textBoxCommentOutput.Location = new System.Drawing.Point(8, 466);
            this.textBoxCommentOutput.Multiline = true;
            this.textBoxCommentOutput.Name = "textBoxCommentOutput";
            this.textBoxCommentOutput.ReadOnly = true;
            this.textBoxCommentOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommentOutput.Size = new System.Drawing.Size(965, 81);
            this.textBoxCommentOutput.TabIndex = 6;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuestion.Location = new System.Drawing.Point(219, 215);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(712, 24);
            this.textBoxQuestion.TabIndex = 2;
            this.textBoxQuestion.Text = "What\'s On Your Mind ?";
            this.textBoxQuestion.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(441, 95);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(308, 52);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelWelcomeCommentGenerator
            // 
            this.labelWelcomeCommentGenerator.AutoSize = true;
            this.labelWelcomeCommentGenerator.Location = new System.Drawing.Point(3, 18);
            this.labelWelcomeCommentGenerator.Name = "labelWelcomeCommentGenerator";
            this.labelWelcomeCommentGenerator.Size = new System.Drawing.Size(274, 18);
            this.labelWelcomeCommentGenerator.TabIndex = 0;
            this.labelWelcomeCommentGenerator.Text = "Welcome To The Comment Generator !!";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Location = new System.Drawing.Point(1002, 13);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(119, 46);
            this.buttonEditProfile.TabIndex = 77;
            this.buttonEditProfile.Text = "Edit Profile";
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.Transparent;
            this.panelProfile.Controls.Add(this.textBoxGender);
            this.panelProfile.Controls.Add(this.textBoxCity);
            this.panelProfile.Controls.Add(this.imageNormalPictureBox);
            this.panelProfile.Controls.Add(this.labelAge);
            this.panelProfile.Controls.Add(this.birthdayTextBox);
            this.panelProfile.Controls.Add(this.emailTextBox);
            this.panelProfile.Controls.Add(this.nameTextBox);
            this.panelProfile.Controls.Add(this.labelNameIcon);
            this.panelProfile.Controls.Add(this.labelEmailIcon);
            this.panelProfile.Controls.Add(this.labelAgeIcon);
            this.panelProfile.Controls.Add(this.labelBirthDayIcon);
            this.panelProfile.Controls.Add(this.labelCityIcon);
            this.panelProfile.Controls.Add(this.labelGenderIcon);
            this.panelProfile.Location = new System.Drawing.Point(243, 3);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(724, 109);
            this.panelProfile.TabIndex = 78;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(485, 84);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.ReadOnly = true;
            this.birthdayTextBox.Size = new System.Drawing.Size(172, 24);
            this.birthdayTextBox.TabIndex = 76;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(222, 44);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(191, 24);
            this.emailTextBox.TabIndex = 78;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(222, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(191, 24);
            this.nameTextBox.TabIndex = 80;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(222, 84);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(37, 18);
            this.labelAge.TabIndex = 83;
            this.labelAge.Text = "Age:";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(13, 7);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 100);
            this.imageNormalPictureBox.TabIndex = 84;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(486, 10);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.ReadOnly = true;
            this.textBoxCity.Size = new System.Drawing.Size(171, 24);
            this.textBoxCity.TabIndex = 85;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(485, 44);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(171, 24);
            this.textBoxGender.TabIndex = 86;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 594);
            this.Controls.Add(this.tabControlApp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.tabControlApp.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabPageNostalgia.ResumeLayout(false);
            this.tabPageNostalgia.PerformLayout();
            this.tabPageCommentGenerator.ResumeLayout(false);
            this.tabPageCommentGenerator.PerformLayout();
            this.flowLayoutPanelOptionButtons.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label labelLoading;

        #endregion
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl tabControlApp;
		private System.Windows.Forms.TabPage tabPageProfile;
		private System.Windows.Forms.TabPage tabPageNostalgia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Button buttonFavoriteTeams;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.ListBox listBoxContent;
        private System.Windows.Forms.Label labelViewTitle;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.Label labelCityIcon;
        private System.Windows.Forms.Label labelAgeIcon;
        private System.Windows.Forms.Label labelBirthDayIcon;
        private System.Windows.Forms.Label labelGenderIcon;
        private System.Windows.Forms.Button buttonNostalgia;
        private System.Windows.Forms.ComboBox comboBoxMediaType;
        private System.Windows.Forms.TextBox textBoxUploadDate;
        private System.Windows.Forms.Label labelNostaldiaExplaination;
        private System.Windows.Forms.TabPage tabPageCommentGenerator;
        private System.Windows.Forms.Label labelEmailIcon;
        private System.Windows.Forms.Label labelNameIcon;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelWelcomeCommentGenerator;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxCommentOutput;
        private System.Windows.Forms.Button buttonPostComment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOptionButtons;
        private System.Windows.Forms.Button buttonAnswer1_1;
        private System.Windows.Forms.Button buttonAnswer1_2;
        private System.Windows.Forms.Label labelExplainationCommentGenerator;
        private System.Windows.Forms.Label labelCommentOutputExplainationCommentGenerator;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxCity;
    }
}

