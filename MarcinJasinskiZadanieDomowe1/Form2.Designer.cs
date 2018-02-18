namespace MarcinJasinskiZadanieDomowe1
{
    partial class FormEndingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEndingWindow));
            this.pictureBoxFinalPicture = new System.Windows.Forms.PictureBox();
            this.buttonEndSession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFinalPicture
            // 
            this.pictureBoxFinalPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFinalPicture.Image")));
            this.pictureBoxFinalPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFinalPicture.InitialImage")));
            this.pictureBoxFinalPicture.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFinalPicture.Name = "pictureBoxFinalPicture";
            this.pictureBoxFinalPicture.Size = new System.Drawing.Size(720, 478);
            this.pictureBoxFinalPicture.TabIndex = 0;
            this.pictureBoxFinalPicture.TabStop = false;
            // 
            // buttonEndSession
            // 
            this.buttonEndSession.Location = new System.Drawing.Point(300, 506);
            this.buttonEndSession.Name = "buttonEndSession";
            this.buttonEndSession.Size = new System.Drawing.Size(146, 23);
            this.buttonEndSession.TabIndex = 1;
            this.buttonEndSession.Text = "ZAKOŃCZ SESJĘ";
            this.buttonEndSession.UseVisualStyleBackColor = true;
            this.buttonEndSession.Click += new System.EventHandler(this.buttonEndSession_Click);
            // 
            // FormEndingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 541);
            this.Controls.Add(this.buttonEndSession);
            this.Controls.Add(this.pictureBoxFinalPicture);
            this.Name = "FormEndingWindow";
            this.Text = "Koniec sesji";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinalPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFinalPicture;
        private System.Windows.Forms.Button buttonEndSession;
    }
}