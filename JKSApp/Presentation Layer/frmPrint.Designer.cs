
namespace JKSApp.Presentation_Layer
{
    partial class frmPrint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.btnGradingHistoryPerDojo = new System.Windows.Forms.Button();
            this.pnlDojo = new System.Windows.Forms.Panel();
            this.cbxAffiliation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDojo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAffiliatedPerDojo = new System.Windows.Forms.Button();
            this.btnLicensedToJapan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pd1 = new System.Windows.Forms.PrintDialog();
            this.ppd = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.pnlGradingHistory = new System.Windows.Forms.Panel();
            this.cbxGradingHistoryDojo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDojo.SuspendLayout();
            this.pnlGradingHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(234, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 553);
            this.panel1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(1054, 510);
            this.dgv.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnLast);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnFirst);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1054, 43);
            this.panel3.TabIndex = 39;
            // 
            // btnLast
            // 
            this.btnLast.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Snow;
            this.btnLast.Location = new System.Drawing.Point(902, 0);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 41);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Snow;
            this.btnNext.Location = new System.Drawing.Point(977, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 41);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.Snow;
            this.btnFirst.Location = new System.Drawing.Point(75, 0);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 41);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Snow;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 41);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnMemberList);
            this.panel2.Controls.Add(this.pnlGradingHistory);
            this.panel2.Controls.Add(this.btnGradingHistoryPerDojo);
            this.panel2.Controls.Add(this.pnlDojo);
            this.panel2.Controls.Add(this.btnAffiliatedPerDojo);
            this.panel2.Controls.Add(this.btnLicensedToJapan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 553);
            this.panel2.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Snow;
            this.btnPrint.Location = new System.Drawing.Point(0, 490);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(5);
            this.btnPrint.Size = new System.Drawing.Size(232, 61);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Snow;
            this.button5.Location = new System.Drawing.Point(0, 395);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5);
            this.button5.Size = new System.Drawing.Size(232, 56);
            this.button5.TabIndex = 26;
            this.button5.Text = "Qualification Statuses";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btnMemberList
            // 
            this.btnMemberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMemberList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMemberList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberList.FlatAppearance.BorderSize = 0;
            this.btnMemberList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnMemberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberList.ForeColor = System.Drawing.Color.Snow;
            this.btnMemberList.Location = new System.Drawing.Point(0, 345);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Padding = new System.Windows.Forms.Padding(5);
            this.btnMemberList.Size = new System.Drawing.Size(232, 50);
            this.btnMemberList.TabIndex = 25;
            this.btnMemberList.Text = "Member List";
            this.btnMemberList.UseVisualStyleBackColor = false;
            this.btnMemberList.Click += new System.EventHandler(this.btnMemberList_Click);
            // 
            // btnGradingHistoryPerDojo
            // 
            this.btnGradingHistoryPerDojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGradingHistoryPerDojo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGradingHistoryPerDojo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGradingHistoryPerDojo.FlatAppearance.BorderSize = 0;
            this.btnGradingHistoryPerDojo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnGradingHistoryPerDojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGradingHistoryPerDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradingHistoryPerDojo.ForeColor = System.Drawing.Color.Snow;
            this.btnGradingHistoryPerDojo.Location = new System.Drawing.Point(0, 227);
            this.btnGradingHistoryPerDojo.Name = "btnGradingHistoryPerDojo";
            this.btnGradingHistoryPerDojo.Padding = new System.Windows.Forms.Padding(5);
            this.btnGradingHistoryPerDojo.Size = new System.Drawing.Size(232, 56);
            this.btnGradingHistoryPerDojo.TabIndex = 24;
            this.btnGradingHistoryPerDojo.Text = "Members Grading History Per Dojo";
            this.btnGradingHistoryPerDojo.UseVisualStyleBackColor = false;
            this.btnGradingHistoryPerDojo.Click += new System.EventHandler(this.btnGradingHistoryPerDojo_Click);
            // 
            // pnlDojo
            // 
            this.pnlDojo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDojo.Controls.Add(this.cbxAffiliation);
            this.pnlDojo.Controls.Add(this.label3);
            this.pnlDojo.Controls.Add(this.cbxDojo);
            this.pnlDojo.Controls.Add(this.label2);
            this.pnlDojo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDojo.Location = new System.Drawing.Point(0, 117);
            this.pnlDojo.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDojo.Name = "pnlDojo";
            this.pnlDojo.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDojo.Size = new System.Drawing.Size(232, 110);
            this.pnlDojo.TabIndex = 41;
            this.pnlDojo.Visible = false;
            // 
            // cbxAffiliation
            // 
            this.cbxAffiliation.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxAffiliation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAffiliation.FormattingEnabled = true;
            this.cbxAffiliation.Location = new System.Drawing.Point(5, 73);
            this.cbxAffiliation.Name = "cbxAffiliation";
            this.cbxAffiliation.Size = new System.Drawing.Size(220, 28);
            this.cbxAffiliation.TabIndex = 86;
            this.cbxAffiliation.SelectedIndexChanged += new System.EventHandler(this.cbxAffiliation_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Select Afilliation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxDojo
            // 
            this.cbxDojo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDojo.FormattingEnabled = true;
            this.cbxDojo.Location = new System.Drawing.Point(5, 25);
            this.cbxDojo.Name = "cbxDojo";
            this.cbxDojo.Size = new System.Drawing.Size(220, 28);
            this.cbxDojo.TabIndex = 83;
            this.cbxDojo.SelectedIndexChanged += new System.EventHandler(this.cbxDojo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Select Dojo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAffiliatedPerDojo
            // 
            this.btnAffiliatedPerDojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAffiliatedPerDojo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAffiliatedPerDojo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAffiliatedPerDojo.FlatAppearance.BorderSize = 0;
            this.btnAffiliatedPerDojo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnAffiliatedPerDojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAffiliatedPerDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAffiliatedPerDojo.ForeColor = System.Drawing.Color.Snow;
            this.btnAffiliatedPerDojo.Location = new System.Drawing.Point(0, 61);
            this.btnAffiliatedPerDojo.Name = "btnAffiliatedPerDojo";
            this.btnAffiliatedPerDojo.Padding = new System.Windows.Forms.Padding(5);
            this.btnAffiliatedPerDojo.Size = new System.Drawing.Size(232, 56);
            this.btnAffiliatedPerDojo.TabIndex = 23;
            this.btnAffiliatedPerDojo.Text = "Affiliated Members Per Dojo";
            this.btnAffiliatedPerDojo.UseVisualStyleBackColor = false;
            this.btnAffiliatedPerDojo.Click += new System.EventHandler(this.btnAffiliatedPerDojo_Click_1);
            // 
            // btnLicensedToJapan
            // 
            this.btnLicensedToJapan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLicensedToJapan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLicensedToJapan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLicensedToJapan.FlatAppearance.BorderSize = 0;
            this.btnLicensedToJapan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnLicensedToJapan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicensedToJapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicensedToJapan.ForeColor = System.Drawing.Color.Snow;
            this.btnLicensedToJapan.Location = new System.Drawing.Point(0, 0);
            this.btnLicensedToJapan.Name = "btnLicensedToJapan";
            this.btnLicensedToJapan.Padding = new System.Windows.Forms.Padding(5);
            this.btnLicensedToJapan.Size = new System.Drawing.Size(232, 61);
            this.btnLicensedToJapan.TabIndex = 22;
            this.btnLicensedToJapan.Text = "List of Members Licensed to Japan";
            this.btnLicensedToJapan.UseVisualStyleBackColor = false;
            this.btnLicensedToJapan.Click += new System.EventHandler(this.btnLicensedToJapan_Click_1);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1288, 40);
            this.label1.TabIndex = 40;
            this.label1.Text = "Report Preview";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pd1
            // 
            this.pd1.UseEXDialog = true;
            // 
            // ppd
            // 
            this.ppd.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppd.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppd.ClientSize = new System.Drawing.Size(400, 300);
            this.ppd.Enabled = true;
            this.ppd.Icon = ((System.Drawing.Icon)(resources.GetObject("ppd.Icon")));
            this.ppd.Name = "ppd";
            this.ppd.Visible = false;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // pnlGradingHistory
            // 
            this.pnlGradingHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGradingHistory.Controls.Add(this.cbxGradingHistoryDojo);
            this.pnlGradingHistory.Controls.Add(this.label5);
            this.pnlGradingHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGradingHistory.Location = new System.Drawing.Point(0, 283);
            this.pnlGradingHistory.Margin = new System.Windows.Forms.Padding(10);
            this.pnlGradingHistory.Name = "pnlGradingHistory";
            this.pnlGradingHistory.Padding = new System.Windows.Forms.Padding(5);
            this.pnlGradingHistory.Size = new System.Drawing.Size(232, 62);
            this.pnlGradingHistory.TabIndex = 42;
            this.pnlGradingHistory.Visible = false;
            // 
            // cbxGradingHistoryDojo
            // 
            this.cbxGradingHistoryDojo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxGradingHistoryDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGradingHistoryDojo.FormattingEnabled = true;
            this.cbxGradingHistoryDojo.Location = new System.Drawing.Point(5, 25);
            this.cbxGradingHistoryDojo.Name = "cbxGradingHistoryDojo";
            this.cbxGradingHistoryDojo.Size = new System.Drawing.Size(220, 28);
            this.cbxGradingHistoryDojo.TabIndex = 83;
            this.cbxGradingHistoryDojo.SelectedIndexChanged += new System.EventHandler(this.cbxGradingHistoryDojo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Select Dojo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1288, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlDojo.ResumeLayout(false);
            this.pnlGradingHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnMemberList;
        private System.Windows.Forms.Button btnGradingHistoryPerDojo;
        private System.Windows.Forms.Button btnAffiliatedPerDojo;
        private System.Windows.Forms.Button btnLicensedToJapan;
        private System.Windows.Forms.PrintDialog pd1;
        private System.Windows.Forms.PrintPreviewDialog ppd;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cbxDojo;
        private System.Windows.Forms.Panel pnlDojo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxAffiliation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlGradingHistory;
        private System.Windows.Forms.ComboBox cbxGradingHistoryDojo;
        private System.Windows.Forms.Label label5;
    }
}