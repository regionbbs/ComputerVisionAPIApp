﻿namespace AzureCVApiExample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdSelectImage = new System.Windows.Forms.Button();
            this.txtResponseContent = new System.Windows.Forms.TextBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(617, 22);
            this.textBox1.TabIndex = 1;
            // 
            // cmdSelectImage
            // 
            this.cmdSelectImage.Location = new System.Drawing.Point(695, 23);
            this.cmdSelectImage.Name = "cmdSelectImage";
            this.cmdSelectImage.Size = new System.Drawing.Size(75, 22);
            this.cmdSelectImage.TabIndex = 2;
            this.cmdSelectImage.Text = "Select";
            this.cmdSelectImage.UseVisualStyleBackColor = true;
            this.cmdSelectImage.Click += new System.EventHandler(this.cmdSelectImage_Click);
            // 
            // txtResponseContent
            // 
            this.txtResponseContent.Location = new System.Drawing.Point(31, 449);
            this.txtResponseContent.Multiline = true;
            this.txtResponseContent.Name = "txtResponseContent";
            this.txtResponseContent.ReadOnly = true;
            this.txtResponseContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponseContent.Size = new System.Drawing.Size(739, 282);
            this.txtResponseContent.TabIndex = 4;
            // 
            // panelImage
            // 
            this.panelImage.AutoScroll = true;
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelImage.Location = new System.Drawing.Point(31, 61);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(739, 382);
            this.panelImage.TabIndex = 5;
            this.panelImage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImage_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 758);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.txtResponseContent);
            this.Controls.Add(this.cmdSelectImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Computer Vision API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdSelectImage;
        private System.Windows.Forms.TextBox txtResponseContent;
        private System.Windows.Forms.Panel panelImage;
    }
}

