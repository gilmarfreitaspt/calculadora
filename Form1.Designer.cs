namespace calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btt7 = new System.Windows.Forms.Button();
            this.btt8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btt6 = new System.Windows.Forms.Button();
            this.btt5 = new System.Windows.Forms.Button();
            this.btt4 = new System.Windows.Forms.Button();
            this.btt3 = new System.Windows.Forms.Button();
            this.btt2 = new System.Windows.Forms.Button();
            this.btt1 = new System.Windows.Forms.Button();
            this.btt0 = new System.Windows.Forms.Button();
            this.bttDivide = new System.Windows.Forms.Button();
            this.brrVezes = new System.Windows.Forms.Button();
            this.bttSoma = new System.Windows.Forms.Button();
            this.bttMenos = new System.Windows.Forms.Button();
            this.bttIgual = new System.Windows.Forms.Button();
            this.bttPonto = new System.Windows.Forms.Button();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblOpcao = new System.Windows.Forms.Label();
            this.bttCe = new System.Windows.Forms.Button();
            this.bttPercentagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(34, 82);
            this.txtNum.MaxLength = 10;
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(311, 41);
            this.txtNum.TabIndex = 0;
            this.txtNum.Text = "0";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btt7
            // 
            this.btt7.BackColor = System.Drawing.Color.Lime;
            this.btt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt7.Location = new System.Drawing.Point(34, 171);
            this.btt7.Name = "btt7";
            this.btt7.Size = new System.Drawing.Size(53, 44);
            this.btt7.TabIndex = 1;
            this.btt7.Text = "7";
            this.btt7.UseVisualStyleBackColor = false;
            this.btt7.Click += new System.EventHandler(this.btt7_Click);
            // 
            // btt8
            // 
            this.btt8.BackColor = System.Drawing.Color.Lime;
            this.btt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt8.Location = new System.Drawing.Point(94, 171);
            this.btt8.Name = "btt8";
            this.btt8.Size = new System.Drawing.Size(53, 44);
            this.btt8.TabIndex = 2;
            this.btt8.Text = "8";
            this.btt8.UseVisualStyleBackColor = false;
            this.btt8.Click += new System.EventHandler(this.btt8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(157, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "9";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btt6
            // 
            this.btt6.BackColor = System.Drawing.Color.Lime;
            this.btt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt6.Location = new System.Drawing.Point(157, 228);
            this.btt6.Name = "btt6";
            this.btt6.Size = new System.Drawing.Size(53, 44);
            this.btt6.TabIndex = 6;
            this.btt6.Text = "6";
            this.btt6.UseVisualStyleBackColor = false;
            this.btt6.Click += new System.EventHandler(this.btt6_Click);
            // 
            // btt5
            // 
            this.btt5.BackColor = System.Drawing.Color.Lime;
            this.btt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt5.Location = new System.Drawing.Point(94, 228);
            this.btt5.Name = "btt5";
            this.btt5.Size = new System.Drawing.Size(53, 44);
            this.btt5.TabIndex = 5;
            this.btt5.Text = "5";
            this.btt5.UseVisualStyleBackColor = false;
            this.btt5.Click += new System.EventHandler(this.btt5_Click);
            // 
            // btt4
            // 
            this.btt4.BackColor = System.Drawing.Color.Lime;
            this.btt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt4.Location = new System.Drawing.Point(34, 228);
            this.btt4.Name = "btt4";
            this.btt4.Size = new System.Drawing.Size(53, 44);
            this.btt4.TabIndex = 4;
            this.btt4.Text = "4";
            this.btt4.UseVisualStyleBackColor = false;
            this.btt4.Click += new System.EventHandler(this.btt4_Click);
            // 
            // btt3
            // 
            this.btt3.BackColor = System.Drawing.Color.Lime;
            this.btt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt3.Location = new System.Drawing.Point(157, 285);
            this.btt3.Name = "btt3";
            this.btt3.Size = new System.Drawing.Size(53, 44);
            this.btt3.TabIndex = 9;
            this.btt3.Text = "3";
            this.btt3.UseVisualStyleBackColor = false;
            this.btt3.Click += new System.EventHandler(this.btt3_Click);
            // 
            // btt2
            // 
            this.btt2.BackColor = System.Drawing.Color.Lime;
            this.btt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt2.Location = new System.Drawing.Point(94, 285);
            this.btt2.Name = "btt2";
            this.btt2.Size = new System.Drawing.Size(53, 44);
            this.btt2.TabIndex = 2;
            this.btt2.Text = "2";
            this.btt2.UseVisualStyleBackColor = false;
            this.btt2.Click += new System.EventHandler(this.btt2_Click);
            // 
            // btt1
            // 
            this.btt1.BackColor = System.Drawing.Color.Lime;
            this.btt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt1.Location = new System.Drawing.Point(34, 285);
            this.btt1.Name = "btt1";
            this.btt1.Size = new System.Drawing.Size(53, 44);
            this.btt1.TabIndex = 7;
            this.btt1.Text = "1";
            this.btt1.UseVisualStyleBackColor = false;
            this.btt1.Click += new System.EventHandler(this.btt1_Click);
            // 
            // btt0
            // 
            this.btt0.BackColor = System.Drawing.Color.Lime;
            this.btt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt0.Location = new System.Drawing.Point(34, 342);
            this.btt0.Name = "btt0";
            this.btt0.Size = new System.Drawing.Size(104, 44);
            this.btt0.TabIndex = 10;
            this.btt0.Text = "0";
            this.btt0.UseVisualStyleBackColor = false;
            this.btt0.Click += new System.EventHandler(this.btt0_Click);
            // 
            // bttDivide
            // 
            this.bttDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDivide.Location = new System.Drawing.Point(226, 171);
            this.bttDivide.Name = "bttDivide";
            this.bttDivide.Size = new System.Drawing.Size(53, 44);
            this.bttDivide.TabIndex = 11;
            this.bttDivide.Text = "/";
            this.bttDivide.UseVisualStyleBackColor = false;
            this.bttDivide.Click += new System.EventHandler(this.bttDivide_Click);
            // 
            // brrVezes
            // 
            this.brrVezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brrVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brrVezes.Location = new System.Drawing.Point(226, 228);
            this.brrVezes.Name = "brrVezes";
            this.brrVezes.Size = new System.Drawing.Size(53, 44);
            this.brrVezes.TabIndex = 12;
            this.brrVezes.Text = "X";
            this.brrVezes.UseVisualStyleBackColor = false;
            this.brrVezes.Click += new System.EventHandler(this.brrVezes_Click);
            // 
            // bttSoma
            // 
            this.bttSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSoma.Location = new System.Drawing.Point(226, 285);
            this.bttSoma.Name = "bttSoma";
            this.bttSoma.Size = new System.Drawing.Size(53, 44);
            this.bttSoma.TabIndex = 13;
            this.bttSoma.Text = "+";
            this.bttSoma.UseVisualStyleBackColor = false;
            this.bttSoma.Click += new System.EventHandler(this.bttSoma_Click);
            // 
            // bttMenos
            // 
            this.bttMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMenos.Location = new System.Drawing.Point(228, 342);
            this.bttMenos.Name = "bttMenos";
            this.bttMenos.Size = new System.Drawing.Size(53, 44);
            this.bttMenos.TabIndex = 14;
            this.bttMenos.Text = "-";
            this.bttMenos.UseVisualStyleBackColor = false;
            this.bttMenos.Click += new System.EventHandler(this.bttMenos_Click);
            // 
            // bttIgual
            // 
            this.bttIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttIgual.Location = new System.Drawing.Point(303, 285);
            this.bttIgual.Name = "bttIgual";
            this.bttIgual.Size = new System.Drawing.Size(53, 101);
            this.bttIgual.TabIndex = 15;
            this.bttIgual.Text = "=";
            this.bttIgual.UseVisualStyleBackColor = false;
            this.bttIgual.Click += new System.EventHandler(this.bttIgual_Click);
            // 
            // bttPonto
            // 
            this.bttPonto.BackColor = System.Drawing.Color.Lime;
            this.bttPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPonto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttPonto.Location = new System.Drawing.Point(157, 342);
            this.bttPonto.Name = "bttPonto";
            this.bttPonto.Size = new System.Drawing.Size(53, 44);
            this.bttPonto.TabIndex = 16;
            this.bttPonto.Text = ".";
            this.bttPonto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttPonto.UseVisualStyleBackColor = false;
            this.bttPonto.Click += new System.EventHandler(this.bttPonto_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTempo.Location = new System.Drawing.Point(212, 412);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(119, 35);
            this.lblTempo.TabIndex = 17;
            this.lblTempo.Visible = false;
            // 
            // lblOpcao
            // 
            this.lblOpcao.BackColor = System.Drawing.Color.Transparent;
            this.lblOpcao.Location = new System.Drawing.Point(33, 412);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(114, 35);
            this.lblOpcao.TabIndex = 18;
            this.lblOpcao.Visible = false;
            this.lblOpcao.Click += new System.EventHandler(this.lblOpcao_Click);
            // 
            // bttCe
            // 
            this.bttCe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCe.Location = new System.Drawing.Point(303, 171);
            this.bttCe.Name = "bttCe";
            this.bttCe.Size = new System.Drawing.Size(53, 44);
            this.bttCe.TabIndex = 19;
            this.bttCe.Text = "C";
            this.bttCe.UseVisualStyleBackColor = false;
            this.bttCe.Click += new System.EventHandler(this.bttCe_Click);
            // 
            // bttPercentagem
            // 
            this.bttPercentagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttPercentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPercentagem.Location = new System.Drawing.Point(303, 228);
            this.bttPercentagem.Name = "bttPercentagem";
            this.bttPercentagem.Size = new System.Drawing.Size(53, 44);
            this.bttPercentagem.TabIndex = 20;
            this.bttPercentagem.Text = "%";
            this.bttPercentagem.UseVisualStyleBackColor = false;
            this.bttPercentagem.Click += new System.EventHandler(this.bttPercentagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::calculadora.Properties.Resources.calculadora;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 503);
            this.Controls.Add(this.bttPercentagem);
            this.Controls.Add(this.bttCe);
            this.Controls.Add(this.lblOpcao);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.bttPonto);
            this.Controls.Add(this.bttIgual);
            this.Controls.Add(this.bttMenos);
            this.Controls.Add(this.bttSoma);
            this.Controls.Add(this.brrVezes);
            this.Controls.Add(this.bttDivide);
            this.Controls.Add(this.btt0);
            this.Controls.Add(this.btt3);
            this.Controls.Add(this.btt2);
            this.Controls.Add(this.btt1);
            this.Controls.Add(this.btt6);
            this.Controls.Add(this.btt5);
            this.Controls.Add(this.btt4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btt8);
            this.Controls.Add(this.btt7);
            this.Controls.Add(this.txtNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btt7;
        private System.Windows.Forms.Button btt8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btt6;
        private System.Windows.Forms.Button btt5;
        private System.Windows.Forms.Button btt4;
        private System.Windows.Forms.Button btt3;
        private System.Windows.Forms.Button btt2;
        private System.Windows.Forms.Button btt1;
        private System.Windows.Forms.Button btt0;
        private System.Windows.Forms.Button bttDivide;
        private System.Windows.Forms.Button brrVezes;
        private System.Windows.Forms.Button bttSoma;
        private System.Windows.Forms.Button bttMenos;
        private System.Windows.Forms.Button bttIgual;
        private System.Windows.Forms.Button bttPonto;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.Button bttCe;
        private System.Windows.Forms.Button bttPercentagem;
    }
}

