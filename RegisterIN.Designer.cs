
namespace ProductionStockCardSystem
{
    partial class RegisterIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_kanban = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.lbl_part_num = new System.Windows.Forms.Label();
            this.txt_material = new System.Windows.Forms.TextBox();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.lbl_line = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_bin_num = new System.Windows.Forms.Label();
            this.txt_bin_num = new System.Windows.Forms.TextBox();
            this.lbl_rack_Add = new System.Windows.Forms.Label();
            this.lbl_rack = new System.Windows.Forms.Label();
            this.lbl_layer = new System.Windows.Forms.Label();
            this.lbl_emp = new System.Windows.Forms.Label();
            this.lbl_bad_num = new System.Windows.Forms.Label();
            this.txt_badge_num = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.ck_A = new System.Windows.Forms.CheckBox();
            this.ck_B = new System.Windows.Forms.CheckBox();
            this.ck_C = new System.Windows.Forms.CheckBox();
            this.ck_D = new System.Windows.Forms.CheckBox();
            this.CK_1 = new System.Windows.Forms.CheckBox();
            this.CK_2 = new System.Windows.Forms.CheckBox();
            this.CK_3 = new System.Windows.Forms.CheckBox();
            this.CK_5 = new System.Windows.Forms.CheckBox();
            this.CK_4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw Material Stock Card Register IN";
            // 
            // lbl_kanban
            // 
            this.lbl_kanban.AutoSize = true;
            this.lbl_kanban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kanban.Location = new System.Drawing.Point(12, 62);
            this.lbl_kanban.Name = "lbl_kanban";
            this.lbl_kanban.Size = new System.Drawing.Size(123, 20);
            this.lbl_kanban.TabIndex = 1;
            this.lbl_kanban.Text = "Kanban Card :";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(142, 63);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(231, 26);
            this.txt_barcode.TabIndex = 1;
            this.txt_barcode.TabStop = false;
            this.txt_barcode.TextChanged += new System.EventHandler(this.txt_barcode_TextChanged);
            this.txt_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_barcode_KeyDown);
            // 
            // lbl_part_num
            // 
            this.lbl_part_num.AutoSize = true;
            this.lbl_part_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_part_num.Location = new System.Drawing.Point(52, 114);
            this.lbl_part_num.Name = "lbl_part_num";
            this.lbl_part_num.Size = new System.Drawing.Size(83, 20);
            this.lbl_part_num.TabIndex = 3;
            this.lbl_part_num.Text = "Material :";
            // 
            // txt_material
            // 
            this.txt_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_material.Location = new System.Drawing.Point(142, 114);
            this.txt_material.Name = "txt_material";
            this.txt_material.ReadOnly = true;
            this.txt_material.Size = new System.Drawing.Size(160, 26);
            this.txt_material.TabIndex = 4;
            this.txt_material.TabStop = false;
            // 
            // txt_line
            // 
            this.txt_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_line.Location = new System.Drawing.Point(396, 114);
            this.txt_line.Name = "txt_line";
            this.txt_line.ReadOnly = true;
            this.txt_line.Size = new System.Drawing.Size(121, 26);
            this.txt_line.TabIndex = 5;
            this.txt_line.TabStop = false;
            // 
            // lbl_line
            // 
            this.lbl_line.AutoSize = true;
            this.lbl_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_line.Location = new System.Drawing.Point(337, 114);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(53, 20);
            this.lbl_line.TabIndex = 6;
            this.lbl_line.Text = "Line :";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(49, 174);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(86, 20);
            this.lbl_qty.TabIndex = 7;
            this.lbl_qty.Text = "Quantity :";
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(142, 173);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(100, 26);
            this.txt_qty.TabIndex = 8;
            this.txt_qty.TabStop = false;
            this.txt_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_qty_KeyDown);
            // 
            // lbl_bin_num
            // 
            this.lbl_bin_num.AutoSize = true;
            this.lbl_bin_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bin_num.Location = new System.Drawing.Point(278, 176);
            this.lbl_bin_num.Name = "lbl_bin_num";
            this.lbl_bin_num.Size = new System.Drawing.Size(112, 20);
            this.lbl_bin_num.TabIndex = 9;
            this.lbl_bin_num.Text = "Bin Number :";
            // 
            // txt_bin_num
            // 
            this.txt_bin_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bin_num.Location = new System.Drawing.Point(396, 173);
            this.txt_bin_num.Name = "txt_bin_num";
            this.txt_bin_num.Size = new System.Drawing.Size(121, 26);
            this.txt_bin_num.TabIndex = 10;
            this.txt_bin_num.TabStop = false;
            this.txt_bin_num.TextChanged += new System.EventHandler(this.txt_bin_num_TextChanged);
            this.txt_bin_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_bin_num_KeyDown);
            // 
            // lbl_rack_Add
            // 
            this.lbl_rack_Add.AutoSize = true;
            this.lbl_rack_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rack_Add.Location = new System.Drawing.Point(5, 250);
            this.lbl_rack_Add.Name = "lbl_rack_Add";
            this.lbl_rack_Add.Size = new System.Drawing.Size(131, 20);
            this.lbl_rack_Add.TabIndex = 11;
            this.lbl_rack_Add.Text = "Rack Address :";
            // 
            // lbl_rack
            // 
            this.lbl_rack.AutoSize = true;
            this.lbl_rack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rack.Location = new System.Drawing.Point(146, 220);
            this.lbl_rack.Name = "lbl_rack";
            this.lbl_rack.Size = new System.Drawing.Size(46, 20);
            this.lbl_rack.TabIndex = 13;
            this.lbl_rack.Text = "Rack";
            // 
            // lbl_layer
            // 
            this.lbl_layer.AutoSize = true;
            this.lbl_layer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_layer.Location = new System.Drawing.Point(221, 220);
            this.lbl_layer.Name = "lbl_layer";
            this.lbl_layer.Size = new System.Drawing.Size(48, 20);
            this.lbl_layer.TabIndex = 15;
            this.lbl_layer.Text = "Layer";
            // 
            // lbl_emp
            // 
            this.lbl_emp.AutoSize = true;
            this.lbl_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp.Location = new System.Drawing.Point(282, 250);
            this.lbl_emp.Name = "lbl_emp";
            this.lbl_emp.Size = new System.Drawing.Size(92, 20);
            this.lbl_emp.TabIndex = 16;
            this.lbl_emp.Text = "Employee ";
            // 
            // lbl_bad_num
            // 
            this.lbl_bad_num.AutoSize = true;
            this.lbl_bad_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bad_num.Location = new System.Drawing.Point(282, 270);
            this.lbl_bad_num.Name = "lbl_bad_num";
            this.lbl_bad_num.Size = new System.Drawing.Size(138, 20);
            this.lbl_bad_num.TabIndex = 17;
            this.lbl_bad_num.Text = "Badge Number :";
            // 
            // txt_badge_num
            // 
            this.txt_badge_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_badge_num.Location = new System.Drawing.Point(426, 269);
            this.txt_badge_num.Name = "txt_badge_num";
            this.txt_badge_num.Size = new System.Drawing.Size(100, 26);
            this.txt_badge_num.TabIndex = 18;
            this.txt_badge_num.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(225, 409);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(117, 43);
            this.btn_save.TabIndex = 19;
            this.btn_save.TabStop = false;
            this.btn_save.Text = "Register IN";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ck_A
            // 
            this.ck_A.AutoSize = true;
            this.ck_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_A.Location = new System.Drawing.Point(150, 249);
            this.ck_A.Name = "ck_A";
            this.ck_A.Size = new System.Drawing.Size(40, 24);
            this.ck_A.TabIndex = 20;
            this.ck_A.TabStop = false;
            this.ck_A.Text = "A";
            this.ck_A.UseVisualStyleBackColor = true;
            this.ck_A.CheckedChanged += new System.EventHandler(this.ck_A_CheckedChanged);
            this.ck_A.CheckStateChanged += new System.EventHandler(this.ck_A_CheckStateChanged);
            this.ck_A.Click += new System.EventHandler(this.ck_A_Click);
            // 
            // ck_B
            // 
            this.ck_B.AutoSize = true;
            this.ck_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_B.Location = new System.Drawing.Point(150, 280);
            this.ck_B.Name = "ck_B";
            this.ck_B.Size = new System.Drawing.Size(40, 24);
            this.ck_B.TabIndex = 21;
            this.ck_B.TabStop = false;
            this.ck_B.Text = "B";
            this.ck_B.UseVisualStyleBackColor = true;
            this.ck_B.CheckedChanged += new System.EventHandler(this.ck_B_CheckedChanged);
            this.ck_B.CheckStateChanged += new System.EventHandler(this.ck_B_CheckStateChanged);
            this.ck_B.Click += new System.EventHandler(this.ck_B_Click);
            // 
            // ck_C
            // 
            this.ck_C.AutoSize = true;
            this.ck_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_C.Location = new System.Drawing.Point(150, 311);
            this.ck_C.Name = "ck_C";
            this.ck_C.Size = new System.Drawing.Size(40, 24);
            this.ck_C.TabIndex = 22;
            this.ck_C.TabStop = false;
            this.ck_C.Text = "C";
            this.ck_C.UseVisualStyleBackColor = true;
            this.ck_C.CheckedChanged += new System.EventHandler(this.ck_C_CheckedChanged);
            this.ck_C.CheckStateChanged += new System.EventHandler(this.ck_C_CheckStateChanged);
            this.ck_C.Click += new System.EventHandler(this.ck_C_Click);
            // 
            // ck_D
            // 
            this.ck_D.AutoSize = true;
            this.ck_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_D.Location = new System.Drawing.Point(150, 341);
            this.ck_D.Name = "ck_D";
            this.ck_D.Size = new System.Drawing.Size(41, 24);
            this.ck_D.TabIndex = 23;
            this.ck_D.TabStop = false;
            this.ck_D.Text = "D";
            this.ck_D.UseVisualStyleBackColor = true;
            this.ck_D.CheckedChanged += new System.EventHandler(this.ck_D_CheckedChanged);
            this.ck_D.CheckStateChanged += new System.EventHandler(this.ck_D_CheckStateChanged);
            this.ck_D.Click += new System.EventHandler(this.ck_D_Click);
            // 
            // CK_1
            // 
            this.CK_1.AutoSize = true;
            this.CK_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK_1.Location = new System.Drawing.Point(225, 249);
            this.CK_1.Name = "CK_1";
            this.CK_1.Size = new System.Drawing.Size(38, 24);
            this.CK_1.TabIndex = 24;
            this.CK_1.TabStop = false;
            this.CK_1.Text = "1";
            this.CK_1.UseVisualStyleBackColor = true;
            this.CK_1.Click += new System.EventHandler(this.CK_1_Click);
            // 
            // CK_2
            // 
            this.CK_2.AutoSize = true;
            this.CK_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK_2.Location = new System.Drawing.Point(225, 280);
            this.CK_2.Name = "CK_2";
            this.CK_2.Size = new System.Drawing.Size(38, 24);
            this.CK_2.TabIndex = 25;
            this.CK_2.TabStop = false;
            this.CK_2.Text = "2";
            this.CK_2.UseVisualStyleBackColor = true;
            this.CK_2.CheckedChanged += new System.EventHandler(this.CK_2_CheckedChanged);
            this.CK_2.Click += new System.EventHandler(this.CK_2_Click);
            // 
            // CK_3
            // 
            this.CK_3.AutoSize = true;
            this.CK_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK_3.Location = new System.Drawing.Point(225, 311);
            this.CK_3.Name = "CK_3";
            this.CK_3.Size = new System.Drawing.Size(38, 24);
            this.CK_3.TabIndex = 26;
            this.CK_3.TabStop = false;
            this.CK_3.Text = "3";
            this.CK_3.UseVisualStyleBackColor = true;
            this.CK_3.Click += new System.EventHandler(this.CK_3_Click);
            // 
            // CK_5
            // 
            this.CK_5.AutoSize = true;
            this.CK_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK_5.Location = new System.Drawing.Point(225, 370);
            this.CK_5.Name = "CK_5";
            this.CK_5.Size = new System.Drawing.Size(38, 24);
            this.CK_5.TabIndex = 27;
            this.CK_5.TabStop = false;
            this.CK_5.Text = "5";
            this.CK_5.UseVisualStyleBackColor = true;
            this.CK_5.Click += new System.EventHandler(this.CK_5_Click);
            // 
            // CK_4
            // 
            this.CK_4.AutoSize = true;
            this.CK_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK_4.Location = new System.Drawing.Point(225, 341);
            this.CK_4.Name = "CK_4";
            this.CK_4.Size = new System.Drawing.Size(38, 24);
            this.CK_4.TabIndex = 28;
            this.CK_4.TabStop = false;
            this.CK_4.Text = "4";
            this.CK_4.UseVisualStyleBackColor = true;
            this.CK_4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.CK_4.Click += new System.EventHandler(this.CK_4_Click);
            // 
            // RegisterIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 464);
            this.Controls.Add(this.CK_4);
            this.Controls.Add(this.CK_5);
            this.Controls.Add(this.CK_3);
            this.Controls.Add(this.CK_2);
            this.Controls.Add(this.CK_1);
            this.Controls.Add(this.ck_D);
            this.Controls.Add(this.ck_C);
            this.Controls.Add(this.ck_B);
            this.Controls.Add(this.ck_A);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_badge_num);
            this.Controls.Add(this.lbl_bad_num);
            this.Controls.Add(this.lbl_emp);
            this.Controls.Add(this.lbl_layer);
            this.Controls.Add(this.lbl_rack);
            this.Controls.Add(this.lbl_rack_Add);
            this.Controls.Add(this.txt_bin_num);
            this.Controls.Add(this.lbl_bin_num);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_line);
            this.Controls.Add(this.txt_line);
            this.Controls.Add(this.txt_material);
            this.Controls.Add(this.lbl_part_num);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.lbl_kanban);
            this.Controls.Add(this.label1);
            this.Name = "RegisterIN";
            this.Text = "RegisterIN";
            this.Activated += new System.EventHandler(this.RegisterIN_Activated);
            this.Load += new System.EventHandler(this.RegisterIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_kanban;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label lbl_part_num;
        private System.Windows.Forms.TextBox txt_material;
        private System.Windows.Forms.TextBox txt_line;
        private System.Windows.Forms.Label lbl_line;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label lbl_bin_num;
        private System.Windows.Forms.TextBox txt_bin_num;
        private System.Windows.Forms.Label lbl_rack_Add;
        private System.Windows.Forms.Label lbl_rack;
        private System.Windows.Forms.Label lbl_layer;
        private System.Windows.Forms.Label lbl_emp;
        private System.Windows.Forms.Label lbl_bad_num;
        private System.Windows.Forms.TextBox txt_badge_num;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox ck_A;
        private System.Windows.Forms.CheckBox ck_B;
        private System.Windows.Forms.CheckBox ck_C;
        private System.Windows.Forms.CheckBox ck_D;
        private System.Windows.Forms.CheckBox CK_1;
        private System.Windows.Forms.CheckBox CK_2;
        private System.Windows.Forms.CheckBox CK_3;
        private System.Windows.Forms.CheckBox CK_5;
        private System.Windows.Forms.CheckBox CK_4;
    }
}