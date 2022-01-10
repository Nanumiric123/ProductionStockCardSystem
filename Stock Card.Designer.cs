
namespace ProductionStockCardSystem
{
    partial class stock_card
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
            this.b_material_search = new System.Windows.Forms.Button();
            this.b_in_reg = new System.Windows.Forms.Button();
            this.b_reg_OUT = new System.Windows.Forms.Button();
            this.b_mat_report = new System.Windows.Forms.Button();
            this.b_mat_mvt_rep = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw Material Rest Rack Stock Card";
            // 
            // b_material_search
            // 
            this.b_material_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_material_search.Location = new System.Drawing.Point(95, 80);
            this.b_material_search.Name = "b_material_search";
            this.b_material_search.Size = new System.Drawing.Size(287, 48);
            this.b_material_search.TabIndex = 1;
            this.b_material_search.Text = "Material Searching";
            this.b_material_search.UseVisualStyleBackColor = true;
            this.b_material_search.Click += new System.EventHandler(this.b_material_search_Click);
            // 
            // b_in_reg
            // 
            this.b_in_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_in_reg.Location = new System.Drawing.Point(95, 154);
            this.b_in_reg.Name = "b_in_reg";
            this.b_in_reg.Size = new System.Drawing.Size(287, 48);
            this.b_in_reg.TabIndex = 2;
            this.b_in_reg.Text = "Register IN";
            this.b_in_reg.UseVisualStyleBackColor = true;
            this.b_in_reg.Click += new System.EventHandler(this.b_in_reg_Click);
            // 
            // b_reg_OUT
            // 
            this.b_reg_OUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_reg_OUT.Location = new System.Drawing.Point(95, 227);
            this.b_reg_OUT.Name = "b_reg_OUT";
            this.b_reg_OUT.Size = new System.Drawing.Size(287, 48);
            this.b_reg_OUT.TabIndex = 3;
            this.b_reg_OUT.Text = "Register OUT";
            this.b_reg_OUT.UseVisualStyleBackColor = true;
            this.b_reg_OUT.Click += new System.EventHandler(this.b_reg_OUT_Click);
            // 
            // b_mat_report
            // 
            this.b_mat_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_mat_report.Location = new System.Drawing.Point(95, 298);
            this.b_mat_report.Name = "b_mat_report";
            this.b_mat_report.Size = new System.Drawing.Size(287, 48);
            this.b_mat_report.TabIndex = 4;
            this.b_mat_report.Text = "Material Stock Report";
            this.b_mat_report.UseVisualStyleBackColor = true;
            this.b_mat_report.Click += new System.EventHandler(this.b_mat_report_Click);
            // 
            // b_mat_mvt_rep
            // 
            this.b_mat_mvt_rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_mat_mvt_rep.Location = new System.Drawing.Point(95, 373);
            this.b_mat_mvt_rep.Name = "b_mat_mvt_rep";
            this.b_mat_mvt_rep.Size = new System.Drawing.Size(287, 48);
            this.b_mat_mvt_rep.TabIndex = 5;
            this.b_mat_mvt_rep.Text = "Material Movement Report";
            this.b_mat_mvt_rep.UseVisualStyleBackColor = true;
            this.b_mat_mvt_rep.Click += new System.EventHandler(this.b_mat_mvt_rep_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProductionStockCardSystem.Properties.Resources.Stock_Card;
            this.pictureBox1.Location = new System.Drawing.Point(441, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 253);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // stock_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_mat_mvt_rep);
            this.Controls.Add(this.b_mat_report);
            this.Controls.Add(this.b_reg_OUT);
            this.Controls.Add(this.b_in_reg);
            this.Controls.Add(this.b_material_search);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "stock_card";
            this.Text = "Stock Card";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_material_search;
        private System.Windows.Forms.Button b_in_reg;
        private System.Windows.Forms.Button b_reg_OUT;
        private System.Windows.Forms.Button b_mat_report;
        private System.Windows.Forms.Button b_mat_mvt_rep;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

