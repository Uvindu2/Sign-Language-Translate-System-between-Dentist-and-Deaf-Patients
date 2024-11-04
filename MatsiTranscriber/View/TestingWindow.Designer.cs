namespace MatsiTranscriber.View
{
    partial class TestingWindow
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
            splitContainer1 = new SplitContainer();
            RecieverImage = new PictureBox();
            SenderImage = new PictureBox();
            panel2 = new Panel();
            TranscriptionTextbox = new TextBox();
            OpenImageButton = new Button();
            ManualTriggerButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RecieverImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SenderImage).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 411);
            panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(RecieverImage);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SenderImage);
            splitContainer1.Size = new Size(936, 411);
            splitContainer1.SplitterDistance = 468;
            splitContainer1.TabIndex = 0;
            // 
            // RecieverImage
            // 
            RecieverImage.Dock = DockStyle.Fill;
            RecieverImage.Location = new Point(0, 0);
            RecieverImage.Name = "RecieverImage";
            RecieverImage.Size = new Size(468, 411);
            RecieverImage.TabIndex = 0;
            RecieverImage.TabStop = false;
            // 
            // SenderImage
            // 
            SenderImage.Dock = DockStyle.Fill;
            SenderImage.Location = new Point(0, 0);
            SenderImage.Name = "SenderImage";
            SenderImage.Size = new Size(464, 411);
            SenderImage.TabIndex = 0;
            SenderImage.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(TranscriptionTextbox);
            panel2.Controls.Add(OpenImageButton);
            panel2.Controls.Add(ManualTriggerButton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 411);
            panel2.Name = "panel2";
            panel2.Size = new Size(936, 38);
            panel2.TabIndex = 1;
            // 
            // TranscriptionTextbox
            // 
            TranscriptionTextbox.Location = new Point(325, 8);
            TranscriptionTextbox.Name = "TranscriptionTextbox";
            TranscriptionTextbox.Size = new Size(599, 23);
            TranscriptionTextbox.TabIndex = 2;
            // 
            // OpenImageButton
            // 
            OpenImageButton.Location = new Point(145, 7);
            OpenImageButton.Name = "OpenImageButton";
            OpenImageButton.Size = new Size(174, 23);
            OpenImageButton.TabIndex = 1;
            OpenImageButton.Text = "Open Image";
            OpenImageButton.UseVisualStyleBackColor = true;
            OpenImageButton.Click += OpenImage;
            // 
            // ManualTriggerButton
            // 
            ManualTriggerButton.Location = new Point(12, 7);
            ManualTriggerButton.Name = "ManualTriggerButton";
            ManualTriggerButton.Size = new Size(127, 23);
            ManualTriggerButton.TabIndex = 0;
            ManualTriggerButton.Text = "Manual Test Trigger";
            ManualTriggerButton.UseVisualStyleBackColor = true;
            ManualTriggerButton.Click += ManualTrigger;
            // 
            // TestingWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 449);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TestingWindow";
            Text = "Testing Window";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RecieverImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)SenderImage).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private PictureBox RecieverImage;
        private PictureBox SenderImage;
        private Panel panel2;
        private TextBox TranscriptionTextbox;
        private Button OpenImageButton;
        private Button ManualTriggerButton;
    }
}