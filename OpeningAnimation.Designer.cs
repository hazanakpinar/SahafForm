namespace BooksellerApp
{
    partial class OpeningAnimation
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
            components = new System.ComponentModel.Container();
            tmrOpening = new System.Windows.Forms.Timer(components);
            picboxBigLibrary = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picboxBigLibrary).BeginInit();
            SuspendLayout();
            // 
            // tmrOpening
            // 
            tmrOpening.Enabled = true;
            tmrOpening.Interval = 10;
            tmrOpening.Tick += tmrOpening_Tick;
            // 
            // picboxBigLibrary
            // 
            picboxBigLibrary.Anchor = AnchorStyles.None;
            picboxBigLibrary.BackColor = SystemColors.ActiveBorder;
            picboxBigLibrary.Image = Properties.Resources.opening;
            picboxBigLibrary.Location = new Point(0, 0);
            picboxBigLibrary.Name = "picboxBigLibrary";
            picboxBigLibrary.Size = new Size(800, 650);
            picboxBigLibrary.SizeMode = PictureBoxSizeMode.Zoom;
            picboxBigLibrary.TabIndex = 3;
            picboxBigLibrary.TabStop = false;
            // 
            // OpeningAnimation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 650);
            Controls.Add(picboxBigLibrary);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OpeningAnimation";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OpeningAnimation";
            TransparencyKey = SystemColors.ActiveBorder;
            ((System.ComponentModel.ISupportInitialize)picboxBigLibrary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer tmrOpening;
        private PictureBox picboxBigLibrary;
    }
}