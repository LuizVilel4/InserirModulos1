using Prodwin.Data.Access;
using System;
using System.Windows.Forms;



namespace WindowsFormsApp1 {
    
    public partial class EditarEXcluir: Form {
        public string oldkey;
      

        public EditarEXcluir() {
            InitializeComponent();
        }

        public EditarEXcluir(string key, string value) {
            InitializeComponent();
            oldkey = key;
            txtValue.Text = value;
            txtKey.Text = key;
           
        }

        private void btnSalvar_Click_1(object sender, EventArgs e) {
            try {

                if(txtKey.Text != string.Empty) {

                    string sql = $@"UPDATE custom SET strkey = '{txtKey.Text}', strvalue = '{txtValue.Text}' WHERE strkey = '{oldkey}'";
                    Database.Execute(sql);

                    MessageBox.Show("Editado com Sucesso");
                    Close();
                } else {
                    MessageBox.Show("O valor não pode ser nulo");
                }

            } catch(Exception ex) {  
                Console.WriteLine($"Erro: {ex.Message}");
                MessageBox.Show($"Erro ao editar o registro: {ex.Message}");
            }
            
            Database.Execute(master);
        }

        private void bntCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void EditarEXcluir_Load(object sender, EventArgs e) {

        }
    }


}
