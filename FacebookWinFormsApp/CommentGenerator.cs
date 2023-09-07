using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal sealed class CommentGenerator
    {
        private const string k_AnswerButtonPrefix = "buttonAnswer";
        private const string k_RestartCommentGenerator = "Restart";
        private const string k_InitialQuestion = "What's on your mind?";

        private static CommentGenerator s_Instance = null;
        private static object s_CommentGeneratorLock = new object();

        private readonly Dictionary<string, HashSet<Button>> r_DictionaryQuestionIdToPossibleAnswerButtons;
        private readonly Dictionary<string, string> r_DictionaryQuestionIdToQuestionDetails;

        private TextBox m_TextBoxQuestions;
        private TextBox m_TextBoxCommentOutput;
        private Button m_ButtonStart;
        private Button m_ButtonPostComment;
        private List<Button> m_ListOfInitialAnswerButtons;
        private Label m_LabelCommentOutputExplaination;
        private FlowLayoutPanel m_FlowLayoutPanelAnswerButtons;

        private string m_CommentOutput;

        private CommentGenerator()
        {
            this.r_DictionaryQuestionIdToPossibleAnswerButtons = new Dictionary<string, HashSet<Button>>();
            this.r_DictionaryQuestionIdToQuestionDetails = new Dictionary<string, string>();
            this.m_CommentOutput = string.Empty;

            initializeQuestionsAndAnswers();
        }

        public static CommentGenerator Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_CommentGeneratorLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new CommentGenerator();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public TextBox TextBoxQuestions
        {
            set { m_TextBoxQuestions = value; }
        }

        public TextBox TextBoxCommentOutput
        {
            set { m_TextBoxCommentOutput = value; }
        }

        public Button ButtonStart
        {
            set { m_ButtonStart = value; }
        }

        public Button ButtonPostComment
        {
            set { m_ButtonPostComment = value; }
        }

        public string CommentOutput
        {
            get { return m_CommentOutput; }
            set { m_CommentOutput = value; }
        }

        public List<Button> ListOfInitialAnswerButtons
        {
            set
            {
                m_ListOfInitialAnswerButtons = value;
                foreach (Button answerButton in m_ListOfInitialAnswerButtons)
                {
                    answerButton.Click += new EventHandler(this.answerButton_Click);
                }
            }
        }

        public Label LabelCommentOutputExplaination
        {
            set { m_LabelCommentOutputExplaination = value; }
        }

        public FlowLayoutPanel FlowLayoutPanelAnswerButtons
        {
            set { m_FlowLayoutPanelAnswerButtons = value; }
        }

        private void initializeQuestionsAndAnswers()
        {
            initializeQuestion("1_1", "What are you happy about?", new string[] { "I've going to a vication.", "I'm celebrating something.", "I've achived something." });

            initializeQuestion("1_2", "Why are you sad?", new string[] { "I had a fight with my girlfriend.", "I've lost my pet.", "I've lost touch with one one my friends." });

            initializeQuestion("1_1_1", "What kind of a vication?", new string[] { "A trip in Europe.", "A trip in America.", "A trip in the north of Israel." });

            initializeQuestion("1_1_2", "What are you celebrating?", new string[] { "I'm getting married.", "I have a new child.", "It's my birthday." });

            initializeQuestion("1_1_3", "What kind of achivement?", new string[] { "I've just finished my degree.", "I've got a new job.", "I've won a marathon." });

            initializeQuestion("1_1_1_1", "From stunning landscapes to captivating cultures, Europe left me in awe. Sharing just a glimpse of the adventure!", null);
            initializeQuestion("1_1_1_2", "Traveling across the diverse landscapes of America was like stepping into a collection of breathtaking postcards.", null);
            initializeQuestion("1_1_1_3", "Exploring the enchanting north of Israel was a soul-nourishing experience. Nature and history intertwined beautifully", null);
            initializeQuestion("1_1_2_1", "Two hearts coming together to write a new chapter. Thrilled to announce our journey toward forever!", null);
            initializeQuestion("1_1_2_2", "Our little bundle of joy has arrived, filling our days with love and endless smiles. Parenthood, here we come!", null);
            initializeQuestion("1_1_2_3", "Another year of incredible moments, lessons, and blessings. Grateful for the journey and excited for what's to come!", null);
            initializeQuestion("1_1_3_1", "Graduation day is finally here, marking the end of one chapter and the beginning of countless new adventures!", null);
            initializeQuestion("1_1_3_2", "Exciting news! Embarking on a fresh professional journey that promises growth, challenges, and endless possibilities.", null);
            initializeQuestion("1_1_3_3", "Crossing that finish line was a victory of determination and perseverance. Grateful for this incredible achievement!", null);
            initializeQuestion("1_2_1", "Life's journey isn't always smooth, but working through challenges together strengthens the bond.", null);
            initializeQuestion("1_2_2", "Saying goodbye to a furry friend is never easy, but the love they brought into your life will always be cherished.", null);
            initializeQuestion("1_2_3", "Rediscovering a lost connection can bring back a flood of memories and laughter. Reunions are simply heartwarming.", null);
        }

        private void initializeQuestion(string i_QuestionId, string i_QuestionDetails, string[] i_Answers)
        {
            HashSet<Button> answerButtonsForQuestion = null;

            r_DictionaryQuestionIdToQuestionDetails.Add(i_QuestionId, i_QuestionDetails);

            if (i_Answers != null)
            {
                answerButtonsForQuestion = new HashSet<Button>();
                for (int i = 0; i < i_Answers.Length; i++)
                {
                    answerButtonsForQuestion.Add(createAnswerButton($"{k_AnswerButtonPrefix}{i_QuestionId}_{i + 1}", i_Answers[i]));
                }
            }

            r_DictionaryQuestionIdToPossibleAnswerButtons.Add(i_QuestionId, answerButtonsForQuestion);
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            const bool v_ToEnable = true;
            const bool v_ToShow = true;
            string questionID = (sender as Button).Name.Substring(k_AnswerButtonPrefix.Length);
            string nextQuestionDetails = r_DictionaryQuestionIdToQuestionDetails[questionID];
            string candidateCommentOutput = r_DictionaryQuestionIdToQuestionDetails[questionID];

            if (r_DictionaryQuestionIdToPossibleAnswerButtons[questionID] == null)
            {
                enableCommentOutputArea(v_ToEnable, candidateCommentOutput);
                showQuestionAndAnswerArea(!v_ToShow);
            }
            else
            {
                showQuestionAndAnswerArea(v_ToShow, nextQuestionDetails, r_DictionaryQuestionIdToPossibleAnswerButtons[questionID].ToList());
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
            answerButton.Click += new EventHandler(answerButton_Click);

            return answerButton;
        }

        public void StartNewCommentGenerator()
        {
            const bool v_ToEnable = true;
            const bool v_ToShow = true;
            showQuestionAndAnswerArea(v_ToShow, k_InitialQuestion, m_ListOfInitialAnswerButtons);
            m_ButtonStart.Text = k_RestartCommentGenerator;
            enableCommentOutputArea(!v_ToEnable);
        }

        private void enableCommentOutputArea(bool i_IsNeedToEnable, string commentOutput = null)
        {
            m_TextBoxCommentOutput.Enabled = i_IsNeedToEnable;
            m_LabelCommentOutputExplaination.Visible = i_IsNeedToEnable;
            m_ButtonPostComment.Enabled = i_IsNeedToEnable;
            this.m_CommentOutput = i_IsNeedToEnable ? commentOutput : string.Empty;
        }

        private void showQuestionAndAnswerArea(bool i_IsNeedToEnable, string i_Question = null, List<Button> i_AnswerButton = null)
        {
            m_TextBoxQuestions.Visible = i_IsNeedToEnable;
            m_FlowLayoutPanelAnswerButtons.Visible = i_IsNeedToEnable;
            m_TextBoxQuestions.Text = i_IsNeedToEnable ? i_Question : string.Empty;

            m_FlowLayoutPanelAnswerButtons.Controls.Clear();
            if (i_IsNeedToEnable)
            {
                foreach (Button answerButton in i_AnswerButton)
                {
                    m_FlowLayoutPanelAnswerButtons.Controls.Add(answerButton);
                }
            }
        }
    }
}
