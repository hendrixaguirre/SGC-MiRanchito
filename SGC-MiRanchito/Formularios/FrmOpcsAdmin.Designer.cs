namespace SGC_MiRanchito.Formularios
{
    partial class FrmOpcsAdmin
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
            this.btnGraficos = new System.Windows.Forms.Button();
            this.btnRespuestas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qué deseas ver?";
            // 
            // btnGraficos
            // 
            this.btnGraficos.Location = new System.Drawing.Point(121, 268);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(164, 91);
            this.btnGraficos.TabIndex = 1;
            this.btnGraficos.Text = "Gráficos";
            this.btnGraficos.UseVisualStyleBackColor = true;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // btnRespuestas
            // 
            this.btnRespuestas.Location = new System.Drawing.Point(121, 136);
            this.btnRespuestas.Name = "btnRespuestas";
            this.btnRespuestas.Size = new System.Drawing.Size(164, 91);
            this.btnRespuestas.TabIndex = 2;
            this.btnRespuestas.Text = "Respuestas";
            this.btnRespuestas.UseVisualStyleBackColor = true;
            this.btnRespuestas.Click += new System.EventHandler(this.btnRespuestas_Click);
            // 
            // FrmOpcsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.btnRespuestas);
            this.Controls.Add(this.btnGraficos);
            this.Controls.Add(this.label1);
            this.Name = "FrmOpcsAdmin";
            this.Text = "FrmOpcsAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Button btnRespuestas;
    }
}