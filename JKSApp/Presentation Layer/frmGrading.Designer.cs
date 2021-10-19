
namespace JKSApp.Presentation_Layer
{
    partial class frmGrading
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
            this.btnDisplayAllGrading = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchGrading = new System.Windows.Forms.Button();
            this.txtSearchGrading = new System.Windows.Forms.TextBox();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvMembers = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteGrading = new System.Windows.Forms.Button();
            this.btnUpdateGrading = new System.Windows.Forms.Button();
            this.btnNewGrading = new System.Windows.Forms.Button();
            this.dgvGrading = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrading)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisplayAllGrading);
            this.groupBox2.Location = new System.Drawing.Point(273, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 48);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // btnDisplayAllGrading
            // 
            this.btnDisplayAllGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllGrading.Location = new System.Drawing.Point(6, 12);
            this.btnDisplayAllGrading.Name = "btnDisplayAllGrading";
            this.btnDisplayAllGrading.Size = new System.Drawing.Size(183, 30);
            this.btnDisplayAllGrading.TabIndex = 12;
            this.btnDisplayAllGrading.Text = "Display All Gradings";
            this.btnDisplayAllGrading.UseVisualStyleBackColor = true;
            this.btnDisplayAllGrading.Click += new System.EventHandler(this.btnDisplayAllGrading_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchGrading);
            this.groupBox1.Controls.Add(this.txtSearchGrading);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 48);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Grading";
            // 
            // btnSearchGrading
            // 
            this.btnSearchGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGrading.Location = new System.Drawing.Point(166, 12);
            this.btnSearchGrading.Name = "btnSearchGrading";
            this.btnSearchGrading.Size = new System.Drawing.Size(87, 30);
            this.btnSearchGrading.TabIndex = 13;
            this.btnSearchGrading.Text = "Search";
            this.btnSearchGrading.UseVisualStyleBackColor = true;
            // 
            // txtSearchGrading
            // 
            this.txtSearchGrading.Location = new System.Drawing.Point(6, 19);
            this.txtSearchGrading.Name = "txtSearchGrading";
            this.txtSearchGrading.Size = new System.Drawing.Size(154, 20);
            this.txtSearchGrading.TabIndex = 11;
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.Location = new System.Drawing.Point(1238, 605);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(75, 32);
            this.btnBackToMainMenu.TabIndex = 32;
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
            this.panel3.TabIndex = 31;
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
            this.panel1.Controls.Add(this.lvMembers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDeleteGrading);
            this.panel1.Controls.Add(this.btnUpdateGrading);
            this.panel1.Controls.Add(this.btnNewGrading);
            this.panel1.Location = new System.Drawing.Point(6, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 533);
            this.panel1.TabIndex = 30;
            // 
            // lvMembers
            // 
            this.lvMembers.HideSelection = false;
            this.lvMembers.Location = new System.Drawing.Point(11, 33);
            this.lvMembers.Name = "lvMembers";
            this.lvMembers.Size = new System.Drawing.Size(247, 331);
            this.lvMembers.TabIndex = 29;
            this.lvMembers.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Members Participated";
            // 
            // btnDeleteGrading
            // 
            this.btnDeleteGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGrading.Location = new System.Drawing.Point(11, 496);
            this.btnDeleteGrading.Name = "btnDeleteGrading";
            this.btnDeleteGrading.Size = new System.Drawing.Size(243, 30);
            this.btnDeleteGrading.TabIndex = 14;
            this.btnDeleteGrading.Text = "Delete Grading";
            this.btnDeleteGrading.UseVisualStyleBackColor = true;
            // 
            // btnUpdateGrading
            // 
            this.btnUpdateGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGrading.Location = new System.Drawing.Point(11, 460);
            this.btnUpdateGrading.Name = "btnUpdateGrading";
            this.btnUpdateGrading.Size = new System.Drawing.Size(243, 30);
            this.btnUpdateGrading.TabIndex = 12;
            this.btnUpdateGrading.Text = "Edit Selected Grading";
            this.btnUpdateGrading.UseVisualStyleBackColor = true;
            // 
            // btnNewGrading
            // 
            this.btnNewGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGrading.Location = new System.Drawing.Point(11, 424);
            this.btnNewGrading.Name = "btnNewGrading";
            this.btnNewGrading.Size = new System.Drawing.Size(243, 30);
            this.btnNewGrading.TabIndex = 9;
            this.btnNewGrading.Text = "Add new Grading";
            this.btnNewGrading.UseVisualStyleBackColor = true;
            // 
            // dgvGrading
            // 
            this.dgvGrading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrading.Location = new System.Drawing.Point(273, 66);
            this.dgvGrading.Name = "dgvGrading";
            this.dgvGrading.Size = new System.Drawing.Size(1040, 498);
            this.dgvGrading.TabIndex = 29;
            // 
            // frmGrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 643);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvGrading);
            this.Name = "frmGrading";
            this.Text = "frmGrading";
            this.Load += new System.EventHandler(this.frmGrading_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisplayAllGrading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchGrading;
        private System.Windows.Forms.TextBox txtSearchGrading;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteGrading;
        private System.Windows.Forms.Button btnUpdateGrading;
        private System.Windows.Forms.Button btnNewGrading;
        private System.Windows.Forms.DataGridView dgvGrading;
    }
}