namespace CifraDeCesar
{
    partial class Form_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.box_texto_original = new System.Windows.Forms.TextBox();
            this.box_cript = new System.Windows.Forms.TextBox();
            this.box_decript = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cripto = new System.Windows.Forms.Button();
            this.btn_decripto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // box_texto_original
            // 
            this.box_texto_original.Location = new System.Drawing.Point(8, 23);
            this.box_texto_original.Multiline = true;
            this.box_texto_original.Name = "box_texto_original";
            this.box_texto_original.Size = new System.Drawing.Size(338, 91);
            this.box_texto_original.TabIndex = 0;
            // 
            // box_cript
            // 
            this.box_cript.Location = new System.Drawing.Point(8, 139);
            this.box_cript.Multiline = true;
            this.box_cript.Name = "box_cript";
            this.box_cript.Size = new System.Drawing.Size(339, 91);
            this.box_cript.TabIndex = 1;
            // 
            // box_decript
            // 
            this.box_decript.Location = new System.Drawing.Point(8, 259);
            this.box_decript.Multiline = true;
            this.box_decript.Name = "box_decript";
            this.box_decript.Size = new System.Drawing.Size(339, 91);
            this.box_decript.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto Criptografado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto Decriptografado";
            // 
            // btn_cripto
            // 
            this.btn_cripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cripto.Location = new System.Drawing.Point(52, 356);
            this.btn_cripto.Name = "btn_cripto";
            this.btn_cripto.Size = new System.Drawing.Size(110, 25);
            this.btn_cripto.TabIndex = 6;
            this.btn_cripto.Text = "Critptografar";
            this.btn_cripto.UseVisualStyleBackColor = true;
            this.btn_cripto.Click += new System.EventHandler(this.btn_cripto_Click);
            // 
            // btn_decripto
            // 
            this.btn_decripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decripto.Location = new System.Drawing.Point(199, 356);
            this.btn_decripto.Name = "btn_decripto";
            this.btn_decripto.Size = new System.Drawing.Size(110, 25);
            this.btn_decripto.TabIndex = 7;
            this.btn_decripto.Text = "Decriptografar";
            this.btn_decripto.UseVisualStyleBackColor = true;
            this.btn_decripto.Click += new System.EventHandler(this.btn_decripto_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 387);
            this.Controls.Add(this.btn_decripto);
            this.Controls.Add(this.btn_cripto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_decript);
            this.Controls.Add(this.box_cript);
            this.Controls.Add(this.box_texto_original);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifra de Cesar - IFTM 2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_texto_original;
        private System.Windows.Forms.TextBox box_cript;
        private System.Windows.Forms.TextBox box_decript;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cripto;
        private System.Windows.Forms.Button btn_decripto;
    }
}

