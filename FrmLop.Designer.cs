namespace BaiThucHanhSo2
{
    partial class FrmLop
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
            this.DataGrid_Lop = new System.Windows.Forms.DataGridView();
            this.CboKHOAVIEN = new System.Windows.Forms.ComboBox();
            this.CboMALOP = new System.Windows.Forms.ComboBox();
            this.CboTENLOP = new System.Windows.Forms.ComboBox();
            this.CboCVHT = new System.Windows.Forms.ComboBox();
            this.txtBoxGHICHU = new System.Windows.Forms.TextBox();
            this.labelMALOP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMOI = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.txtMALOP = new System.Windows.Forms.TextBox();
            this.txtGHICHU = new System.Windows.Forms.TextBox();
            this.txtTENLOP = new System.Windows.Forms.TextBox();
            this.txtKHOAVIEN = new System.Windows.Forms.TextBox();
            this.txtCVHT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Lop)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_SinhVien
            // 
            this.DataGrid_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Lop.Location = new System.Drawing.Point(64, 289);
            this.DataGrid_Lop.Name = "DataGrid_Lop";
            this.DataGrid_Lop.Size = new System.Drawing.Size(634, 143);
            this.DataGrid_Lop.TabIndex = 0;
            // 
            // CboKHOAVIEN
            // 
            this.CboKHOAVIEN.FormattingEnabled = true;
            this.CboKHOAVIEN.Location = new System.Drawing.Point(137, 116);
            this.CboKHOAVIEN.Name = "CboKHOAVIEN";
            this.CboKHOAVIEN.Size = new System.Drawing.Size(91, 21);
            this.CboKHOAVIEN.TabIndex = 1;
            this.CboKHOAVIEN.SelectedIndexChanged += new System.EventHandler(this.cboKhoaVien_SelectedIndexChanged);
            // 
            // CboMALOP
            // 
            this.CboMALOP.FormattingEnabled = true;
            this.CboMALOP.Location = new System.Drawing.Point(137, 36);
            this.CboMALOP.Name = "CboMALOP";
            this.CboMALOP.Size = new System.Drawing.Size(91, 21);
            this.CboMALOP.TabIndex = 2;
            // 
            // CboTENLOP
            // 
            this.CboTENLOP.FormattingEnabled = true;
            this.CboTENLOP.Location = new System.Drawing.Point(137, 76);
            this.CboTENLOP.Name = "CboTENLOP";
            this.CboTENLOP.Size = new System.Drawing.Size(91, 21);
            this.CboTENLOP.TabIndex = 3;
            // 
            // CboCVHT
            // 
            this.CboCVHT.FormattingEnabled = true;
            this.CboCVHT.Location = new System.Drawing.Point(137, 156);
            this.CboCVHT.Name = "CboCVHT";
            this.CboCVHT.Size = new System.Drawing.Size(91, 21);
            this.CboCVHT.TabIndex = 4;
            // 
            // txtBoxGHICHU
            // 
            this.txtBoxGHICHU.Location = new System.Drawing.Point(137, 196);
            this.txtBoxGHICHU.Name = "txtBoxGHICHU";
            this.txtBoxGHICHU.Size = new System.Drawing.Size(90, 20);
            this.txtBoxGHICHU.TabIndex = 5;
            // 
            // labelMALOP
            // 
            this.labelMALOP.AutoSize = true;
            this.labelMALOP.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.labelMALOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMALOP.Location = new System.Drawing.Point(38, 39);
            this.labelMALOP.Name = "labelMALOP";
            this.labelMALOP.Size = new System.Drawing.Size(54, 18);
            this.labelMALOP.TabIndex = 6;
            this.labelMALOP.Text = "MaLop";
            this.labelMALOP.Click += new System.EventHandler(this.labelMALOP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ten Lop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Khoa Vien";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Co Van HT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ghi Chu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnMOI
            // 
            this.btnMOI.Location = new System.Drawing.Point(642, 38);
            this.btnMOI.Name = "btnMOI";
            this.btnMOI.Size = new System.Drawing.Size(75, 23);
            this.btnMOI.TabIndex = 11;
            this.btnMOI.Text = "Tạo Mới";
            this.btnMOI.UseVisualStyleBackColor = true;
            this.btnMOI.Click += new System.EventHandler(this.btnMOI_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Location = new System.Drawing.Point(642, 76);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(75, 23);
            this.btnLUU.TabIndex = 12;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(642, 114);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(75, 23);
            this.btnSUA.TabIndex = 13;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(642, 154);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(75, 23);
            this.btnXOA.TabIndex = 14;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Location = new System.Drawing.Point(642, 190);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(75, 23);
            this.btnTHOAT.TabIndex = 15;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // txtMALOP
            // 
            this.txtMALOP.Location = new System.Drawing.Point(272, 36);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(100, 20);
            this.txtMALOP.TabIndex = 16;
            // 
            // txtGHICHU
            // 
            this.txtGHICHU.Location = new System.Drawing.Point(272, 193);
            this.txtGHICHU.Name = "txtGHICHU";
            this.txtGHICHU.Size = new System.Drawing.Size(100, 20);
            this.txtGHICHU.TabIndex = 17;
            // 
            // txtTENLOP
            // 
            this.txtTENLOP.Location = new System.Drawing.Point(272, 79);
            this.txtTENLOP.Name = "txtTENLOP";
            this.txtTENLOP.Size = new System.Drawing.Size(100, 20);
            this.txtTENLOP.TabIndex = 18;
            // 
            // txtKHOAVIEN
            // 
            this.txtKHOAVIEN.Location = new System.Drawing.Point(272, 114);
            this.txtKHOAVIEN.Name = "txtKHOAVIEN";
            this.txtKHOAVIEN.Size = new System.Drawing.Size(100, 20);
            this.txtKHOAVIEN.TabIndex = 19;
            // 
            // txtCVHT
            // 
            this.txtCVHT.Location = new System.Drawing.Point(272, 157);
            this.txtCVHT.Name = "txtCVHT";
            this.txtCVHT.Size = new System.Drawing.Size(100, 20);
            this.txtCVHT.TabIndex = 20;
            // 
            // FrmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCVHT);
            this.Controls.Add(this.txtKHOAVIEN);
            this.Controls.Add(this.txtTENLOP);
            this.Controls.Add(this.txtGHICHU);
            this.Controls.Add(this.txtMALOP);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnMOI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMALOP);
            this.Controls.Add(this.txtBoxGHICHU);
            this.Controls.Add(this.CboCVHT);
            this.Controls.Add(this.CboTENLOP);
            this.Controls.Add(this.CboMALOP);
            this.Controls.Add(this.CboKHOAVIEN);
            this.Controls.Add(this.DataGrid_Lop);
            this.Name = "FrmLop";
            this.Text = "FrmLop";
            this.Load += new System.EventHandler(this.FrmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Lop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Lop;
        private System.Windows.Forms.ComboBox CboKHOAVIEN;
        private System.Windows.Forms.ComboBox CboMALOP;
        private System.Windows.Forms.ComboBox CboTENLOP;
        private System.Windows.Forms.ComboBox CboCVHT;
        private System.Windows.Forms.TextBox txtBoxGHICHU;
        private System.Windows.Forms.Label labelMALOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMOI;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.TextBox txtMALOP;
        private System.Windows.Forms.TextBox txtGHICHU;
        private System.Windows.Forms.TextBox txtTENLOP;
        private System.Windows.Forms.TextBox txtKHOAVIEN;
        private System.Windows.Forms.TextBox txtCVHT;
    }
}