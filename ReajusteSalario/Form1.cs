using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReajusteSalario
{

    public partial class LeituraArquivo : Form
    {
        private RepositorioFuncionario respositorio =
            new RepositorioFuncionario();
        private BindingSource leituraSouce =
            new BindingSource();

        public LeituraArquivo()
        {
            InitializeComponent();
            leituraSouce.DataSource =
                respositorio.obterTodos();
            dgvleitura.DataSource = leituraSouce;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(ofdListaFuncionarios.ShowDialog() == DialogResult.OK)
            {
                txtarquivo.Text = ofdListaFuncionarios.FileName;
                ProcessarArquivo(txtarquivo.Text);
                if(respositorio.obterTodos().Count > 0)
                {
                    TotalizarValores(respositorio.obterTodos());
                }
               
            }
        }      
        private void TotalizarValores(IList<Funcionario> dadosLidos)
        {
            double totalSemReajuste = 0, totalComReajuste = 0;
            foreach(var funcionario in dadosLidos)
            {
                totalSemReajuste += funcionario.Salario;
                totalComReajuste += funcionario.NovoSalario;
            }
            double percentualReajuste = (totalComReajuste - totalSemReajuste) * 100 / totalSemReajuste;
            lblSemReajuste.Text = string.Format("{0:c}", totalSemReajuste);

            lblComReajuste.Text = string.Format("{0,c}", totalComReajuste);

            lblPercentual.Text = string.Format("{0:n}%", percentualReajuste);    
            
        }
        private void ProcessarArquivo(string nomeArquivo)
        {
            respositorio.obterTodos().Clear();
            string linhaLida;
            var arquivo = new System.IO.StreamReader(@nomeArquivo);
            while((linhaLida = arquivo.ReadLine()) != null)
            {
                var dadosLidos = linhaLida.Split(';');
                var funcionario = new Funcionario
                {
                    Codigo = Convert.ToInt32(dadosLidos[0]),
                    Salario = Convert.ToDouble(dadosLidos[1])
                };
                respositorio.Inserir(funcionario);
            }
            arquivo.Close();
        }

        public class Funcionario
        {
            public int Codigo { get; set; }
            public double Salario { get; set; }
            public double Percentual
            {
                get
                {
                    if (this.Salario < 1000)
                        return 15;
                    else
                        if (this.Salario < 1500)
                        return 10;
                    else
                        return 5;
                }
            }
            public double NovoSalario
            {
                get
                {
                    return (this.Salario * this.Percentual / 1000) + this.Salario;
                }
            }
        }

        public class RepositorioFuncionario
        {
            private IList<Funcionario> funcionarios =
                new BindingList<Funcionario>();

            public void Inserir(Funcionario funcionario)
            {
                funcionarios.Add(funcionario);
            }

            public IList<Funcionario> obterTodos()
            {
                return this.funcionarios;
            }
        }
    }
}

