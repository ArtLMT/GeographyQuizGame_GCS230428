namespace GeographyQuizGame.Forms
{
    partial class HomePageForm
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
            Play = new Button();
            CreateGame = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Play
            // 
            Play.Location = new Point(407, 314);
            Play.Name = "Play";
            Play.Size = new Size(150, 50);
            Play.TabIndex = 0;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // CreateGame
            // 
            CreateGame.Location = new Point(407, 387);
            CreateGame.Name = "CreateGame";
            CreateGame.Size = new Size(150, 50);
            CreateGame.TabIndex = 1;
            CreateGame.Text = "Create Game";
            CreateGame.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label1.Location = new Point(300, 63);
            label1.Name = "label1";
            label1.Size = new Size(379, 86);
            label1.TabIndex = 2;
            label1.Text = "Welcome to";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            label2.Location = new Point(131, 134);
            label2.Name = "label2";
            label2.Size = new Size(691, 86);
            label2.TabIndex = 3;
            label2.Text = "Geography Quiz Game";
            label2.Click += label2_Click;
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CreateGame);
            Controls.Add(Play);
            Name = "HomePageForm";
            Size = new Size(944, 528);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Play;
        private Button CreateGame;
        private Label label1;
        private Label label2;
    }
}
