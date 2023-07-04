namespace StockTracking
{
    partial class UserGUIMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGUIMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonListProducts = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonModifyProducts = new System.Windows.Forms.Button();
            this.buttonSellProducts = new System.Windows.Forms.Button();
            this.buttonAddProducts = new System.Windows.Forms.Button();
            this.panelSubForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxMainUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 111);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.buttonListProducts);
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Controls.Add(this.buttonModifyProducts);
            this.panel3.Controls.Add(this.buttonSellProducts);
            this.panel3.Controls.Add(this.buttonAddProducts);
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 462);
            this.panel3.TabIndex = 2;
            // 
            // buttonListProducts
            // 
            this.buttonListProducts.FlatAppearance.BorderSize = 0;
            this.buttonListProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListProducts.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.buttonListProducts.Location = new System.Drawing.Point(0, 3);
            this.buttonListProducts.Name = "buttonListProducts";
            this.buttonListProducts.Size = new System.Drawing.Size(184, 85);
            this.buttonListProducts.TabIndex = 4;
            this.buttonListProducts.Text = "ÜRÜN LİSTELE";
            this.buttonListProducts.UseVisualStyleBackColor = true;
            this.buttonListProducts.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.buttonExit.Location = new System.Drawing.Point(-3, 378);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(187, 81);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "ÇIKIŞ";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonModifyProducts
            // 
            this.buttonModifyProducts.FlatAppearance.BorderSize = 0;
            this.buttonModifyProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifyProducts.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonModifyProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.buttonModifyProducts.Location = new System.Drawing.Point(-3, 289);
            this.buttonModifyProducts.Name = "buttonModifyProducts";
            this.buttonModifyProducts.Size = new System.Drawing.Size(187, 83);
            this.buttonModifyProducts.TabIndex = 2;
            this.buttonModifyProducts.Text = "ÜRÜN DÜZENLE";
            this.buttonModifyProducts.UseVisualStyleBackColor = true;
            this.buttonModifyProducts.Click += new System.EventHandler(this.buttonModifyProducts_Click);
            // 
            // buttonSellProducts
            // 
            this.buttonSellProducts.FlatAppearance.BorderSize = 0;
            this.buttonSellProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSellProducts.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSellProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.buttonSellProducts.Location = new System.Drawing.Point(0, 189);
            this.buttonSellProducts.Name = "buttonSellProducts";
            this.buttonSellProducts.Size = new System.Drawing.Size(184, 94);
            this.buttonSellProducts.TabIndex = 1;
            this.buttonSellProducts.Text = "ÜRÜN SAT";
            this.buttonSellProducts.UseVisualStyleBackColor = true;
            this.buttonSellProducts.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAddProducts
            // 
            this.buttonAddProducts.FlatAppearance.BorderSize = 0;
            this.buttonAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProducts.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.buttonAddProducts.Location = new System.Drawing.Point(0, 98);
            this.buttonAddProducts.Name = "buttonAddProducts";
            this.buttonAddProducts.Size = new System.Drawing.Size(184, 85);
            this.buttonAddProducts.TabIndex = 0;
            this.buttonAddProducts.Text = "ÜRÜN EKLE";
            this.buttonAddProducts.UseVisualStyleBackColor = true;
            this.buttonAddProducts.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSubForm
            // 
            this.panelSubForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panelSubForm.Location = new System.Drawing.Point(184, 75);
            this.panelSubForm.Name = "panelSubForm";
            this.panelSubForm.Size = new System.Drawing.Size(889, 497);
            this.panelSubForm.TabIndex = 4;
            this.panelSubForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ YAPILDI : ";
            // 
            // txtboxMainUsername
            // 
            this.txtboxMainUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtboxMainUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxMainUsername.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxMainUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.txtboxMainUsername.Location = new System.Drawing.Point(200, 21);
            this.txtboxMainUsername.Multiline = true;
            this.txtboxMainUsername.Name = "txtboxMainUsername";
            this.txtboxMainUsername.ReadOnly = true;
            this.txtboxMainUsername.Size = new System.Drawing.Size(383, 30);
            this.txtboxMainUsername.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.txtboxMainUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 76);
            this.panel2.TabIndex = 3;
            // 
            // UserGUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1072, 570);
            this.Controls.Add(this.panelSubForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserGUIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddProducts;
        private System.Windows.Forms.Button buttonSellProducts;
        private System.Windows.Forms.Button buttonModifyProducts;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonListProducts;
        private System.Windows.Forms.Panel panelSubForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxMainUsername;
        private System.Windows.Forms.Panel panel2;
    }
}