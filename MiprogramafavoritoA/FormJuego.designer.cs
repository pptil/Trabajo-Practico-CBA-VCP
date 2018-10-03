namespace MiprogramafavoritoA
{
    partial class FormJuego
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
            this.groupBoxRes = new System.Windows.Forms.GroupBox();
            this.btnRespuesta = new System.Windows.Forms.Button();
            this.btnSonido = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBoxOp = new System.Windows.Forms.GroupBox();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.btnOpcion3 = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion4 = new System.Windows.Forms.Button();
            this.groupBoxRes.SuspendLayout();
            this.groupBoxOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRes
            // 
            this.groupBoxRes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRes.Controls.Add(this.btnRespuesta);
            this.groupBoxRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBoxRes.Location = new System.Drawing.Point(23, 21);
            this.groupBoxRes.Name = "groupBoxRes";
            this.groupBoxRes.Size = new System.Drawing.Size(227, 339);
            this.groupBoxRes.TabIndex = 33;
            this.groupBoxRes.TabStop = false;
            this.groupBoxRes.Visible = false;
            this.groupBoxRes.Enter += new System.EventHandler(this.groupBoxRes_Enter);
            // 
            // btnRespuesta
            // 
            this.btnRespuesta.Location = new System.Drawing.Point(0, 0);
            this.btnRespuesta.Name = "btnRespuesta";
            this.btnRespuesta.Size = new System.Drawing.Size(198, 202);
            this.btnRespuesta.TabIndex = 0;
            this.btnRespuesta.UseVisualStyleBackColor = true;
            this.btnRespuesta.Visible = false;
            this.btnRespuesta.Click += new System.EventHandler(this.btnRespuesta_Click);
            // 
            // btnSonido
            // 
            this.btnSonido.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.sound;
            this.btnSonido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSonido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSonido.Location = new System.Drawing.Point(23, 21);
            this.btnSonido.Name = "btnSonido";
            this.btnSonido.Size = new System.Drawing.Size(304, 148);
            this.btnSonido.TabIndex = 25;
            this.btnSonido.UseVisualStyleBackColor = true;
            this.btnSonido.Click += new System.EventHandler(this.btnSonido_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Atras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Location = new System.Drawing.Point(23, 586);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(157, 71);
            this.btnAtras.TabIndex = 34;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // groupBoxOp
            // 
            this.groupBoxOp.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxOp.Controls.Add(this.btnOpcion1);
            this.groupBoxOp.Controls.Add(this.btnOpcion3);
            this.groupBoxOp.Controls.Add(this.btnOpcion2);
            this.groupBoxOp.Controls.Add(this.btnOpcion4);
            this.groupBoxOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBoxOp.Location = new System.Drawing.Point(708, 21);
            this.groupBoxOp.Name = "groupBoxOp";
            this.groupBoxOp.Size = new System.Drawing.Size(555, 530);
            this.groupBoxOp.TabIndex = 32;
            this.groupBoxOp.TabStop = false;
            this.groupBoxOp.Text = "Animal";
            this.groupBoxOp.Visible = false;
            this.groupBoxOp.Enter += new System.EventHandler(this.groupBoxOp_Enter);
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpcion1.Location = new System.Drawing.Point(56, 74);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(151, 142);
            this.btnOpcion1.TabIndex = 19;
            this.btnOpcion1.UseVisualStyleBackColor = true;
            this.btnOpcion1.Click += new System.EventHandler(this.btnOpcion1_Click);
            // 
            // btnOpcion3
            // 
            this.btnOpcion3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpcion3.Location = new System.Drawing.Point(56, 344);
            this.btnOpcion3.Name = "btnOpcion3";
            this.btnOpcion3.Size = new System.Drawing.Size(151, 142);
            this.btnOpcion3.TabIndex = 20;
            this.btnOpcion3.UseVisualStyleBackColor = true;
            this.btnOpcion3.Click += new System.EventHandler(this.btnOpcion3_Click);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpcion2.Location = new System.Drawing.Point(345, 74);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(151, 142);
            this.btnOpcion2.TabIndex = 17;
            this.btnOpcion2.UseVisualStyleBackColor = true;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click);
            // 
            // btnOpcion4
            // 
            this.btnOpcion4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpcion4.Location = new System.Drawing.Point(345, 323);
            this.btnOpcion4.Name = "btnOpcion4";
            this.btnOpcion4.Size = new System.Drawing.Size(151, 142);
            this.btnOpcion4.TabIndex = 18;
            this.btnOpcion4.UseVisualStyleBackColor = true;
            this.btnOpcion4.Click += new System.EventHandler(this.btnOpcion4_Click);
            // 
            // FormJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiprogramafavoritoA.Properties.Resources.Fondo_2;
            this.ClientSize = new System.Drawing.Size(1348, 669);
            this.ControlBox = false;
            this.Controls.Add(this.btnSonido);
            this.Controls.Add(this.groupBoxRes);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.groupBoxOp);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJuego";
            this.Load += new System.EventHandler(this.FormJuego_Load);
            this.groupBoxRes.ResumeLayout(false);
            this.groupBoxOp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxRes;
        private System.Windows.Forms.Button btnRespuesta;
        private System.Windows.Forms.Button btnSonido;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox groupBoxOp;
        private System.Windows.Forms.Button btnOpcion3;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Button btnOpcion4;
        private System.Windows.Forms.Button btnOpcion2;
    }
}