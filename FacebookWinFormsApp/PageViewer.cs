using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PageViewer : IViewer
    {
        private readonly Label r_LabelDescription;
        private readonly TextBox r_TextBoxDescription;

        public PageViewer()
        {
            r_LabelDescription = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(595, 178),
                Name = "labelDescription",
                Size = new System.Drawing.Size(127, 26),
                TabIndex = 70,
                Text = "Description:",
            };

            r_TextBoxDescription = new TextBox
            {
                Location = new System.Drawing.Point(600, 211),
                Multiline = true,
                Name = "textBoxDescription",
                Size = new System.Drawing.Size(521, 135),
                TabIndex = 71,
                ReadOnly = true,
            };

            setVisible(false);
        }

        public void loadPageDetailsToComponents(Page i_Page)
        {
            if (i_Page.Description != null)
            {
                r_TextBoxDescription.Text = i_Page.Description;
            }
            else
            {
                r_TextBoxDescription.Text = Constants.NO_DESCRIPTION;
            }

            setVisible(true);
        }

        public void AddControls(TabPage i_TabPage)
        {
            i_TabPage.Controls.Add(r_LabelDescription);
            i_TabPage.Controls.Add(r_TextBoxDescription);
        }

        public void HideControls()
        {
            setVisible(false);
        }

        internal void setVisible(bool i_Visible)
        {
            r_LabelDescription.Visible = i_Visible;
            r_TextBoxDescription.Visible = i_Visible;
        }
    }
}
