namespace GeographyQuizGame.Forms.Controls
{
    partial class PlayTrueFalseControl
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
            TrueBtn = new Button();
            FalseBtn = new Button();
            SuspendLayout();
            // 
            // QuestionText
            // 
            QuestionText.AutoSize = true;
            QuestionText.Location = new Point(43, 29);
            QuestionText.Name = "QuestionText";
            QuestionText.Size = new Size(38, 15);
            QuestionText.TabIndex = 6;
            QuestionText.Text = "label1";
            // 
            // TrueBtn
            // 
            TrueBtn.Location = new Point(43, 175);
            TrueBtn.Name = "TrueBtn";
            TrueBtn.Size = new Size(150, 75);
            TrueBtn.TabIndex = 7;
            TrueBtn.Text = "True";
            TrueBtn.UseVisualStyleBackColor = true;
            // 
            // FalseBtn
            // 
            FalseBtn.Location = new Point(267, 175);
            FalseBtn.Name = "FalseBtn";
            FalseBtn.Size = new Size(150, 75);
            FalseBtn.TabIndex = 8;
            FalseBtn.Text = "False";
            FalseBtn.UseVisualStyleBackColor = true;
            // 
            // PlayTrueFalseControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FalseBtn);
            Controls.Add(TrueBtn);
            Controls.Add(QuestionText);
            Name = "PlayTrueFalseControl";
            Size = new Size(500, 303);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label QuestionText;
        private Button TrueBtn;
        private Button FalseBtn;
    }
}
