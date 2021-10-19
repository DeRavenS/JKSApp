
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDisplayAllDojo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchDojo = new System.Windows.Forms.Button();
            this.txtSearchComp = new System.Windows.Forms.TextBox();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCompetitorName = new System.Windows.Forms.Label();
            this.btnDeleteDojo = new System.Windows.Forms.Button();
            this.btnUpdateDojo = new System.Windows.Forms.Button();
            this.btnNewDojo = new System.Windows.Forms.Button();
            this.dgvDojo = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDojo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisplayAllDojo);
            this.groupBox2.Location = new System.Drawing.Point(272, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 48);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // btnDisplayAllDojo
            // 
            this.btnDisplayAllDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllDojo.Location = new System.Drawing.Point(6, 12);
            this.btnDisplayAllDojo.Name = "btnDisplayAllDojo";
            this.btnDisplayAllDojo.Size = new System.Drawing.Size(183, 30);
            this.btnDisplayAllDojo.TabIndex = 12;
            this.btnDisplayAllDojo.Text = "Display All Dojos";
            this.btnDisplayAllDojo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchDojo);
            this.groupBox1.Controls.Add(this.txtSearchComp);
            this.groupBox1.Location = new System.Drawing.Point(11, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 48);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Dojo";
            // 
            // btnSearchDojo
            // 
            this.btnSearchDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDojo.Location = new System.Drawing.Point(166, 12);
            this.btnSearchDojo.Name = "btnSearchDojo";
            this.btnSearchDojo.Size = new System.Drawing.Size(87, 30);
            this.btnSearchDojo.TabIndex = 13;
            this.btnSearchDojo.Text = "Search";
            this.btnSearchDojo.UseVisualStyleBackColor = true;
            this.btnSearchDojo.Click += new System.EventHandler(this.btnSearchDojo_Click);
            // 
            // txtSearchComp
            // 
            this.txtSearchComp.Location = new System.Drawing.Point(6, 19);
            this.txtSearchComp.Name = "txtSearchComp";
            this.txtSearchComp.Size = new System.Drawing.Size(154, 20);
            this.txtSearchComp.TabIndex = 11;
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.Location = new System.Drawing.Point(1237, 598);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(75, 32);
            this.btnBackToMainMenu.TabIndex = 14;
            this.btnBackToMainMenu.Text = "Back";
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnLast);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnFirst);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Location = new System.Drawing.Point(272, 559);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 33);
            this.panel3.TabIndex = 13;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(964, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(883, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.lblCompetitorName);
            this.panel1.Controls.Add(this.btnDeleteDojo);
            this.panel1.Controls.Add(this.btnUpdateDojo);
            this.panel1.Controls.Add(this.btnNewDojo);
            this.panel1.Location = new System.Drawing.Point(5, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 533);
            this.panel1.TabIndex = 12;
            // 
            // lblCompetitorName
            // 
            this.lblCompetitorName.AutoSize = true;
            this.lblCompetitorName.Location = new System.Drawing.Point(81, 0);
            this.lblCompetitorName.Name = "lblCompetitorName";
            this.lblCompetitorName.Size = new System.Drawing.Size(84, 13);
            this.lblCompetitorName.TabIndex = 11;
            this.lblCompetitorName.Text = "\'Head Instructor\'";
            // 
            // btnDeleteDojo
            // 
            this.btnDeleteDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDojo.Location = new System.Drawing.Point(11, 496);
            this.btnDeleteDojo.Name = "btnDeleteDojo";
            this.btnDeleteDojo.Size = new System.Drawing.Size(243, 30);
            this.btnDeleteDojo.TabIndex = 14;
            this.btnDeleteDojo.Text = "Delete Dojo";
            this.btnDeleteDojo.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDojo
            // 
            this.btnUpdateDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDojo.Location = new System.Drawing.Point(11, 460);
            this.btnUpdateDojo.Name = "btnUpdateDojo";
            this.btnUpdateDojo.Size = new System.Drawing.Size(243, 30);
            this.btnUpdateDojo.TabIndex = 12;
            this.btnUpdateDojo.Text = "Edit Selected Dojo";
            this.btnUpdateDojo.UseVisualStyleBackColor = true;
            // 
            // btnNewDojo
            // 
            this.btnNewDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDojo.Location = new System.Drawing.Point(11, 424);
            this.btnNewDojo.Name = "btnNewDojo";
            this.btnNewDojo.Size = new System.Drawing.Size(243, 30);
            this.btnNewDojo.TabIndex = 9;
            this.btnNewDojo.Text = "Create new Dojo";
            this.btnNewDojo.UseVisualStyleBackColor = true;
            this.btnNewDojo.EnabledChanged += new System.EventHandler(this.btnNewDojo_EnabledChanged);
            this.btnNewDojo.Click += new System.EventHandler(this.btnNewDojo_Click);
            // 
            // dgvDojo
            // 
            this.dgvDojo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDojo.Location = new System.Drawing.Point(272, 59);
            this.dgvDojo.Name = "dgvDojo";
            this.dgvDojo.Size = new System.Drawing.Size(1040, 498);
            this.dgvDojo.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(243, 310);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Current Students";
            // 
            // frmDojo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDojo);
            this.Name = "frmDojo";
            this.Text = "frmDojo";
            this.Load += new System.EventHandler(this.frmDojo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDojo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisplayAllDojo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchDojo;
        private System.Windows.Forms.TextBox txtSearchComp;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCompetitorName;
        private System.Windows.Forms.Button btnDeleteDojo;
        private System.Windows.Forms.Button btnUpdateDojo;
        private System.Windows.Forms.Button btnNewDojo;
        private System.Windows.Forms.DataGridView dgvDojo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}