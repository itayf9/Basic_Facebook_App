using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class CommentGenerator
    {
        private TextBox textBoxQuestions;
        private TextBox textBoxCommentOutput;
        private Button buttonStart;
        private Button buttonPostComment;
        private FlowLayoutPanel flowLayoutPanelButtonOptions;

        private Dictionary<string, HashSet<Button>> questionID2possibleAnswears;
        private Dictionary<string, string> questionID2questionDetails;

        public CommentGenerator(TextBox textBoxQuestions, TextBox textBoxCommentOutput, Button buttonStart, Button buttonPostComment, FlowLayoutPanel flowLayoutPanelButtonOptions)
        {
            this.textBoxQuestions = textBoxQuestions;
            this.textBoxCommentOutput = textBoxCommentOutput;
            this.buttonStart = buttonStart;
            this.buttonPostComment = buttonPostComment;
            this.flowLayoutPanelButtonOptions = flowLayoutPanelButtonOptions;
            this.questionID2possibleAnswears = new Dictionary<string, HashSet<Button>>();
            this.questionID2questionDetails = new Dictionary<string, string>();

            foreach (object button in flowLayoutPanelButtonOptions.Controls)
            {
                (button as Button).Click += new EventHandler(this.ButtonOption_Click);
            }

            init();
        }

        private void init()
        {
            HashSet<Button> tempSet = new HashSet<Button>();
            Button button1 = new Button();
            button1.AutoSize = true;
            button1.Location = new System.Drawing.Point(3, 45);
            button1.Name = "button2_1";
            button1.Size = new System.Drawing.Size(195, 36);
            button1.TabIndex = 2;
            button1.Text = "I am awesome";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new EventHandler(ButtonOption_Click);
            tempSet.Add(button1);

            HashSet<Button> tempSet2 = new HashSet<Button>();
            Button button2 = new Button();
            button2.AutoSize = true;
            button2.Location = new System.Drawing.Point(3, 45);
            button2.Name = "button2_1";
            button2.Size = new System.Drawing.Size(195, 36);
            button2.TabIndex = 2;
            button2.Text = "i dont know why i am sad";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new EventHandler(ButtonOption_Click);
            tempSet2.Add(button2);

            questionID2possibleAnswears.Add("1_1", tempSet);
            questionID2possibleAnswears.Add("1_2", tempSet2);

            questionID2questionDetails.Add("1_1", "What are you happy about");
            questionID2questionDetails.Add("1_2", "Why are you sad ya pakid");
        }

        private void ButtonOption_Click(object sender, EventArgs e)
        {
            string key = (sender as Button).Name.Substring("button".Length);
            string nextQuestionOrCommentOutput = questionID2questionDetails[key];

            // TODO change the name of this element to not confuse us

            if (questionID2possibleAnswears[key].Count == 0)
            {
               textBoxQuestions.Text = string.Empty;
               textBoxCommentOutput.Text = nextQuestionOrCommentOutput; // this contains the comment output
            }
            else
            {
                textBoxQuestions.Text = nextQuestionOrCommentOutput;
                flowLayoutPanelButtonOptions.Controls.Clear();

                foreach (Button button in questionID2possibleAnswears[key])
                {
                    flowLayoutPanelButtonOptions.Controls.Add(button);
                }
            }
        }
    }
}
