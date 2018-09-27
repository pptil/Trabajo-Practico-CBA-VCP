namespace MiprogramafavoritoA
{
    partial class FrmMenu
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
            this.BtnJardin = new System.Windows.Forms.Button();
            this.BtnPrimaria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnJardin
            // 
            this.BtnJardin.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BtnJardin.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJardin.Location = new System.Drawing.Point(2, 171);
            this.BtnJardin.Name = "BtnJardin";
            this.BtnJardin.Size = new System.Drawing.Size(405, 280);
            this.BtnJardin.TabIndex = 0;
            this.BtnJardin.Text = "NIVEL INICIAL";
            this.BtnJardin.UseVisualStyleBackColor = false;
            this.BtnJardin.Click += new System.EventHandler(this.BtnJardin_Click);
            // 
            // BtnPrimaria
            // 
            this.BtnPrimaria.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnPrimaria.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimaria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnPrimaria.Location = new System.Drawing.Point(407, 171);
            this.BtnPrimaria.Name = "BtnPrimaria";
            this.BtnPrimaria.Size = new System.Drawing.Size(400, 280);
            this.BtnPrimaria.TabIndex = 1;
            this.BtnPrimaria.Text = "NIVEL PRIMARIO";
            this.BtnPrimaria.UseVisualStyleBackColor = false;
            this.BtnPrimaria.Click += new System.EventHandler(this.BtnPrimaria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(191, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "MI PROGRAMA FAVORITO";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPrimaria);
            this.Controls.Add(this.BtnJardin);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnJardin;
        private System.Windows.Forms.Button BtnPrimaria;
        private System.Windows.Forms.Label label1;
    }
}