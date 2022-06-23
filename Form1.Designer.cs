namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView_medidasGlicemias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_conectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbmedidaGlicemia = new System.Windows.Forms.TextBox();
            this.tbValorGlicemia = new System.Windows.Forms.TextBox();
            this.tbDataMedicao = new System.Windows.Forms.TextBox();
            this.tbPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.button_desconectar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nomeBanco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_medidasGlicemias
            // 
            this.listView_medidasGlicemias.BackColor = System.Drawing.Color.RosyBrown;
            this.listView_medidasGlicemias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_medidasGlicemias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_medidasGlicemias.HideSelection = false;
            this.listView_medidasGlicemias.Location = new System.Drawing.Point(-1, 0);
            this.listView_medidasGlicemias.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.listView_medidasGlicemias.Name = "listView_medidasGlicemias";
            this.listView_medidasGlicemias.Size = new System.Drawing.Size(657, 252);
            this.listView_medidasGlicemias.TabIndex = 0;
            this.listView_medidasGlicemias.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "idMedidaGlicemia";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor Glicemia";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data da Medição";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Paciente";
            this.columnHeader4.Width = 100;
            // 
            // button_conectar
            // 
            this.button_conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_conectar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_conectar.Location = new System.Drawing.Point(497, 261);
            this.button_conectar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(159, 52);
            this.button_conectar.TabIndex = 1;
            this.button_conectar.Text = "Conectar";
            this.button_conectar.UseVisualStyleBackColor = false;
            this.button_conectar.Click += new System.EventHandler(this.button_conectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Medida Glicemia:";
            // 
            // tbmedidaGlicemia
            // 
            this.tbmedidaGlicemia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbmedidaGlicemia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmedidaGlicemia.Location = new System.Drawing.Point(183, 316);
            this.tbmedidaGlicemia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbmedidaGlicemia.Name = "tbmedidaGlicemia";
            this.tbmedidaGlicemia.Size = new System.Drawing.Size(94, 22);
            this.tbmedidaGlicemia.TabIndex = 3;
            // 
            // tbValorGlicemia
            // 
            this.tbValorGlicemia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbValorGlicemia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorGlicemia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbValorGlicemia.Location = new System.Drawing.Point(183, 366);
            this.tbValorGlicemia.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbValorGlicemia.Name = "tbValorGlicemia";
            this.tbValorGlicemia.Size = new System.Drawing.Size(94, 22);
            this.tbValorGlicemia.TabIndex = 4;
            // 
            // tbDataMedicao
            // 
            this.tbDataMedicao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDataMedicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDataMedicao.Location = new System.Drawing.Point(183, 422);
            this.tbDataMedicao.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbDataMedicao.Name = "tbDataMedicao";
            this.tbDataMedicao.Size = new System.Drawing.Size(94, 22);
            this.tbDataMedicao.TabIndex = 5;
            this.tbDataMedicao.TextChanged += new System.EventHandler(this.tbDataMedicao_TextChanged);
            // 
            // tbPaciente
            // 
            this.tbPaciente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPaciente.Location = new System.Drawing.Point(183, 468);
            this.tbPaciente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.Size = new System.Drawing.Size(94, 22);
            this.tbPaciente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor Glicemia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 422);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data Medição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 472);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id Paciente:";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(497, 325);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(159, 52);
            this.buttonCadastrar.TabIndex = 10;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRemover.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(497, 385);
            this.btRemover.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(162, 52);
            this.btRemover.TabIndex = 12;
            this.btRemover.Text = "Remover item";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // button_desconectar
            // 
            this.button_desconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_desconectar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_desconectar.Location = new System.Drawing.Point(494, 454);
            this.button_desconectar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button_desconectar.Name = "button_desconectar";
            this.button_desconectar.Size = new System.Drawing.Size(162, 52);
            this.button_desconectar.TabIndex = 13;
            this.button_desconectar.Text = "Desconectar";
            this.button_desconectar.UseVisualStyleBackColor = false;
            this.button_desconectar.Click += new System.EventHandler(this.button_desconectar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome do banco:";
            // 
            // textBox_nomeBanco
            // 
            this.textBox_nomeBanco.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_nomeBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nomeBanco.Location = new System.Drawing.Point(183, 273);
            this.textBox_nomeBanco.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox_nomeBanco.Name = "textBox_nomeBanco";
            this.textBox_nomeBanco.Size = new System.Drawing.Size(94, 22);
            this.textBox_nomeBanco.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(659, 519);
            this.Controls.Add(this.textBox_nomeBanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_desconectar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPaciente);
            this.Controls.Add(this.tbDataMedicao);
            this.Controls.Add(this.tbValorGlicemia);
            this.Controls.Add(this.tbmedidaGlicemia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_conectar);
            this.Controls.Add(this.listView_medidasGlicemias);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.Text = "GESTÃO DE MEDIDAS GLICÊMICAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_medidasGlicemias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button_conectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbmedidaGlicemia;
        private System.Windows.Forms.TextBox tbValorGlicemia;
        private System.Windows.Forms.TextBox tbDataMedicao;
        private System.Windows.Forms.TextBox tbPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button button_desconectar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_nomeBanco;
    }
}

