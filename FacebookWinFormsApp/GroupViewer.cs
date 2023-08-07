using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class GroupViewer : IViewer
    {
        private readonly Label r_LabelDescription;
        private readonly TextBox r_TextBoxDescription;

        public GroupViewer()
        {
            r_LabelDescription = new Label();
            r_LabelDescription.AutoSize = true;
            r_LabelDescription.Location = new System.Drawing.Point(610, 178);
            r_LabelDescription.Name = "labelDesctiption";
            r_LabelDescription.Size = new System.Drawing.Size(193, 26);
            r_LabelDescription.TabIndex = 70;
            r_LabelDescription.Text = "Group Description:";
            r_LabelDescription.Visible = false;


            r_TextBoxDescription = new TextBox();
            r_TextBoxDescription.Location = new System.Drawing.Point(615, 219);
            r_TextBoxDescription.Multiline = true;
            r_TextBoxDescription.Name = "textBoxDescription";
            r_TextBoxDescription.Size = new System.Drawing.Size(308, 152);
            r_TextBoxDescription.TabIndex = 71;
            r_TextBoxDescription.Visible = false;
            r_TextBoxDescription.ReadOnly = true;
        }

        public Label LabelDecription { get { return r_LabelDescription; } }

        public TextBox TextBoxDescription {  get { return r_TextBoxDescription; } }


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
