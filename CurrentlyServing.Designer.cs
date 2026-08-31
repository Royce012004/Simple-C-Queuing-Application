namespace QueuingForm
{
    partial class CurrentlyServing
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
            this.lblServingNumber = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServingNumber
            // 
            this.lblServingNumber.AutoSize = true;
            this.lblServingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lblServingNumber.Location = new System.Drawing.Point(101, 99);
            this.lblServingNumber.Name = "lblServingNumber";
            this.lblServingNumber.Size = new System.Drawing.Size(299, 54);
            this.lblServingNumber.TabIndex = 0;
            this.lblServingNumber.Text = "No Customer";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTitle.Location = new System.Drawing.Point(103, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Currently Serving";
            // 
            // CurrentlyServing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 213);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblServingNumber);
            this.Name = "CurrentlyServing";
            this.Text = "CurrentlyServing";
            this.Load += new System.EventHandler(this.CurrentlyServing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServingNumber;
        private System.Windows.Forms.Label lblTitle;
    }
}