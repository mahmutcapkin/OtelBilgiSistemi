namespace OtelBilgiSistemi
{
    partial class FrmOtelBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOtelBilgi));
            this.txtOtelAd = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnOtelBilgi = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btndeneme = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOtelAd
            // 
            this.txtOtelAd.Location = new System.Drawing.Point(66, 92);
            this.txtOtelAd.Name = "txtOtelAd";
            this.txtOtelAd.Size = new System.Drawing.Size(329, 22);
            this.txtOtelAd.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(442, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(506, 470);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnOtelBilgi
            // 
            this.btnOtelBilgi.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOtelBilgi.Appearance.Options.UseFont = true;
            this.btnOtelBilgi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOtelBilgi.ImageOptions.Image")));
            this.btnOtelBilgi.Location = new System.Drawing.Point(155, 120);
            this.btnOtelBilgi.Name = "btnOtelBilgi";
            this.btnOtelBilgi.Size = new System.Drawing.Size(152, 42);
            this.btnOtelBilgi.TabIndex = 4;
            this.btnOtelBilgi.Text = "Bilgileri gör";
            this.btnOtelBilgi.Click += new System.EventHandler(this.btnOtelBilgi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(120, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Otelin Adını Giriniz:\r\n";
            // 
            // btndeneme
            // 
            this.btndeneme.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndeneme.Appearance.Options.UseFont = true;
            this.btndeneme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btndeneme.Location = new System.Drawing.Point(124, 255);
            this.btndeneme.Name = "btndeneme";
            this.btndeneme.Size = new System.Drawing.Size(152, 42);
            this.btndeneme.TabIndex = 6;
            this.btndeneme.Text = "ss";
            this.btndeneme.Click += new System.EventHandler(this.btndeneme_Click);
            // 
            // FrmOtelBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 842);
            this.Controls.Add(this.btndeneme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOtelBilgi);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtOtelAd);
            this.Name = "FrmOtelBilgi";
            this.Text = "Otel Bilgi";
            this.Load += new System.EventHandler(this.FrmOtelBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOtelAd;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnOtelBilgi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btndeneme;
    }
}