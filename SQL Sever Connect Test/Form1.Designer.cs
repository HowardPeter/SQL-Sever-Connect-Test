namespace SQL_Sever_Connect_Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnTongTien = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridKH1 = new System.Windows.Forms.DataGridView();
            this.dataGridThanhTien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThanhTien)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(333, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm KH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtID.Location = new System.Drawing.Point(333, 50);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 43);
            this.txtID.TabIndex = 1;
            // 
            // btnTongTien
            // 
            this.btnTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTongTien.Location = new System.Drawing.Point(12, 401);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.Size = new System.Drawing.Size(130, 46);
            this.btnTongTien.TabIndex = 2;
            this.btnTongTien.Text = "Tổng Tiền";
            this.btnTongTien.UseVisualStyleBackColor = true;
            this.btnTongTien.Click += new System.EventHandler(this.btnTongTien_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtName.Location = new System.Drawing.Point(333, 135);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 43);
            this.txtName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress.Location = new System.Drawing.Point(333, 237);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 43);
            this.txtAddress.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã khách hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(9, 700);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 46);
            this.button4.TabIndex = 10;
            this.button4.Text = "Bảng KH";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridKH1
            // 
            this.dataGridKH1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKH1.Location = new System.Drawing.Point(157, 700);
            this.dataGridKH1.Name = "dataGridKH1";
            this.dataGridKH1.RowHeadersWidth = 62;
            this.dataGridKH1.RowTemplate.Height = 28;
            this.dataGridKH1.Size = new System.Drawing.Size(631, 248);
            this.dataGridKH1.TabIndex = 11;
            this.dataGridKH1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridThanhTien
            // 
            this.dataGridThanhTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThanhTien.Location = new System.Drawing.Point(157, 401);
            this.dataGridThanhTien.Name = "dataGridThanhTien";
            this.dataGridThanhTien.RowHeadersWidth = 62;
            this.dataGridThanhTien.RowTemplate.Height = 28;
            this.dataGridThanhTien.Size = new System.Drawing.Size(631, 248);
            this.dataGridThanhTien.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 989);
            this.Controls.Add(this.dataGridThanhTien);
            this.Controls.Add(this.dataGridKH1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnTongTien);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThanhTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnTongTien;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridKH1;
        private System.Windows.Forms.DataGridView dataGridThanhTien;
    }
}

