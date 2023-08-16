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
        private const string k_AnswerButtonPrefix = "buttonAnswer";

        private readonly TextBox r_TextBoxQuestions;
        private readonly TextBox r_TextBoxCommentOutput;
        private readonly Button r_ButtonStart;
        private readonly Button r_ButtonPostComment;
        private readonly List<Button> r_ListOfInitialAnswerButtons;
        private readonly Label r_LabelCommentOutputExplaination;
        private readonly FlowLayoutPanel r_FlowLayoutPanelAnswerButtons;
        private readonly Dictionary<string, HashSet<Button>> r_DictionaryQuestionIdToPossibleAnswerButtons;
        private readonly Dictionary<string, string> r_DictionaryQuestionIdToQuestionDetails;

        public CommentGenerator(TextBox i_TextBoxQuestions, TextBox i_TextBoxCommentOutput, Button i_ButtonStart, Button i_ButtonPostComment, Label i_LabelOutputCommentExplaination, FlowLayoutPanel i_FlowLayoutPanelAnswerButtons, List<Button> i_ListOfInitialAnswerButtons)
        {
            this.r_TextBoxQuestions = i_TextBoxQuestions;
            this.r_TextBoxCommentOutput = i_TextBoxCommentOutput;
            this.r_ButtonStart = i_ButtonStart;
            this.r_ButtonPostComment = i_ButtonPostComment;
            this.r_LabelCommentOutputExplaination = i_LabelOutputCommentExplaination;
            this.r_FlowLayoutPanelAnswerButtons = i_FlowLayoutPanelAnswerButtons;
            this.r_ListOfInitialAnswerButtons = i_ListOfInitialAnswerButtons;
            this.r_DictionaryQuestionIdToPossibleAnswerButtons = new Dictionary<string, HashSet<Button>>();
            this.r_DictionaryQuestionIdToQuestionDetails = new Dictionary<string, string>();

            foreach (Button answerButton in r_ListOfInitialAnswerButtons)
            {
                answerButton.Click += new EventHandler(this.AnswerButton_Click);
            }

            initializeQuestionsAndAnswers();
        }

        private void initializeQuestionsAndAnswers()
        {
            r_DictionaryQuestionIdToQuestionDetails.Add("1_1", "What are you happy about?");

            HashSet<Button> answerButtonsForQuestion11 = new HashSet<Button>();
            answerButtonsForQuestion11.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_1", "I've going to a vication."));
            answerButtonsForQuestion11.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_2", "I'm celebrating something."));
            answerButtonsForQuestion11.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_3", "I've achived something."));
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1", answerButtonsForQuestion11);

            r_DictionaryQuestionIdToQuestionDetails.Add("1_2", "Why are you sad ya pakid");

            HashSet<Button> answerButtonsForQuestion12 = new HashSet<Button>();
            answerButtonsForQuestion12.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_2_1", "I had a fight with my girlfriend."));
            answerButtonsForQuestion12.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_2_2", "I've lost my pet."));
            answerButtonsForQuestion12.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_2_3", "I've lost touch with one one my friends."));
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_2", answerButtonsForQuestion12);

            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_1", "What kind of a vication?");

            HashSet<Button> answerButtonsForQuestion111 = new HashSet<Button>();
            answerButtonsForQuestion111.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_1_1", "A trip in Europe."));
            answerButtonsForQuestion111.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_1_2", "A trip in America."));
            answerButtonsForQuestion111.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_1_3", "A trip in the north of Israel."));
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_1", answerButtonsForQuestion111);

            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_2", "What are you celebrating?");

            HashSet<Button> answerButtonsForQuestion112 = new HashSet<Button>();
            answerButtonsForQuestion112.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_2_1", "I'm getting married."));
            answerButtonsForQuestion112.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_2_2", "I have a new child."));
            answerButtonsForQuestion112.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_2_3", "It's my birthday."));
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_2", answerButtonsForQuestion112);

            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_3", "What kind of achivement?");

            HashSet<Button> answerButtonsForQuestion113 = new HashSet<Button>();
            answerButtonsForQuestion113.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_3_1", "I've just finished my degree."));
            answerButtonsForQuestion113.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_3_2", "I've got a new job."));
            answerButtonsForQuestion113.Add(createAnswerButton($"{k_AnswerButtonPrefix}1_1_3_3", "I've won a marathon."));
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_3", answerButtonsForQuestion113);

            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_1_1", "From stunning landscapes to captivating cultures, Europe left me in awe. Sharing just a glimpse of the adventure!");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_1_1", null);
            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_1_2", "Traveling across the diverse landscapes of America was like stepping into a collection of breathtaking postcards.");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_1_2", null);
            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_1_3", "Exploring the enchanting north of Israel was a soul-nourishing experience. Nature and history intertwined beautifully");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_1_3", null);
            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_2_1", "Two hearts coming together to write a new chapter. Thrilled to announce our journey toward forever!");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_2_1", null);
            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_2_2", "Our little bundle of joy has arrived, filling our days with love and endless smiles. Parenthood, here we come!");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_2_2", null);
            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_2_3", "Another year of incredible moments, lessons, and blessings. Grateful for the journey and excited for what's to come!");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_2_3", null);
            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_3_1", "Graduation day is finally here, marking the end of one chapter and the beginning of countless new adventures!");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_3_1", null);
            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_3_2", "Exciting news! Embarking on a fresh professional journey that promises growth, challenges, and endless possibilities.");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_3_2", null);
            r_DictionaryQuestionIdToQuestionDetails.Add("1_1_3_3", "Crossing that finish line was a victory of determination and perseverance. Grateful for this incredible achievement!");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_1_3_3", null);
            r_DictionaryQuestionIdToQuestionDetails.Add("1_2_1", "Life's journey isn't always smooth, but working through challenges together strengthens the bond.");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_2_1", null);
            r_DictionaryQuestionIdToQuestionDetails.Add("1_2_2", "Saying goodbye to a furry friend is never easy, but the love they brought into your life will always be cherished.");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_2_2", null);
            r_DictionaryQuestionIdToQuestionDetails.Add("1_2_3", "Rediscovering a lost connection can bring back a flood of memories and laughter. Reunions are simply heartwarming.");
            r_DictionaryQuestionIdToPossibleAnswerButtons.Add("1_2_3", null);
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            string questionID = (sender as Button).Name.Substring("buttonAnswer".Length);
            string nextQuestionDetails = r_DictionaryQuestionIdToQuestionDetails[questionID];
            string commentOutput = r_DictionaryQuestionIdToQuestionDetails[questionID];

            if (r_DictionaryQuestionIdToPossibleAnswerButtons[questionID] == null)
            {
                enableCommentOutputArea(true, commentOutput);
                showQuestionAndAnswerArea(false);
            }
            else
            {
                showQuestionAndAnswerArea(true, nextQuestionDetails, r_DictionaryQuestionIdToPossibleAnswerButtons[questionID].ToList());
            }
        }

        private Button createAnswerButton(string i_ButtonName, string i_AnswerToBeShownOnTopOfTheButton)
        {
            Button answerButton = new Button();
            answerButton.AutoSize = true;
            answerButton.Location = new System.Drawing.Point(3, 45);
            answerButton.Name = i_ButtonName;
            answerButton.Size = new System.Drawing.Size(195, 36);
            answerButton.TabIndex = 2;
            answerButton.Text = i_AnswerToBeShownOnTopOfTheButton;
            answerButton.UseVisualStyleBackColor = true;
            answerButton.Click += new EventHandler(AnswerButton_Click);

            return answerButton;
        }

        internal void startNewCommentGenerator()
        {
            showQuestionAndAnswerArea(true, "What's on your mind?", r_ListOfInitialAnswerButtons);
            r_ButtonStart.Text = "Restart";
            enableCommentOutputArea(false);
        }

        private void enableCommentOutputArea(bool i_IsNeedToEnable, string commentOutput = null)
        {
            r_TextBoxCommentOutput.Enabled = i_IsNeedToEnable;
            r_LabelCommentOutputExplaination.Visible = i_IsNeedToEnable;
            r_ButtonPostComment.Enabled = i_IsNeedToEnable;
            r_TextBoxCommentOutput.Text = i_IsNeedToEnable ? commentOutput : string.Empty;
        }

        private void showQuestionAndAnswerArea(bool i_IsNeedToEnable, string i_Question = null, List<Button> i_AnswerButton = null)
        {
            r_TextBoxQuestions.Visible = i_IsNeedToEnable;
            r_FlowLayoutPanelAnswerButtons.Visible = i_IsNeedToEnable;
            r_TextBoxQuestions.Text = i_IsNeedToEnable ? i_Question : string.Empty;

            r_FlowLayoutPanelAnswerButtons.Controls.Clear();
            if (i_IsNeedToEnable)
            {
                foreach (Button answerButton in i_AnswerButton)
                {
                    r_FlowLayoutPanelAnswerButtons.Controls.Add(answerButton);
                }
            }
        }
    }
}
