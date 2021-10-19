
namespace JKSApp.Presentation_Layer
{
    partial class frmCompetition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompetition));
            this.dgvCompetitions = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteCompetition = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdateComp = new System.Windows.Forms.Button();
            this.btnNewCompetition = new System.Windows.Forms.Button();
            this.btnCompetitorStats = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxSearchCompetitor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchComp = new System.Windows.Forms.Button();
            this.txtSearchComp = new System.Windows.Forms.TextBox();
            this.btnFilterUpcoming = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDisplayAllComp = new System.Windows.Forms.Button();
            this.btnFilterFinished = new System.Windows.Forms.Button();
            this.lblCompetitorName = new System.Windows.Forms.Label();
            this.rtxtStats = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitions)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompetitions
            // 
            this.dgvCompetitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetitions.Location = new System.Drawing.Point(279, 66);
            this.dgvCompetitions.Name = "dgvCompetitions";
            this.dgvCompetitions.Size = new System.Drawing.Size(1040, 498);
            this.dgvCompetitions.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnLast);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnFirst);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Location = new System.Drawing.Point(279, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 33);
            this.panel3.TabIndex = 2;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(964, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(883, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(3, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(84, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.Location = new System.Drawing.Point(1244, 605);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(75, 32);
            this.btnBackToMainMenu.TabIndex = 7;
            this.btnBackToMainMenu.Text = "Back";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtxtStats);
            this.panel1.Controls.Add(this.lblCompetitorName);
            this.panel1.Controls.Add(this.btnDeleteCompetition);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnUpdateComp);
            this.panel1.Controls.Add(this.btnNewCompetition);
            this.panel1.Controls.Add(this.btnCompetitorStats);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 533);
            this.panel1.TabIndex = 1;
            // 
            // btnDeleteCompetition
            // 
            this.btnDeleteCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCompetition.Location = new System.Drawing.Point(11, 496);
            this.btnDeleteCompetition.Name = "btnDeleteCompetition";
            this.btnDeleteCompetition.Size = new System.Drawing.Size(243, 30);
            this.btnDeleteCompetition.TabIndex = 14;
            this.btnDeleteCompetition.Text = "Delete Competition";
            this.btnDeleteCompetition.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "View Competitors for Competition";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateComp
            // 
            this.btnUpdateComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateComp.Location = new System.Drawing.Point(11, 460);
            this.btnUpdateComp.Name = "btnUpdateComp";
            this.btnUpdateComp.Size = new System.Drawing.Size(243, 30);
            this.btnUpdateComp.TabIndex = 12;
            this.btnUpdateComp.Text = "Edit Selected Competition";
            this.btnUpdateComp.UseVisualStyleBackColor = true;
            // 
            // btnNewCompetition
            // 
            this.btnNewCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCompetition.Location = new System.Drawing.Point(11, 424);
            this.btnNewCompetition.Name = "btnNewCompetition";
            this.btnNewCompetition.Size = new System.Drawing.Size(243, 30);
            this.btnNewCompetition.TabIndex = 9;
            this.btnNewCompetition.Text = "Create new Competition";
            this.btnNewCompetition.UseVisualStyleBackColor = true;
            this.btnNewCompetition.Click += new System.EventHandler(this.btnNewCompetition_Click);
            // 
            // btnCompetitorStats
            // 
            this.btnCompetitorStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetitorStats.Location = new System.Drawing.Point(11, 63);
            this.btnCompetitorStats.Name = "btnCompetitorStats";
            this.btnCompetitorStats.Size = new System.Drawing.Size(243, 30);
            this.btnCompetitorStats.TabIndex = 11;
            this.btnCompetitorStats.Text = "View Competitor Stats";
            this.btnCompetitorStats.UseVisualStyleBackColor = true;
            this.btnCompetitorStats.Click += new System.EventHandler(this.btnCompetitorStats_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxSearchCompetitor);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 54);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Competitions for specific Competitor";
            // 
            // cbxSearchCompetitor
            // 
            this.cbxSearchCompetitor.FormattingEnabled = true;
            this.cbxSearchCompetitor.Location = new System.Drawing.Point(6, 25);
            this.cbxSearchCompetitor.Name = "cbxSearchCompetitor";
            this.cbxSearchCompetitor.Size = new System.Drawing.Size(243, 23);
            this.cbxSearchCompetitor.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchComp);
            this.groupBox1.Controls.Add(this.txtSearchComp);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Competition";
            // 
            // btnSearchComp
            // 
            this.btnSearchComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchComp.Location = new System.Drawing.Point(166, 12);
            this.btnSearchComp.Name = "btnSearchComp";
            this.btnSearchComp.Size = new System.Drawing.Size(87, 30);
            this.btnSearchComp.TabIndex = 13;
            this.btnSearchComp.Text = "Search";
            this.btnSearchComp.UseVisualStyleBackColor = true;
            this.btnSearchComp.Click += new System.EventHandler(this.btnSearchComp_Click_1);
            // 
            // txtSearchComp
            // 
            this.txtSearchComp.Location = new System.Drawing.Point(6, 19);
            this.txtSearchComp.Name = "txtSearchComp";
            this.txtSearchComp.Size = new System.Drawing.Size(154, 20);
            this.txtSearchComp.TabIndex = 11;
            // 
            // btnFilterUpcoming
            // 
            this.btnFilterUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterUpcoming.Location = new System.Drawing.Point(378, 12);
            this.btnFilterUpcoming.Name = "btnFilterUpcoming";
            this.btnFilterUpcoming.Size = new System.Drawing.Size(177, 30);
            this.btnFilterUpcoming.TabIndex = 7;
            this.btnFilterUpcoming.Text = "View Upcoming Competitions";
            this.btnFilterUpcoming.UseVisualStyleBackColor = true;
            this.btnFilterUpcoming.Click += new System.EventHandler(this.btnFilterUpcoming_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisplayAllComp);
            this.groupBox2.Controls.Add(this.btnFilterFinished);
            this.groupBox2.Controls.Add(this.btnFilterUpcoming);
            this.groupBox2.Location = new System.Drawing.Point(279, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 48);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // btnDisplayAllComp
            // 
            this.btnDisplayAllComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllComp.Location = new System.Drawing.Point(6, 12);
            this.btnDisplayAllComp.Name = "btnDisplayAllComp";
            this.btnDisplayAllComp.Size = new System.Drawing.Size(183, 30);
            this.btnDisplayAllComp.TabIndex = 12;
            this.btnDisplayAllComp.Text = "Display All Competitions";
            this.btnDisplayAllComp.UseVisualStyleBackColor = true;
            this.btnDisplayAllComp.Click += new System.EventHandler(this.btnDisplayAllComp_Click);
            // 
            // btnFilterFinished
            // 
            this.btnFilterFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterFinished.Location = new System.Drawing.Point(195, 12);
            this.btnFilterFinished.Name = "btnFilterFinished";
            this.btnFilterFinished.Size = new System.Drawing.Size(177, 30);
            this.btnFilterFinished.TabIndex = 8;
            this.btnFilterFinished.Text = "View Finished Competitions";
            this.btnFilterFinished.UseVisualStyleBackColor = true;
            this.btnFilterFinished.Click += new System.EventHandler(this.btnFilterFinished_Click);
            // 
            // lblCompetitorName
            // 
            this.lblCompetitorName.AutoSize = true;
            this.lblCompetitorName.Location = new System.Drawing.Point(113, 96);
            this.lblCompetitorName.Name = "lblCompetitorName";
            this.lblCompetitorName.Size = new System.Drawing.Size(42, 13);
            this.lblCompetitorName.TabIndex = 11;
            this.lblCompetitorName.Text = "\'NAME\'";
            // 
            // rtxtStats
            // 
            this.rtxtStats.Location = new System.Drawing.Point(11, 112);
            this.rtxtStats.Name = "rtxtStats";
            this.rtxtStats.ReadOnly = true;
            this.rtxtStats.Size = new System.Drawing.Size(243, 270);
            this.rtxtStats.TabIndex = 11;
            this.rtxtStats.Text = "";
            // 
            // frmCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCompetitions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompetition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competitions";
            this.Load += new System.EventHandler(this.frmCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetitions)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompetitions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFilterUpcoming;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilterFinished;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateComp;
        private System.Windows.Forms.Button btnNewCompetition;
        private System.Windows.Forms.Button btnCompetitorStats;
        private System.Windows.Forms.Button btnDisplayAllComp;
        private System.Windows.Forms.Button btnDeleteCompetition;
        private System.Windows.Forms.ComboBox cbxSearchCompetitor;
        private System.Windows.Forms.Button btnSearchComp;
        private System.Windows.Forms.TextBox txtSearchComp;
        private System.Windows.Forms.Label lblCompetitorName;
        private System.Windows.Forms.RichTextBox rtxtStats;
    }
}