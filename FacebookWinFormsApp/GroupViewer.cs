using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class GroupViewer : IViewer
    {
        private readonly Label r_LabelDescription;
        private readonly TextBox r_TextBoxDescription;

        public GroupViewer()
        {
            r_LabelDescription = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(610, 178),
                Name = "labelDesctiption",
                Size = new System.Drawing.Size(193, 26),
                TabIndex = 70,
                Text = "Group Description:",
            };

            r_TextBoxDescription = new TextBox
            {
                Location = new System.Drawing.Point(615, 219),
                Multiline = true,
                Name = "textBoxDescription",
                Size = new System.Drawing.Size(308, 152),
                TabIndex = 71,
                ReadOnly = true,
            };

            setVisible(false);
        }

        public Label LabelDecription
        {
            get { return r_LabelDescription; }
        }

        public TextBox TextBoxDescription
        {
            get { return r_TextBoxDescription; }
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

        internal void LoadGroupDetailsToComponents(Group i_SelectedGroup)
        {
            r_TextBoxDescription.Text = i_SelectedGroup.Description;
            setVisible(true);
        }

        internal void setVisible(bool i_Visible)
        {
           r_LabelDescription.Visible = i_Visible;
           r_TextBoxDescription.Visible = i_Visible;
        }
    }
}
