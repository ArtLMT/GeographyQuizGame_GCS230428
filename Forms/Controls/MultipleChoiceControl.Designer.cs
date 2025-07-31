namespace GeographyQuizGame.Forms.Controls
{
    partial class MultipleChoiceControl
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
            CreateMultiQuestionBtn = new Button();
            comboBoxCorrectAnswer = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            OptionD = new TextBox();
            OptionC = new TextBox();
            OptionB = new TextBox();
            OptionA = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            MultipleChoiceQuestionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MultipleChoiceQuestionPanel
            // 
            MultipleChoiceQuestionPanel.Controls.Add(DeleteBtn);
            MultipleChoiceQuestionPanel.Controls.Add(CreateMultiQuestionBtn);
            MultipleChoiceQuestionPanel.Controls.Add(comboBoxCorrectAnswer);
            MultipleChoiceQuestionPanel.Controls.Add(label7);
            MultipleChoiceQuestionPanel.Controls.Add(label6);
            MultipleChoiceQuestionPanel.Controls.Add(label5);
            MultipleChoiceQuestionPanel.Controls.Add(label4);
            MultipleChoiceQuestionPanel.Controls.Add(label3);
            MultipleChoiceQuestionPanel.Controls.Add(OptionD);
            MultipleChoiceQuestionPanel.Controls.Add(OptionC);
            MultipleChoiceQuestionPanel.Controls.Add(OptionB);
            MultipleChoiceQuestionPanel.Controls.Add(OptionA);
            MultipleChoiceQuestionPanel.Controls.Add(label2);
            MultipleChoiceQuestionPanel.Controls.Add(textBox1);
            MultipleChoiceQuestionPanel.Location = new Point(0, 0);
            MultipleChoiceQuestionPanel.Name = "MultipleChoiceQuestionPanel";
            MultipleChoiceQuestionPanel.Size = new Size(500, 338);
            MultipleChoiceQuestionPanel.TabIndex = 8;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.OrangeRed;
            DeleteBtn.Location = new Point(330, 262);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(125, 50);
            DeleteBtn.TabIndex = 20;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Visible = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // CreateMultiQuestionBtn
            // 
            CreateMultiQuestionBtn.Location = new Point(167, 262);
            CreateMultiQuestionBtn.Name = "CreateMultiQuestionBtn";
            CreateMultiQuestionBtn.Size = new Size(125, 50);
            CreateMultiQuestionBtn.TabIndex = 19;
            CreateMultiQuestionBtn.Text = "Create";
            CreateMultiQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // comboBoxCorrectAnswer
            // 
            comboBoxCorrectAnswer.FormattingEnabled = true;
            comboBoxCorrectAnswer.ImeMode = ImeMode.On;
            comboBoxCorrectAnswer.Items.AddRange(new object[] { "A", "B", "C", "D" });
            comboBoxCorrectAnswer.Location = new Point(167, 66);
            comboBoxCorrectAnswer.Name = "comboBoxCorrectAnswer";
            comboBoxCorrectAnswer.Size = new Size(46, 23);
            comboBoxCorrectAnswer.TabIndex = 8;
            comboBoxCorrectAnswer.Text = "Question Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 69);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 18;
            label7.Text = "Correct Answer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 203);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 16;
            label6.Text = "D.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 174);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 15;
            label5.Text = "C.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 145);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 14;
            label4.Text = "B.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 111);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 13;
            label3.Text = "A.";
            // 
            // OptionD
            // 
            OptionD.Location = new Point(105, 200);
            OptionD.Name = "OptionD";
            OptionD.Size = new Size(272, 23);
            OptionD.TabIndex = 12;
            // 
            // OptionC
            // 
            OptionC.Location = new Point(105, 166);
            OptionC.Name = "OptionC";
            OptionC.Size = new Size(272, 23);
            OptionC.TabIndex = 11;
            // 
            // OptionB
            // 
            OptionB.Location = new Point(105, 137);
            OptionB.Name = "OptionB";
            OptionB.Size = new Size(272, 23);
            OptionB.TabIndex = 10;
            // 
            // OptionA
            // 
            OptionA.Location = new Point(105, 108);
            OptionA.Name = "OptionA";
            OptionA.Size = new Size(272, 23);
            OptionA.TabIndex = 9;
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
            // MultipleChoiceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MultipleChoiceQuestionPanel);
            Name = "MultipleChoiceControl";
            Size = new Size(500, 338);
            MultipleChoiceQuestionPanel.ResumeLayout(false);
            MultipleChoiceQuestionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MultipleChoiceQuestionPanel;
        private ComboBox comboBoxCorrectAnswer;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox OptionD;
        private TextBox OptionC;
        private TextBox OptionB;
        private TextBox OptionA;
        private Label label2;
        private TextBox textBox1;
        private Button CreateMultiQuestionBtn;
        private Button DeleteBtn;
    }
}
