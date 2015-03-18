namespace COMP123_Lesson10_Part2
{
    partial class NewForm
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
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Image = global::COMP123_Lesson10_Part2.Properties.Resources.Welcome_large;
            this.MainPictureBox.Location = new System.Drawing.Point(12, 12);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(280, 163);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(101, 181);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(93, 32);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "NEXT";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainPictureBox);
            this.Name = "NewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Form";
            this.Load += new System.EventHandler(this.NewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Button NextButton;
    }
}

