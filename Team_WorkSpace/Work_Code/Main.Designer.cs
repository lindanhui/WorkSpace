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
            this.button_Submit = new System.Windows.Forms.Button();
            this.label_Submit_Data = new System.Windows.Forms.Label();
            this.richTextBox_Submit_Data = new System.Windows.Forms.RichTextBox();
            this.label_Return_Data = new System.Windows.Forms.Label();
            this.richTextBox_Return_Data = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MID = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Token = new System.Windows.Forms.Label();
            this.textBox_token = new System.Windows.Forms.TextBox();
            this.label_Submit_Type = new System.Windows.Forms.Label();
            this.comboBox_Submit_Type = new System.Windows.Forms.ComboBox();
            this.label_Deal = new System.Windows.Forms.Label();
            this.label_Message = new System.Windows.Forms.Label();
            this.label_Message_Print = new System.Windows.Forms.Label();
            this.label_Field_Instruction = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_Transform = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Export_Txt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Export_Html = new System.Windows.Forms.Button();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.comboBox_Code = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
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
            // button_Submit
            // 
            this.button_Submit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Submit.Location = new System.Drawing.Point(326, 466);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(534, 36);
            this.button_Submit.TabIndex = 2;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // label_Submit_Data
            // 
            this.label_Submit_Data.AutoSize = true;
            this.label_Submit_Data.Location = new System.Drawing.Point(27, 167);
            this.label_Submit_Data.Name = "label_Submit_Data";
            this.label_Submit_Data.Size = new System.Drawing.Size(82, 14);
            this.label_Submit_Data.TabIndex = 3;
            this.label_Submit_Data.Text = "提交数据：";
            // 
            // richTextBox_Submit_Data
            // 
            this.richTextBox_Submit_Data.Location = new System.Drawing.Point(112, 139);
            this.richTextBox_Submit_Data.Name = "richTextBox_Submit_Data";
            this.richTextBox_Submit_Data.Size = new System.Drawing.Size(752, 75);
            this.richTextBox_Submit_Data.TabIndex = 4;
            this.richTextBox_Submit_Data.Text = "";
            // 
            // label_Return_Data
            // 
            this.label_Return_Data.AutoSize = true;
            this.label_Return_Data.Location = new System.Drawing.Point(26, 285);
            this.label_Return_Data.Name = "label_Return_Data";
            this.label_Return_Data.Size = new System.Drawing.Size(82, 14);
            this.label_Return_Data.TabIndex = 5;
            this.label_Return_Data.Text = "返回数据：";
            // 
            // richTextBox_Return_Data
            // 
            this.richTextBox_Return_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_Return_Data.Location = new System.Drawing.Point(112, 228);
            this.richTextBox_Return_Data.Name = "richTextBox_Return_Data";
            this.richTextBox_Return_Data.ReadOnly = true;
            this.richTextBox_Return_Data.Size = new System.Drawing.Size(752, 125);
            this.richTextBox_Return_Data.TabIndex = 6;
            this.richTextBox_Return_Data.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Token查询：";
            // 
            // textBox_MID
            // 
            this.textBox_MID.Location = new System.Drawing.Point(115, 378);
            this.textBox_MID.Name = "textBox_MID";
            this.textBox_MID.Size = new System.Drawing.Size(144, 23);
            this.textBox_MID.TabIndex = 8;
            this.textBox_MID.Text = "请输入MID";
            this.textBox_MID.Click += new System.EventHandler(this.textBox_MID_Click);
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(12, 6);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(1196, 40);
            this.label_Title.TabIndex = 9;
            this.label_Title.Text = "WDD_API_Hanher";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Token
            // 
            this.label_Token.AutoSize = true;
            this.label_Token.Location = new System.Drawing.Point(265, 383);
            this.label_Token.Name = "label_Token";
            this.label_Token.Size = new System.Drawing.Size(55, 14);
            this.label_Token.TabIndex = 10;
            this.label_Token.Text = "Token:";
            // 
            // textBox_token
            // 
            this.textBox_token.Location = new System.Drawing.Point(326, 379);
            this.textBox_token.Name = "textBox_token";
            this.textBox_token.ReadOnly = true;
            this.textBox_token.Size = new System.Drawing.Size(392, 23);
            this.textBox_token.TabIndex = 11;
            // 
            // label_Submit_Type
            // 
            this.label_Submit_Type.AutoSize = true;
            this.label_Submit_Type.Location = new System.Drawing.Point(26, 429);
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
            this.comboBox_Submit_Type.Location = new System.Drawing.Point(114, 425);
            this.comboBox_Submit_Type.Name = "comboBox_Submit_Type";
            this.comboBox_Submit_Type.Size = new System.Drawing.Size(145, 22);
            this.comboBox_Submit_Type.TabIndex = 13;
            this.comboBox_Submit_Type.Text = "GET";
            // 
            // label_Deal
            // 
            this.label_Deal.AutoSize = true;
            this.label_Deal.Location = new System.Drawing.Point(273, 477);
            this.label_Deal.Name = "label_Deal";
            this.label_Deal.Size = new System.Drawing.Size(47, 14);
            this.label_Deal.TabIndex = 14;
            this.label_Deal.Text = "Deal:";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Location = new System.Drawing.Point(26, 521);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(71, 14);
            this.label_Message.TabIndex = 15;
            this.label_Message.Text = "Message:";
            // 
            // label_Message_Print
            // 
            this.label_Message_Print.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Message_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Message_Print.Location = new System.Drawing.Point(112, 512);
            this.label_Message_Print.Name = "label_Message_Print";
            this.label_Message_Print.Size = new System.Drawing.Size(1096, 31);
            this.label_Message_Print.TabIndex = 16;
            this.label_Message_Print.Text = "NULL";
            this.label_Message_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Field_Instruction
            // 
            this.label_Field_Instruction.AutoSize = true;
            this.label_Field_Instruction.Location = new System.Drawing.Point(130, 20);
            this.label_Field_Instruction.Name = "label_Field_Instruction";
            this.label_Field_Instruction.Size = new System.Drawing.Size(67, 14);
            this.label_Field_Instruction.TabIndex = 17;
            this.label_Field_Instruction.Text = "参数对照";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(6, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(326, 404);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // button_Transform
            // 
            this.button_Transform.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_Transform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Transform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Transform.Location = new System.Drawing.Point(724, 378);
            this.button_Transform.Name = "button_Transform";
            this.button_Transform.Size = new System.Drawing.Size(136, 25);
            this.button_Transform.TabIndex = 19;
            this.button_Transform.Text = "一键转换测试";
            this.button_Transform.UseVisualStyleBackColor = true;
            this.button_Transform.Click += new System.EventHandler(this.button_Transform_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "请求编码：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Field_Instruction);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(870, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 459);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // button_Export_Txt
            // 
            this.button_Export_Txt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_Export_Txt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Export_Txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Export_Txt.Location = new System.Drawing.Point(326, 424);
            this.button_Export_Txt.Name = "button_Export_Txt";
            this.button_Export_Txt.Size = new System.Drawing.Size(257, 25);
            this.button_Export_Txt.TabIndex = 23;
            this.button_Export_Txt.Text = "导出TXT";
            this.button_Export_Txt.UseVisualStyleBackColor = true;
            this.button_Export_Txt.Click += new System.EventHandler(this.button_Export_Txt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tools:";
            // 
            // button_Export_Html
            // 
            this.button_Export_Html.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_Export_Html.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Export_Html.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Export_Html.Location = new System.Drawing.Point(608, 425);
            this.button_Export_Html.Name = "button_Export_Html";
            this.button_Export_Html.Size = new System.Drawing.Size(252, 25);
            this.button_Export_Html.TabIndex = 25;
            this.button_Export_Html.Text = "转换XML";
            this.button_Export_Html.UseVisualStyleBackColor = true;
            this.button_Export_Html.Click += new System.EventHandler(this.button_Export_Html_Click);
            // 
            // textBox_URL
            // 
            this.textBox_URL.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_URL.Location = new System.Drawing.Point(112, 52);
            this.textBox_URL.Multiline = true;
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_URL.Size = new System.Drawing.Size(753, 75);
            this.textBox_URL.TabIndex = 26;
            // 
            // comboBox_Code
            // 
            this.comboBox_Code.FormattingEnabled = true;
            this.comboBox_Code.Items.AddRange(new object[] {
            "UTF-8",
            "Unicode",
            "BigEndianUnicode",
            "ASCII"});
            this.comboBox_Code.Location = new System.Drawing.Point(114, 472);
            this.comboBox_Code.Name = "comboBox_Code";
            this.comboBox_Code.Size = new System.Drawing.Size(145, 22);
            this.comboBox_Code.TabIndex = 27;
            this.comboBox_Code.Text = "UTF-8";
            // 
            // APIDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 549);
            this.Controls.Add(this.comboBox_Code);
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.button_Export_Html);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Export_Txt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Transform);
            this.Controls.Add(this.label_Message_Print);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.label_Deal);
            this.Controls.Add(this.comboBox_Submit_Type);
            this.Controls.Add(this.label_Submit_Type);
            this.Controls.Add(this.textBox_token);
            this.Controls.Add(this.label_Token);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.textBox_MID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Return_Data);
            this.Controls.Add(this.label_Return_Data);
            this.Controls.Add(this.richTextBox_Submit_Data);
            this.Controls.Add(this.label_Submit_Data);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label_URL);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "APIDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APITest";
            this.Load += new System.EventHandler(this.APIDeal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_URL;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Label label_Submit_Data;
        private System.Windows.Forms.RichTextBox richTextBox_Submit_Data;
        private System.Windows.Forms.Label label_Return_Data;
        private System.Windows.Forms.RichTextBox richTextBox_Return_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MID;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Token;
        private System.Windows.Forms.TextBox textBox_token;
        private System.Windows.Forms.Label label_Submit_Type;
        private System.Windows.Forms.ComboBox comboBox_Submit_Type;
        private System.Windows.Forms.Label label_Deal;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label_Message_Print;
        private System.Windows.Forms.Label label_Field_Instruction;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_Transform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Export_Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Export_Html;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.ComboBox comboBox_Code;
    }
}

