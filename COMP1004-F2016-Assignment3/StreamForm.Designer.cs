namespace COMP1004_F2016_Assignment3
{
    partial class StreamForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.ChargeLabel = new System.Windows.Forms.Label();
            this.StreamLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(102, 214);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Location = new System.Drawing.Point(34, 36);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(180, 13);
            this.ThankYouLabel.TabIndex = 1;
            this.ThankYouLabel.Text = "Thank You for using Movie Bonanza";
            // 
            // ChargeLabel
            // 
            this.ChargeLabel.AutoSize = true;
            this.ChargeLabel.Location = new System.Drawing.Point(34, 84);
            this.ChargeLabel.Name = "ChargeLabel";
            this.ChargeLabel.Size = new System.Drawing.Size(171, 13);
            this.ChargeLabel.TabIndex = 2;
            this.ChargeLabel.Text = "Your credit card has been charged";
            // 
            // StreamLabel
            // 
            this.StreamLabel.AutoSize = true;
            this.StreamLabel.Location = new System.Drawing.Point(34, 132);
            this.StreamLabel.Name = "StreamLabel";
            this.StreamLabel.Size = new System.Drawing.Size(163, 13);
            this.StreamLabel.TabIndex = 3;
            this.StreamLabel.Text = "Movie will begin streaming shortly";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.StreamLabel);
            this.Controls.Add(this.ChargeLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Controls.Add(this.OKButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Label ChargeLabel;
        private System.Windows.Forms.Label StreamLabel;
    }
}