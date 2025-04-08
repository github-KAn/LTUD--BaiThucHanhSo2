namespace BaiThucHanhSo2
{
    partial class FrmTimKiem
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
            this.labeTITLE_TK = new System.Windows.Forms.Label();
            this.txtMASV = new System.Windows.Forms.TextBox();
            this.btnTIMKIEM = new System.Windows.Forms.Button();
            this.grid_KETQUATK = new System.Windows.Forms.DataGridView();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.cboKHOA = new System.Windows.Forms.ComboBox();
            this.cboLOP = new System.Windows.Forms.ComboBox();
            this.optNHAPMASV = new System.Windows.Forms.RadioButton();
            this.optNHAPTEN = new System.Windows.Forms.RadioButton();
            this.optNHAPMAKHOA = new System.Windows.Forms.RadioButton();
            this.optNHAPMALOP = new System.Windows.Forms.RadioButton();
            this.cboMAHE = new System.Windows.Forms.ComboBox();
            this.optMAHE = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KETQUATK)).BeginInit();
            this.SuspendLayout();
            // 
            // labeTITLE_TK
            // 
            this.labeTITLE_TK.AutoSize = true;
            this.labeTITLE_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeTITLE_TK.Location = new System.Drawing.Point(261, 9);
            this.labeTITLE_TK.Name = "labeTITLE_TK";
            this.labeTITLE_TK.Size = new System.Drawing.Size(234, 29);
            this.labeTITLE_TK.TabIndex = 0;
            this.labeTITLE_TK.Text = "Tìm Kiếm Thông Tin";
            this.labeTITLE_TK.Click += new System.EventHandler(this.labeTITLE_TK_Click);
            // 
            // txtMASV
            // 
            this.txtMASV.Location = new System.Drawing.Point(234, 41);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(193, 20);
            this.txtMASV.TabIndex = 1;
            this.txtMASV.TextChanged += new System.EventHandler(this.txtTIMKIEM_TextChanged);
            // 
            // btnTIMKIEM
            // 
            this.btnTIMKIEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTIMKIEM.Location = new System.Drawing.Point(485, 41);
            this.btnTIMKIEM.Name = "btnTIMKIEM";
            this.btnTIMKIEM.Size = new System.Drawing.Size(82, 26);
            this.btnTIMKIEM.TabIndex = 2;
            this.btnTIMKIEM.Text = "Tìm Kiếm";
            this.btnTIMKIEM.UseVisualStyleBackColor = true;
            this.btnTIMKIEM.Click += new System.EventHandler(this.btnTIMKIEM_Click);
            // 
            // grid_KETQUATK
            // 
            this.grid_KETQUATK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_KETQUATK.Location = new System.Drawing.Point(108, 219);
            this.grid_KETQUATK.Name = "grid_KETQUATK";
            this.grid_KETQUATK.Size = new System.Drawing.Size(497, 219);
            this.grid_KETQUATK.TabIndex = 4;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(485, 83);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(82, 26);
            this.btnTHOAT.TabIndex = 5;
            this.btnTHOAT.Text = "Thoát ";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // txtTEN
            // 
            this.txtTEN.Location = new System.Drawing.Point(234, 67);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(193, 20);
            this.txtTEN.TabIndex = 7;
            this.txtTEN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboKHOA
            // 
            this.cboKHOA.FormattingEnabled = true;
            this.cboKHOA.Location = new System.Drawing.Point(234, 97);
            this.cboKHOA.Name = "cboKHOA";
            this.cboKHOA.Size = new System.Drawing.Size(193, 21);
            this.cboKHOA.TabIndex = 11;
            // 
            // cboLOP
            // 
            this.cboLOP.FormattingEnabled = true;
            this.cboLOP.Location = new System.Drawing.Point(233, 128);
            this.cboLOP.Name = "cboLOP";
            this.cboLOP.Size = new System.Drawing.Size(194, 21);
            this.cboLOP.TabIndex = 12;
            this.cboLOP.SelectedIndexChanged += new System.EventHandler(this.cboLOP_SelectedIndexChanged);
            // 
            // optNHAPMASV
            // 
            this.optNHAPMASV.AutoSize = true;
            this.optNHAPMASV.Location = new System.Drawing.Point(116, 47);
            this.optNHAPMASV.Name = "optNHAPMASV";
            this.optNHAPMASV.Size = new System.Drawing.Size(86, 17);
            this.optNHAPMASV.TabIndex = 13;
            this.optNHAPMASV.TabStop = true;
            this.optNHAPMASV.Text = "Nhap Ma SV";
            this.optNHAPMASV.UseVisualStyleBackColor = true;
            // 
            // optNHAPTEN
            // 
            this.optNHAPTEN.AutoSize = true;
            this.optNHAPTEN.Location = new System.Drawing.Point(116, 72);
            this.optNHAPTEN.Name = "optNHAPTEN";
            this.optNHAPTEN.Size = new System.Drawing.Size(76, 17);
            this.optNHAPTEN.TabIndex = 14;
            this.optNHAPTEN.TabStop = true;
            this.optNHAPTEN.Text = "Nhap TEN";
            this.optNHAPTEN.UseVisualStyleBackColor = true;
            // 
            // optNHAPMAKHOA
            // 
            this.optNHAPMAKHOA.AutoSize = true;
            this.optNHAPMAKHOA.Location = new System.Drawing.Point(116, 101);
            this.optNHAPMAKHOA.Name = "optNHAPMAKHOA";
            this.optNHAPMAKHOA.Size = new System.Drawing.Size(102, 17);
            this.optNHAPMAKHOA.TabIndex = 15;
            this.optNHAPMAKHOA.TabStop = true;
            this.optNHAPMAKHOA.Text = "Nhap Ma KHOA";
            this.optNHAPMAKHOA.UseVisualStyleBackColor = true;
            // 
            // optNHAPMALOP
            // 
            this.optNHAPMALOP.AutoSize = true;
            this.optNHAPMALOP.Location = new System.Drawing.Point(116, 130);
            this.optNHAPMALOP.Name = "optNHAPMALOP";
            this.optNHAPMALOP.Size = new System.Drawing.Size(93, 17);
            this.optNHAPMALOP.TabIndex = 17;
            this.optNHAPMALOP.TabStop = true;
            this.optNHAPMALOP.Text = "Nhap Ma LOP";
            this.optNHAPMALOP.UseVisualStyleBackColor = true;
            // 
            // cboMAHE
            // 
            this.cboMAHE.FormattingEnabled = true;
            this.cboMAHE.Location = new System.Drawing.Point(233, 155);
            this.cboMAHE.Name = "cboMAHE";
            this.cboMAHE.Size = new System.Drawing.Size(194, 21);
            this.cboMAHE.TabIndex = 18;
            // 
            // optMAHE
            // 
            this.optMAHE.AutoSize = true;
            this.optMAHE.Location = new System.Drawing.Point(116, 156);
            this.optMAHE.Name = "optMAHE";
            this.optMAHE.Size = new System.Drawing.Size(87, 17);
            this.optMAHE.TabIndex = 19;
            this.optMAHE.TabStop = true;
            this.optMAHE.Text = "Nhap Ma HE";
            this.optMAHE.UseVisualStyleBackColor = true;
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optMAHE);
            this.Controls.Add(this.cboMAHE);
            this.Controls.Add(this.optNHAPMASV);
            this.Controls.Add(this.optNHAPMALOP);
            this.Controls.Add(this.cboLOP);
            this.Controls.Add(this.optNHAPTEN);
            this.Controls.Add(this.cboKHOA);
            this.Controls.Add(this.optNHAPMAKHOA);
            this.Controls.Add(this.txtTEN);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.grid_KETQUATK);
            this.Controls.Add(this.btnTIMKIEM);
            this.Controls.Add(this.txtMASV);
            this.Controls.Add(this.labeTITLE_TK);
            this.Name = "FrmTimKiem";
            this.Text = "FormTimKiem";
            this.Load += new System.EventHandler(this.FrmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KETQUATK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeTITLE_TK;
        private System.Windows.Forms.TextBox txtMASV;
        private System.Windows.Forms.Button btnTIMKIEM;
        private System.Windows.Forms.DataGridView grid_KETQUATK;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.ComboBox cboKHOA;
        private System.Windows.Forms.ComboBox cboLOP;
        private System.Windows.Forms.RadioButton optNHAPMASV;
        private System.Windows.Forms.RadioButton optNHAPTEN;
        private System.Windows.Forms.RadioButton optNHAPMAKHOA;
        private System.Windows.Forms.RadioButton optNHAPMALOP;
        private System.Windows.Forms.ComboBox cboMAHE;
        private System.Windows.Forms.RadioButton optMAHE;
    }
}