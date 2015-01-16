namespace ConvertTIFtoPDF
{
    partial class frmImages
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
            this.btnSelectExcelOutputPath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblImagesFolder = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectExcelOutputPath
            // 
            this.btnSelectExcelOutputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectExcelOutputPath.Location = new System.Drawing.Point(380, 37);
            this.btnSelectExcelOutputPath.Name = "btnSelectExcelOutputPath";
            this.btnSelectExcelOutputPath.Size = new System.Drawing.Size(224, 23);
            this.btnSelectExcelOutputPath.TabIndex = 20;
            this.btnSelectExcelOutputPath.Text = "Select Directory";
            this.btnSelectExcelOutputPath.UseVisualStyleBackColor = true;
            this.btnSelectExcelOutputPath.Click += new System.EventHandler(this.btnSelectExcelOutputPath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Select Directory that contains tif images:";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(269, 115);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(95, 23);
            this.btnProcess.TabIndex = 22;
            this.btnProcess.Text = "Process Images";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblImagesFolder
            // 
            this.lblImagesFolder.AutoSize = true;
            this.lblImagesFolder.Location = new System.Drawing.Point(150, 76);
            this.lblImagesFolder.Name = "lblImagesFolder";
            this.lblImagesFolder.Size = new System.Drawing.Size(0, 13);
            this.lblImagesFolder.TabIndex = 23;
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(226, 158);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(0, 16);
            this.lblTimeElapsed.TabIndex = 24;
            // 
            // frmImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 200);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.lblImagesFolder);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnSelectExcelOutputPath);
            this.Controls.Add(this.label5);
            this.Name = "frmImages";
            this.Text = "frmImages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectExcelOutputPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblImagesFolder;
        private System.Windows.Forms.Label lblTimeElapsed;
    }
}