
namespace adpt_xcl_tool
{
    partial class Form1
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
            this.OriginFile_Path = new System.Windows.Forms.TextBox();
            this.OriginFile_Btn = new System.Windows.Forms.Button();
            this.SaveTo_Path = new System.Windows.Forms.TextBox();
            this.OriginalFilePath_Label = new System.Windows.Forms.Label();
            this.SaveTo_Label = new System.Windows.Forms.Label();
            this.Execute_btn = new System.Windows.Forms.Button();
            this.SaveTo_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OriginFile_Path
            // 
            this.OriginFile_Path.Location = new System.Drawing.Point(12, 70);
            this.OriginFile_Path.Name = "OriginFile_Path";
            this.OriginFile_Path.Size = new System.Drawing.Size(499, 22);
            this.OriginFile_Path.TabIndex = 0;
            // 
            // OriginFile_Btn
            // 
            this.OriginFile_Btn.Location = new System.Drawing.Point(517, 69);
            this.OriginFile_Btn.Name = "OriginFile_Btn";
            this.OriginFile_Btn.Size = new System.Drawing.Size(75, 23);
            this.OriginFile_Btn.TabIndex = 1;
            this.OriginFile_Btn.Text = "Select";
            this.OriginFile_Btn.UseVisualStyleBackColor = true;
            this.OriginFile_Btn.Click += new System.EventHandler(this.OriginFile_Btn_Click);
            // 
            // SaveTo_Path
            // 
            this.SaveTo_Path.Location = new System.Drawing.Point(12, 129);
            this.SaveTo_Path.Name = "SaveTo_Path";
            this.SaveTo_Path.Size = new System.Drawing.Size(499, 22);
            this.SaveTo_Path.TabIndex = 2;
            // 
            // OriginalFilePath_Label
            // 
            this.OriginalFilePath_Label.AutoSize = true;
            this.OriginalFilePath_Label.Location = new System.Drawing.Point(9, 50);
            this.OriginalFilePath_Label.Name = "OriginalFilePath_Label";
            this.OriginalFilePath_Label.Size = new System.Drawing.Size(105, 17);
            this.OriginalFilePath_Label.TabIndex = 4;
            this.OriginalFilePath_Label.Text = "Origin File Path";
            // 
            // SaveTo_Label
            // 
            this.SaveTo_Label.AutoSize = true;
            this.SaveTo_Label.Location = new System.Drawing.Point(12, 109);
            this.SaveTo_Label.Name = "SaveTo_Label";
            this.SaveTo_Label.Size = new System.Drawing.Size(56, 17);
            this.SaveTo_Label.TabIndex = 5;
            this.SaveTo_Label.Text = "Save to";
            // 
            // Execute_btn
            // 
            this.Execute_btn.Location = new System.Drawing.Point(266, 217);
            this.Execute_btn.Name = "Execute_btn";
            this.Execute_btn.Size = new System.Drawing.Size(75, 23);
            this.Execute_btn.TabIndex = 6;
            this.Execute_btn.Text = "Execute";
            this.Execute_btn.UseVisualStyleBackColor = true;
            this.Execute_btn.Click += new System.EventHandler(this.Execute_btn_Click);
            // 
            // SaveTo_Btn
            // 
            this.SaveTo_Btn.Location = new System.Drawing.Point(517, 128);
            this.SaveTo_Btn.Name = "SaveTo_Btn";
            this.SaveTo_Btn.Size = new System.Drawing.Size(75, 23);
            this.SaveTo_Btn.TabIndex = 7;
            this.SaveTo_Btn.Text = "Select";
            this.SaveTo_Btn.UseVisualStyleBackColor = true;
            this.SaveTo_Btn.Click += new System.EventHandler(this.SaveTo_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 252);
            this.Controls.Add(this.SaveTo_Btn);
            this.Controls.Add(this.Execute_btn);
            this.Controls.Add(this.SaveTo_Label);
            this.Controls.Add(this.OriginalFilePath_Label);
            this.Controls.Add(this.SaveTo_Path);
            this.Controls.Add(this.OriginFile_Btn);
            this.Controls.Add(this.OriginFile_Path);
            this.Name = "Form1";
            this.Text = "adpt_xcl_tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OriginFile_Path;
        private System.Windows.Forms.Button OriginFile_Btn;
        private System.Windows.Forms.TextBox SaveTo_Path;
        private System.Windows.Forms.Label OriginalFilePath_Label;
        private System.Windows.Forms.Label SaveTo_Label;
        private System.Windows.Forms.Button Execute_btn;
        private System.Windows.Forms.Button SaveTo_Btn;
    }
}

