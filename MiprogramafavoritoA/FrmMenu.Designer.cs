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
            this.BtnPrimaria = new System.Windows.Forms.Button();
            this.BtnJardin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPrimaria
            // 
            this.BtnPrimaria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPrimaria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPrimaria.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnPrimaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrimaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.BtnPrimaria.Image = global::MiprogramafavoritoA.Properties.Resources.Estudiante_Estudiando_60757;
            this.BtnPrimaria.Location = new System.Drawing.Point(689, -16);
            this.BtnPrimaria.Name = "BtnPrimaria";
            this.BtnPrimaria.Size = new System.Drawing.Size(684, 698);
            this.BtnPrimaria.TabIndex = 1;
            this.BtnPrimaria.Text = "PRIMARIO";
            this.BtnPrimaria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPrimaria.UseVisualStyleBackColor = false;
            this.BtnPrimaria.Click += new System.EventHandler(this.BtnPrimaria_Click);
            // 
            // BtnJardin
            // 
            this.BtnJardin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnJardin.AutoSize = true;
            this.BtnJardin.BackColor = System.Drawing.Color.Crimson;
            this.BtnJardin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnJardin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJardin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(184)))), ((int)(((byte)(254)))));
            this.BtnJardin.Image = global::MiprogramafavoritoA.Properties.Resources.niña_jardin;
            this.BtnJardin.Location = new System.Drawing.Point(-13, -16);
            this.BtnJardin.Name = "BtnJardin";
            this.BtnJardin.Size = new System.Drawing.Size(704, 698);
            this.BtnJardin.TabIndex = 0;
            this.BtnJardin.Text = "JARDIN";
            this.BtnJardin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnJardin.UseVisualStyleBackColor = false;
            this.BtnJardin.Click += new System.EventHandler(this.BtnJardin_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-13, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1386, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "SALIR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1364, 708);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnPrimaria);
            this.Controls.Add(this.BtnJardin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnJardin;
        private System.Windows.Forms.Button BtnPrimaria;
        private System.Windows.Forms.Button button1;
    }
}