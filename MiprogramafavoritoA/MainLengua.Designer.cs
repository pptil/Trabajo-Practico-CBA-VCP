namespace VCPApp
{
    partial class MainLengua
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
            this.btnCigarra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCigarra
            // 
            this.btnCigarra.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCigarra.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCigarra.Location = new System.Drawing.Point(67, 171);
            this.btnCigarra.Name = "btnCigarra";
            this.btnCigarra.Size = new System.Drawing.Size(254, 56);
            this.btnCigarra.TabIndex = 0;
            this.btnCigarra.Text = "La Cigarra y la Hormiga";
            this.btnCigarra.UseVisualStyleBackColor = false;
            this.btnCigarra.Click += new System.EventHandler(this.btnCigarra_Click);
            // 
            // MainLengua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCigarra);
            this.Name = "MainLengua";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCigarra;
    }
}