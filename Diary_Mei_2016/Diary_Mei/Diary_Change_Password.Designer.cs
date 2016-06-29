namespace Diary_Mei
{
    partial class Diary_Change_Password
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
            this.Password_Enter_Label_0 = new System.Windows.Forms.Label();
            this.TextBox_Password_0 = new System.Windows.Forms.TextBox();
            this.Button_Submit = new System.Windows.Forms.Button();
            this.Password_Enter_Label_T = new System.Windows.Forms.Label();
            this.TextBox_Password_1 = new System.Windows.Forms.TextBox();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password_Enter_Label_0
            // 
            this.Password_Enter_Label_0.AutoSize = true;
            this.Password_Enter_Label_0.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password_Enter_Label_0.Location = new System.Drawing.Point(15, 41);
            this.Password_Enter_Label_0.Name = "Password_Enter_Label_0";
            this.Password_Enter_Label_0.Size = new System.Drawing.Size(133, 14);
            this.Password_Enter_Label_0.TabIndex = 1;
            this.Password_Enter_Label_0.Text = "请输入您的新密码：";
            // 
            // TextBox_Password_0
            // 
            this.TextBox_Password_0.Location = new System.Drawing.Point(151, 37);
            this.TextBox_Password_0.Name = "TextBox_Password_0";
            this.TextBox_Password_0.Size = new System.Drawing.Size(209, 21);
            this.TextBox_Password_0.TabIndex = 3;
            this.TextBox_Password_0.UseSystemPasswordChar = true;
            // 
            // Button_Submit
            // 
            this.Button_Submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Submit.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Submit.Location = new System.Drawing.Point(378, 36);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(75, 23);
            this.Button_Submit.TabIndex = 5;
            this.Button_Submit.Text = "Submit";
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // Password_Enter_Label_T
            // 
            this.Password_Enter_Label_T.AutoSize = true;
            this.Password_Enter_Label_T.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Password_Enter_Label_T.Location = new System.Drawing.Point(12, 104);
            this.Password_Enter_Label_T.Name = "Password_Enter_Label_T";
            this.Password_Enter_Label_T.Size = new System.Drawing.Size(133, 14);
            this.Password_Enter_Label_T.TabIndex = 6;
            this.Password_Enter_Label_T.Text = "请再次输入新密码：";
            // 
            // TextBox_Password_1
            // 
            this.TextBox_Password_1.Location = new System.Drawing.Point(151, 101);
            this.TextBox_Password_1.Name = "TextBox_Password_1";
            this.TextBox_Password_1.Size = new System.Drawing.Size(209, 21);
            this.TextBox_Password_1.TabIndex = 7;
            this.TextBox_Password_1.UseSystemPasswordChar = true;
            // 
            // Button_Clear
            // 
            this.Button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Clear.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Clear.Location = new System.Drawing.Point(378, 100);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(75, 23);
            this.Button_Clear.TabIndex = 8;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Diary_Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 172);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.TextBox_Password_1);
            this.Controls.Add(this.Password_Enter_Label_T);
            this.Controls.Add(this.Button_Submit);
            this.Controls.Add(this.TextBox_Password_0);
            this.Controls.Add(this.Password_Enter_Label_0);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Diary_Change_Password";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password_Enter_Label_0;
        private System.Windows.Forms.TextBox TextBox_Password_0;
        private System.Windows.Forms.Button Button_Submit;
        private System.Windows.Forms.Label Password_Enter_Label_T;
        private System.Windows.Forms.TextBox TextBox_Password_1;
        private System.Windows.Forms.Button Button_Clear;
    }
}