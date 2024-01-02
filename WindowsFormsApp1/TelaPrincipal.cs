using Prodwin.Data.Access;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class TelaPrincipal : Form
    {
        public string strConn;
        public string oldkey;


        public TelaPrincipal()
        {
            InitializeComponent();

            listModulosAtivos.GridLines = true;
            listModulosAtivos.FullRowSelect = true;
            listModulosAtivos.AllowColumnReorder = true;
            listModulosAtivos.View = View.Details;
            listModulosAtivos.Columns.Add("Strkey", 150);
            listModulosAtivos.Columns.Add("Strvalue", 150);


            ContextMenu contextMenu = new ContextMenu();
            listModulosAtivos.ContextMenu = contextMenu;
            MenuItem menuItemExcluir = new MenuItem("Excluir");
            MenuItem menuItemEditar = new MenuItem("Editar");
            contextMenu.MenuItems.Add(menuItemExcluir);
            contextMenu.MenuItems.Add(menuItemEditar);

            menuItemExcluir.Click += MenuItemExcluir_Click;
            menuItemEditar.Click += MenuItemEditar_Click;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

            DatabaseConfig.Open();

            cbTipo.Text = DatabaseConfig.Instance.Tipo;
            txtServidor.Text = DatabaseConfig.Instance.Servidor;
            txtBase.Text = DatabaseConfig.Instance.NomeBaseDados;
            txtUsuario.Text = DatabaseConfig.Instance.Usuario;
            txtSenha.Text = DatabaseConfig.Instance.Senha;

            MontarForm();
            txtBase.Items.Clear();
            ListarModulos();
        }

        public List<string> ListarModulos(string caminho = "D:\\WindowsFormsApp1\\WindowsFormsApp1\\WindowsFormsApp1\\listModulos.json")
        {
            try
            {
                using (StreamReader r = new StreamReader(caminho))
                {
                    string json = r.ReadToEnd();
                    JsonConfig config = JsonConvert.DeserializeObject<JsonConfig>(json);

                    foreach (string modulo in config.modulos)
                    {
                        checkedListModulos.Items.Add(modulo);
                    }

                    return config.modulos;

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Erro ao desserializar o arquivo: {ex.Message}");
                return null;
            }

        }

        public class JsonConfig
        {
            public List<string> modulos { get; set; }

        }


        private void MenuItemExcluir_Click(object sender, EventArgs e)
        {
            if (listModulosAtivos.SelectedItems.Count > 0)
            {
                string text = listModulosAtivos.SelectedItems[0].Text;
                string delete = $@"
DELETE FROM custom WHERE strkey = ('{text}')
";
                Database.Execute(delete);
                MessageBox.Show("Excluído com sucesso");
                listModulosAtivos.Items.Clear();
                returnList();
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para exclusão.");
            }
        }

        private void MenuItemEditar_Click(object sender, EventArgs e)
        {
            if (listModulosAtivos.SelectedItems.Count > 0)
            {
                string text = listModulosAtivos.SelectedItems[0].Text;
                string oldkey = listModulosAtivos.SelectedItems[0].SubItems[1].Text;
                EditarEXcluir editarEXcluir = new EditarEXcluir(text, oldkey);
                editarEXcluir.Show();

            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para edição.");
            }
        }

        private void btnInserirManual_Click(object sender, EventArgs e)
        {

            string textoInserto = txtBoxModulo.Text;
            string valorInserido = txtBoxValor.Text;

            if (txtBoxModulo.Text == string.Empty)
            {
                return;
            }

            try
            {
                string Inserir = $@"
INSERT INTO custom (strkey, strvalue) VALUES ('{textoInserto}' , '{valorInserido}')
";
                Database.Execute(Inserir);
                txtBoxModulo.Clear();
                txtBoxValor.Clear();
                MessageBox.Show("Inserido com Sucesso");
                listModulosAtivos.Items.Clear();
                returnList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.InnerException?.Message);
                throw;
            }

        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            if (cbTipo.Text == "SQL")
            {

                try
                {
                    DatabaseConfig dbc = new DatabaseConfig();

                    dbc.Tipo = cbTipo.Text;
                    dbc.Servidor = txtServidor.Text;
                    dbc.NomeBaseDados = txtBase.Text == string.Empty ? "master" : txtBase.Text;
                    dbc.Usuario = txtUsuario.Text;
                    dbc.Senha = txtSenha.Text;

                    txtBase.Items.Clear();
                    using (DbHandler dbh = new DbHandler(dbc))
                    {
                        string dbc2 = @"
SELECT name FROM sysdatabases
";
                        dbh.LoopReader(dr => {
                            string bd = DbUtil.ToString(dr[0]);
                            txtBase.Items.Add(bd);
                        }, dbc2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.InnerException?.Message);
                }

            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtBase.Text = openFileDialog1.FileName;
                }
            }
        }

        protected void MontarForm()
        {
            txtBase.Visible = true;
            btnProcurar.Visible = false;


            if (cbTipo.Text == "SQL")
            {
                btnProcurar.Visible = true;
                return;
            }
        }

        public void returnList()
        {

            if (cbTipo.Text == "SQL")
            {

                try
                {
                    DatabaseConfig dbc = new DatabaseConfig();

                    dbc.Tipo = cbTipo.Text;
                    dbc.Servidor = txtServidor.Text;
                    dbc.NomeBaseDados = txtBase.Text;
                    dbc.Usuario = txtUsuario.Text;
                    dbc.Senha = txtSenha.Text;

                    txtBase.Items.Clear();
                    using (DbHandler dbh = new DbHandler(dbc))
                    {
                        string dbc2 = @"
SELECT strkey, strvalue FROM custom
";
                        dbh.LoopReader(dr => {
                            string chave = DbUtil.ToString(dr["strkey"]);
                            string valor = DbUtil.ToString(dr["strvalue"]);


                            ListViewItem item = new ListViewItem(chave);
                            item.SubItems.Add(valor);


                            listModulosAtivos.Items.Add(item);
                        }, dbc2);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n" + ex.InnerException?.Message);
                }
            }
        }


        private void BuscarProduto()
         {
            try
            {
                using (DbHandler dbh = new DbHandler())
                {
                    string q = txtBoxPesquisar.Text;
                    string dbc2 = $@"
SELECT * FROM custom WHERE strkey like '%{q}%'
";
                    listModulosAtivos.Items.Clear();
                    dbh.LoopReader(dr => {
                        string chave = DbUtil.ToString(dr["strkey"]);
                        string valor = DbUtil.ToString(dr["strvalue"]);


                        ListViewItem item = new ListViewItem(chave);
                        item.SubItems.Add(valor);

                       
                        listModulosAtivos.Items.Add(item);
                    }, dbc2);
                }

            }catch (Exception ex)
            {
                listModulosAtivos.Items.Clear();
                MessageBox.Show("Ocorreu um erro ao buscar os módulos: " + ex.Message);
            }
        }

        protected void Validar()
        {

        }

        private void btnTestar_Click(object sender, EventArgs e)
        {

            try
            {
                Enabled = false;

                Validar();

                DatabaseConfig dbc = new DatabaseConfig();

                dbc.Tipo = cbTipo.Text;
                dbc.Servidor = txtServidor.Text;
                dbc.NomeBaseDados = txtBase.Text;
                dbc.Usuario = txtUsuario.Text;
                dbc.Senha = txtSenha.Text;

                DbHandler dbh = new DbHandler();

                dbh.TestConnect(dbc);
                MessageBox.Show("Conectado com sucesso!");

                dbh = null;
                dbc = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Enabled = true;
            Cursor = Cursors.Arrow;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                Validar();

                DatabaseConfig.Instance.Tipo = cbTipo.Text;
                DatabaseConfig.Instance.Servidor = txtServidor.Text;
                DatabaseConfig.Instance.NomeBaseDados = txtBase.Text;
                DatabaseConfig.Instance.Usuario = txtUsuario.Text;
                DatabaseConfig.Instance.Senha = txtSenha.Text;

                DatabaseConfig.Save();
                listModulosAtivos.Items.Clear();
                returnList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            returnList();
            BuscarProduto();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string textoInserto = checkedListModulos.Text;
            string valorInserido = ("on");
            try
            {
                string Inserir = $@"
INSERT INTO custom (strkey, strvalue) VALUES ('{textoInserto}' , '{valorInserido}')
";
                Database.Execute(Inserir);
                MessageBox.Show("Inserido com Sucesso");
                listModulosAtivos.Items.Clear();
                returnList();
            }
            catch (Exception)
            {
                MessageBox.Show("Módulo já existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            checkedListModulos.ClearSelected();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            checkedListModulos.ClearSelected();
        }
    }
}


