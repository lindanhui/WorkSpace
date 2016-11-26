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
            this.label_Submit_Data = new System.Windows.Forms.Label();
            this.richTextBox_Submit_Data = new System.Windows.Forms.RichTextBox();
            this.label_Return_Data = new System.Windows.Forms.Label();
            this.richTextBox_Return_Data = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MID = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Token = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Submit_Type = new System.Windows.Forms.Label();
            this.comboBox_Submit_Type = new System.Windows.Forms.ComboBox();
            this.label_Deal = new System.Windows.Forms.Label();
            this.label_Message = new System.Windows.Forms.Label();
            this.label_Message_Print = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_URL
            // 
            this.label_URL.AutoSize = true;
            this.label_URL.Location = new System.Drawing.Point(32, 80);
            this.label_URL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(76, 14);
            this.label_URL.TabIndex = 0;
            this.label_URL.Text = "URL路径：";
            // 
            // richTextBox_URL
            // 
            this.richTextBox_URL.Location = new System.Drawing.Point(115, 52);
            this.richTextBox_URL.Name = "richTextBox_URL";
            this.richTextBox_URL.Size = new System.Drawing.Size(924, 70);
            this.richTextBox_URL.TabIndex = 1;
            this.richTextBox_URL.Text = "";
            // 
            // button_Submit
            // 
            this.button_Submit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Submit.Location = new System.Drawing.Point(326, 464);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(714, 23);
            this.button_Submit.TabIndex = 2;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // label_Submit_Data
            // 
            this.label_Submit_Data.AutoSize = true;
            this.label_Submit_Data.Location = new System.Drawing.Point(27, 200);
            this.label_Submit_Data.Name = "label_Submit_Data";
            this.label_Submit_Data.Size = new System.Drawing.Size(82, 14);
            this.label_Submit_Data.TabIndex = 3;
            this.label_Submit_Data.Text = "提交数据：";
            // 
            // richTextBox_Submit_Data
            // 
            this.richTextBox_Submit_Data.Location = new System.Drawing.Point(115, 148);
            this.richTextBox_Submit_Data.Name = "richTextBox_Submit_Data";
            this.richTextBox_Submit_Data.Size = new System.Drawing.Size(925, 122);
            this.richTextBox_Submit_Data.TabIndex = 4;
            this.richTextBox_Submit_Data.Text = "";
            // 
            // label_Return_Data
            // 
            this.label_Return_Data.AutoSize = true;
            this.label_Return_Data.Location = new System.Drawing.Point(26, 336);
            this.label_Return_Data.Name = "label_Return_Data";
            this.label_Return_Data.Size = new System.Drawing.Size(82, 14);
            this.label_Return_Data.TabIndex = 5;
            this.label_Return_Data.Text = "返回数据：";
            // 
            // richTextBox_Return_Data
            // 
            this.richTextBox_Return_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_Return_Data.Location = new System.Drawing.Point(115, 295);
            this.richTextBox_Return_Data.Name = "richTextBox_Return_Data";
            this.richTextBox_Return_Data.Size = new System.Drawing.Size(924, 96);
            this.richTextBox_Return_Data.TabIndex = 6;
            this.richTextBox_Return_Data.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Token查询：";
            // 
            // textBox_MID
            // 
            this.textBox_MID.Location = new System.Drawing.Point(115, 412);
            this.textBox_MID.Name = "textBox_MID";
            this.textBox_MID.Size = new System.Drawing.Size(121, 23);
            this.textBox_MID.TabIndex = 8;
            this.textBox_MID.Text = "请输入MID";
            this.textBox_MID.Click += new System.EventHandler(this.textBox_MID_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(471, 17);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(134, 16);
            this.label_Title.TabIndex = 9;
            this.label_Title.Text = "WDD_API_Hanher";
            // 
            // label_Token
            // 
            this.label_Token.AutoSize = true;
            this.label_Token.Location = new System.Drawing.Point(265, 416);
            this.label_Token.Name = "label_Token";
            this.label_Token.Size = new System.Drawing.Size(55, 14);
            this.label_Token.TabIndex = 10;
            this.label_Token.Text = "Token:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(714, 23);
            this.textBox1.TabIndex = 11;
            // 
            // label_Submit_Type
            // 
            this.label_Submit_Type.AutoSize = true;
            this.label_Submit_Type.Location = new System.Drawing.Point(26, 468);
            this.label_Submit_Type.Name = "label_Submit_Type";
            this.label_Submit_Type.Size = new System.Drawing.Size(82, 14);
            this.label_Submit_Type.TabIndex = 12;
            this.label_Submit_Type.Text = "提交方式：";
            // 
            // comboBox_Submit_Type
            // 
            this.comboBox_Submit_Type.FormattingEnabled = true;
            this.comboBox_Submit_Type.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.comboBox_Submit_Type.Location = new System.Drawing.Point(114, 465);
            this.comboBox_Submit_Type.Name = "comboBox_Submit_Type";
            this.comboBox_Submit_Type.Size = new System.Drawing.Size(122, 22);
            this.comboBox_Submit_Type.TabIndex = 13;
            this.comboBox_Submit_Type.Text = "GET";
            // 
            // label_Deal
            // 
            this.label_Deal.AutoSize = true;
            this.label_Deal.Location = new System.Drawing.Point(273, 468);
            this.label_Deal.Name = "label_Deal";
            this.label_Deal.Size = new System.Drawing.Size(47, 14);
            this.label_Deal.TabIndex = 14;
            this.label_Deal.Text = "Deal:";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Location = new System.Drawing.Point(26, 510);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(71, 14);
            this.label_Message.TabIndex = 15;
            this.label_Message.Text = "Message:";
            // 
            // label_Message_Print
            // 
            this.label_Message_Print.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Message_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Message_Print.Location = new System.Drawing.Point(112, 503);
            this.label_Message_Print.Name = "label_Message_Print";
            this.label_Message_Print.Size = new System.Drawing.Size(927, 31);
            this.label_Message_Print.TabIndex = 16;
            this.label_Message_Print.Text = "NULL";
            this.label_Message_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // APIDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 550);
            this.Controls.Add(this.label_Message_Print);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.label_Deal);
            this.Controls.Add(this.comboBox_Submit_Type);
            this.Controls.Add(this.label_Submit_Type);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Token);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.textBox_MID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Return_Data);
            this.Controls.Add(this.label_Return_Data);
            this.Controls.Add(this.richTextBox_Submit_Data);
            this.Controls.Add(this.label_Submit_Data);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.richTextBox_URL);
            this.Controls.Add(this.label_URL);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "APIDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APITest";
            this.Load += new System.EventHandler(this.APIDeal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_URL;
        private System.Windows.Forms.RichTextBox richTextBox_URL;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Label label_Submit_Data;
        private System.Windows.Forms.RichTextBox richTextBox_Submit_Data;
        private System.Windows.Forms.Label label_Return_Data;
        private System.Windows.Forms.RichTextBox richTextBox_Return_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MID;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Token;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Submit_Type;
        private System.Windows.Forms.ComboBox comboBox_Submit_Type;
        private System.Windows.Forms.Label label_Deal;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label_Message_Print;
    }
}

