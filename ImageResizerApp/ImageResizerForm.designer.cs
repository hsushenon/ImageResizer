namespace ImageResizerApp
{
    partial class ImageResizerForm
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
            this.btnResize = new System.Windows.Forms.Button();
            this.txtSourceDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTargetDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPercentToResize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbImageType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(140, 195);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(75, 23);
            this.btnResize.TabIndex = 0;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // txtSourceDir
            // 
            this.txtSourceDir.Location = new System.Drawing.Point(140, 47);
            this.txtSourceDir.Name = "txtSourceDir";
            this.txtSourceDir.Size = new System.Drawing.Size(156, 20);
            this.txtSourceDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target  folder";
            // 
            // txtTargetDir
            // 
            this.txtTargetDir.Location = new System.Drawing.Point(140, 83);
            this.txtTargetDir.Name = "txtTargetDir";
            this.txtTargetDir.Size = new System.Drawing.Size(156, 20);
            this.txtTargetDir.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Percentage to resize";
            // 
            // txtPercentToResize
            // 
            this.txtPercentToResize.Location = new System.Drawing.Point(142, 123);
            this.txtPercentToResize.Name = "txtPercentToResize";
            this.txtPercentToResize.Size = new System.Drawing.Size(73, 20);
            this.txtPercentToResize.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Image type";
            // 
            // cmbImageType
            // 
            this.cmbImageType.FormattingEnabled = true;
            this.cmbImageType.Items.AddRange(new object[] {
            "JPEG",
            "PNG",
            "BMP"});
            this.cmbImageType.Location = new System.Drawing.Point(140, 158);
            this.cmbImageType.Name = "cmbImageType";
            this.cmbImageType.Size = new System.Drawing.Size(75, 21);
            this.cmbImageType.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 370);
            this.Controls.Add(this.cmbImageType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPercentToResize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTargetDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSourceDir);
            this.Controls.Add(this.btnResize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.TextBox txtSourceDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPercentToResize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbImageType;
    }
}

