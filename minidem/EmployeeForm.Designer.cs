
namespace minidem
{
    partial class EmployeeForm
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
            this.btnEndedWashes = new System.Windows.Forms.Button();
            this.btnActiveWashes = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblSection = new System.Windows.Forms.Label();
            this.btnAddWash = new System.Windows.Forms.Button();
            this.dgvSection = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEndedWashes
            // 
            this.btnEndedWashes.Location = new System.Drawing.Point(104, 31);
            this.btnEndedWashes.Name = "btnEndedWashes";
            this.btnEndedWashes.Size = new System.Drawing.Size(89, 37);
            this.btnEndedWashes.TabIndex = 0;
            this.btnEndedWashes.Text = "Завершенные стирки";
            this.btnEndedWashes.UseVisualStyleBackColor = true;
            // 
            // btnActiveWashes
            // 
            this.btnActiveWashes.Location = new System.Drawing.Point(9, 31);
            this.btnActiveWashes.Name = "btnActiveWashes";
            this.btnActiveWashes.Size = new System.Drawing.Size(89, 37);
            this.btnActiveWashes.TabIndex = 1;
            this.btnActiveWashes.Text = "Активные стирки";
            this.btnActiveWashes.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(199, 31);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(89, 37);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Кассовый отчет";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(448, 43);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(53, 13);
            this.lblSection.TabIndex = 3;
            this.lblSection.Text = "lblSection";
            // 
            // btnAddWash
            // 
            this.btnAddWash.Location = new System.Drawing.Point(690, 31);
            this.btnAddWash.Name = "btnAddWash";
            this.btnAddWash.Size = new System.Drawing.Size(89, 37);
            this.btnAddWash.TabIndex = 1;
            this.btnAddWash.Text = "Добавить стирку";
            this.btnAddWash.UseVisualStyleBackColor = true;
            // 
            // dgvSection
            // 
            this.dgvSection.BackgroundColor = System.Drawing.Color.White;
            this.dgvSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSection.Location = new System.Drawing.Point(9, 74);
            this.dgvSection.Name = "dgvSection";
            this.dgvSection.Size = new System.Drawing.Size(770, 364);
            this.dgvSection.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSection);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.btnAddWash);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnActiveWashes);
            this.Controls.Add(this.btnEndedWashes);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEndedWashes;
        private System.Windows.Forms.Button btnActiveWashes;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Button btnAddWash;
        private System.Windows.Forms.DataGridView dgvSection;
    }
}