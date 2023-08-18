using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {
        private const string k_AppID = "832742648143866";
        private const string k_SessionLoginButtonText = "Continue as {0}";
        private const string k_DefaultLoginButtonText = "Login";
        private const string k_LoginErrorMessage = "Login Error !! Please Try Again.";

        private static readonly string[] sr_RequestedPermissions =
        {
            "email",
            "public_profile",
            "user_age_range",
            "user_birthday",
            "user_events",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
        };

        private Session m_Session;
        private User m_LoggedInUser;

        public LoginForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;

            if (Session.IsSessionExists())
            {
                m_Session = Session.LoadFromFile();
            }

            setLoginFormComponents();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (m_Session != null && !checkBoxRememberMe.Checked)
            {
                Session.DeleteSession();
            }
            else if (m_Session != null)
            {
                m_Session.SaveToFile();
            }

            base.OnFormClosing(e);
        }

        private void setLoginFormComponents()
        {
            const bool v_ToCheck = true;
            if (m_Session != null)
            {
                checkBoxRememberMe.Checked = m_Session.IsRememberMe;
                buttonLogin.Text = m_Session.IsRememberMe ?
                    string.Format(k_SessionLoginButtonText, m_Session.LoggedInUserName) :
                    k_DefaultLoginButtonText;
            }
            else
            {
                checkBoxRememberMe.Checked = !v_ToCheck;
                buttonLogin.Text = k_DefaultLoginButtonText;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_Session != null)
            {
                loginWithSession(m_Session);
            }
            else
            {
                loginWithoutSession();
            }
        }

        private void loginWithSession(Session i_SessionToLoginWith)
        {
            try
            {
                LoginResult loginResult = FacebookService.Connect(i_SessionToLoginWith.AccessToken);
                m_LoggedInUser = loginResult.LoggedInUser;

                handleAppearenceOfLoginAndMainDialogs();
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
            }
        }

        private void loginWithoutSession()
        {
            const bool v_ToEnable = true;
            const bool v_ToBeVisible = true;
            try
            {
                LoginResult loginResult = FacebookService.Login(k_AppID, sr_RequestedPermissions);

                if (!string.IsNullOrEmpty(loginResult.AccessToken))
                {
                    labelError.Visible = !v_ToBeVisible;
                    m_LoggedInUser = loginResult.LoggedInUser;

                    m_Session = new Session
                    {
                        AccessToken = loginResult.AccessToken,
                        IsRememberMe = checkBoxRememberMe.Checked,
                        LoggedInUserName = m_LoggedInUser.Name,
                    };
                    m_Session.SaveToFile();

                    handleAppearenceOfLoginAndMainDialogs();
                }
                else if (loginResult.ErrorMessage.Equals(string.Empty))
                {
                    labelError.Visible = v_ToBeVisible;
                    labelError.Text = k_LoginErrorMessage;
                }
                else
                {
                    labelError.Enabled = v_ToEnable;
                    labelError.Text = loginResult.ErrorMessage;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
            }
        }

        private void handleAppearenceOfLoginAndMainDialogs()
        {
            this.Hide();
            new FormMain(m_LoggedInUser).ShowDialog();
            if (!Session.IsSessionExists())
            {
                m_Session = null;
            }

            setLoginFormComponents();
            this.Show();
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (m_Session != null)
            {
                m_Session.IsRememberMe = checkBoxRememberMe.Checked;
            }
        }
    }
}
