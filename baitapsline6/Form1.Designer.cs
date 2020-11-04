namespace baitapsline6
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
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xem
            // 
            this.btn_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.Location = new System.Drawing.Point(41, 347);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(87, 38);
            this.btn_xem.TabIndex = 0;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(242, 346);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(91, 39);
            this.btn_xoa.TabIndex = 0;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(134, 347);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(102, 38);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(339, 346);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 39);
            this.btn_sua.TabIndex = 0;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.Location = new System.Drawing.Point(461, 358);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(200, 27);
            this.txt_tim.TabIndex = 1;
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(683, 347);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(89, 39);
            this.btn_tim.TabIndex = 2;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmb.Location = new System.Drawing.Point(242, 406);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(150, 28);
            this.cmb.TabIndex = 3;
            this.cmb.Text = "True";
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "";
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(461, 406);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 27);
            this.dtp.TabIndex = 4;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(41, 26);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(739, 300);
            this.dgv.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 487);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_xem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DataGridView dgv;
    }
}

