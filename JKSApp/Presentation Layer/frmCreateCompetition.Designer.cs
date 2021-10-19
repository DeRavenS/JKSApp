
namespace JKSApp.Presentation_Layer
{
    partial class frmCreateCompetition
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
            this.gbxCompCreateDetails = new System.Windows.Forms.GroupBox();
            this.btnCreateComp = new System.Windows.Forms.Button();
            this.dtComp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCompName = new System.Windows.Forms.Label();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxCompCreateDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCompCreateDetails
            // 
            this.gbxCompCreateDetails.Controls.Add(this.btnBack);
            this.gbxCompCreateDetails.Controls.Add(this.btnCreateComp);
            this.gbxCompCreateDetails.Controls.Add(this.dtComp);
            this.gbxCompCreateDetails.Controls.Add(this.label1);
            this.gbxCompCreateDetails.Controls.Add(this.lblCompName);
            this.gbxCompCreateDetails.Controls.Add(this.txtCompName);
            this.gbxCompCreateDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCompCreateDetails.Location = new System.Drawing.Point(12, 12);
            this.gbxCompCreateDetails.Name = "gbxCompCreateDetails";
            this.gbxCompCreateDetails.Size = new System.Drawing.Size(262, 426);
            this.gbxCompCreateDetails.TabIndex = 0;
            this.gbxCompCreateDetails.TabStop = false;
            this.gbxCompCreateDetails.Text = "Enter Competition Details";
            // 
            // btnCreateComp
            // 
            this.btnCreateComp.Location = new System.Drawing.Point(22, 397);
            this.btnCreateComp.Name = "btnCreateComp";
            this.btnCreateComp.Size = new System.Drawing.Size(90, 23);
            this.btnCreateComp.TabIndex = 6;
            this.btnCreateComp.Text = "Create Competition";
            this.btnCreateComp.UseVisualStyleBackColor = true;
            this.btnCreateComp.Click += new System.EventHandler(this.btnCreateComp_Click);
            // 
            // dtComp
            // 
            this.dtComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtComp.Location = new System.Drawing.Point(22, 127);
            this.dtComp.Name = "dtComp";
            this.dtComp.Size = new System.Drawing.Size(234, 21);
            this.dtComp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Competition Date:";
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Location = new System.Drawing.Point(19, 47);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(122, 16);
            this.lblCompName.TabIndex = 2;
            this.lblCompName.Text = "Competition Name:";
            // 
            // txtCompName
            // 
            this.txtCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompName.Location = new System.Drawing.Point(22, 66);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(234, 20);
            this.txtCompName.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(166, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCreateCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 450);
            this.Controls.Add(this.gbxCompCreateDetails);
            this.Name = "frmCreateCompetition";
            this.Text = "frmCreateCompetition";
            this.Load += new System.EventHandler(this.frmCreateCompetition_Load);
            this.gbxCompCreateDetails.ResumeLayout(false);
            this.gbxCompCreateDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCompCreateDetails;
        private System.Windows.Forms.DateTimePicker dtComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.Button btnCreateComp;
        private System.Windows.Forms.Button btnBack;
    }
}