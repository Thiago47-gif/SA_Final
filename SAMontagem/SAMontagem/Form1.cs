using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMontagem
{
    public partial class FormMontagem : Form
    {
        List<Patio> patio;

        

        public FormMontagem()
        {
            InitializeComponent();

            patio = new List<Patio>();

            // Tipo de veículo
            tipoVeiculo.Items.Add("Carro");
            tipoVeiculo.Items.Add("Moto");
           
        }

        public void Listar()
        {
            lista.Items.Clear();

            foreach (Patio p in patio)
            {
                
                    lista.Items.Add(p.Tipo + " - " + p.Modelo + " , Ano " + p.Ano +", Placa " + p.Placa + ", Chassi " + p.Chassi);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pecas_Click_1(object sender, EventArgs e)
        {
            // Peças de Carro
            if (tipoVeiculo.Text == "Carro")
            {
                int motorC = 1, rodasC = 4, farolC = 4;
                qtdMotor.Text = motorC.ToString();
                qtdFarol.Text = farolC.ToString();
                qtdRodas.Text = rodasC.ToString();
            }
            // Quantidade de Portas no Carro
            if (tipoVeiculo.Text == "Carro")
            {
                // Para que as portas não se repitem
                if (portas.Items.Count == 0)
                {
                    portas.Items.Add("2");
                    portas.Items.Add("4");
                }
            }
            // Modelo de Carros
            if (tipoVeiculo.Text == "Carro")
            {
                // Para que os modelos não se repitem
                if (modelo.Items.Count == 0)
                {
                    modelo.Items.Add("Chevrolet");
                    modelo.Items.Add("Ford");
                    modelo.Items.Add("Nissan");
                    modelo.Items.Add("Toyota");
                }
            }

            // Modelo de Motos
            if (tipoVeiculo.Text == "Moto")
            {
                // Para que os modelos não se repitem
                if (modelo.Items.Count == 0)
                {
                    modelo.Items.Add("Honda");
                    modelo.Items.Add("Suzuki");
                    modelo.Items.Add("Yamaha");
                }
            }
            // Peças de Motos
            if (tipoVeiculo.Text == "Moto")
            {
                int motorM = 1, rodasM = 2, farolM = 2;
                qtdMotor.Text = motorM.ToString();
                qtdFarol.Text = farolM.ToString();
                qtdRodas.Text = rodasM.ToString();
            }
        }


        private void finalizar_Click_1(object sender, EventArgs e)
        {
            Patio p = new Patio();
            p.Tipo = tipoVeiculo.Text;
            p.Modelo = modelo.Text;
            p.Portas = portas.Text;
            p.Ano = ano.Text;
            p.Chassi = chassi.Text;
            p.Placa = placa.Text;

            patio.Add(p);

            limpar_Click(limpar, EventArgs.Empty);

            Listar();

            // Mensagem
            MessageBox.Show("Montagem Solicitada.");

            // Remove modelos de carros
            modelo.Items.Remove("Chevrolet");
            modelo.Items.Remove("Ford");
            modelo.Items.Remove("Nissan");
            modelo.Items.Remove("Toyota");

            // Remove modelos de motos
            modelo.Items.Remove("Honda");
            modelo.Items.Remove("Suzuki");
            modelo.Items.Remove("Yamaha");

            // Remove quantidades de portas
            portas.Items.Remove("2");
            portas.Items.Remove("4");
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            tipoVeiculo.SelectedIndex = -1;
            qtdMotor.Text = "0";
            qtdRodas.Text = "0";
            qtdFarol.Text = "0";
            portas.SelectedIndex = -1;
            modelo.SelectedIndex = -1;
            ano.Text = "";
            chassi.Text = "";
            placa.Text = "";

            

        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lista.SelectedIndex;

            tipoVeiculo.Text = patio[index].Tipo;
            modelo.Text = patio[index].Modelo;
            portas.Text = patio[index].Portas;
            ano.Text = patio[index].Ano;
            chassi.Text = patio[index].Chassi;
            placa.Text = patio[index].Placa;

        }

        private void vender_Click(object sender, EventArgs e)
        {
            int indece = lista.SelectedIndex;
            patio.RemoveAt(indece);
            Listar();
        }
    }
}
