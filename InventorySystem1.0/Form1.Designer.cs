namespace InventorySystem1._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.ts_stocks = new System.Windows.Forms.ToolStripButton();
            this.ts_settings = new System.Windows.Forms.ToolStripButton();
            this.ts_StockOut = new System.Windows.Forms.ToolStripButton();
            this.ts_Return = new System.Windows.Forms.ToolStripButton();
            this.ts_ManageUsers = new System.Windows.Forms.ToolStripButton();
            this.ts_Report = new System.Windows.Forms.ToolStripButton();
            this.ts_Login = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_stocks,
            this.ts_settings,
            this.ts_StockOut,
            this.ts_Return,
            this.ts_ManageUsers,
            this.ts_Report,
            this.ts_Login});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(142, 634);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(142, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(643, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 204);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jess Galarraga\r\nDarwin Mena\r\nNixon Poma\r\nEdison Pullupaxi\r\nNelson Recalde\r\nElizab" +
    "eth Unaucho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ts_stocks
            // 
            this.ts_stocks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_stocks.Image = ((System.Drawing.Image)(resources.GetObject("ts_stocks.Image")));
            this.ts_stocks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_stocks.Name = "ts_stocks";
            this.ts_stocks.Size = new System.Drawing.Size(139, 59);
            this.ts_stocks.Text = "Articulos";
            this.ts_stocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_stocks.Click += new System.EventHandler(this.ts_stocks_Click);
            // 
            // ts_settings
            // 
            this.ts_settings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_settings.Image = global::InventorySystem1._0.Properties.Resources.add_icon;
            this.ts_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_settings.Name = "ts_settings";
            this.ts_settings.Size = new System.Drawing.Size(139, 59);
            this.ts_settings.Text = "Categorias";
            this.ts_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_settings.Click += new System.EventHandler(this.ts_settings_Click);
            // 
            // ts_StockOut
            // 
            this.ts_StockOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_StockOut.Image = ((System.Drawing.Image)(resources.GetObject("ts_StockOut.Image")));
            this.ts_StockOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_StockOut.Name = "ts_StockOut";
            this.ts_StockOut.Size = new System.Drawing.Size(139, 59);
            this.ts_StockOut.Text = "Ventas";
            this.ts_StockOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_StockOut.Click += new System.EventHandler(this.ts_StockOut_Click);
            // 
            // ts_Return
            // 
            this.ts_Return.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Return.Image = ((System.Drawing.Image)(resources.GetObject("ts_Return.Image")));
            this.ts_Return.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Return.Name = "ts_Return";
            this.ts_Return.Size = new System.Drawing.Size(139, 59);
            this.ts_Return.Text = "Articulos Devueltos";
            this.ts_Return.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Return.Click += new System.EventHandler(this.ts_Return_Click);
            // 
            // ts_ManageUsers
            // 
            this.ts_ManageUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_ManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("ts_ManageUsers.Image")));
            this.ts_ManageUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_ManageUsers.Name = "ts_ManageUsers";
            this.ts_ManageUsers.Size = new System.Drawing.Size(139, 59);
            this.ts_ManageUsers.Text = "Acceso";
            this.ts_ManageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_ManageUsers.Click += new System.EventHandler(this.ts_ManageUsers_Click);
            // 
            // ts_Report
            // 
            this.ts_Report.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Report.Image = ((System.Drawing.Image)(resources.GetObject("ts_Report.Image")));
            this.ts_Report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Report.Name = "ts_Report";
            this.ts_Report.Size = new System.Drawing.Size(139, 59);
            this.ts_Report.Text = "Report";
            this.ts_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Report.Visible = false;
            this.ts_Report.Click += new System.EventHandler(this.ts_Report_Click);
            // 
            // ts_Login
            // 
            this.ts_Login.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Login.Image = global::InventorySystem1._0.Properties.Resources.security_protection_protect_key_password_login_108554;
            this.ts_Login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Login.Name = "ts_Login";
            this.ts_Login.Size = new System.Drawing.Size(139, 59);
            this.ts_Login.Text = "Login";
            this.ts_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Login.Click += new System.EventHandler(this.ts_Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::InventorySystem1._0.Properties.Resources.Sin_título_1;
            this.pictureBox1.Location = new System.Drawing.Point(532, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventorySystem1._0.Properties.Resources.LOGO_ISTVN_300x300;
            this.pictureBox2.Location = new System.Drawing.Point(649, 472);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 634);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema  de Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_stocks;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton ts_StockOut;
        private System.Windows.Forms.ToolStripButton ts_Return;
        private System.Windows.Forms.ToolStripButton ts_ManageUsers;
        private System.Windows.Forms.ToolStripButton ts_Report;
        private System.Windows.Forms.ToolStripButton ts_Login;
        private System.Windows.Forms.ToolStripButton ts_settings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

