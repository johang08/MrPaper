namespace MrPaper.UI.Consultas
{
    partial class cProductos
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
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.ConsultaBuscarbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS REGISTRADOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.AllowUserToOrderColumns = true;
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(38, 89);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.Size = new System.Drawing.Size(447, 176);
            this.ConsultaDataGridView.TabIndex = 1;
            // 
            // ConsultaBuscarbutton
            // 
            this.ConsultaBuscarbutton.Location = new System.Drawing.Point(341, 30);
            this.ConsultaBuscarbutton.Name = "ConsultaBuscarbutton";
            this.ConsultaBuscarbutton.Size = new System.Drawing.Size(127, 40);
            this.ConsultaBuscarbutton.TabIndex = 2;
            this.ConsultaBuscarbutton.Text = "Buscar";
            this.ConsultaBuscarbutton.UseVisualStyleBackColor = true;
            this.ConsultaBuscarbutton.Click += new System.EventHandler(this.ConsultaBuscarbutton_Click);
            // 
            // cProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 317);
            this.Controls.Add(this.ConsultaBuscarbutton);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "cProductos";
            this.Text = "cProductos";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.Button ConsultaBuscarbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}