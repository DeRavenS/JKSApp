
namespace JKSApp.Presentation_Layer
{
    partial class frmMember
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
            this.btnFilterDojo = new System.Windows.Forms.Button();
            this.btnDisplayAllMember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAffiliationFees = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteDojo = new System.Windows.Forms.Button();
            this.btnUpdateDojo = new System.Windows.Forms.Button();
            this.btnNewDojo = new System.Windows.Forms.Button();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFilterDojo);
            this.groupBox2.Controls.Add(this.btnDisplayAllMember);
            this.groupBox2.Location = new System.Drawing.Point(273, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 48);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // btnFilterDojo
            // 
            this.btnFilterDojo.Location = new System.Drawing.Point(195, 12);
            this.btnFilterDojo.Name = "btnFilterDojo";
            this.btnFilterDojo.Size = new System.Drawing.Size(130, 28);
            this.btnFilterDojo.TabIndex = 13;
            this.btnFilterDojo.Text = "Filter By Dojo";
            this.btnFilterDojo.UseVisualStyleBackColor = true;
            // 
            // btnDisplayAllMember
            // 
            this.btnDisplayAllMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllMember.Location = new System.Drawing.Point(6, 12);
            this.btnDisplayAllMember.Name = "btnDisplayAllMember";
            this.btnDisplayAllMember.Size = new System.Drawing.Size(183, 30);
            this.btnDisplayAllMember.TabIndex = 12;
            this.btnDisplayAllMember.Text = "Display All Members";
            this.btnDisplayAllMember.UseVisualStyleBackColor = true;
            this.btnDisplayAllMember.Click += new System.EventHandler(this.btnDisplayAllMember_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchMember);
            this.groupBox1.Controls.Add(this.txtSearchMember);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 48);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Member";
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.Location = new System.Drawing.Point(166, 12);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(87, 30);
            this.btnSearchMember.TabIndex = 13;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Location = new System.Drawing.Point(6, 19);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(154, 20);
            this.txtSearchMember.TabIndex = 11;
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.Location = new System.Drawing.Point(1238, 605);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(75, 32);
            this.btnBackToMainMenu.TabIndex = 20;
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
            this.panel3.Location = new System.Drawing.Point(273, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 33);
            this.panel3.TabIndex = 19;
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAffiliationFees);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDeleteDojo);
            this.panel1.Controls.Add(this.btnUpdateDojo);
            this.panel1.Controls.Add(this.btnNewDojo);
            this.panel1.Location = new System.Drawing.Point(6, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 533);
            this.panel1.TabIndex = 18;
            // 
            // btnAffiliationFees
            // 
            this.btnAffiliationFees.Location = new System.Drawing.Point(11, 364);
            this.btnAffiliationFees.Name = "btnAffiliationFees";
            this.btnAffiliationFees.Size = new System.Drawing.Size(106, 42);
            this.btnAffiliationFees.TabIndex = 23;
            this.btnAffiliationFees.Text = "View Member\'s Affiliation Fees";
            this.btnAffiliationFees.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dojo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Member Details";
            // 
            // btnDeleteDojo
            // 
            this.btnDeleteDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDojo.Location = new System.Drawing.Point(11, 496);
            this.btnDeleteDojo.Name = "btnDeleteDojo";
            this.btnDeleteDojo.Size = new System.Drawing.Size(243, 30);
            this.btnDeleteDojo.TabIndex = 14;
            this.btnDeleteDojo.Text = "Delete Member";
            this.btnDeleteDojo.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDojo
            // 
            this.btnUpdateDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDojo.Location = new System.Drawing.Point(11, 460);
            this.btnUpdateDojo.Name = "btnUpdateDojo";
            this.btnUpdateDojo.Size = new System.Drawing.Size(243, 30);
            this.btnUpdateDojo.TabIndex = 12;
            this.btnUpdateDojo.Text = "Edit Selected Member";
            this.btnUpdateDojo.UseVisualStyleBackColor = true;
            // 
            // btnNewDojo
            // 
            this.btnNewDojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDojo.Location = new System.Drawing.Point(11, 424);
            this.btnNewDojo.Name = "btnNewDojo";
            this.btnNewDojo.Size = new System.Drawing.Size(243, 30);
            this.btnNewDojo.TabIndex = 9;
            this.btnNewDojo.Text = "Add new Member";
            this.btnNewDojo.UseVisualStyleBackColor = true;
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(273, 66);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.Size = new System.Drawing.Size(1040, 498);
            this.dgvMember.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Qualifications";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Belt";
            // 
            // frmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMember);
            this.Name = "frmMember";
            this.Text = "frmMember";
            this.Load += new System.EventHandler(this.frmMember_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisplayAllMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteDojo;
        private System.Windows.Forms.Button btnUpdateDojo;
        private System.Windows.Forms.Button btnNewDojo;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Button btnFilterDojo;
        private System.Windows.Forms.Button btnAffiliationFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}