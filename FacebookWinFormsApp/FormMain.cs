using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppID = "832742648143866";
        private User m_LoggedInUser;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        //FacebookWrapper.LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoggedInUser == null)
            {
                login();
            }
        }

        private void login()
        {
            FacebookWrapper.LoginResult m_LoginResult = FacebookService.Login(
                k_AppID,
                /// requested permissions:
                "email",
                "public_profile"
                /// add any relevant permissions
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in as {m_LoggedInUser.Name}";
                labelName.Text = m_LoggedInUser.Name;
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }
            else
            {
                // error
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoggedInUser = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            listBoxContent.Items.Clear();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxContent.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxContent.Items.Add(post.Caption);
                }
                else
                {
                    listBoxContent.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxContent.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
            else
            {
                labelViewTitle.Text = (sender as Button).Text;
            }
        }
    }
}
