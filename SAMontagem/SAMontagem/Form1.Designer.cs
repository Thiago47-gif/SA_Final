
namespace SAMontagem
{
    partial class FormMontagem
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
            this.qtdMotor = new System.Windows.Forms.Label();
            this.labe2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qtdRodas = new System.Windows.Forms.Label();
            this.qtdFarol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pecas = new System.Windows.Forms.Button();
            this.tipoVeiculo = new System.Windows.Forms.ComboBox();
            this.portas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.ComboBox();
            this.finalizar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.limpar = new System.Windows.Forms.Button();
            this.text_ = new System.Windows.Forms.Label();
            this.ano = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vender = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.placa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chassi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // qtdMotor
            // 
            this.qtdMotor.AutoSize = true;
            this.qtdMotor.Font = new System.Drawing.Font("Arial", 10.25F);
            this.qtdMotor.Location = new System.Drawing.Point(177, 162);
            this.qtdMotor.Name = "qtdMotor";
            this.qtdMotor.Size = new System.Drawing.Size(16, 16);
            this.qtdMotor.TabIndex = 0;
            this.qtdMotor.Text = "0";
            // 
            // labe2
            // 
            this.labe2.AutoSize = true;
            this.labe2.Font = new System.Drawing.Font("Arial", 12.25F);
            this.labe2.Location = new System.Drawing.Point(41, 160);
            this.labe2.Name = "labe2";
            this.labe2.Size = new System.Drawing.Size(50, 19);
            this.labe2.TabIndex = 1;
            this.labe2.Text = "Motor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label3.Location = new System.Drawing.Point(41, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rodas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label4.Location = new System.Drawing.Point(41, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Portas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label5.Location = new System.Drawing.Point(41, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Farol";
            // 
            // qtdRodas
            // 
            this.qtdRodas.AutoSize = true;
            this.qtdRodas.Font = new System.Drawing.Font("Arial", 10.25F);
            this.qtdRodas.Location = new System.Drawing.Point(177, 198);
            this.qtdRodas.Name = "qtdRodas";
            this.qtdRodas.Size = new System.Drawing.Size(16, 16);
            this.qtdRodas.TabIndex = 7;
            this.qtdRodas.Text = "0";
            // 
            // qtdFarol
            // 
            this.qtdFarol.AutoSize = true;
            this.qtdFarol.Font = new System.Drawing.Font("Arial", 10.25F);
            this.qtdFarol.Location = new System.Drawing.Point(177, 231);
            this.qtdFarol.Name = "qtdFarol";
            this.qtdFarol.Size = new System.Drawing.Size(16, 16);
            this.qtdFarol.TabIndex = 9;
            this.qtdFarol.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label1.Location = new System.Drawing.Point(41, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo de Veículo";
            // 
            // pecas
            // 
            this.pecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pecas.Location = new System.Drawing.Point(45, 267);
            this.pecas.Name = "pecas";
            this.pecas.Size = new System.Drawing.Size(117, 29);
            this.pecas.TabIndex = 12;
            this.pecas.Text = "Mostrar Peças";
            this.pecas.UseVisualStyleBackColor = true;
            this.pecas.Click += new System.EventHandler(this.pecas_Click_1);
            // 
            // tipoVeiculo
            // 
            this.tipoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tipoVeiculo.FormattingEnabled = true;
            this.tipoVeiculo.Location = new System.Drawing.Point(180, 120);
            this.tipoVeiculo.Name = "tipoVeiculo";
            this.tipoVeiculo.Size = new System.Drawing.Size(64, 26);
            this.tipoVeiculo.TabIndex = 13;
            // 
            // portas
            // 
            this.portas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.portas.FormattingEnabled = true;
            this.portas.Location = new System.Drawing.Point(180, 318);
            this.portas.Name = "portas";
            this.portas.Size = new System.Drawing.Size(64, 25);
            this.portas.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label2.Location = new System.Drawing.Point(42, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Modelo";
            // 
            // modelo
            // 
            this.modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.modelo.FormattingEnabled = true;
            this.modelo.Location = new System.Drawing.Point(180, 355);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(121, 25);
            this.modelo.TabIndex = 16;
            // 
            // finalizar
            // 
            this.finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.finalizar.Location = new System.Drawing.Point(45, 505);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(75, 27);
            this.finalizar.TabIndex = 17;
            this.finalizar.Text = "Finalizar";
            this.finalizar.UseVisualStyleBackColor = true;
            this.finalizar.Click += new System.EventHandler(this.finalizar_Click_1);
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 17;
            this.lista.Location = new System.Drawing.Point(472, 159);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(471, 310);
            this.lista.TabIndex = 18;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // limpar
            // 
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.limpar.Location = new System.Drawing.Point(347, 505);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(75, 27);
            this.limpar.TabIndex = 19;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // text_
            // 
            this.text_.AutoSize = true;
            this.text_.Font = new System.Drawing.Font("Arial", 12.25F);
            this.text_.Location = new System.Drawing.Point(42, 399);
            this.text_.Name = "text_";
            this.text_.Size = new System.Drawing.Size(38, 19);
            this.text_.TabIndex = 21;
            this.text_.Text = "Ano";
            // 
            // ano
            // 
            this.ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ano.Location = new System.Drawing.Point(180, 397);
            this.ano.Name = "ano";
            this.ano.Size = new System.Drawing.Size(121, 23);
            this.ano.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(456, -57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(10, 667);
            this.listBox1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label7.Location = new System.Drawing.Point(577, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "Patio de Veículos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.Location = new System.Drawing.Point(119, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = "Montagem de Veículos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label8.Location = new System.Drawing.Point(506, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Esta é a lista de todos os veículo para vendas";
            // 
            // vender
            // 
            this.vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.vender.Location = new System.Drawing.Point(719, 505);
            this.vender.Name = "vender";
            this.vender.Size = new System.Drawing.Size(128, 27);
            this.vender.TabIndex = 28;
            this.vender.Text = "Veículo Vendido";
            this.vender.UseVisualStyleBackColor = true;
            this.vender.Click += new System.EventHandler(this.vender_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label9.Location = new System.Drawing.Point(42, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Placa";
            // 
            // placa
            // 
            this.placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.placa.Location = new System.Drawing.Point(180, 433);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(121, 23);
            this.placa.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label10.Location = new System.Drawing.Point(41, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "Chassi";
            // 
            // chassi
            // 
            this.chassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.chassi.Location = new System.Drawing.Point(180, 471);
            this.chassi.Name = "chassi";
            this.chassi.Size = new System.Drawing.Size(121, 23);
            this.chassi.TabIndex = 32;
            // 
            // FormMontagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 544);
            this.Controls.Add(this.chassi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.placa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ano);
            this.Controls.Add(this.text_);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portas);
            this.Controls.Add(this.tipoVeiculo);
            this.Controls.Add(this.pecas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qtdFarol);
            this.Controls.Add(this.qtdRodas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labe2);
            this.Controls.Add(this.qtdMotor);
            this.Name = "FormMontagem";
            this.Text = "Montagem de Veículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qtdMotor;
        private System.Windows.Forms.Label labe2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label qtdRodas;
        private System.Windows.Forms.Label qtdFarol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pecas;
        private System.Windows.Forms.ComboBox tipoVeiculo;
        private System.Windows.Forms.ComboBox portas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox modelo;
        private System.Windows.Forms.Button finalizar;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Label text_;
        private System.Windows.Forms.TextBox ano;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button vender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox placa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox chassi;
    }
}

