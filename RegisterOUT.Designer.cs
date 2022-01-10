
namespace ProductionStockCardSystem
{
    partial class RegisterIOUT
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
            this.lbl_emp = new System.Windows.Forms.Label();
            this.lbl_bad_num = new System.Windows.Forms.Label();
            this.txt_badge_num = new System.Windows.Forms.TextBox();
            this.lbl_loc = new System.Windows.Forms.Label();
            this.btn_out = new System.Windows.Forms.Button();
            this.lbl_loc_desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw Material Stock Card Register OUT";
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
            this.txt_barcode.TabIndex = 2;
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
            this.txt_qty.ReadOnly = true;
            this.txt_qty.Size = new System.Drawing.Size(100, 26);
            this.txt_qty.TabIndex = 8;
            this.txt_qty.TabStop = false;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
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
            this.txt_bin_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_bin_num_KeyDown);
            // 
            // lbl_emp
            // 
            this.lbl_emp.AutoSize = true;
            this.lbl_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp.Location = new System.Drawing.Point(252, 210);
            this.lbl_emp.Name = "lbl_emp";
            this.lbl_emp.Size = new System.Drawing.Size(92, 20);
            this.lbl_emp.TabIndex = 16;
            this.lbl_emp.Text = "Employee ";
            // 
            // lbl_bad_num
            // 
            this.lbl_bad_num.AutoSize = true;
            this.lbl_bad_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bad_num.Location = new System.Drawing.Point(252, 231);
            this.lbl_bad_num.Name = "lbl_bad_num";
            this.lbl_bad_num.Size = new System.Drawing.Size(138, 20);
            this.lbl_bad_num.TabIndex = 17;
            this.lbl_bad_num.Text = "Badge Number :";
            // 
            // txt_badge_num
            // 
            this.txt_badge_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_badge_num.Location = new System.Drawing.Point(396, 227);
            this.txt_badge_num.Name = "txt_badge_num";
            this.txt_badge_num.ReadOnly = true;
            this.txt_badge_num.Size = new System.Drawing.Size(100, 26);
            this.txt_badge_num.TabIndex = 18;
            this.txt_badge_num.TabStop = false;
            this.txt_badge_num.TextChanged += new System.EventHandler(this.txt_badge_num_TextChanged);
            // 
            // lbl_loc
            // 
            this.lbl_loc.AutoSize = true;
            this.lbl_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loc.Location = new System.Drawing.Point(138, 257);
            this.lbl_loc.Name = "lbl_loc";
            this.lbl_loc.Size = new System.Drawing.Size(106, 20);
            this.lbl_loc.TabIndex = 19;
            this.lbl_loc.Text = "Lbl_location";
            this.lbl_loc.Visible = false;
            // 
            // btn_out
            // 
            this.btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_out.Location = new System.Drawing.Point(215, 295);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(129, 40);
            this.btn_out.TabIndex = 20;
            this.btn_out.TabStop = false;
            this.btn_out.Text = "Register Out";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // lbl_loc_desc
            // 
            this.lbl_loc_desc.AutoSize = true;
            this.lbl_loc_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loc_desc.Location = new System.Drawing.Point(12, 257);
            this.lbl_loc_desc.Name = "lbl_loc_desc";
            this.lbl_loc_desc.Size = new System.Drawing.Size(131, 20);
            this.lbl_loc_desc.TabIndex = 21;
            this.lbl_loc_desc.Text = "Rack Address :";
            // 
            // RegisterIOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 347);
            this.Controls.Add(this.lbl_loc_desc);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.lbl_loc);
            this.Controls.Add(this.txt_badge_num);
            this.Controls.Add(this.lbl_bad_num);
            this.Controls.Add(this.lbl_emp);
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
            this.Name = "RegisterIOUT";
            this.Text = "RegisterIN";
            this.Activated += new System.EventHandler(this.RegisterIOUT_Activated);
            this.Load += new System.EventHandler(this.RegisterIOUT_Load);
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
        private System.Windows.Forms.Label lbl_emp;
        private System.Windows.Forms.Label lbl_bad_num;
        private System.Windows.Forms.TextBox txt_badge_num;
        private System.Windows.Forms.Label lbl_loc;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label lbl_loc_desc;
    }
}