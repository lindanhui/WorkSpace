namespace API_Hander_Test
{
    partial class APIDeal
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APIDeal));
            this.label_URL = new System.Windows.Forms.Label();
            this.richTextBox_URL = new System.Windows.Forms.RichTextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_URL
            // 
            this.label_URL.AutoSize = true;
            this.label_URL.Location = new System.Drawing.Point(32, 53);
            this.label_URL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(76, 14);
            this.label_URL.TabIndex = 0;
            this.label_URL.Text = "URL路径：";
            // 
            // richTextBox_URL
            // 
            this.richTextBox_URL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_URL.Location = new System.Drawing.Point(115, 12);
            this.richTextBox_URL.Name = "richTextBox_URL";
            this.richTextBox_URL.Size = new System.Drawing.Size(924, 96);
            this.richTextBox_URL.TabIndex = 1;
            this.richTextBox_URL.Text = "";
            // 
            // button_Submit
            // 
            this.button_Submit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Submit.Location = new System.Drawing.Point(272, 453);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(533, 23);
            this.button_Submit.TabIndex = 2;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            // 
            // APIDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 488);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.richTextBox_URL);
            this.Controls.Add(this.label_URL);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "APIDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APITest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_URL;
        private System.Windows.Forms.RichTextBox richTextBox_URL;
        private System.Windows.Forms.Button button_Submit;
    }
}

