
namespace ProductionStockCardSystem
{
    partial class StockReport
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
            this.stockdv = new System.Windows.Forms.DataGridView();
            this.btn_mat_srch = new System.Windows.Forms.Button();
            this.txt_mat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockdv)).BeginInit();
            this.SuspendLayout();
            // 
            // stockdv
            // 
            this.stockdv.AllowUserToAddRows = false;
            this.stockdv.AllowUserToDeleteRows = false;
            this.stockdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockdv.Location = new System.Drawing.Point(12, 61);
            this.stockdv.Name = "stockdv";
            this.stockdv.Size = new System.Drawing.Size(775, 425);
            this.stockdv.TabIndex = 0;
            // 
            // btn_mat_srch
            // 
            this.btn_mat_srch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mat_srch.Location = new System.Drawing.Point(228, 13);
            this.btn_mat_srch.Name = "btn_mat_srch";
            this.btn_mat_srch.Size = new System.Drawing.Size(146, 29);
            this.btn_mat_srch.TabIndex = 1;
            this.btn_mat_srch.Text = "Material Search";
            this.btn_mat_srch.UseVisualStyleBackColor = true;
            this.btn_mat_srch.Click += new System.EventHandler(this.btn_mat_srch_Click);
            // 
            // txt_mat
            // 
            this.txt_mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat.Location = new System.Drawing.Point(30, 16);
            this.txt_mat.Name = "txt_mat";
            this.txt_mat.Size = new System.Drawing.Size(192, 26);
            this.txt_mat.TabIndex = 2;
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.txt_mat);
            this.Controls.Add(this.btn_mat_srch);
            this.Controls.Add(this.stockdv);
            this.Name = "StockReport";
            this.Text = "StockReport";
            this.Load += new System.EventHandler(this.StockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockdv;
        private System.Windows.Forms.Button btn_mat_srch;
        private System.Windows.Forms.TextBox txt_mat;
    }
}