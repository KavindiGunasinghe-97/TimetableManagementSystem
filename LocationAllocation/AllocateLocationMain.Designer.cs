namespace Time_Table_Management_System.LocationAllocation
{
    partial class AllocateLocationMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.viewConsecRoom = new System.Windows.Forms.Button();
            this.addConsecRoom = new System.Windows.Forms.Button();
            this.comboBoxloc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewSessions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.con1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.con2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewN = new System.Windows.Forms.Button();
            this.btnAddN = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridViewSessionRoom = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lec1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lec2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessionRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(2, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 20);
            this.button2.TabIndex = 16;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(61, 20);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(163, 26);
            this.title.TabIndex = 19;
            this.title.Text = "Add Locations";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl.Location = new System.Drawing.Point(22, 60);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(641, 278);
            this.tabControl.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSessionRoom);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.btnAddRoom);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(633, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sessions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 26;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.viewConsecRoom);
            this.tabPage2.Controls.Add(this.addConsecRoom);
            this.tabPage2.Controls.Add(this.comboBoxloc);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridViewSessions);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(633, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consecutive";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // viewConsecRoom
            // 
            this.viewConsecRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewConsecRoom.BackColor = System.Drawing.Color.DarkOrange;
            this.viewConsecRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewConsecRoom.ForeColor = System.Drawing.SystemColors.Info;
            this.viewConsecRoom.Location = new System.Drawing.Point(471, 193);
            this.viewConsecRoom.Margin = new System.Windows.Forms.Padding(2);
            this.viewConsecRoom.Name = "viewConsecRoom";
            this.viewConsecRoom.Size = new System.Drawing.Size(90, 32);
            this.viewConsecRoom.TabIndex = 43;
            this.viewConsecRoom.Text = "View";
            this.viewConsecRoom.UseVisualStyleBackColor = false;
            // 
            // addConsecRoom
            // 
            this.addConsecRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addConsecRoom.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addConsecRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addConsecRoom.ForeColor = System.Drawing.SystemColors.Info;
            this.addConsecRoom.Location = new System.Drawing.Point(377, 194);
            this.addConsecRoom.Margin = new System.Windows.Forms.Padding(2);
            this.addConsecRoom.Name = "addConsecRoom";
            this.addConsecRoom.Size = new System.Drawing.Size(90, 32);
            this.addConsecRoom.TabIndex = 42;
            this.addConsecRoom.Text = "Add Room";
            this.addConsecRoom.UseVisualStyleBackColor = false;
            // 
            // comboBoxloc
            // 
            this.comboBoxloc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxloc.FormattingEnabled = true;
            this.comboBoxloc.Location = new System.Drawing.Point(182, 197);
            this.comboBoxloc.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxloc.Name = "comboBoxloc";
            this.comboBoxloc.Size = new System.Drawing.Size(156, 28);
            this.comboBoxloc.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(70, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "Select Room";
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.AllowUserToAddRows = false;
            this.dataGridViewSessions.AllowUserToDeleteRows = false;
            this.dataGridViewSessions.AllowUserToResizeColumns = false;
            this.dataGridViewSessions.AllowUserToResizeRows = false;
            this.dataGridViewSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSessions.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.con1,
            this.con2});
            this.dataGridViewSessions.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewSessions.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSessions.MultiSelect = false;
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.ReadOnly = true;
            this.dataGridViewSessions.RowHeadersVisible = false;
            this.dataGridViewSessions.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSessions.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSessions.RowTemplate.Height = 24;
            this.dataGridViewSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSessions.Size = new System.Drawing.Size(631, 171);
            this.dataGridViewSessions.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "                      ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // con1
            // 
            this.con1.HeaderText = "Consecutive Session 1 ID";
            this.con1.MinimumWidth = 6;
            this.con1.Name = "con1";
            this.con1.ReadOnly = true;
            this.con1.Width = 225;
            // 
            // con2
            // 
            this.con2.HeaderText = "Consecutive Session 2 ID";
            this.con2.MinimumWidth = 6;
            this.con2.Name = "con2";
            this.con2.ReadOnly = true;
            this.con2.Width = 225;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtRoom);
            this.tabPage3.Controls.Add(this.txtEndTime);
            this.tabPage3.Controls.Add(this.txtStartTime);
            this.tabPage3.Controls.Add(this.comboBoxDay);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnViewN);
            this.tabPage3.Controls.Add(this.btnAddN);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(633, 246);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Not Available Times";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.Location = new System.Drawing.Point(394, 37);
            this.txtStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(123, 26);
            this.txtStartTime.TabIndex = 47;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBoxDay.Location = new System.Drawing.Point(155, 118);
            this.comboBoxDay.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(123, 28);
            this.comboBoxDay.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(305, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 29);
            this.label7.TabIndex = 44;
            this.label7.Text = "End Time";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(305, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 43;
            this.label6.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(43, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 42;
            this.label5.Text = "Select Day";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(43, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 41;
            this.label4.Text = "Select Room";
            // 
            // btnViewN
            // 
            this.btnViewN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewN.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewN.ForeColor = System.Drawing.SystemColors.Info;
            this.btnViewN.Location = new System.Drawing.Point(310, 206);
            this.btnViewN.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewN.Name = "btnViewN";
            this.btnViewN.Size = new System.Drawing.Size(90, 32);
            this.btnViewN.TabIndex = 29;
            this.btnViewN.Text = "Clear";
            this.btnViewN.UseVisualStyleBackColor = false;
            // 
            // btnAddN
            // 
            this.btnAddN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddN.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddN.Location = new System.Drawing.Point(188, 206);
            this.btnAddN.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddN.Name = "btnAddN";
            this.btnAddN.Size = new System.Drawing.Size(90, 32);
            this.btnAddN.TabIndex = 28;
            this.btnAddN.Text = "Add Session";
            this.btnAddN.UseVisualStyleBackColor = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(633, 246);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tags";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoom.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddRoom.Location = new System.Drawing.Point(151, 176);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(120, 44);
            this.btnAddRoom.TabIndex = 36;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRefresh.Location = new System.Drawing.Point(375, 176);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 44);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(633, 246);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Lecturers";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(633, 246);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Subjects";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSessionRoom
            // 
            this.dataGridViewSessionRoom.AllowUserToAddRows = false;
            this.dataGridViewSessionRoom.AllowUserToDeleteRows = false;
            this.dataGridViewSessionRoom.AllowUserToResizeColumns = false;
            this.dataGridViewSessionRoom.AllowUserToResizeRows = false;
            this.dataGridViewSessionRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSessionRoom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSessionRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSessionRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessionRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.lec1,
            this.lec2,
            this.subject_code,
            this.subject_name,
            this.group_id,
            this.tag,
            this.room});
            this.dataGridViewSessionRoom.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewSessionRoom.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSessionRoom.MultiSelect = false;
            this.dataGridViewSessionRoom.Name = "dataGridViewSessionRoom";
            this.dataGridViewSessionRoom.ReadOnly = true;
            this.dataGridViewSessionRoom.RowHeadersVisible = false;
            this.dataGridViewSessionRoom.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSessionRoom.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSessionRoom.RowTemplate.Height = 24;
            this.dataGridViewSessionRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSessionRoom.Size = new System.Drawing.Size(631, 130);
            this.dataGridViewSessionRoom.TabIndex = 41;
            this.dataGridViewSessionRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // lec1
            // 
            this.lec1.HeaderText = "Lecturer 1";
            this.lec1.MinimumWidth = 6;
            this.lec1.Name = "lec1";
            this.lec1.ReadOnly = true;
            this.lec1.Width = 150;
            // 
            // lec2
            // 
            this.lec2.HeaderText = "Lecturer 2";
            this.lec2.MinimumWidth = 6;
            this.lec2.Name = "lec2";
            this.lec2.ReadOnly = true;
            this.lec2.Width = 150;
            // 
            // subject_code
            // 
            this.subject_code.HeaderText = "Subject Code";
            this.subject_code.MinimumWidth = 6;
            this.subject_code.Name = "subject_code";
            this.subject_code.ReadOnly = true;
            this.subject_code.Width = 80;
            // 
            // subject_name
            // 
            this.subject_name.HeaderText = "Subject Name";
            this.subject_name.MinimumWidth = 6;
            this.subject_name.Name = "subject_name";
            this.subject_name.ReadOnly = true;
            this.subject_name.Width = 80;
            // 
            // group_id
            // 
            this.group_id.HeaderText = "Group ID";
            this.group_id.MinimumWidth = 6;
            this.group_id.Name = "group_id";
            this.group_id.ReadOnly = true;
            this.group_id.Width = 115;
            // 
            // tag
            // 
            this.tag.HeaderText = "Tag";
            this.tag.MinimumWidth = 6;
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            this.tag.Width = 70;
            // 
            // room
            // 
            this.room.HeaderText = "Room";
            this.room.Name = "room";
            this.room.ReadOnly = true;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndTime.Location = new System.Drawing.Point(394, 123);
            this.txtEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(123, 26);
            this.txtEndTime.TabIndex = 48;
            // 
            // txtRoom
            // 
            this.txtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoom.Location = new System.Drawing.Point(155, 37);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(123, 26);
            this.txtRoom.TabIndex = 49;
            // 
            // AllocateLocationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(661, 359);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button2);
            this.Name = "AllocateLocationMain";
            this.Text = "AllocateLocationMain";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessionRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnViewN;
        private System.Windows.Forms.Button btnAddN;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn con1;
        private System.Windows.Forms.DataGridViewTextBoxColumn con2;
        private System.Windows.Forms.Button viewConsecRoom;
        private System.Windows.Forms.Button addConsecRoom;
        private System.Windows.Forms.ComboBox comboBoxloc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridViewSessionRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtEndTime;
    }
}