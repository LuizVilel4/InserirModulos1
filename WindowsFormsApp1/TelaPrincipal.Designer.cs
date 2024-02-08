namespace WindowsFormsApp1 {
	partial class TelaPrincipal {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panelConfigDB = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnTestar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.panelInserirMod = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listModulosAtivos = new System.Windows.Forms.ListView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtBoxPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.checkedListModulos = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblModulo = new System.Windows.Forms.Label();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.txtBoxModulo = new System.Windows.Forms.TextBox();
            this.btnInserirManual = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.MenuItemEditar = new System.Windows.Forms.MenuStrip();
            this.panelConfigDB.SuspendLayout();
            this.panelInserirMod.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(22, 10);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 16);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            // 
            // panelConfigDB
            // 
            this.panelConfigDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfigDB.Controls.Add(this.label5);
            this.panelConfigDB.Controls.Add(this.label4);
            this.panelConfigDB.Controls.Add(this.label3);
            this.panelConfigDB.Controls.Add(this.txtBase);
            this.panelConfigDB.Controls.Add(this.checkBox1);
            this.panelConfigDB.Controls.Add(this.btnProcurar);
            this.panelConfigDB.Controls.Add(this.btnTestar);
            this.panelConfigDB.Controls.Add(this.btnSalvar);
            this.panelConfigDB.Controls.Add(this.txtSenha);
            this.panelConfigDB.Controls.Add(this.txtUsuario);
            this.panelConfigDB.Controls.Add(this.txtServidor);
            this.panelConfigDB.Controls.Add(this.lblSenha);
            this.panelConfigDB.Controls.Add(this.lblUsuario);
            this.panelConfigDB.Controls.Add(this.lblBase);
            this.panelConfigDB.Controls.Add(this.lblServidor);
            this.panelConfigDB.Controls.Add(this.cbTipo);
            this.panelConfigDB.Controls.Add(this.lblTipo);
            this.panelConfigDB.Font = new System.Drawing.Font("Arial", 10F);
            this.panelConfigDB.Location = new System.Drawing.Point(9, 10);
            this.panelConfigDB.Margin = new System.Windows.Forms.Padding(2);
            this.panelConfigDB.Name = "panelConfigDB";
            this.panelConfigDB.Size = new System.Drawing.Size(766, 143);
            this.panelConfigDB.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "2 - Após , clique na \"Pasta\" para listar o banco desejado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "3 - Clique em salvar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "1 - Preencha todos os campos de acordo com seu banco de dados";
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.FormattingEnabled = true;
            this.txtBase.Items.AddRange(new object[] {
            "SQL",
            "ORACLE"});
            this.txtBase.Location = new System.Drawing.Point(77, 98);
            this.txtBase.Margin = new System.Windows.Forms.Padding(2);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(207, 21);
            this.txtBase.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(215, 165);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 20);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.MicrosoftTeams_image__2_;
            this.btnProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcurar.Location = new System.Drawing.Point(288, 94);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(29, 27);
            this.btnProcurar.TabIndex = 15;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // btnTestar
            // 
            this.btnTestar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Layer_2;
            this.btnTestar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTestar.Location = new System.Drawing.Point(331, 7);
            this.btnTestar.Margin = new System.Windows.Forms.Padding(2);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(39, 35);
            this.btnTestar.TabIndex = 14;
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Page_1;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Location = new System.Drawing.Point(387, 7);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(39, 35);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSenha.Location = new System.Drawing.Point(544, 58);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(162, 23);
            this.txtSenha.TabIndex = 11;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(544, 20);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(162, 23);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(77, 51);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(2);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(207, 23);
            this.txtServidor.TabIndex = 8;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(476, 58);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 16);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(476, 27);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 16);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(16, 99);
            this.lblBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(43, 16);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Base:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(16, 54);
            this.lblServidor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(64, 16);
            this.lblServidor.TabIndex = 3;
            this.lblServidor.Text = "Servidor:";
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "SQL",
            "ORACLE"});
            this.cbTipo.Location = new System.Drawing.Point(77, 9);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(207, 21);
            this.cbTipo.TabIndex = 2;
            // 
            // panelInserirMod
            // 
            this.panelInserirMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelInserirMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInserirMod.Controls.Add(this.label1);
            this.panelInserirMod.Controls.Add(this.label2);
            this.panelInserirMod.Controls.Add(this.listModulosAtivos);
            this.panelInserirMod.Controls.Add(this.btnInserir);
            this.panelInserirMod.Controls.Add(this.txtBoxPesquisar);
            this.panelInserirMod.Controls.Add(this.btnPesquisar);
            this.panelInserirMod.Controls.Add(this.checkedListModulos);
            this.panelInserirMod.Location = new System.Drawing.Point(9, 167);
            this.panelInserirMod.Margin = new System.Windows.Forms.Padding(2);
            this.panelInserirMod.Name = "panelInserirMod";
            this.panelInserirMod.Size = new System.Drawing.Size(766, 286);
            this.panelInserirMod.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "- Insira um modulo por vez";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pesquisar Modulo:";
            // 
            // listModulosAtivos
            // 
            this.listModulosAtivos.HideSelection = false;
            this.listModulosAtivos.Location = new System.Drawing.Point(470, 34);
            this.listModulosAtivos.Margin = new System.Windows.Forms.Padding(2);
            this.listModulosAtivos.Name = "listModulosAtivos";
            this.listModulosAtivos.Size = new System.Drawing.Size(287, 212);
            this.listModulosAtivos.TabIndex = 21;
            this.listModulosAtivos.UseCompatibleStateImageBehavior = false;
            this.listModulosAtivos.View = System.Windows.Forms.View.Details;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Arial", 10F);
            this.btnInserir.Location = new System.Drawing.Point(342, 122);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(62, 27);
            this.btnInserir.TabIndex = 18;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtBoxPesquisar
            // 
            this.txtBoxPesquisar.Location = new System.Drawing.Point(470, 8);
            this.txtBoxPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPesquisar.Multiline = true;
            this.txtBoxPesquisar.Name = "txtBoxPesquisar";
            this.txtBoxPesquisar.Size = new System.Drawing.Size(255, 23);
            this.txtBoxPesquisar.TabIndex = 16;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.search_svgrepo_com;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(733, 7);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(23, 25);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // checkedListModulos
            // 
            this.checkedListModulos.Font = new System.Drawing.Font("Arial", 10F);
            this.checkedListModulos.FormattingEnabled = true;
            this.checkedListModulos.Location = new System.Drawing.Point(20, 34);
            this.checkedListModulos.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListModulos.Name = "checkedListModulos";
            this.checkedListModulos.Size = new System.Drawing.Size(266, 202);
            this.checkedListModulos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.lblModulo);
            this.panel1.Controls.Add(this.txtBoxValor);
            this.panel1.Controls.Add(this.txtBoxModulo);
            this.panel1.Controls.Add(this.btnInserirManual);
            this.panel1.Location = new System.Drawing.Point(8, 466);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 92);
            this.panel1.TabIndex = 4;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial", 10F);
            this.lblValor.Location = new System.Drawing.Point(179, 60);
            this.lblValor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 16);
            this.lblValor.TabIndex = 22;
            this.lblValor.Text = "Valor:";
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblModulo.Location = new System.Drawing.Point(168, 16);
            this.lblModulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(57, 16);
            this.lblModulo.TabIndex = 21;
            this.lblModulo.Text = "Módulo:";
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBoxValor.Location = new System.Drawing.Point(232, 53);
            this.txtBoxValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxValor.Multiline = true;
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.Size = new System.Drawing.Size(391, 24);
            this.txtBoxValor.TabIndex = 20;
            // 
            // txtBoxModulo
            // 
            this.txtBoxModulo.Font = new System.Drawing.Font("Arial", 8F);
            this.txtBoxModulo.Location = new System.Drawing.Point(232, 11);
            this.txtBoxModulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxModulo.MaxLength = 50;
            this.txtBoxModulo.Multiline = true;
            this.txtBoxModulo.Name = "txtBoxModulo";
            this.txtBoxModulo.Size = new System.Drawing.Size(391, 21);
            this.txtBoxModulo.TabIndex = 17;
            // 
            // btnInserirManual
            // 
            this.btnInserirManual.Font = new System.Drawing.Font("Arial", 10F);
            this.btnInserirManual.Location = new System.Drawing.Point(645, 29);
            this.btnInserirManual.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserirManual.Name = "btnInserirManual";
            this.btnInserirManual.Size = new System.Drawing.Size(62, 27);
            this.btnInserirManual.TabIndex = 19;
            this.btnInserirManual.Text = "Inserir";
            this.btnInserirManual.UseVisualStyleBackColor = true;
            this.btnInserirManual.Click += new System.EventHandler(this.btnInserirManual_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // MenuItemEditar
            // 
            this.MenuItemEditar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuItemEditar.Location = new System.Drawing.Point(0, 0);
            this.MenuItemEditar.Name = "MenuItemEditar";
            this.MenuItemEditar.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuItemEditar.Size = new System.Drawing.Size(791, 24);
            this.MenuItemEditar.TabIndex = 6;
            this.MenuItemEditar.Text = "MenuItemEditar";
            this.MenuItemEditar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuItemEditar_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInserirMod);
            this.Controls.Add(this.panelConfigDB);
            this.Controls.Add(this.MenuItemEditar);
            this.MainMenuStrip = this.MenuItemEditar;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panelConfigDB.ResumeLayout(false);
            this.panelConfigDB.PerformLayout();
            this.panelInserirMod.ResumeLayout(false);
            this.panelInserirMod.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}


        #endregion
        private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Panel panelConfigDB;
		private System.Windows.Forms.Button btnProcurar;
		private System.Windows.Forms.Button btnTestar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtServidor;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblBase;
		private System.Windows.Forms.Label lblServidor;
		private System.Windows.Forms.ComboBox cbTipo;
		private System.Windows.Forms.Panel panelInserirMod;
		private System.Windows.Forms.Button btnInserir;
		private System.Windows.Forms.TextBox txtBoxPesquisar;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.CheckedListBox checkedListModulos;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Label lblModulo;
		private System.Windows.Forms.TextBox txtBoxValor;
		private System.Windows.Forms.TextBox txtBoxModulo;
		private System.Windows.Forms.Button btnInserirManual;
        private System.Windows.Forms.ComboBox txtBase;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView listModulosAtivos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.MenuStrip MenuItemEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}