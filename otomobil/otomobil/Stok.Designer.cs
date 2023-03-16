namespace otomobil
{
    partial class Stok
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.STK_MKYJ = new System.Windows.Forms.Button();
            this.STK_MTR = new System.Windows.Forms.Button();
            this.STK_KPRT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 52);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(435, 227);
            this.dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "LÜTFEN STOK MİKTARINA GÖRE SEPETE EKLEME YAPINIZ!";
            // 
            // STK_MKYJ
            // 
            this.STK_MKYJ.Location = new System.Drawing.Point(12, 285);
            this.STK_MKYJ.Name = "STK_MKYJ";
            this.STK_MKYJ.Size = new System.Drawing.Size(130, 36);
            this.STK_MKYJ.TabIndex = 2;
            this.STK_MKYJ.Text = "STOK MAKYAJ";
            this.STK_MKYJ.UseVisualStyleBackColor = true;
            this.STK_MKYJ.Click += new System.EventHandler(this.STK_MKYJ_Click);
            // 
            // STK_MTR
            // 
            this.STK_MTR.Location = new System.Drawing.Point(148, 285);
            this.STK_MTR.Name = "STK_MTR";
            this.STK_MTR.Size = new System.Drawing.Size(141, 37);
            this.STK_MTR.TabIndex = 3;
            this.STK_MTR.Text = "STOK MOTOR";
            this.STK_MTR.UseVisualStyleBackColor = true;
            this.STK_MTR.Click += new System.EventHandler(this.STK_MTR_Click);
            // 
            // STK_KPRT
            // 
            this.STK_KPRT.Location = new System.Drawing.Point(295, 285);
            this.STK_KPRT.Name = "STK_KPRT";
            this.STK_KPRT.Size = new System.Drawing.Size(152, 36);
            this.STK_KPRT.TabIndex = 4;
            this.STK_KPRT.Text = "STOK KAPORTA";
            this.STK_KPRT.UseVisualStyleBackColor = true;
            this.STK_KPRT.Click += new System.EventHandler(this.STK_KPRT_Click);
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 334);
            this.Controls.Add(this.STK_KPRT);
            this.Controls.Add(this.STK_MTR);
            this.Controls.Add(this.STK_MKYJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Stok";
            this.Text = "Stok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button STK_MKYJ;
        private System.Windows.Forms.Button STK_MTR;
        private System.Windows.Forms.Button STK_KPRT;
    }
}