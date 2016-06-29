namespace Diary_Mei
{
    partial class Login
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login_Name = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 100);
            this.panel1.TabIndex = 0;
            // 
            // Login_Name
            // 
            this.Login_Name.AutoSize = true;
            this.Login_Name.Font = new System.Drawing.Font("华文行楷", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login_Name.Location = new System.Drawing.Point(47, 149);
            this.Login_Name.Name = "Login_Name";
            this.Login_Name.Size = new System.Drawing.Size(73, 22);
            this.Login_Name.TabIndex = 1;
            this.Login_Name.Text = "钟小梅";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.Name_TextBox.Location = new System.Drawing.Point(147, 149);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(167, 21);
            this.Name_TextBox.TabIndex = 2;
            this.Name_TextBox.UseSystemPasswordChar = true;
            this.Name_TextBox.WordWrap = false;
            // 
            // Login_Button
            // 
            this.Login_Button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Login_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Login_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Location = new System.Drawing.Point(351, 147);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(69, 24);
            this.Login_Button.TabIndex = 3;
            this.Login_Button.Text = "New Start";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.Login_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 213);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Login_Name);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Login_Name;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Button Login_Button;
    }
}

