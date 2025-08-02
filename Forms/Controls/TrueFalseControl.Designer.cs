namespace GeographyQuizGame.Forms.Controls
{
    partial class TrueFalseControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MultipleChoiceQuestionPanel = new Panel();
            DeleteBtn = new Button();
            CreateQuestionBtn = new Button();
            comboBoxCorrectAnswer = new ComboBox();
            label7 = new Label();
            label2 = new Label();
            QuestionTextInput = new TextBox();
            MultipleChoiceQuestionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MultipleChoiceQuestionPanel
            // 
            MultipleChoiceQuestionPanel.Controls.Add(DeleteBtn);
            MultipleChoiceQuestionPanel.Controls.Add(CreateQuestionBtn);
            MultipleChoiceQuestionPanel.Controls.Add(comboBoxCorrectAnswer);
            MultipleChoiceQuestionPanel.Controls.Add(label7);
            MultipleChoiceQuestionPanel.Controls.Add(label2);
            MultipleChoiceQuestionPanel.Controls.Add(QuestionTextInput);
            MultipleChoiceQuestionPanel.Location = new Point(3, 3);
            MultipleChoiceQuestionPanel.Name = "MultipleChoiceQuestionPanel";
            MultipleChoiceQuestionPanel.Size = new Size(500, 338);
            MultipleChoiceQuestionPanel.TabIndex = 9;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.OrangeRed;
            DeleteBtn.Location = new Point(332, 257);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(125, 50);
            DeleteBtn.TabIndex = 21;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Visible = false;
            // 
            // CreateQuestionBtn
            // 
            CreateQuestionBtn.Location = new Point(167, 257);
            CreateQuestionBtn.Name = "CreateQuestionBtn";
            CreateQuestionBtn.Size = new Size(125, 50);
            CreateQuestionBtn.TabIndex = 20;
            CreateQuestionBtn.Text = "Create";
            CreateQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // comboBoxCorrectAnswer
            // 
            comboBoxCorrectAnswer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCorrectAnswer.FormattingEnabled = true;
            comboBoxCorrectAnswer.ImeMode = ImeMode.On;
            comboBoxCorrectAnswer.Items.AddRange(new object[] { "True", "False" });
            comboBoxCorrectAnswer.Location = new Point(167, 99);
            comboBoxCorrectAnswer.Name = "comboBoxCorrectAnswer";
            comboBoxCorrectAnswer.Size = new Size(89, 23);
            comboBoxCorrectAnswer.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 102);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 18;
            label7.Text = "Correct Answer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 60);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 8;
            label2.Text = "Question Text";
            // 
            // QuestionTextInput
            // 
            QuestionTextInput.Location = new Point(167, 57);
            QuestionTextInput.Name = "QuestionTextInput";
            QuestionTextInput.Size = new Size(272, 23);
            QuestionTextInput.TabIndex = 7;
            // 
            // TrueFalseControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MultipleChoiceQuestionPanel);
            Name = "TrueFalseControl";
            Size = new Size(511, 348);
            MultipleChoiceQuestionPanel.ResumeLayout(false);
            MultipleChoiceQuestionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MultipleChoiceQuestionPanel;
        private ComboBox comboBoxCorrectAnswer;
        private Label label7;
        private Label label2;
        private TextBox QuestionTextInput;
        private Button CreateQuestionBtn;
        private Button DeleteBtn;
    }
}
