namespace WorkSheetEditorProgram
{
    partial class formLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLoad));
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
            this.pictureBoxSQL = new System.Windows.Forms.PictureBox();
            this.pictureBoxCsharp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCsharp)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Location = new System.Drawing.Point(0, 290);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(408, 33);
            this.progressBarLoad.TabIndex = 1;
            // 
            // pictureBoxSQL
            // 
            this.pictureBoxSQL.Image = global::WorkSheetEditorProgram.Properties.Resources.SQL;
            this.pictureBoxSQL.Location = new System.Drawing.Point(236, 130);
            this.pictureBoxSQL.Name = "pictureBoxSQL";
            this.pictureBoxSQL.Size = new System.Drawing.Size(172, 154);
            this.pictureBoxSQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSQL.TabIndex = 3;
            this.pictureBoxSQL.TabStop = false;
            // 
            // pictureBoxCsharp
            // 
            this.pictureBoxCsharp.Image = global::WorkSheetEditorProgram.Properties.Resources.cs;
            this.pictureBoxCsharp.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxCsharp.Name = "pictureBoxCsharp";
            this.pictureBoxCsharp.Size = new System.Drawing.Size(172, 154);
            this.pictureBoxCsharp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCsharp.TabIndex = 2;
            this.pictureBoxCsharp.TabStop = false;
            // 
            // formLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 325);
            this.Controls.Add(this.pictureBoxSQL);
            this.Controls.Add(this.pictureBoxCsharp);
            this.Controls.Add(this.progressBarLoad);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(427, 368);
            this.MinimumSize = new System.Drawing.Size(427, 368);
            this.Name = "formLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worksheet Editor Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCsharp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarLoad;
        private System.Windows.Forms.PictureBox pictureBoxCsharp;
        private System.Windows.Forms.PictureBox pictureBoxSQL;
    }
}

