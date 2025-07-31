namespace GeographyQuizGame.Forms
{
    partial class PlayOpenEndedControl
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
            QuestionText = new Label();
            UserAnswerBtn = new TextBox();
            label1 = new Label();
            NextBtn = new Button();
            SuspendLayout();
            // 
            // QuestionText
            // 
            QuestionText.AutoSize = true;
            QuestionText.Location = new Point(38, 37);
            QuestionText.Name = "QuestionText";
            QuestionText.Size = new Size(38, 15);
            QuestionText.TabIndex = 5;
            QuestionText.Text = "label1";
            // 
            // UserAnswerBtn
            // 
            UserAnswerBtn.Location = new Point(38, 123);
            UserAnswerBtn.Name = "UserAnswerBtn";
            UserAnswerBtn.Size = new Size(418, 23);
            UserAnswerBtn.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 105);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 7;
            label1.Text = "Your answer:";
            // 
            // NextBtn
            // 
            NextBtn.Location = new Point(342, 228);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(120, 50);
            NextBtn.TabIndex = 8;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = true;
            // 
            // PlayOpenEndedControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NextBtn);
            Controls.Add(label1);
            Controls.Add(UserAnswerBtn);
            Controls.Add(QuestionText);
            Name = "PlayOpenEndedControl";
            Size = new Size(500, 303);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionText;
        private TextBox UserAnswerBtn;
        private Label label1;
        private Button NextBtn;
    }
}
