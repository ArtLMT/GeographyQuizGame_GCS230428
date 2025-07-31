namespace GeographyQuizGame.Forms
{
    partial class AddQuestionBase
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
            label1 = new Label();
            comboBoxQuestionType = new ComboBox();
            panelInputArea = new Panel();
            listBoxQuestions = new ListBox();
            HomeBtn = new Button();
            PlayBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.Location = new Point(341, 23);
            label1.Name = "label1";
            label1.Size = new Size(276, 45);
            label1.TabIndex = 1;
            label1.Text = "Create your game";
            // 
            // comboBoxQuestionType
            // 
            comboBoxQuestionType.FormattingEnabled = true;
            comboBoxQuestionType.ImeMode = ImeMode.On;
            comboBoxQuestionType.Location = new Point(623, 94);
            comboBoxQuestionType.Name = "comboBoxQuestionType";
            comboBoxQuestionType.Size = new Size(114, 23);
            comboBoxQuestionType.TabIndex = 5;
            comboBoxQuestionType.Text = "Question Type";
            comboBoxQuestionType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panelInputArea
            // 
            panelInputArea.Location = new Point(411, 123);
            panelInputArea.Name = "panelInputArea";
            panelInputArea.Size = new Size(500, 338);
            panelInputArea.TabIndex = 7;
            panelInputArea.Paint += panel1_Paint;
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.ItemHeight = 15;
            listBoxQuestions.Location = new Point(32, 94);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(321, 364);
            listBoxQuestions.TabIndex = 8;
            // 
            // HomeBtn
            // 
            HomeBtn.Location = new Point(32, 23);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(125, 50);
            HomeBtn.TabIndex = 9;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // PlayBtn
            // 
            PlayBtn.Location = new Point(786, 29);
            PlayBtn.Name = "PlayBtn";
            PlayBtn.Size = new Size(125, 50);
            PlayBtn.TabIndex = 10;
            PlayBtn.Text = "Play Game";
            PlayBtn.UseVisualStyleBackColor = true;
            // 
            // AddQuestionBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PlayBtn);
            Controls.Add(HomeBtn);
            Controls.Add(listBoxQuestions);
            Controls.Add(panelInputArea);
            Controls.Add(comboBoxQuestionType);
            Controls.Add(label1);
            Name = "AddQuestionBase";
            Size = new Size(944, 528);
            Load += AddQuestionBase_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBoxQuestionType;
        private Panel panelInputArea;
        private ListBox listBoxQuestions;
        private Button HomeBtn;
        private Button PlayBtn;
    }
}
