
namespace JKSApp.Presentation_Layer
{
    partial class frmCreateCategory
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAchievementName = new System.Windows.Forms.TextBox();
            this.lblCompName = new System.Windows.Forms.Label();
            this.cbxMaxAge = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxMinAge = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Snow;
            this.btnConfirm.Location = new System.Drawing.Point(0, 156);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(251, 51);
            this.btnConfirm.TabIndex = 37;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Snow;
            this.btnCancel.Location = new System.Drawing.Point(0, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(251, 51);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAchievementName
            // 
            this.txtAchievementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAchievementName.Location = new System.Drawing.Point(28, 35);
            this.txtAchievementName.Name = "txtAchievementName";
            this.txtAchievementName.Size = new System.Drawing.Size(200, 26);
            this.txtAchievementName.TabIndex = 35;
            // 
            // lblCompName
            // 
            this.lblCompName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.lblCompName.Location = new System.Drawing.Point(0, 0);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(251, 46);
            this.lblCompName.TabIndex = 36;
            this.lblCompName.Text = "Category Name:";
            this.lblCompName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxMaxAge
            // 
            this.cbxMaxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaxAge.FormattingEnabled = true;
            this.cbxMaxAge.Location = new System.Drawing.Point(118, 91);
            this.cbxMaxAge.Name = "cbxMaxAge";
            this.cbxMaxAge.Size = new System.Drawing.Size(110, 24);
            this.cbxMaxAge.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label16.Location = new System.Drawing.Point(25, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 22);
            this.label16.TabIndex = 42;
            this.label16.Text = "Maximum Age:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxMinAge
            // 
            this.cbxMinAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMinAge.FormattingEnabled = true;
            this.cbxMinAge.Location = new System.Drawing.Point(118, 64);
            this.cbxMinAge.Name = "cbxMinAge";
            this.cbxMinAge.Size = new System.Drawing.Size(110, 24);
            this.cbxMinAge.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(190)))), ((int)(((byte)(126)))));
            this.label14.Location = new System.Drawing.Point(25, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 22);
            this.label14.TabIndex = 40;
            this.label14.Text = "Minimum Age:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(251, 258);
            this.ControlBox = false;
            this.Controls.Add(this.cbxMaxAge);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbxMinAge);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAchievementName);
            this.Controls.Add(this.lblCompName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInsertCategory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreateCategory_FormClosed);
            this.Load += new System.EventHandler(this.frmCreateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAchievementName;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.ComboBox cbxMaxAge;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxMinAge;
        private System.Windows.Forms.Label label14;
    }
}