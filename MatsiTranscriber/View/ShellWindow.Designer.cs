namespace MatsiTranscriber.View
{
    partial class ShellWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Previewer = new PictureBox();
            panel2 = new Panel();
            TranscriptionTextbox = new TextBox();
            Stop = new Button();
            StartButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Previewer).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Previewer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 380);
            panel1.TabIndex = 0;
            // 
            // Previewer
            // 
            Previewer.Dock = DockStyle.Fill;
            Previewer.Location = new Point(0, 0);
            Previewer.Name = "Previewer";
            Previewer.Size = new Size(800, 380);
            Previewer.TabIndex = 0;
            Previewer.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(TranscriptionTextbox);
            panel2.Controls.Add(Stop);
            panel2.Controls.Add(StartButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 40);
            panel2.TabIndex = 1;
            // 
            // TranscriptionTextbox
            // 
            TranscriptionTextbox.Location = new Point(165, 7);
            TranscriptionTextbox.Name = "TranscriptionTextbox";
            TranscriptionTextbox.Size = new Size(623, 23);
            TranscriptionTextbox.TabIndex = 2;
            // 
            // Stop
            // 
            Stop.Location = new Point(84, 6);
            Stop.Name = "Stop";
            Stop.Size = new Size(75, 23);
            Stop.TabIndex = 1;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(3, 6);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += Start;
            // 
            // ShellWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "ShellWindow";
            Text = "Shell Window";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Previewer).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox TranscriptionTextbox;
        private Button Stop;
        private Button StartButton;
        private PictureBox Previewer;
    }
}