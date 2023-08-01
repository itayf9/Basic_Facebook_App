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

        public FormMain(User i_m_LoggedInUser)
        {
            m_LoggedInUser = i_m_LoggedInUser;
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            labelName.Text = m_LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
            buttonLogout.Enabled = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoggedInUser = null;
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
