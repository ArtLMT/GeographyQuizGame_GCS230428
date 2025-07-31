namespace GeographyQuizGame.Forms
{
    partial class PlayGameForm
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
            listBoxQuestions = new ListBox();
            panelInputArea = new Panel();
            label1 = new Label();
            Timer = new Label();
            SuspendLayout();
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.ItemHeight = 15;
            listBoxQuestions.Location = new Point(35, 89);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(321, 364);
            listBoxQuestions.TabIndex = 11;
            // 
            // panelInputArea
            // 
            panelInputArea.Location = new Point(414, 153);
            panelInputArea.Name = "panelInputArea";
            panelInputArea.Size = new Size(500, 303);
            panelInputArea.TabIndex = 10;
            panelInputArea.Paint += panelInputArea_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.Location = new Point(373, 20);
            label1.Name = "label1";
            label1.Size = new Size(221, 45);
            label1.TabIndex = 12;
            label1.Text = "Playing Game";
            // 
            // Timer
            // 
            Timer.AutoSize = true;
            Timer.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Timer.Location = new Point(702, 28);
            Timer.Name = "Timer";
            Timer.Size = new Size(83, 37);
            Timer.TabIndex = 13;
            Timer.Text = "00:00";
            // 
            // PlayGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Timer);
            Controls.Add(label1);
            Controls.Add(listBoxQuestions);
            Controls.Add(panelInputArea);
            Name = "PlayGameForm";
            Size = new Size(944, 528);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxQuestions;
        private Panel panelInputArea;
        private Label label1;
        private Label Timer;
    }
}
