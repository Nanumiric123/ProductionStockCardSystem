
namespace ProductionStockCardSystem
{
    partial class material_search
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
            this.lbl_mat_num = new System.Windows.Forms.Label();
            this.txt_mat_num = new System.Windows.Forms.TextBox();
            this.lbl_line = new System.Windows.Forms.Label();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.lbl_barcode = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.txt_bin_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_mat_num
            // 
            this.lbl_mat_num.AutoSize = true;
            this.lbl_mat_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mat_num.Location = new System.Drawing.Point(14, 79);
            this.lbl_mat_num.Name = "lbl_mat_num";
            this.lbl_mat_num.Size = new System.Drawing.Size(150, 20);
            this.lbl_mat_num.TabIndex = 0;
            this.lbl_mat_num.Text = "Material Number :";
            // 
            // txt_mat_num
            // 
            this.txt_mat_num.Enabled = false;
            this.txt_mat_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_num.Location = new System.Drawing.Point(170, 76);
            this.txt_mat_num.Name = "txt_mat_num";
            this.txt_mat_num.ReadOnly = true;
            this.txt_mat_num.Size = new System.Drawing.Size(219, 26);
            this.txt_mat_num.TabIndex = 1;
            this.txt_mat_num.TabStop = false;
            // 
            // lbl_line
            // 
            this.lbl_line.AutoSize = true;
            this.lbl_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_line.Location = new System.Drawing.Point(60, 127);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(104, 20);
            this.lbl_line.TabIndex = 2;
            this.lbl_line.Text = "Line S.Loc :";
            // 
            // txt_line
            // 
            this.txt_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_line.Location = new System.Drawing.Point(170, 124);
            this.txt_line.Name = "txt_line";
            this.txt_line.ReadOnly = true;
            this.txt_line.Size = new System.Drawing.Size(135, 26);
            this.txt_line.TabIndex = 3;
            this.txt_line.TabStop = false;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(170, 34);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(243, 26);
            this.txt_barcode.TabIndex = 4;
            this.txt_barcode.TabStop = false;
            this.txt_barcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.AutoSize = true;
            this.lbl_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barcode.Location = new System.Drawing.Point(41, 34);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(123, 20);
            this.lbl_barcode.TabIndex = 5;
            this.lbl_barcode.Text = "Kanban Card :";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.Location = new System.Drawing.Point(170, 218);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(100, 20);
            this.lbl_location.TabIndex = 6;
            this.lbl_location.Text = "lbl_location";
            this.lbl_location.Visible = false;
            // 
            // txt_bin_num
            // 
            this.txt_bin_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bin_num.Location = new System.Drawing.Point(170, 163);
            this.txt_bin_num.Name = "txt_bin_num";
            this.txt_bin_num.Size = new System.Drawing.Size(100, 26);
            this.txt_bin_num.TabIndex = 7;
            this.txt_bin_num.TabStop = false;
            this.txt_bin_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_bin_num_KeyDown);
            this.txt_bin_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bin_num_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bin Num :";
            // 
            // material_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_bin_num);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_barcode);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.txt_line);
            this.Controls.Add(this.lbl_line);
            this.Controls.Add(this.txt_mat_num);
            this.Controls.Add(this.lbl_mat_num);
            this.Name = "material_search";
            this.Text = "material_search";
            this.Activated += new System.EventHandler(this.material_search_Activated);
            this.Load += new System.EventHandler(this.material_search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mat_num;
        private System.Windows.Forms.TextBox txt_mat_num;
        private System.Windows.Forms.Label lbl_line;
        private System.Windows.Forms.TextBox txt_line;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label lbl_barcode;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.TextBox txt_bin_num;
        private System.Windows.Forms.Label label1;
    }
}