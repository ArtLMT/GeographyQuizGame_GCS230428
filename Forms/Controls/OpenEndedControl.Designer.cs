namespace GeographyQuizGame.Forms.Controls
{
    partial class OpenEndedControl
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
            CreateQuestionBtn = new Button();
            label7 = new Label();
            AcceptableAnswerBox = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            DeleteBtn = new Button();
            MultipleChoiceQuestionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MultipleChoiceQuestionPanel
            // 
            MultipleChoiceQuestionPanel.Controls.Add(DeleteBtn);
            MultipleChoiceQuestionPanel.Controls.Add(CreateQuestionBtn);
            MultipleChoiceQuestionPanel.Controls.Add(label7);
            MultipleChoiceQuestionPanel.Controls.Add(AcceptableAnswerBox);
            MultipleChoiceQuestionPanel.Controls.Add(label2);
            MultipleChoiceQuestionPanel.Controls.Add(textBox1);
            MultipleChoiceQuestionPanel.Location = new Point(3, 3);
            MultipleChoiceQuestionPanel.Name = "MultipleChoiceQuestionPanel";
            MultipleChoiceQuestionPanel.Size = new Size(500, 338);
            MultipleChoiceQuestionPanel.TabIndex = 9;
            // 
            // CreateQuestionBtn
            // 
            CreateQuestionBtn.Location = new Point(180, 266);
            CreateQuestionBtn.Name = "CreateQuestionBtn";
            CreateQuestionBtn.Size = new Size(125, 50);
            CreateQuestionBtn.TabIndex = 20;
            CreateQuestionBtn.Text = "Create";
            CreateQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 106);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 18;
            label7.Text = "Acceptable Answer";
            // 
            // AcceptableAnswerBox
            // 
            AcceptableAnswerBox.Location = new Point(167, 98);
            AcceptableAnswerBox.Name = "AcceptableAnswerBox";
            AcceptableAnswerBox.Size = new Size(272, 23);
            AcceptableAnswerBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 32);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 8;
            label2.Text = "Question Text";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 23);
            textBox1.TabIndex = 7;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.OrangeRed;
            DeleteBtn.Location = new Point(340, 266);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(125, 50);
            DeleteBtn.TabIndex = 21;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Visible = false;
            // 
            // OpenEndedControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MultipleChoiceQuestionPanel);
            Name = "OpenEndedControl";
            Size = new Size(510, 347);
            MultipleChoiceQuestionPanel.ResumeLayout(false);
            MultipleChoiceQuestionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MultipleChoiceQuestionPanel;
        private Label label7;
        private TextBox AcceptableAnswerBox;
        private Label label2;
        private TextBox textBox1;
        private Button CreateQuestionBtn;
        private Button DeleteBtn;
    }
}
