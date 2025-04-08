namespace BaiThucHanhSo2
{
    partial class FrmSinhVien
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
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.txtMASINHVIEN = new System.Windows.Forms.TextBox();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnMOI = new System.Windows.Forms.Button();
            this.labelNOISINH = new System.Windows.Forms.Label();
            this.labelNGAYSINH = new System.Windows.Forms.Label();
            this.labelHOTEN = new System.Windows.Forms.Label();
            this.labelMASINHVIEN = new System.Windows.Forms.Label();
            this.txtNOISINH = new System.Windows.Forms.TextBox();
            this.labelMAHE = new System.Windows.Forms.Label();
            this.labelMALOP = new System.Windows.Forms.Label();
            this.labelMAKHOA = new System.Windows.Forms.Label();
            this.CboMALOP = new System.Windows.Forms.ComboBox();
            this.CboMAKHOA = new System.Windows.Forms.ComboBox();
            this.datePickerNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.CboMAHE = new System.Windows.Forms.ComboBox();
            this.optNam = new System.Windows.Forms.RadioButton();
            this.optNu = new System.Windows.Forms.RadioButton();
            this.gboGIOITINH = new System.Windows.Forms.GroupBox();
            this.labelSVtitle = new System.Windows.Forms.Label();
            this.DataGrid_SinhVien = new System.Windows.Forms.DataGridView();
            this.gboGIOITINH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_SinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Location = new System.Drawing.Point(159, 109);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(176, 20);
            this.txtHOTEN.TabIndex = 37;
            // 
            // txtMASINHVIEN
            // 
            this.txtMASINHVIEN.Location = new System.Drawing.Point(159, 76);
            this.txtMASINHVIEN.Name = "txtMASINHVIEN";
            this.txtMASINHVIEN.Size = new System.Drawing.Size(176, 20);
            this.txtMASINHVIEN.TabIndex = 36;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Location = new System.Drawing.Point(666, 250);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(75, 23);
            this.btnTHOAT.TabIndex = 49;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.BtnTHOAT_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(666, 214);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(75, 23);
            this.btnXOA.TabIndex = 48;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.BtnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(666, 174);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(75, 23);
            this.btnSUA.TabIndex = 47;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.BtnSUA_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Location = new System.Drawing.Point(666, 136);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(75, 23);
            this.btnLUU.TabIndex = 46;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.BtnLUU_Click);
            // 
            // btnMOI
            // 
            this.btnMOI.Location = new System.Drawing.Point(666, 98);
            this.btnMOI.Name = "btnMOI";
            this.btnMOI.Size = new System.Drawing.Size(75, 23);
            this.btnMOI.TabIndex = 45;
            this.btnMOI.Text = "Tạo Mới";
            this.btnMOI.UseVisualStyleBackColor = true;
            // 
            // labelNOISINH
            // 
            this.labelNOISINH.AutoSize = true;
            this.labelNOISINH.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.labelNOISINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOISINH.Location = new System.Drawing.Point(59, 177);
            this.labelNOISINH.Name = "labelNOISINH";
            this.labelNOISINH.Size = new System.Drawing.Size(64, 18);
            this.labelNOISINH.TabIndex = 30;
            this.labelNOISINH.Text = "Noi Sinh";
            // 
            // labelNGAYSINH
            // 
            this.labelNGAYSINH.AutoSize = true;
            this.labelNGAYSINH.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.labelNGAYSINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNGAYSINH.Location = new System.Drawing.Point(59, 141);
            this.labelNGAYSINH.Name = "labelNGAYSINH";
            this.labelNGAYSINH.Size = new System.Drawing.Size(75, 18);
            this.labelNGAYSINH.TabIndex = 29;
            this.labelNGAYSINH.Text = "Ngay Sinh";
            // 
            // labelHOTEN
            // 
            this.labelHOTEN.AutoSize = true;
            this.labelHOTEN.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.labelHOTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHOTEN.Location = new System.Drawing.Point(59, 111);
            this.labelHOTEN.Name = "labelHOTEN";
            this.labelHOTEN.Size = new System.Drawing.Size(57, 18);
            this.labelHOTEN.TabIndex = 27;
            this.labelHOTEN.Text = "Ho Ten";
            // 
            // labelMASINHVIEN
            // 
            this.labelMASINHVIEN.AutoSize = true;
            this.labelMASINHVIEN.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.labelMASINHVIEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMASINHVIEN.Location = new System.Drawing.Point(59, 76);
            this.labelMASINHVIEN.Name = "labelMASINHVIEN";
            this.labelMASINHVIEN.Size = new System.Drawing.Size(94, 18);
            this.labelMASINHVIEN.TabIndex = 26;
            this.labelMASINHVIEN.Text = "Ma Sinh Vien";
            // 
            // txtNOISINH
            // 
            this.txtNOISINH.Location = new System.Drawing.Point(159, 175);
            this.txtNOISINH.Name = "txtNOISINH";
            this.txtNOISINH.Size = new System.Drawing.Size(175, 20);
            this.txtNOISINH.TabIndex = 39;
            // 
            // labelMAHE
            // 
            this.labelMAHE.AutoSize = true;
            this.labelMAHE.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.labelMAHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMAHE.Location = new System.Drawing.Point(59, 279);
            this.labelMAHE.Name = "labelMAHE";
            this.labelMAHE.Size = new System.Drawing.Size(52, 18);
            this.labelMAHE.TabIndex = 46;
            this.labelMAHE.Text = "Ma He";
            // 
            // labelMALOP
            // 
            this.labelMALOP.AutoSize = true;
            this.labelMALOP.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.labelMALOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMALOP.Location = new System.Drawing.Point(59, 245);
            this.labelMALOP.Name = "labelMALOP";
            this.labelMALOP.Size = new System.Drawing.Size(58, 18);
            this.labelMALOP.TabIndex = 45;
            this.labelMALOP.Text = "Ma Lop";
            // 
            // labelMAKHOA
            // 
            this.labelMAKHOA.AutoSize = true;
            this.labelMAKHOA.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.labelMAKHOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMAKHOA.Location = new System.Drawing.Point(59, 211);
            this.labelMAKHOA.Name = "labelMAKHOA";
            this.labelMAKHOA.Size = new System.Drawing.Size(68, 18);
            this.labelMAKHOA.TabIndex = 44;
            this.labelMAKHOA.Text = "Ma Khoa";
            // 
            // CboMALOP
            // 
            this.CboMALOP.FormattingEnabled = true;
            this.CboMALOP.Location = new System.Drawing.Point(160, 242);
            this.CboMALOP.Name = "CboMALOP";
            this.CboMALOP.Size = new System.Drawing.Size(176, 21);
            this.CboMALOP.TabIndex = 41;
            // 
            // CboMAKHOA
            // 
            this.CboMAKHOA.FormattingEnabled = true;
            this.CboMAKHOA.Location = new System.Drawing.Point(161, 208);
            this.CboMAKHOA.Name = "CboMAKHOA";
            this.CboMAKHOA.Size = new System.Drawing.Size(176, 21);
            this.CboMAKHOA.TabIndex = 40;
            // 
            // datePickerNGAYSINH
            // 
            this.datePickerNGAYSINH.Location = new System.Drawing.Point(159, 142);
            this.datePickerNGAYSINH.Name = "datePickerNGAYSINH";
            this.datePickerNGAYSINH.Size = new System.Drawing.Size(176, 20);
            this.datePickerNGAYSINH.TabIndex = 38;
            // 
            // CboMAHE
            // 
            this.CboMAHE.FormattingEnabled = true;
            this.CboMAHE.Location = new System.Drawing.Point(160, 276);
            this.CboMAHE.Name = "CboMAHE";
            this.CboMAHE.Size = new System.Drawing.Size(176, 21);
            this.CboMAHE.TabIndex = 42;
            // 
            // optNam
            // 
            this.optNam.AutoSize = true;
            this.optNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNam.Location = new System.Drawing.Point(6, 19);
            this.optNam.Name = "optNam";
            this.optNam.Size = new System.Drawing.Size(58, 22);
            this.optNam.TabIndex = 43;
            this.optNam.TabStop = true;
            this.optNam.Text = "Nam";
            this.optNam.UseVisualStyleBackColor = true;
            // 
            // optNu
            // 
            this.optNu.AutoSize = true;
            this.optNu.Location = new System.Drawing.Point(6, 40);
            this.optNu.Name = "optNu";
            this.optNu.Size = new System.Drawing.Size(47, 24);
            this.optNu.TabIndex = 44;
            this.optNu.TabStop = true;
            this.optNu.Text = "Nu";
            this.optNu.UseVisualStyleBackColor = true;
            // 
            // gboGIOITINH
            // 
            this.gboGIOITINH.Controls.Add(this.optNam);
            this.gboGIOITINH.Controls.Add(this.optNu);
            this.gboGIOITINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboGIOITINH.Location = new System.Drawing.Point(398, 76);
            this.gboGIOITINH.Name = "gboGIOITINH";
            this.gboGIOITINH.Size = new System.Drawing.Size(200, 100);
            this.gboGIOITINH.TabIndex = 45;
            this.gboGIOITINH.TabStop = false;
            this.gboGIOITINH.Text = "Gioi Tinh";
            this.gboGIOITINH.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelSVtitle
            // 
            this.labelSVtitle.AutoSize = true;
            this.labelSVtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSVtitle.Location = new System.Drawing.Point(268, 9);
            this.labelSVtitle.Name = "labelSVtitle";
            this.labelSVtitle.Size = new System.Drawing.Size(258, 31);
            this.labelSVtitle.TabIndex = 55;
            this.labelSVtitle.Text = "Thong Tin Sinh Vien";
            // 
            // DataGrid_SinhVien
            // 
            this.DataGrid_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_SinhVien.Location = new System.Drawing.Point(62, 303);
            this.DataGrid_SinhVien.Name = "DataGrid_SinhVien";
            this.DataGrid_SinhVien.Size = new System.Drawing.Size(634, 143);
            this.DataGrid_SinhVien.TabIndex = 56;
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGrid_SinhVien);
            this.Controls.Add(this.labelSVtitle);
            this.Controls.Add(this.gboGIOITINH);
            this.Controls.Add(this.CboMAHE);
            this.Controls.Add(this.datePickerNGAYSINH);
            this.Controls.Add(this.labelMAHE);
            this.Controls.Add(this.labelMALOP);
            this.Controls.Add(this.labelMAKHOA);
            this.Controls.Add(this.CboMALOP);
            this.Controls.Add(this.CboMAKHOA);
            this.Controls.Add(this.txtHOTEN);
            this.Controls.Add(this.txtMASINHVIEN);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnMOI);
            this.Controls.Add(this.labelNOISINH);
            this.Controls.Add(this.labelNGAYSINH);
            this.Controls.Add(this.labelHOTEN);
            this.Controls.Add(this.labelMASINHVIEN);
            this.Controls.Add(this.txtNOISINH);
            this.Name = "FrmSinhVien";
            this.Text = "FrmSINHVIEN";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            this.gboGIOITINH.ResumeLayout(false);
            this.gboGIOITINH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_SinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.TextBox txtMASINHVIEN;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnMOI;
        private System.Windows.Forms.Label labelNOISINH;
        private System.Windows.Forms.Label labelNGAYSINH;
        private System.Windows.Forms.Label labelHOTEN;
        private System.Windows.Forms.Label labelMASINHVIEN;
        private System.Windows.Forms.TextBox txtNOISINH;
        private System.Windows.Forms.Label labelMAHE;
        private System.Windows.Forms.Label labelMALOP;
        private System.Windows.Forms.Label labelMAKHOA;
        private System.Windows.Forms.ComboBox CboMALOP;
        private System.Windows.Forms.ComboBox CboMAKHOA;
        private System.Windows.Forms.DateTimePicker datePickerNGAYSINH;
        private System.Windows.Forms.ComboBox CboMAHE;
        private System.Windows.Forms.RadioButton optNam;
        private System.Windows.Forms.RadioButton optNu;
        private System.Windows.Forms.GroupBox gboGIOITINH;
        private System.Windows.Forms.Label labelSVtitle;
        private System.Windows.Forms.DataGridView DataGrid_SinhVien;
    }
}