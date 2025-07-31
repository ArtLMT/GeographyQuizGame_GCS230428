namespace GeographyQuizGame.Forms.Controls
{
    partial class PlayMutlipleChoiceControl
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
            OptionA = new Button();
            OptionB = new Button();
            OptionD = new Button();
            OptionC = new Button();
            QuestionText = new Label();
            SuspendLayout();
            // 
            // OptionA
            // 
            OptionA.ImageAlign = ContentAlignment.TopLeft;
            OptionA.Location = new Point(16, 119);
            OptionA.Name = "OptionA";
            OptionA.RightToLeft = RightToLeft.Yes;
            OptionA.Size = new Size(227, 80);
            OptionA.TabIndex = 0;
            OptionA.Text = "button1";
            OptionA.UseVisualStyleBackColor = true;
            OptionA.Click += OptionA_Click;
            // 
            // OptionB
            // 
            OptionB.Location = new Point(16, 205);
            OptionB.Name = "OptionB";
            OptionB.Size = new Size(227, 83);
            OptionB.TabIndex = 1;
            OptionB.Text = "button2";
            OptionB.UseVisualStyleBackColor = true;
            // 
            // OptionD
            // 
            OptionD.Location = new Point(261, 205);
            OptionD.Name = "OptionD";
            OptionD.Size = new Size(227, 83);
            OptionD.TabIndex = 3;
            OptionD.Text = "button1";
            OptionD.UseVisualStyleBackColor = true;
            // 
            // OptionC
            // 
            OptionC.ImageAlign = ContentAlignment.TopLeft;
            OptionC.Location = new Point(261, 119);
            OptionC.Name = "OptionC";
            OptionC.RightToLeft = RightToLeft.Yes;
            OptionC.Size = new Size(227, 80);
            OptionC.TabIndex = 2;
            OptionC.Text = "button1";
            OptionC.UseVisualStyleBackColor = true;
            // 
            // QuestionText
            // 
            QuestionText.AutoSize = true;
            QuestionText.Location = new Point(22, 25);
            QuestionText.Name = "QuestionText";
            QuestionText.Size = new Size(38, 15);
            QuestionText.TabIndex = 4;
            QuestionText.Text = "label1";
            // 
            // PlayMutlipleChoiceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(QuestionText);
            Controls.Add(OptionD);
            Controls.Add(OptionC);
            Controls.Add(OptionB);
            Controls.Add(OptionA);
            Name = "PlayMutlipleChoiceControl";
            Size = new Size(500, 303);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OptionA;
        private Button OptionB;
        private Button OptionD;
        private Button OptionC;
        private Label QuestionText;
    }
}
