namespace StockTracking.AdminGUI
{
    partial class AdminGUILognExc
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
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListException = new System.Windows.Forms.DataGridView();
            this.dgvListLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListException)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLog)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxSearch.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.txtboxSearch.Location = new System.Drawing.Point(210, 20);
            this.txtboxSearch.Multiline = true;
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(309, 30);
            this.txtboxSearch.TabIndex = 9;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.panel1.Location = new System.Drawing.Point(210, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 1);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Ara : ";
            // 
            // dgvListException
            // 
            this.dgvListException.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListException.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListException.Location = new System.Drawing.Point(8, 267);
            this.dgvListException.Name = "dgvListException";
            this.dgvListException.ReadOnly = true;
            this.dgvListException.Size = new System.Drawing.Size(856, 172);
            this.dgvListException.TabIndex = 6;
            // 
            // dgvListLog
            // 
            this.dgvListLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLog.Location = new System.Drawing.Point(8, 89);
            this.dgvListLog.Name = "dgvListLog";
            this.dgvListLog.ReadOnly = true;
            this.dgvListLog.Size = new System.Drawing.Size(856, 172);
            this.dgvListLog.TabIndex = 10;
            // 
            // AdminGUILognExc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 458);
            this.Controls.Add(this.dgvListLog);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListException);
            this.Name = "AdminGUILognExc";
            this.Text = "AdminGUIListUser";
            this.Load += new System.EventHandler(this.AdminGUIListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListException)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListException;
        private System.Windows.Forms.DataGridView dgvListLog;
    }
}