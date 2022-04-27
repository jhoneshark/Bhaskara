namespace Calcular_Bhaskara
{
    partial class Bhaskara
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bhaskara));
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textC = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbDelta = new System.Windows.Forms.Label();
            this.lbXP = new System.Windows.Forms.Label();
            this.lbXN = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textA
            // 
            this.textA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textA.Location = new System.Drawing.Point(210, 94);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(100, 26);
            this.textA.TabIndex = 0;
            // 
            // textB
            // 
            this.textB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB.Location = new System.Drawing.Point(383, 94);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 26);
            this.textB.TabIndex = 1;
            // 
            // textC
            // 
            this.textC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textC.Location = new System.Drawing.Point(567, 94);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(100, 26);
            this.textC.TabIndex = 2;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(229, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(321, 63);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "BHASKARA";
            // 
            // lbDelta
            // 
            this.lbDelta.AutoSize = true;
            this.lbDelta.BackColor = System.Drawing.Color.Silver;
            this.lbDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDelta.Location = new System.Drawing.Point(36, 272);
            this.lbDelta.Name = "lbDelta";
            this.lbDelta.Size = new System.Drawing.Size(47, 20);
            this.lbDelta.TabIndex = 4;
            this.lbDelta.Text = "Delta";
            this.lbDelta.Visible = false;
            this.lbDelta.Click += new System.EventHandler(this.lbDelta_Click);
            // 
            // lbXP
            // 
            this.lbXP.AutoSize = true;
            this.lbXP.BackColor = System.Drawing.Color.Silver;
            this.lbXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbXP.Location = new System.Drawing.Point(36, 344);
            this.lbXP.Name = "lbXP";
            this.lbXP.Size = new System.Drawing.Size(20, 20);
            this.lbXP.TabIndex = 5;
            this.lbXP.Text = "X";
            this.lbXP.Visible = false;
            this.lbXP.Click += new System.EventHandler(this.lbXP_Click);
            // 
            // lbXN
            // 
            this.lbXN.AutoSize = true;
            this.lbXN.BackColor = System.Drawing.Color.Silver;
            this.lbXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbXN.Location = new System.Drawing.Point(36, 416);
            this.lbXN.Name = "lbXN";
            this.lbXN.Size = new System.Drawing.Size(25, 20);
            this.lbXN.TabIndex = 6;
            this.lbXN.Text = "X²";
            this.lbXN.Visible = false;
            this.lbXN.Click += new System.EventHandler(this.lbXN_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Black;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.Color.White;
            this.btCalcular.Location = new System.Drawing.Point(586, 378);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(202, 60);
            this.btCalcular.TabIndex = 7;
            this.btCalcular.Text = "CALCULAR";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Informe valor A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(500, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor C";
            // 
            // lbLimpar
            // 
            this.lbLimpar.BackColor = System.Drawing.Color.Lime;
            this.lbLimpar.Location = new System.Drawing.Point(713, 349);
            this.lbLimpar.Name = "lbLimpar";
            this.lbLimpar.Size = new System.Drawing.Size(75, 23);
            this.lbLimpar.TabIndex = 11;
            this.lbLimpar.Text = "Limpar";
            this.lbLimpar.UseVisualStyleBackColor = false;
            this.lbLimpar.Click += new System.EventHandler(this.lbLimpar_Click);
            // 
            // Bhaskara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Calcular_Bhaskara.Properties.Resources.albert_einstein_biografia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbXN);
            this.Controls.Add(this.lbXP);
            this.Controls.Add(this.lbDelta);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bhaskara";
            this.Text = "Bhaskara";
            this.Load += new System.EventHandler(this.Bhaskara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbDelta;
        private System.Windows.Forms.Label lbXP;
        private System.Windows.Forms.Label lbXN;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lbLimpar;
    }
}

