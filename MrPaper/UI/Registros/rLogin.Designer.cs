namespace MrPaper.UI.Registros
{
    partial class rLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.LoginUserTextBox = new System.Windows.Forms.TextBox();
            this.LoginContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.LogInicioButton = new System.Windows.Forms.Button();
            this.LogCancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // LoginUserTextBox
            // 
            this.LoginUserTextBox.Location = new System.Drawing.Point(124, 41);
            this.LoginUserTextBox.Name = "LoginUserTextBox";
            this.LoginUserTextBox.Size = new System.Drawing.Size(128, 20);
            this.LoginUserTextBox.TabIndex = 2;
            // 
            // LoginContraseñaTextBox
            // 
            this.LoginContraseñaTextBox.Location = new System.Drawing.Point(124, 74);
            this.LoginContraseñaTextBox.Name = "LoginContraseñaTextBox";
            this.LoginContraseñaTextBox.Size = new System.Drawing.Size(128, 20);
            this.LoginContraseñaTextBox.TabIndex = 3;
            // 
            // LogInicioButton
            // 
            this.LogInicioButton.BackgroundImage = global::MrPaper.Properties.Resources._160_F_39116629_AWc7QbKIEKbfkDdbkTH6HICZBBZg6Q67;
            this.LogInicioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInicioButton.Location = new System.Drawing.Point(110, 121);
            this.LogInicioButton.Name = "LogInicioButton";
            this.LogInicioButton.Size = new System.Drawing.Size(68, 56);
            this.LogInicioButton.TabIndex = 4;
            this.LogInicioButton.UseVisualStyleBackColor = true;
            this.LogInicioButton.Click += new System.EventHandler(this.LogInicioButton_Click);
            // 
            // LogCancelarButton
            // 
            this.LogCancelarButton.BackgroundImage = global::MrPaper.Properties.Resources.icons8_Delete_35px;
            this.LogCancelarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogCancelarButton.Location = new System.Drawing.Point(184, 121);
            this.LogCancelarButton.Name = "LogCancelarButton";
            this.LogCancelarButton.Size = new System.Drawing.Size(68, 56);
            this.LogCancelarButton.TabIndex = 5;
            this.LogCancelarButton.UseVisualStyleBackColor = true;
            this.LogCancelarButton.Click += new System.EventHandler(this.LogCancelarButton_Click);
            // 
            // rLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MrPaper.Properties.Resources.Sin_título_12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(288, 215);
            this.Controls.Add(this.LogCancelarButton);
            this.Controls.Add(this.LogInicioButton);
            this.Controls.Add(this.LoginContraseñaTextBox);
            this.Controls.Add(this.LoginUserTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "rLogin";
            this.Text = "Login de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginUserTextBox;
        private System.Windows.Forms.TextBox LoginContraseñaTextBox;
        private System.Windows.Forms.Button LogInicioButton;
        private System.Windows.Forms.Button LogCancelarButton;
    }
}