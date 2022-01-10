
namespace ProductionStockCardSystem
{
    partial class MovementReport
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
            this.movement_Dv = new System.Windows.Forms.DataGridView();
            this.txt_date_from = new System.Windows.Forms.TextBox();
            this.lbl_date_to = new System.Windows.Forms.Label();
            this.lbl_Date_from = new System.Windows.Forms.Label();
            this.txt_date_to = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_material = new System.Windows.Forms.Label();
            this.txt_material = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.movement_Dv)).BeginInit();
            this.SuspendLayout();
            // 
            // movement_Dv
            // 
            this.movement_Dv.AllowUserToAddRows = false;
            this.movement_Dv.AllowUserToDeleteRows = false;
            this.movement_Dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movement_Dv.Location = new System.Drawing.Point(13, 64);
            this.movement_Dv.Name = "movement_Dv";
            this.movement_Dv.ReadOnly = true;
            this.movement_Dv.Size = new System.Drawing.Size(1056, 374);
            this.movement_Dv.TabIndex = 0;
            this.movement_Dv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.movement_Dv_CellFormatting);
            // 
            // txt_date_from
            // 
            this.txt_date_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date_from.Location = new System.Drawing.Point(131, 19);
            this.txt_date_from.Name = "txt_date_from";
            this.txt_date_from.Size = new System.Drawing.Size(149, 26);
            this.txt_date_from.TabIndex = 1;
            // 
            // lbl_date_to
            // 
            this.lbl_date_to.AutoSize = true;
            this.lbl_date_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_to.Location = new System.Drawing.Point(286, 19);
            this.lbl_date_to.Name = "lbl_date_to";
            this.lbl_date_to.Size = new System.Drawing.Size(83, 20);
            this.lbl_date_to.TabIndex = 2;
            this.lbl_date_to.Text = "Date To :";
            // 
            // lbl_Date_from
            // 
            this.lbl_Date_from.AutoSize = true;
            this.lbl_Date_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_from.Location = new System.Drawing.Point(21, 22);
            this.lbl_Date_from.Name = "lbl_Date_from";
            this.lbl_Date_from.Size = new System.Drawing.Size(104, 20);
            this.lbl_Date_from.TabIndex = 3;
            this.lbl_Date_from.Text = "Date From :";
            // 
            // txt_date_to
            // 
            this.txt_date_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date_to.Location = new System.Drawing.Point(375, 16);
            this.txt_date_to.Name = "txt_date_to";
            this.txt_date_to.Size = new System.Drawing.Size(143, 26);
            this.txt_date_to.TabIndex = 4;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(970, 14);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(99, 36);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_material
            // 
            this.lbl_material.AutoSize = true;
            this.lbl_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_material.Location = new System.Drawing.Point(541, 22);
            this.lbl_material.Name = "lbl_material";
            this.lbl_material.Size = new System.Drawing.Size(83, 20);
            this.lbl_material.TabIndex = 6;
            this.lbl_material.Text = "Material :";
            // 
            // txt_material
            // 
            this.txt_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_material.Location = new System.Drawing.Point(630, 24);
            this.txt_material.Name = "txt_material";
            this.txt_material.Size = new System.Drawing.Size(207, 26);
            this.txt_material.TabIndex = 7;
            // 
            // MovementReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.txt_material);
            this.Controls.Add(this.lbl_material);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_date_to);
            this.Controls.Add(this.lbl_Date_from);
            this.Controls.Add(this.lbl_date_to);
            this.Controls.Add(this.txt_date_from);
            this.Controls.Add(this.movement_Dv);
            this.Name = "MovementReport";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MovementReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movement_Dv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView movement_Dv;
        private System.Windows.Forms.TextBox txt_date_from;
        private System.Windows.Forms.Label lbl_date_to;
        private System.Windows.Forms.Label lbl_Date_from;
        private System.Windows.Forms.TextBox txt_date_to;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_material;
        private System.Windows.Forms.TextBox txt_material;
    }
}