using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class FriendViewer
    {
        private readonly Label r_LabelBirthdayTitle;
        private readonly Label r_LabelBirthdayValue;
        private readonly Label r_LabelGenderTitle;
        private readonly Label r_LabelGenderValue;

        public FriendViewer()
        {
            r_LabelBirthdayTitle = new Label();
            r_LabelBirthdayTitle.AutoSize = true;
            r_LabelBirthdayTitle.Location = new System.Drawing.Point(595, 178);
            r_LabelBirthdayTitle.Name = "labelBirthdayTitle";
            r_LabelBirthdayTitle.Size = new System.Drawing.Size(98, 26);
            r_LabelBirthdayTitle.TabIndex = 70;
            r_LabelBirthdayTitle.Text = "Birthday:";

            r_LabelBirthdayValue = new Label();
            r_LabelBirthdayValue.AutoSize = true;
            r_LabelBirthdayValue.Location = new System.Drawing.Point(699, 178);
            r_LabelBirthdayValue.Name = "labelBirthdayValue";
            r_LabelBirthdayValue.Size = new System.Drawing.Size(96, 26);
            r_LabelBirthdayValue.TabIndex = 71;
            r_LabelBirthdayValue.Text = "0/0/0001";

            r_LabelGenderTitle = new Label();
            r_LabelGenderTitle.AutoSize = true;
            r_LabelGenderTitle.Location = new System.Drawing.Point(595, 214);
            r_LabelGenderTitle.Name = "labelGenderTitle";
            r_LabelGenderTitle.Size = new System.Drawing.Size(90, 26);
            r_LabelGenderTitle.TabIndex = 72;
            r_LabelGenderTitle.Text = "Gender:";

            r_LabelGenderValue = new Label();
            r_LabelGenderValue.AutoSize = true;
            r_LabelGenderValue.Location = new System.Drawing.Point(699, 214);
            r_LabelGenderValue.Name = "labelGenderValue";
            r_LabelGenderValue.Size = new System.Drawing.Size(60, 26);
            r_LabelGenderValue.TabIndex = 73;
            r_LabelGenderValue.Text = "male";
        }
    }
}
