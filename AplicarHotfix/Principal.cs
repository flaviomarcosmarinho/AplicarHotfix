using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AplicarHotfix
{
    public partial class Principal : Form
    {
        #region Atributos

        private Dictionary<string, string> dicMD5Original = new Dictionary<string, string>(); //Dicionario de MD5 indexado por nome da dll.
        private Dictionary<string, string> dicMD5Aplicado = new Dictionary<string, string>(); //Dicionario de MD5 indexado por nome da dll. 

        #endregion

        #region Contrutor

        public Principal()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        private string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void CarregarMD5(string path)
        {
            this.dicMD5Original.Clear();

            using (StreamReader reading = File.OpenText(path))
            {
                string str;
                while ((str = reading.ReadLine()) != null)
                {
                    string[] md5 = str.Split('*');
                    string dllName = md5[md5.Length - 1];

                    if (md5.Length > 1 && !string.IsNullOrEmpty(md5[0]))
                    {
                        this.dicMD5Original.Add(md5[md5.Length - 1], md5[0]);
                    }
                }
            }
        }

        #endregion

        #region Eventos

        private void btnSelecionarMD5_Click(object sender, EventArgs e)
        {
            this.openFileDialog.InitialDirectory = this.txtPathHotfix.Text;
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] file = this.openFileDialog.FileName.Split('\\');
                string fileName = file[file.Length - 1];

                this.txtMD5.Text = fileName;
                this.CarregarMD5(openFileDialog.FileName);
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPathHotfix.Text))
            {
                MessageBox.Show("Selecione a pasta do Hotfix não oficial.");
                this.btnPath.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtMD5.Text))
            {
                MessageBox.Show("Selecione o arquivo MD5 do Hotfix não oficial.");
                this.btnSelecionarMD5.Focus();
                return;
            }

            var regexArquivoDll = new Regex(".dll$");
            var arquivosDll = Directory.GetFiles(this.txtPathHotfix.Text).Where(a => regexArquivoDll.IsMatch(a));

            foreach (var dll in arquivosDll)
            {
                string[] file = dll.Split('\\');
                string dllName = file[file.Length - 1];
                dicMD5Aplicado.Add(dllName, this.CalculateMD5(dll));
            }

            var regexArquivoEXE = new Regex(".exe$");
            var arquivosEXE = Directory.GetFiles(this.txtPathHotfix.Text).Where(a => regexArquivoEXE.IsMatch(a));

            foreach (var exe in arquivosEXE)
            {
                string[] file = exe.Split('\\');
                string exeName = file[file.Length - 1];
                dicMD5Aplicado.Add(exeName, this.CalculateMD5(exe));
            }

            string text = File.ReadAllText(Path.Combine(this.txtPathHotfix.Text, this.txtMD5.Text));
            foreach (KeyValuePair<string, string> md5Aplicado in dicMD5Aplicado)
            {
                if (dicMD5Original.ContainsKey(md5Aplicado.Key))
                {
                    //Altera o MD5 existente no arquivo
                    text = text.Replace(dicMD5Original[md5Aplicado.Key], md5Aplicado.Value + " ");
                }
                else
                {
                    //Inclui um novo MD5 no arquivo (Nova dll ou Exe)
                    text = text + md5Aplicado.Value + " *" + md5Aplicado.Key;
                }
            }            

            File.WriteAllText(Path.Combine(this.txtPathHotfix.Text, this.txtMD5.Text), text);

            MessageBox.Show("Hotfix não oficial aplicado com sucesso. Agora basta compactar a pasta e colocar no FTP!");

            this.dicMD5Aplicado.Clear();
            this.CarregarMD5(openFileDialog.FileName);
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.SelectedPath = @"\\192.168.5.1\Setores\BUGS";
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtPathHotfix.Text = this.folderBrowserDialog.SelectedPath;
            }
        } 

        #endregion        
    }
}
