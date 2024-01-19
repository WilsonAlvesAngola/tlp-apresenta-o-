namespace calculadora_final
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bum = new System.Windows.Forms.Button();
            this.bquatro = new System.Windows.Forms.Button();
            this.bsete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bdois = new System.Windows.Forms.Button();
            this.bcinco = new System.Windows.Forms.Button();
            this.boito = new System.Windows.Forms.Button();
            this.bzero = new System.Windows.Forms.Button();
            this.btres = new System.Windows.Forms.Button();
            this.bseis = new System.Windows.Forms.Button();
            this.bnove = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.bsoma = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.bmult = new System.Windows.Forms.Button();
            this.bdivisao = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(493, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bum
            // 
            this.bum.Location = new System.Drawing.Point(25, 90);
            this.bum.Margin = new System.Windows.Forms.Padding(5);
            this.bum.Name = "bum";
            this.bum.Size = new System.Drawing.Size(103, 39);
            this.bum.TabIndex = 1;
            this.bum.Text = "1";
            this.bum.UseVisualStyleBackColor = true;
            this.bum.Click += new System.EventHandler(this.button1_Click);
            // 
            // bquatro
            // 
            this.bquatro.Location = new System.Drawing.Point(25, 149);
            this.bquatro.Margin = new System.Windows.Forms.Padding(5);
            this.bquatro.Name = "bquatro";
            this.bquatro.Size = new System.Drawing.Size(103, 39);
            this.bquatro.TabIndex = 2;
            this.bquatro.Text = "4";
            this.bquatro.UseVisualStyleBackColor = true;
            this.bquatro.Click += new System.EventHandler(this.bquatro_Click);
            // 
            // bsete
            // 
            this.bsete.Location = new System.Drawing.Point(25, 212);
            this.bsete.Margin = new System.Windows.Forms.Padding(5);
            this.bsete.Name = "bsete";
            this.bsete.Size = new System.Drawing.Size(103, 39);
            this.bsete.TabIndex = 3;
            this.bsete.Text = "7";
            this.bsete.UseVisualStyleBackColor = true;
            this.bsete.Click += new System.EventHandler(this.bsete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 274);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "#";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // bdois
            // 
            this.bdois.Location = new System.Drawing.Point(138, 90);
            this.bdois.Margin = new System.Windows.Forms.Padding(5);
            this.bdois.Name = "bdois";
            this.bdois.Size = new System.Drawing.Size(103, 39);
            this.bdois.TabIndex = 5;
            this.bdois.Text = "2";
            this.bdois.UseVisualStyleBackColor = true;
            this.bdois.Click += new System.EventHandler(this.bdois_Click);
            // 
            // bcinco
            // 
            this.bcinco.Location = new System.Drawing.Point(138, 149);
            this.bcinco.Margin = new System.Windows.Forms.Padding(5);
            this.bcinco.Name = "bcinco";
            this.bcinco.Size = new System.Drawing.Size(103, 39);
            this.bcinco.TabIndex = 6;
            this.bcinco.Text = "5";
            this.bcinco.UseVisualStyleBackColor = true;
            this.bcinco.Click += new System.EventHandler(this.bcinco_Click);
            // 
            // boito
            // 
            this.boito.Location = new System.Drawing.Point(138, 212);
            this.boito.Margin = new System.Windows.Forms.Padding(5);
            this.boito.Name = "boito";
            this.boito.Size = new System.Drawing.Size(103, 39);
            this.boito.TabIndex = 7;
            this.boito.Text = "8";
            this.boito.UseVisualStyleBackColor = true;
            this.boito.Click += new System.EventHandler(this.boito_Click);
            // 
            // bzero
            // 
            this.bzero.Location = new System.Drawing.Point(138, 274);
            this.bzero.Margin = new System.Windows.Forms.Padding(5);
            this.bzero.Name = "bzero";
            this.bzero.Size = new System.Drawing.Size(103, 39);
            this.bzero.TabIndex = 8;
            this.bzero.Text = "0";
            this.bzero.UseVisualStyleBackColor = true;
            this.bzero.Click += new System.EventHandler(this.bzero_Click);
            // 
            // btres
            // 
            this.btres.Location = new System.Drawing.Point(256, 90);
            this.btres.Margin = new System.Windows.Forms.Padding(5);
            this.btres.Name = "btres";
            this.btres.Size = new System.Drawing.Size(103, 39);
            this.btres.TabIndex = 9;
            this.btres.Text = "3";
            this.btres.UseVisualStyleBackColor = true;
            this.btres.Click += new System.EventHandler(this.btres_Click);
            // 
            // bseis
            // 
            this.bseis.Location = new System.Drawing.Point(256, 149);
            this.bseis.Margin = new System.Windows.Forms.Padding(5);
            this.bseis.Name = "bseis";
            this.bseis.Size = new System.Drawing.Size(103, 39);
            this.bseis.TabIndex = 10;
            this.bseis.Text = "6";
            this.bseis.UseVisualStyleBackColor = true;
            this.bseis.Click += new System.EventHandler(this.bseis_Click);
            // 
            // bnove
            // 
            this.bnove.Location = new System.Drawing.Point(264, 212);
            this.bnove.Margin = new System.Windows.Forms.Padding(5);
            this.bnove.Name = "bnove";
            this.bnove.Size = new System.Drawing.Size(103, 39);
            this.bnove.TabIndex = 11;
            this.bnove.Text = "9";
            this.bnove.UseVisualStyleBackColor = true;
            this.bnove.Click += new System.EventHandler(this.bnove_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(264, 274);
            this.button12.Margin = new System.Windows.Forms.Padding(5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(103, 39);
            this.button12.TabIndex = 12;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // bsoma
            // 
            this.bsoma.Location = new System.Drawing.Point(392, 90);
            this.bsoma.Margin = new System.Windows.Forms.Padding(5);
            this.bsoma.Name = "bsoma";
            this.bsoma.Size = new System.Drawing.Size(103, 39);
            this.bsoma.TabIndex = 13;
            this.bsoma.Text = "+";
            this.bsoma.UseVisualStyleBackColor = true;
            this.bsoma.Click += new System.EventHandler(this.bsoma_Click);
            // 
            // bsub
            // 
            this.bsub.Location = new System.Drawing.Point(392, 149);
            this.bsub.Margin = new System.Windows.Forms.Padding(5);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(103, 39);
            this.bsub.TabIndex = 14;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // bmult
            // 
            this.bmult.Location = new System.Drawing.Point(392, 212);
            this.bmult.Margin = new System.Windows.Forms.Padding(5);
            this.bmult.Name = "bmult";
            this.bmult.Size = new System.Drawing.Size(103, 39);
            this.bmult.TabIndex = 15;
            this.bmult.Text = "x";
            this.bmult.UseVisualStyleBackColor = true;
            this.bmult.Click += new System.EventHandler(this.bmult_Click);
            // 
            // bdivisao
            // 
            this.bdivisao.Location = new System.Drawing.Point(392, 274);
            this.bdivisao.Margin = new System.Windows.Forms.Padding(5);
            this.bdivisao.Name = "bdivisao";
            this.bdivisao.Size = new System.Drawing.Size(103, 39);
            this.bdivisao.TabIndex = 16;
            this.bdivisao.Text = "/";
            this.bdivisao.UseVisualStyleBackColor = true;
            this.bdivisao.Click += new System.EventHandler(this.bdivisao_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(138, 323);
            this.button17.Margin = new System.Windows.Forms.Padding(5);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(103, 51);
            this.button17.TabIndex = 17;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "AC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.bdivisao);
            this.Controls.Add(this.bmult);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bsoma);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.bnove);
            this.Controls.Add(this.bseis);
            this.Controls.Add(this.btres);
            this.Controls.Add(this.bzero);
            this.Controls.Add(this.boito);
            this.Controls.Add(this.bcinco);
            this.Controls.Add(this.bdois);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bsete);
            this.Controls.Add(this.bquatro);
            this.Controls.Add(this.bum);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bum;
        private System.Windows.Forms.Button bquatro;
        private System.Windows.Forms.Button bsete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bdois;
        private System.Windows.Forms.Button bcinco;
        private System.Windows.Forms.Button boito;
        private System.Windows.Forms.Button bzero;
        private System.Windows.Forms.Button btres;
        private System.Windows.Forms.Button bseis;
        private System.Windows.Forms.Button bnove;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button bsoma;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button bmult;
        private System.Windows.Forms.Button bdivisao;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
    }
}

