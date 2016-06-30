namespace Diary_Mei
{
    partial class Diary_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diary_Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_Picture = new System.Windows.Forms.Button();
            this.Button_Record = new System.Windows.Forms.Button();
            this.Button_Friend = new System.Windows.Forms.Button();
            this.Button_Diary = new System.Windows.Forms.Button();
            this.Button_Client = new System.Windows.Forms.Button();
            this.Button_Password = new System.Windows.Forms.Button();
            this.Timer_Print_Date = new System.Windows.Forms.Timer(this.components);
            this.Panel_Welcome = new System.Windows.Forms.Panel();
            this.Label_Date = new System.Windows.Forms.Label();
            this.Label_Welcome = new System.Windows.Forms.Label();
            this.Panel_Client_Friend = new System.Windows.Forms.Panel();
            this.dataGridView_Archive_Print = new System.Windows.Forms.DataGridView();
            this.Panel_Function = new System.Windows.Forms.Panel();
            this.TSDiary = new System.Windows.Forms.ToolStrip();
            this.TSBFirstPage = new System.Windows.Forms.ToolStripButton();
            this.TSBPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.TSBNextPage = new System.Windows.Forms.ToolStripButton();
            this.TSBLastPage = new System.Windows.Forms.ToolStripButton();
            this.TSLAllPageS = new System.Windows.Forms.ToolStripLabel();
            this.TSLPagesPrint = new System.Windows.Forms.ToolStripLabel();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Button_Export = new System.Windows.Forms.Button();
            this.TextBox_Keyword = new System.Windows.Forms.TextBox();
            this.Label_Keyword = new System.Windows.Forms.Label();
            this.Label_Level = new System.Windows.Forms.Label();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.ComboBox_Type = new System.Windows.Forms.ComboBox();
            this.Button_Editor = new System.Windows.Forms.Button();
            this.ComboBox_Level = new System.Windows.Forms.ComboBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Button_Search = new System.Windows.Forms.Button();
            this.Label_Client = new System.Windows.Forms.GroupBox();
            this.Label_Client_Company = new System.Windows.Forms.Label();
            this.Label_Client_Address = new System.Windows.Forms.Label();
            this.Label_Client_Phone = new System.Windows.Forms.Label();
            this.Label_Client_Name = new System.Windows.Forms.Label();
            this.Menu_Panel.SuspendLayout();
            this.Panel_Welcome.SuspendLayout();
            this.Panel_Client_Friend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Archive_Print)).BeginInit();
            this.Panel_Function.SuspendLayout();
            this.TSDiary.SuspendLayout();
            this.Label_Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Menu_Panel.Controls.Add(this.Button_Close);
            this.Menu_Panel.Controls.Add(this.Button_Picture);
            this.Menu_Panel.Controls.Add(this.Button_Record);
            this.Menu_Panel.Controls.Add(this.Button_Friend);
            this.Menu_Panel.Controls.Add(this.Button_Diary);
            this.Menu_Panel.Controls.Add(this.Button_Client);
            this.Menu_Panel.Controls.Add(this.Button_Password);
            this.Menu_Panel.Location = new System.Drawing.Point(-7, 362);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(997, 96);
            this.Menu_Panel.TabIndex = 0;
            // 
            // Button_Close
            // 
            this.Button_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Close.Image = ((System.Drawing.Image)(resources.GetObject("Button_Close.Image")));
            this.Button_Close.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Close.Location = new System.Drawing.Point(879, 8);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(80, 80);
            this.Button_Close.TabIndex = 6;
            this.Button_Close.Text = "关闭";
            this.Button_Close.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.button6_Click);
            // 
            // Button_Picture
            // 
            this.Button_Picture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Picture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Picture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Picture.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Picture.Image = ((System.Drawing.Image)(resources.GetObject("Button_Picture.Image")));
            this.Button_Picture.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Picture.Location = new System.Drawing.Point(599, 8);
            this.Button_Picture.Name = "Button_Picture";
            this.Button_Picture.Size = new System.Drawing.Size(80, 80);
            this.Button_Picture.TabIndex = 5;
            this.Button_Picture.Text = "图片";
            this.Button_Picture.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Picture.UseVisualStyleBackColor = true;
            this.Button_Picture.Click += new System.EventHandler(this.Button_Picture_Click);
            // 
            // Button_Record
            // 
            this.Button_Record.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Record.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Record.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Record.Image = ((System.Drawing.Image)(resources.GetObject("Button_Record.Image")));
            this.Button_Record.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Record.Location = new System.Drawing.Point(455, 8);
            this.Button_Record.Name = "Button_Record";
            this.Button_Record.Size = new System.Drawing.Size(80, 80);
            this.Button_Record.TabIndex = 4;
            this.Button_Record.Text = "录音";
            this.Button_Record.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Record.UseVisualStyleBackColor = true;
            this.Button_Record.Click += new System.EventHandler(this.Button_Record_Click);
            // 
            // Button_Friend
            // 
            this.Button_Friend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Friend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Friend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Friend.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Friend.Image = ((System.Drawing.Image)(resources.GetObject("Button_Friend.Image")));
            this.Button_Friend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Friend.Location = new System.Drawing.Point(172, 8);
            this.Button_Friend.Name = "Button_Friend";
            this.Button_Friend.Size = new System.Drawing.Size(80, 80);
            this.Button_Friend.TabIndex = 3;
            this.Button_Friend.Text = "朋友档案";
            this.Button_Friend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Friend.UseVisualStyleBackColor = true;
            this.Button_Friend.Click += new System.EventHandler(this.Button_Friend_Click);
            // 
            // Button_Diary
            // 
            this.Button_Diary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Diary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Diary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Diary.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Diary.Image = ((System.Drawing.Image)(resources.GetObject("Button_Diary.Image")));
            this.Button_Diary.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Diary.Location = new System.Drawing.Point(309, 8);
            this.Button_Diary.Name = "Button_Diary";
            this.Button_Diary.Size = new System.Drawing.Size(80, 80);
            this.Button_Diary.TabIndex = 2;
            this.Button_Diary.Text = "日记本";
            this.Button_Diary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Diary.UseVisualStyleBackColor = true;
            this.Button_Diary.Click += new System.EventHandler(this.Button_Diary_Click);
            // 
            // Button_Client
            // 
            this.Button_Client.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Client.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Client.Image = ((System.Drawing.Image)(resources.GetObject("Button_Client.Image")));
            this.Button_Client.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Client.Location = new System.Drawing.Point(35, 8);
            this.Button_Client.Name = "Button_Client";
            this.Button_Client.Size = new System.Drawing.Size(80, 80);
            this.Button_Client.TabIndex = 1;
            this.Button_Client.Text = "客户档案";
            this.Button_Client.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Client.UseVisualStyleBackColor = true;
            this.Button_Client.Click += new System.EventHandler(this.Button_Client_Click);
            // 
            // Button_Password
            // 
            this.Button_Password.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Password.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Password.Image = ((System.Drawing.Image)(resources.GetObject("Button_Password.Image")));
            this.Button_Password.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Password.Location = new System.Drawing.Point(738, 8);
            this.Button_Password.Name = "Button_Password";
            this.Button_Password.Size = new System.Drawing.Size(80, 80);
            this.Button_Password.TabIndex = 0;
            this.Button_Password.Text = "修改密码";
            this.Button_Password.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Password.UseVisualStyleBackColor = true;
            this.Button_Password.Click += new System.EventHandler(this.Diary_Password_Click);
            // 
            // Timer_Print_Date
            // 
            this.Timer_Print_Date.Enabled = true;
            this.Timer_Print_Date.Interval = 1000;
            this.Timer_Print_Date.Tick += new System.EventHandler(this.Timer_Print_Date_Tick);
            // 
            // Panel_Welcome
            // 
            this.Panel_Welcome.Controls.Add(this.Label_Date);
            this.Panel_Welcome.Controls.Add(this.Label_Welcome);
            this.Panel_Welcome.Location = new System.Drawing.Point(23, 36);
            this.Panel_Welcome.Name = "Panel_Welcome";
            this.Panel_Welcome.Size = new System.Drawing.Size(942, 274);
            this.Panel_Welcome.TabIndex = 4;
            // 
            // Label_Date
            // 
            this.Label_Date.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Date.ForeColor = System.Drawing.Color.Gray;
            this.Label_Date.Location = new System.Drawing.Point(196, 162);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(542, 55);
            this.Label_Date.TabIndex = 1;
            this.Label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Welcome
            // 
            this.Label_Welcome.AutoSize = true;
            this.Label_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Label_Welcome.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Welcome.ForeColor = System.Drawing.Color.Silver;
            this.Label_Welcome.Location = new System.Drawing.Point(320, 80);
            this.Label_Welcome.Name = "Label_Welcome";
            this.Label_Welcome.Size = new System.Drawing.Size(285, 29);
            this.Label_Welcome.TabIndex = 0;
            this.Label_Welcome.Text = "Welcome To Here !";
            this.Label_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Client_Friend
            // 
            this.Panel_Client_Friend.BackColor = System.Drawing.Color.White;
            this.Panel_Client_Friend.Controls.Add(this.dataGridView_Archive_Print);
            this.Panel_Client_Friend.Controls.Add(this.Panel_Function);
            this.Panel_Client_Friend.Controls.Add(this.Label_Client);
            this.Panel_Client_Friend.Location = new System.Drawing.Point(-1, 1);
            this.Panel_Client_Friend.Name = "Panel_Client_Friend";
            this.Panel_Client_Friend.Size = new System.Drawing.Size(987, 360);
            this.Panel_Client_Friend.TabIndex = 5;
            this.Panel_Client_Friend.Visible = false;
            // 
            // dataGridView_Archive_Print
            // 
            this.dataGridView_Archive_Print.AllowUserToAddRows = false;
            this.dataGridView_Archive_Print.AllowUserToDeleteRows = false;
            this.dataGridView_Archive_Print.AllowUserToResizeColumns = false;
            this.dataGridView_Archive_Print.AllowUserToResizeRows = false;
            this.dataGridView_Archive_Print.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Archive_Print.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Archive_Print.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Archive_Print.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Archive_Print.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Archive_Print.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Archive_Print.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Archive_Print.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Archive_Print.GridColor = System.Drawing.Color.White;
            this.dataGridView_Archive_Print.Location = new System.Drawing.Point(-4, 32);
            this.dataGridView_Archive_Print.MultiSelect = false;
            this.dataGridView_Archive_Print.Name = "dataGridView_Archive_Print";
            this.dataGridView_Archive_Print.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Archive_Print.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Archive_Print.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView_Archive_Print.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Archive_Print.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView_Archive_Print.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Archive_Print.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView_Archive_Print.RowTemplate.Height = 23;
            this.dataGridView_Archive_Print.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Archive_Print.Size = new System.Drawing.Size(991, 231);
            this.dataGridView_Archive_Print.TabIndex = 10;
            // 
            // Panel_Function
            // 
            this.Panel_Function.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Panel_Function.Controls.Add(this.TSDiary);
            this.Panel_Function.Controls.Add(this.button_Clear);
            this.Panel_Function.Controls.Add(this.label1);
            this.Panel_Function.Controls.Add(this.BirthTimePicker);
            this.Panel_Function.Controls.Add(this.Button_Export);
            this.Panel_Function.Controls.Add(this.TextBox_Keyword);
            this.Panel_Function.Controls.Add(this.Label_Keyword);
            this.Panel_Function.Controls.Add(this.Label_Level);
            this.Panel_Function.Controls.Add(this.Button_Delete);
            this.Panel_Function.Controls.Add(this.ComboBox_Type);
            this.Panel_Function.Controls.Add(this.Button_Editor);
            this.Panel_Function.Controls.Add(this.ComboBox_Level);
            this.Panel_Function.Controls.Add(this.Button_Add);
            this.Panel_Function.Controls.Add(this.Label_Type);
            this.Panel_Function.Controls.Add(this.Button_Search);
            this.Panel_Function.Location = new System.Drawing.Point(-4, 263);
            this.Panel_Function.Name = "Panel_Function";
            this.Panel_Function.Size = new System.Drawing.Size(997, 97);
            this.Panel_Function.TabIndex = 9;
            // 
            // TSDiary
            // 
            this.TSDiary.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TSDiary.AutoSize = false;
            this.TSDiary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TSDiary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TSDiary.Dock = System.Windows.Forms.DockStyle.None;
            this.TSDiary.GripMargin = new System.Windows.Forms.Padding(5);
            this.TSDiary.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TSDiary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBFirstPage,
            this.TSBPreviousPage,
            this.TSBNextPage,
            this.TSBLastPage,
            this.TSLAllPageS,
            this.TSLPagesPrint});
            this.TSDiary.Location = new System.Drawing.Point(652, 59);
            this.TSDiary.Name = "TSDiary";
            this.TSDiary.Padding = new System.Windows.Forms.Padding(1, 1, 2, 1);
            this.TSDiary.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TSDiary.ShowItemToolTips = false;
            this.TSDiary.Size = new System.Drawing.Size(326, 26);
            this.TSDiary.Stretch = true;
            this.TSDiary.TabIndex = 15;
            // 
            // TSBFirstPage
            // 
            this.TSBFirstPage.Enabled = false;
            this.TSBFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("TSBFirstPage.Image")));
            this.TSBFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBFirstPage.Name = "TSBFirstPage";
            this.TSBFirstPage.Size = new System.Drawing.Size(52, 21);
            this.TSBFirstPage.Text = "首页";
            this.TSBFirstPage.Click += new System.EventHandler(this.TSBFirstPage_Click);
            // 
            // TSBPreviousPage
            // 
            this.TSBPreviousPage.Enabled = false;
            this.TSBPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("TSBPreviousPage.Image")));
            this.TSBPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBPreviousPage.Name = "TSBPreviousPage";
            this.TSBPreviousPage.Size = new System.Drawing.Size(64, 21);
            this.TSBPreviousPage.Text = "上一页";
            this.TSBPreviousPage.Click += new System.EventHandler(this.TSBPreviousPage_Click);
            // 
            // TSBNextPage
            // 
            this.TSBNextPage.Enabled = false;
            this.TSBNextPage.Image = ((System.Drawing.Image)(resources.GetObject("TSBNextPage.Image")));
            this.TSBNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBNextPage.Name = "TSBNextPage";
            this.TSBNextPage.Size = new System.Drawing.Size(64, 21);
            this.TSBNextPage.Text = "下一页";
            this.TSBNextPage.Click += new System.EventHandler(this.TSBNextPage_Click);
            // 
            // TSBLastPage
            // 
            this.TSBLastPage.Enabled = false;
            this.TSBLastPage.Image = ((System.Drawing.Image)(resources.GetObject("TSBLastPage.Image")));
            this.TSBLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBLastPage.Name = "TSBLastPage";
            this.TSBLastPage.Size = new System.Drawing.Size(52, 21);
            this.TSBLastPage.Text = "末页";
            this.TSBLastPage.Click += new System.EventHandler(this.TSBLastPage_Click);
            // 
            // TSLAllPageS
            // 
            this.TSLAllPageS.Name = "TSLAllPageS";
            this.TSLAllPageS.Size = new System.Drawing.Size(56, 21);
            this.TSLAllPageS.Text = "总页数：";
            // 
            // TSLPagesPrint
            // 
            this.TSLPagesPrint.Name = "TSLPagesPrint";
            this.TSLPagesPrint.Size = new System.Drawing.Size(15, 21);
            this.TSLPagesPrint.Text = "0";
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Clear.Location = new System.Drawing.Point(555, 59);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 26);
            this.button_Clear.TabIndex = 14;
            this.button_Clear.Text = "清空";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(712, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "出生日期：";
            // 
            // BirthTimePicker
            // 
            this.BirthTimePicker.Location = new System.Drawing.Point(790, 20);
            this.BirthTimePicker.Name = "BirthTimePicker";
            this.BirthTimePicker.Size = new System.Drawing.Size(150, 21);
            this.BirthTimePicker.TabIndex = 12;
            // 
            // Button_Export
            // 
            this.Button_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Export.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Button_Export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Export.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Export.Location = new System.Drawing.Point(340, 59);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(75, 26);
            this.Button_Export.TabIndex = 11;
            this.Button_Export.Text = "导出";
            this.Button_Export.UseVisualStyleBackColor = false;
            // 
            // TextBox_Keyword
            // 
            this.TextBox_Keyword.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Keyword.Location = new System.Drawing.Point(524, 20);
            this.TextBox_Keyword.Name = "TextBox_Keyword";
            this.TextBox_Keyword.Size = new System.Drawing.Size(150, 23);
            this.TextBox_Keyword.TabIndex = 10;
            // 
            // Label_Keyword
            // 
            this.Label_Keyword.AutoSize = true;
            this.Label_Keyword.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Keyword.Location = new System.Drawing.Point(462, 22);
            this.Label_Keyword.Name = "Label_Keyword";
            this.Label_Keyword.Size = new System.Drawing.Size(63, 14);
            this.Label_Keyword.TabIndex = 9;
            this.Label_Keyword.Text = "关键字：";
            // 
            // Label_Level
            // 
            this.Label_Level.AutoSize = true;
            this.Label_Level.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Level.Location = new System.Drawing.Point(49, 22);
            this.Label_Level.Name = "Label_Level";
            this.Label_Level.Size = new System.Drawing.Size(49, 14);
            this.Label_Level.TabIndex = 5;
            this.Label_Level.Text = "等级：";
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Button_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Delete.Location = new System.Drawing.Point(447, 59);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(75, 26);
            this.Button_Delete.TabIndex = 4;
            this.Button_Delete.Text = "删除";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // ComboBox_Type
            // 
            this.ComboBox_Type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox_Type.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_Type.FormattingEnabled = true;
            this.ComboBox_Type.Items.AddRange(new object[] {
            "全部查询",
            "姓名",
            "家庭住址",
            "现居住地",
            "现任职公司",
            "曾任职公司",
            "现任职职务",
            "曾任职职务",
            "技能",
            "出生日期",
            "学历",
            "毕业学校",
            "擅长的运动",
            "婚姻状况",
            "配偶姓名",
            "配偶生日",
            "父亲姓名",
            "父亲生日",
            "母亲姓名",
            "母亲生日",
            "兄弟姐妹状况",
            "子女状况",
            "最重要的好朋友",
            "长期的事业目标",
            "短期的事业目标",
            "最偏好的菜式",
            "最喜欢的度假方式",
            "最喜欢参加的运动",
            "喜欢的车子",
            "喜欢的话题",
            "是否参加过培训",
            "喜欢的讲师",
            "是否有看书的习惯",
            "喜欢书的类型",
            "是否常看电影",
            "喜欢的电影类型",
            "喜欢的朋友类型",
            "除父母外，影响最大的三个人",
            "最让自己骄傲的事",
            "备注"});
            this.ComboBox_Type.Location = new System.Drawing.Point(275, 20);
            this.ComboBox_Type.Name = "ComboBox_Type";
            this.ComboBox_Type.Size = new System.Drawing.Size(150, 22);
            this.ComboBox_Type.TabIndex = 8;
            this.ComboBox_Type.Text = "全部查询";
            // 
            // Button_Editor
            // 
            this.Button_Editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Editor.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Button_Editor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Editor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Editor.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Editor.Location = new System.Drawing.Point(234, 59);
            this.Button_Editor.Name = "Button_Editor";
            this.Button_Editor.Size = new System.Drawing.Size(75, 26);
            this.Button_Editor.TabIndex = 3;
            this.Button_Editor.Text = "编辑";
            this.Button_Editor.UseVisualStyleBackColor = false;
            this.Button_Editor.Click += new System.EventHandler(this.Button_Editor_Click);
            // 
            // ComboBox_Level
            // 
            this.ComboBox_Level.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox_Level.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox_Level.FormattingEnabled = true;
            this.ComboBox_Level.Items.AddRange(new object[] {
            "All",
            "A",
            "B"});
            this.ComboBox_Level.Location = new System.Drawing.Point(99, 20);
            this.ComboBox_Level.Name = "ComboBox_Level";
            this.ComboBox_Level.Size = new System.Drawing.Size(80, 22);
            this.ComboBox_Level.TabIndex = 6;
            this.ComboBox_Level.Text = "All";
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Add.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Add.Location = new System.Drawing.Point(129, 59);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 26);
            this.Button_Add.TabIndex = 2;
            this.Button_Add.Text = "添加";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Label_Type
            // 
            this.Label_Type.AutoSize = true;
            this.Label_Type.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Type.Location = new System.Drawing.Point(201, 22);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(77, 14);
            this.Label_Type.TabIndex = 7;
            this.Label_Type.Text = "查询类型：";
            // 
            // Button_Search
            // 
            this.Button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Search.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Button_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Search.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Search.Location = new System.Drawing.Point(25, 59);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(75, 26);
            this.Button_Search.TabIndex = 1;
            this.Button_Search.Text = "查询";
            this.Button_Search.UseVisualStyleBackColor = false;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // Label_Client
            // 
            this.Label_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label_Client.Controls.Add(this.Label_Client_Company);
            this.Label_Client.Controls.Add(this.Label_Client_Address);
            this.Label_Client.Controls.Add(this.Label_Client_Phone);
            this.Label_Client.Controls.Add(this.Label_Client_Name);
            this.Label_Client.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Client.Location = new System.Drawing.Point(1, -8);
            this.Label_Client.Name = "Label_Client";
            this.Label_Client.Size = new System.Drawing.Size(990, 43);
            this.Label_Client.TabIndex = 0;
            this.Label_Client.TabStop = false;
            // 
            // Label_Client_Company
            // 
            this.Label_Client_Company.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Client_Company.Location = new System.Drawing.Point(751, 12);
            this.Label_Client_Company.Name = "Label_Client_Company";
            this.Label_Client_Company.Size = new System.Drawing.Size(100, 23);
            this.Label_Client_Company.TabIndex = 3;
            this.Label_Client_Company.Text = "现任职公司";
            this.Label_Client_Company.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Client_Address
            // 
            this.Label_Client_Address.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Client_Address.Location = new System.Drawing.Point(510, 12);
            this.Label_Client_Address.Name = "Label_Client_Address";
            this.Label_Client_Address.Size = new System.Drawing.Size(100, 23);
            this.Label_Client_Address.TabIndex = 2;
            this.Label_Client_Address.Text = "家庭住址";
            this.Label_Client_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Client_Phone
            // 
            this.Label_Client_Phone.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Client_Phone.Location = new System.Drawing.Point(263, 12);
            this.Label_Client_Phone.Name = "Label_Client_Phone";
            this.Label_Client_Phone.Size = new System.Drawing.Size(100, 23);
            this.Label_Client_Phone.TabIndex = 1;
            this.Label_Client_Phone.Text = "电话号码";
            this.Label_Client_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Client_Name
            // 
            this.Label_Client_Name.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Client_Name.Location = new System.Drawing.Point(10, 12);
            this.Label_Client_Name.Name = "Label_Client_Name";
            this.Label_Client_Name.Size = new System.Drawing.Size(100, 23);
            this.Label_Client_Name.TabIndex = 0;
            this.Label_Client_Name.Text = "姓名";
            this.Label_Client_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Diary_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 457);
            this.Controls.Add(this.Panel_Client_Friend);
            this.Controls.Add(this.Panel_Welcome);
            this.Controls.Add(this.Menu_Panel);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Diary_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diary Systems";
            this.Load += new System.EventHandler(this.Diary_Main_Load);
            this.Menu_Panel.ResumeLayout(false);
            this.Panel_Welcome.ResumeLayout(false);
            this.Panel_Welcome.PerformLayout();
            this.Panel_Client_Friend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Archive_Print)).EndInit();
            this.Panel_Function.ResumeLayout(false);
            this.Panel_Function.PerformLayout();
            this.TSDiary.ResumeLayout(false);
            this.TSDiary.PerformLayout();
            this.Label_Client.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu_Panel;
        private System.Windows.Forms.Button Button_Password;
        private System.Windows.Forms.Button Button_Friend;
        private System.Windows.Forms.Button Button_Diary;
        private System.Windows.Forms.Button Button_Client;
        private System.Windows.Forms.Button Button_Picture;
        private System.Windows.Forms.Button Button_Record;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Timer Timer_Print_Date;
        private System.Windows.Forms.Panel Panel_Welcome;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.Label Label_Welcome;
        private System.Windows.Forms.Panel Panel_Client_Friend;
        private System.Windows.Forms.Panel Panel_Function;
        private System.Windows.Forms.Button Button_Export;
        private System.Windows.Forms.TextBox TextBox_Keyword;
        private System.Windows.Forms.Label Label_Keyword;
        private System.Windows.Forms.Label Label_Level;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.ComboBox ComboBox_Type;
        private System.Windows.Forms.Button Button_Editor;
        private System.Windows.Forms.ComboBox ComboBox_Level;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.GroupBox Label_Client;
        private System.Windows.Forms.Label Label_Client_Company;
        private System.Windows.Forms.Label Label_Client_Address;
        private System.Windows.Forms.Label Label_Client_Phone;
        private System.Windows.Forms.Label Label_Client_Name;
        private System.Windows.Forms.DataGridView dataGridView_Archive_Print;
        private System.Windows.Forms.DateTimePicker BirthTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ToolStrip TSDiary;
        private System.Windows.Forms.ToolStripButton TSBFirstPage;
        private System.Windows.Forms.ToolStripButton TSBPreviousPage;
        private System.Windows.Forms.ToolStripButton TSBNextPage;
        private System.Windows.Forms.ToolStripButton TSBLastPage;
        private System.Windows.Forms.ToolStripLabel TSLAllPageS;
        private System.Windows.Forms.ToolStripLabel TSLPagesPrint;
    }
}