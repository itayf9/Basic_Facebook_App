using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class GroupViewer
    {
        private readonly Label r_LabelDescription;
        private readonly TextBox r_TextBoxDescription;
        private readonly Label r_LabelNumberOfMembersTitle;
        private readonly Label r_LabelNumberOfMembersValue;

        public GroupViewer()
        {
            r_LabelDescription = new Label();
            r_LabelDescription.AutoSize = true;
            r_LabelDescription.Location = new System.Drawing.Point(610, 178);
            r_LabelDescription.Name = "labelDesctiption";
            r_LabelDescription.Size = new System.Drawing.Size(193, 26);
            r_LabelDescription.TabIndex = 70;
            r_LabelDescription.Text = "Group Description:";

            r_TextBoxDescription = new TextBox();
            r_TextBoxDescription.Location = new System.Drawing.Point(615, 219);
            r_TextBoxDescription.Multiline = true;
            r_TextBoxDescription.Name = "textBoxDescription";
            r_TextBoxDescription.Size = new System.Drawing.Size(308, 152);
            r_TextBoxDescription.TabIndex = 71;

            r_LabelNumberOfMembersTitle = new Label();
            r_LabelNumberOfMembersTitle.AutoSize = true;
            r_LabelNumberOfMembersTitle.Location = new System.Drawing.Point(610, 395);
            r_LabelNumberOfMembersTitle.Name = "labelNumberOfMembersTitle";
            r_LabelNumberOfMembersTitle.Size = new System.Drawing.Size(222, 26);
            r_LabelNumberOfMembersTitle.TabIndex = 72;
            r_LabelNumberOfMembersTitle.Text = "Number Of Members:";

            r_LabelNumberOfMembersValue = new Label();
            r_LabelNumberOfMembersValue.AutoSize = true;
            r_LabelNumberOfMembersValue.Location = new System.Drawing.Point(838, 395);
            r_LabelNumberOfMembersValue.Name = "labelNumberOfMembersValue";
            r_LabelNumberOfMembersValue.Size = new System.Drawing.Size(48, 26);
            r_LabelNumberOfMembersValue.TabIndex = 73;
            r_LabelNumberOfMembersValue.Text = "100";
        }

        public Label LabelDecription { get { return r_LabelDescription; } }

        public TextBox TextBoxDescription {  get { return r_TextBoxDescription; } }

        public Label LabelNumberOfMembersTitle {  get { return r_LabelNumberOfMembersTitle; } }

        public Label LabelNumberOfMembersValue { get { return r_LabelNumberOfMembersValue; } }

        internal void LoadGroupDetailsToComponents(Group i_SelectedGroup)
        {
            r_TextBoxDescription.Text = i_SelectedGroup.Description;
            r_LabelNumberOfMembersValue.Text = i_SelectedGroup.Members.Count.ToString();
        }

        internal void setVisible(bool i_Visible)
        {
           r_LabelDescription.Visible = i_Visible;
           r_TextBoxDescription.Visible = i_Visible;
           r_LabelNumberOfMembersTitle.Visible = i_Visible;
           r_LabelNumberOfMembersValue.Visible = i_Visible;
        }
    }
}
