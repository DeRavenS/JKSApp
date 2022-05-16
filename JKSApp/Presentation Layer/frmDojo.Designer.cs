
namespace JKSApp.Presentation_Layer
{
    partial class frmDojo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowHideFilters = new System.Windows.Forms.Button();
            this.btnDisplayAllDojo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchComp = new System.Windows.Forms.TextBox();
            this.btnSearchDojo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvMembers = new System.Windows.Forms.ListView();
            this.MemberFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MemberLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompetitorName = new System.Windows.Forms.Label();
            this.dgvDojo = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmsDojo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSort = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmcbxSort = new System.Windows.Forms.ToolStripComboBox();
            this.tsmbtnASC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmbtnDESC = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDojoFilter = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxmaxStudFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxminStudFilter = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cbxActiveFilter = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxCountryFilter = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxProvinceFilter = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbxCityFilter = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxSuburbFilter = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDojo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.cmsDojo.SuspendLayout();
            this.pnlDojoFilter.SuspendLayout();
            this.panel13.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowHideFilters);
            this.groupBox2.Controls.Add(this.btnDisplayAllDojo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.groupBox2.Location = new System.Drawing.Point(10, 625);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 89);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // btnShowHideFilters
            // 
            this.btnShowHideFilters.FlatAppearance.BorderSize = 0;
            this.btnShowHideFilters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnShowHideFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHideFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHideFilters.ForeColor = System.Drawing.Color.Snow;
            this.btnShowHideFilters.Location = new System.Drawing.Point(7, 46);
            this.btnShowHideFilters.Name = "btnShowHideFilters";
            this.btnShowHideFilters.Size = new System.Drawing.Size(241, 30);
            this.btnShowHideFilters.TabIndex = 13;
            this.btnShowHideFilters.Text = "Hide Filters";
            this.btnShowHideFilters.UseVisualStyleBackColor = true;
            this.btnShowHideFilters.Click += new System.EventHandler(this.btnShowHideFilters_Click);
            // 
            // btnDisplayAllDojo
            // 
            this.btnDisplayAllDojo.FlatAppearance.BorderSize = 0;
            this.btnDisplayAllDojo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnDisplayAllDojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAllDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllDojo.ForeColor = System.Drawing.Color.Snow;
            this.btnDisplayAllDojo.Location = new System.Drawing.Point(7, 18);
            this.btnDisplayAllDojo.Name = "btnDisplayAllDojo";
            this.btnDisplayAllDojo.Size = new System.Drawing.Size(241, 30);
            this.btnDisplayAllDojo.TabIndex = 12;
            this.btnDisplayAllDojo.Text = "Display All Dojos";
            this.btnDisplayAllDojo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchComp);
            this.groupBox1.Controls.Add(this.btnSearchDojo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 51);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Dojo";
            // 
            // txtSearchComp
            // 
            this.txtSearchComp.Location = new System.Drawing.Point(7, 19);
            this.txtSearchComp.Name = "txtSearchComp";
            this.txtSearchComp.Size = new System.Drawing.Size(154, 26);
            this.txtSearchComp.TabIndex = 11;
            // 
            // btnSearchDojo
            // 
            this.btnSearchDojo.FlatAppearance.BorderSize = 0;
            this.btnSearchDojo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnSearchDojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDojo.ForeColor = System.Drawing.Color.Snow;
            this.btnSearchDojo.Location = new System.Drawing.Point(166, 17);
            this.btnSearchDojo.Name = "btnSearchDojo";
            this.btnSearchDojo.Size = new System.Drawing.Size(87, 30);
            this.btnSearchDojo.TabIndex = 13;
            this.btnSearchDojo.Text = "Search";
            this.btnSearchDojo.UseVisualStyleBackColor = true;
            this.btnSearchDojo.Click += new System.EventHandler(this.btnSearchDojo_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnLast);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Controls.Add(this.btnFirst);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 663);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 51);
            this.panel3.TabIndex = 13;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Snow;
            this.btnNext.Location = new System.Drawing.Point(715, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 49);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Snow;
            this.btnLast.Location = new System.Drawing.Point(790, 0);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 49);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Snow;
            this.btnPrevious.Location = new System.Drawing.Point(75, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 49);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.Snow;
            this.btnFirst.Location = new System.Drawing.Point(0, 0);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 49);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvMembers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lblCompetitorName);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(270, 724);
            this.panel1.TabIndex = 12;
            // 
            // lvMembers
            // 
            this.lvMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MemberFirstName,
            this.MemberLastName});
            this.lvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMembers.HideSelection = false;
            this.lvMembers.Location = new System.Drawing.Point(10, 110);
            this.lvMembers.Name = "lvMembers";
            this.lvMembers.Size = new System.Drawing.Size(250, 515);
            this.lvMembers.TabIndex = 17;
            this.lvMembers.UseCompatibleStateImageBehavior = false;
            this.lvMembers.View = System.Windows.Forms.View.Details;
            // 
            // MemberFirstName
            // 
            this.MemberFirstName.Text = "First Name";
            this.MemberFirstName.Width = 104;
            // 
            // MemberLastName
            // 
            this.MemberLastName.Text = "LastName";
            this.MemberLastName.Width = 95;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(10, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Current Students";
            // 
            // lblCompetitorName
            // 
            this.lblCompetitorName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompetitorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.lblCompetitorName.Location = new System.Drawing.Point(10, 61);
            this.lblCompetitorName.Name = "lblCompetitorName";
            this.lblCompetitorName.Size = new System.Drawing.Size(250, 33);
            this.lblCompetitorName.TabIndex = 11;
            this.lblCompetitorName.Text = "\'Head Instructor\'";
            this.lblCompetitorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDojo
            // 
            this.dgvDojo.AllowUserToAddRows = false;
            this.dgvDojo.AllowUserToDeleteRows = false;
            this.dgvDojo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDojo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgvDojo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDojo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDojo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDojo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDojo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDojo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDojo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDojo.EnableHeadersVisualStyles = false;
            this.dgvDojo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dgvDojo.Location = new System.Drawing.Point(10, 10);
            this.dgvDojo.Name = "dgvDojo";
            this.dgvDojo.RowHeadersVisible = false;
            this.dgvDojo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDojo.Size = new System.Drawing.Size(867, 653);
            this.dgvDojo.TabIndex = 11;
            this.dgvDojo.SelectionChanged += new System.EventHandler(this.dgvDojo_SelectionChanged);
            this.dgvDojo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvDojo_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(303, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1157, 724);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvDojo);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(270, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(887, 724);
            this.panel5.TabIndex = 19;
            // 
            // cmsDojo
            // 
            this.cmsDojo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSort});
            this.cmsDojo.Name = "cmsAchievement";
            this.cmsDojo.Size = new System.Drawing.Size(96, 26);
            // 
            // tsmSort
            // 
            this.tsmSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmcbxSort,
            this.tsmbtnASC,
            this.tsmbtnDESC});
            this.tsmSort.Name = "tsmSort";
            this.tsmSort.Size = new System.Drawing.Size(95, 22);
            this.tsmSort.Text = "Sort";
            this.tsmSort.Click += new System.EventHandler(this.tsmSort_Click);
            // 
            // tsmcbxSort
            // 
            this.tsmcbxSort.Items.AddRange(new object[] {
            "DojoID",
            "DojoName",
            "DojoStreet",
            "DojoSuburb",
            "DojoCity",
            "DojoProvince",
            "DojoCountry"});
            this.tsmcbxSort.Name = "tsmcbxSort";
            this.tsmcbxSort.Size = new System.Drawing.Size(121, 23);
            // 
            // tsmbtnASC
            // 
            this.tsmbtnASC.Name = "tsmbtnASC";
            this.tsmbtnASC.Size = new System.Drawing.Size(181, 22);
            this.tsmbtnASC.Text = "Assending";
            this.tsmbtnASC.Click += new System.EventHandler(this.tsmbtnASC_Click);
            // 
            // tsmbtnDESC
            // 
            this.tsmbtnDESC.Name = "tsmbtnDESC";
            this.tsmbtnDESC.Size = new System.Drawing.Size(181, 22);
            this.tsmbtnDESC.Text = "Descending";
            this.tsmbtnDESC.Click += new System.EventHandler(this.tsmbtnDESC_Click);
            // 
            // pnlDojoFilter
            // 
            this.pnlDojoFilter.Controls.Add(this.panel13);
            this.pnlDojoFilter.Controls.Add(this.groupBox4);
            this.pnlDojoFilter.Controls.Add(this.label12);
            this.pnlDojoFilter.Controls.Add(this.groupBox3);
            this.pnlDojoFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDojoFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlDojoFilter.Name = "pnlDojoFilter";
            this.pnlDojoFilter.Size = new System.Drawing.Size(303, 724);
            this.pnlDojoFilter.TabIndex = 14;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnApplyFilter);
            this.panel13.Controls.Add(this.btnClearFilter);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 624);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(303, 100);
            this.panel13.TabIndex = 44;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyFilter.ForeColor = System.Drawing.Color.Snow;
            this.btnApplyFilter.Location = new System.Drawing.Point(141, 0);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(162, 100);
            this.btnApplyFilter.TabIndex = 6;
            this.btnApplyFilter.Text = "Apply Filters";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.Snow;
            this.btnClearFilter.Location = new System.Drawing.Point(0, 0);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(141, 100);
            this.btnClearFilter.TabIndex = 5;
            this.btnClearFilter.Text = "Clear Filters";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cbxmaxStudFilter);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cbxminStudFilter);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.cbxActiveFilter);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.groupBox4.Location = new System.Drawing.Point(12, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 135);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(4, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 39);
            this.label3.TabIndex = 50;
            this.label3.Text = "Maximum Students:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxmaxStudFilter
            // 
            this.cbxmaxStudFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxmaxStudFilter.FormattingEnabled = true;
            this.cbxmaxStudFilter.Location = new System.Drawing.Point(99, 90);
            this.cbxmaxStudFilter.Name = "cbxmaxStudFilter";
            this.cbxmaxStudFilter.Size = new System.Drawing.Size(170, 24);
            this.cbxmaxStudFilter.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 42);
            this.label2.TabIndex = 48;
            this.label2.Text = "Minimum Students:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxminStudFilter
            // 
            this.cbxminStudFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxminStudFilter.FormattingEnabled = true;
            this.cbxminStudFilter.Location = new System.Drawing.Point(99, 54);
            this.cbxminStudFilter.Name = "cbxminStudFilter";
            this.cbxminStudFilter.Size = new System.Drawing.Size(170, 24);
            this.cbxminStudFilter.TabIndex = 47;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label25.Location = new System.Drawing.Point(4, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 22);
            this.label25.TabIndex = 46;
            this.label25.Text = "Active:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxActiveFilter
            // 
            this.cbxActiveFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActiveFilter.FormattingEnabled = true;
            this.cbxActiveFilter.Items.AddRange(new object[] {
            "Any",
            "true",
            "false"});
            this.cbxActiveFilter.Location = new System.Drawing.Point(99, 22);
            this.cbxActiveFilter.Name = "cbxActiveFilter";
            this.cbxActiveFilter.Size = new System.Drawing.Size(170, 24);
            this.cbxActiveFilter.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(303, 25);
            this.label12.TabIndex = 40;
            this.label12.Text = "Filters";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxCountryFilter);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.cbxProvinceFilter);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cbxCityFilter);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.cbxSuburbFilter);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.groupBox3.Location = new System.Drawing.Point(12, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 135);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address";
            // 
            // cbxCountryFilter
            // 
            this.cbxCountryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCountryFilter.FormattingEnabled = true;
            this.cbxCountryFilter.Location = new System.Drawing.Point(100, 104);
            this.cbxCountryFilter.Name = "cbxCountryFilter";
            this.cbxCountryFilter.Size = new System.Drawing.Size(170, 24);
            this.cbxCountryFilter.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label20.Location = new System.Drawing.Point(4, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 22);
            this.label20.TabIndex = 37;
            this.label20.Text = "Country:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxProvinceFilter
            // 
            this.cbxProvinceFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProvinceFilter.FormattingEnabled = true;
            this.cbxProvinceFilter.Location = new System.Drawing.Point(100, 77);
            this.cbxProvinceFilter.Name = "cbxProvinceFilter";
            this.cbxProvinceFilter.Size = new System.Drawing.Size(170, 24);
            this.cbxProvinceFilter.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label21.Location = new System.Drawing.Point(7, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 22);
            this.label21.TabIndex = 35;
            this.label21.Text = "Province:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxCityFilter
            // 
            this.cbxCityFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCityFilter.FormattingEnabled = true;
            this.cbxCityFilter.Location = new System.Drawing.Point(99, 50);
            this.cbxCityFilter.Name = "cbxCityFilter";
            this.cbxCityFilter.Size = new System.Drawing.Size(170, 24);
            this.cbxCityFilter.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label18.Location = new System.Drawing.Point(4, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 22);
            this.label18.TabIndex = 33;
            this.label18.Text = "City:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxSuburbFilter
            // 
            this.cbxSuburbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSuburbFilter.FormattingEnabled = true;
            this.cbxSuburbFilter.Location = new System.Drawing.Point(99, 23);
            this.cbxSuburbFilter.Name = "cbxSuburbFilter";
            this.cbxSuburbFilter.Size = new System.Drawing.Size(170, 24);
            this.cbxSuburbFilter.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label19.Location = new System.Drawing.Point(7, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 22);
            this.label19.TabIndex = 31;
            this.label19.Text = "Suburb:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1460, 724);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlDojoFilter);
            this.Name = "frmDojo";
            this.Text = "frmDojo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDojo_FormClosed);
            this.Load += new System.EventHandler(this.frmDojo_Load);
            this.EnabledChanged += new System.EventHandler(this.frmDojo_EnabledChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDojo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.cmsDojo.ResumeLayout(false);
            this.pnlDojoFilter.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisplayAllDojo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchDojo;
        private System.Windows.Forms.TextBox txtSearchComp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCompetitorName;
        private System.Windows.Forms.DataGridView dgvDojo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvMembers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ColumnHeader MemberFirstName;
        private System.Windows.Forms.ColumnHeader MemberLastName;
        private System.Windows.Forms.ContextMenuStrip cmsDojo;
        private System.Windows.Forms.ToolStripMenuItem tsmSort;
        private System.Windows.Forms.ToolStripComboBox tsmcbxSort;
        private System.Windows.Forms.ToolStripMenuItem tsmbtnASC;
        private System.Windows.Forms.ToolStripMenuItem tsmbtnDESC;
        private System.Windows.Forms.Button btnShowHideFilters;
        private System.Windows.Forms.Panel pnlDojoFilter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxCountryFilter;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbxProvinceFilter;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbxCityFilter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxSuburbFilter;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxmaxStudFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxminStudFilter;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbxActiveFilter;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnClearFilter;
    }
}