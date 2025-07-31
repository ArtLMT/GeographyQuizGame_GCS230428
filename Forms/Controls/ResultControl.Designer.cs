namespace GeographyQuizGame.Forms.Controls
{
    partial class ResultControl
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
            timer = new Label();
            ResultLbl = new Label();
            HomeBtn = new Button();
            PlayAgainBtn = new Button();
            ShowResultBtn = new Button();
            listBoxQuestions = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.Location = new Point(390, 35);
            label1.Name = "label1";
            label1.Size = new Size(170, 45);
            label1.TabIndex = 0;
            label1.Text = "Well Done";
            // 
            // timer
            // 
            timer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            timer.AutoSize = true;
            timer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            timer.Location = new Point(447, 90);
            timer.Name = "timer";
            timer.Size = new Size(47, 21);
            timer.TabIndex = 1;
            timer.Text = "timer";
            timer.TextAlign = ContentAlignment.TopCenter;
            // 
            // ResultLbl
            // 
            ResultLbl.AutoSize = true;
            ResultLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            ResultLbl.Location = new Point(406, 125);
            ResultLbl.Name = "ResultLbl";
            ResultLbl.Size = new Size(124, 21);
            ResultLbl.TabIndex = 2;
            ResultLbl.Text = "Your result: 0 / 0";
            // 
            // HomeBtn
            // 
            HomeBtn.Location = new Point(234, 360);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(120, 50);
            HomeBtn.TabIndex = 3;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            // 
            // PlayAgainBtn
            // 
            PlayAgainBtn.Location = new Point(410, 360);
            PlayAgainBtn.Name = "PlayAgainBtn";
            PlayAgainBtn.Size = new Size(120, 50);
            PlayAgainBtn.TabIndex = 4;
            PlayAgainBtn.Text = "Play Again";
            PlayAgainBtn.UseVisualStyleBackColor = true;
            // 
            // ShowResultBtn
            // 
            ShowResultBtn.Location = new Point(586, 360);
            ShowResultBtn.Name = "ShowResultBtn";
            ShowResultBtn.Size = new Size(120, 50);
            ShowResultBtn.TabIndex = 5;
            ShowResultBtn.Text = "Show Result";
            ShowResultBtn.UseVisualStyleBackColor = true;
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.ItemHeight = 15;
            listBoxQuestions.Location = new Point(320, 160);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(289, 169);
            listBoxQuestions.TabIndex = 6;
            listBoxQuestions.Visible = false;
            // 
            // ResultControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxQuestions);
            Controls.Add(ShowResultBtn);
            Controls.Add(PlayAgainBtn);
            Controls.Add(HomeBtn);
            Controls.Add(ResultLbl);
            Controls.Add(timer);
            Controls.Add(label1);
            Name = "ResultControl";
            Size = new Size(944, 528);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label timer;
        private Label ResultLbl;
        private Button HomeBtn;
        private Button PlayAgainBtn;
        private Button ShowResultBtn;
        private ListBox listBoxQuestions;
    }
}
