﻿
namespace JKSApp.Presentation_Layer
{
    partial class frmAffiliation
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
            this.btnDisplayAllAchievement = new System.Windows.Forms.Button();
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
            this.btnDeleteAffiliation = new System.Windows.Forms.Button();
            this.btnUpdateAffiliation = new System.Windows.Forms.Button();
            this.btnNewAffiliation = new System.Windows.Forms.Button();
            this.dgvAffiliation = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffiliation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisplayAllAchievement);
            this.groupBox2.Location = new System.Drawing.Point(273, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 48);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // btnDisplayAllAchievement
            // 
            this.btnDisplayAllAchievement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllAchievement.Location = new System.Drawing.Point(6, 12);
            this.btnDisplayAllAchievement.Name = "btnDisplayAllAchievement";
            this.btnDisplayAllAchievement.Size = new System.Drawing.Size(183, 30);
            this.btnDisplayAllAchievement.TabIndex = 12;
            this.btnDisplayAllAchievement.Text = "Display All Afilliation fees";
            this.btnDisplayAllAchievement.UseVisualStyleBackColor = true;
            this.btnDisplayAllAchievement.Click += new System.EventHandler(this.btnDisplayAllAchievement_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchGrading);
            this.groupBox1.Controls.Add(this.txtSearchGrading);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 48);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Member";
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
            this.btnBackToMainMenu.Location = new System.Drawing.Point(1238, 596);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(75, 32);
            this.btnBackToMainMenu.TabIndex = 44;
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
            this.panel3.Location = new System.Drawing.Point(273, 557);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 33);
            this.panel3.TabIndex = 43;
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
            this.panel1.Controls.Add(this.btnDeleteAffiliation);
            this.panel1.Controls.Add(this.btnUpdateAffiliation);
            this.panel1.Controls.Add(this.btnNewAffiliation);
            this.panel1.Location = new System.Drawing.Point(6, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 533);
            this.panel1.TabIndex = 42;
            // 
            // btnDeleteAffiliation
            // 
            this.btnDeleteAffiliation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAffiliation.Location = new System.Drawing.Point(11, 496);
            this.btnDeleteAffiliation.Name = "btnDeleteAffiliation";
            this.btnDeleteAffiliation.Size = new System.Drawing.Size(243, 30);
            this.btnDeleteAffiliation.TabIndex = 14;
            this.btnDeleteAffiliation.Text = "Delete Fee";
            this.btnDeleteAffiliation.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAffiliation
            // 
            this.btnUpdateAffiliation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAffiliation.Location = new System.Drawing.Point(11, 460);
            this.btnUpdateAffiliation.Name = "btnUpdateAffiliation";
            this.btnUpdateAffiliation.Size = new System.Drawing.Size(243, 30);
            this.btnUpdateAffiliation.TabIndex = 12;
            this.btnUpdateAffiliation.Text = "Edit Selected fee";
            this.btnUpdateAffiliation.UseVisualStyleBackColor = true;
            // 
            // btnNewAffiliation
            // 
            this.btnNewAffiliation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAffiliation.Location = new System.Drawing.Point(11, 424);
            this.btnNewAffiliation.Name = "btnNewAffiliation";
            this.btnNewAffiliation.Size = new System.Drawing.Size(243, 30);
            this.btnNewAffiliation.TabIndex = 9;
            this.btnNewAffiliation.Text = "Add new Payment";
            this.btnNewAffiliation.UseVisualStyleBackColor = true;
            // 
            // dgvAffiliation
            // 
            this.dgvAffiliation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAffiliation.Location = new System.Drawing.Point(273, 57);
            this.dgvAffiliation.Name = "dgvAffiliation";
            this.dgvAffiliation.Size = new System.Drawing.Size(1040, 498);
            this.dgvAffiliation.TabIndex = 41;
            // 
            // frmAffiliation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 631);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAffiliation);
            this.Name = "frmAffiliation";
            this.Text = "frmAffiliation";
            this.Load += new System.EventHandler(this.frmAffiliation_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAffiliation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisplayAllAchievement;
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
        private System.Windows.Forms.Button btnDeleteAffiliation;
        private System.Windows.Forms.Button btnUpdateAffiliation;
        private System.Windows.Forms.Button btnNewAffiliation;
        private System.Windows.Forms.DataGridView dgvAffiliation;
    }
}