namespace WindowsFormsApp3
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
            this.tbNomeDoUsuario = new System.Windows.Forms.TextBox();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewUsuario = new System.Windows.Forms.ListView();
            this.columnIdUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNomeCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNomeDoUsuario
            // 
            this.tbNomeDoUsuario.Location = new System.Drawing.Point(140, 69);
            this.tbNomeDoUsuario.Name = "tbNomeDoUsuario";
            this.tbNomeDoUsuario.Size = new System.Drawing.Size(196, 20);
            this.tbNomeDoUsuario.TabIndex = 2;
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConectar.Location = new System.Drawing.Point(12, 175);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(120, 45);
            this.buttonConectar.TabIndex = 3;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = false;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(12, 246);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(120, 43);
            this.buttonAdicionar.TabIndex = 4;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.Location = new System.Drawing.Point(12, 308);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(120, 43);
            this.buttonRemover.TabIndex = 5;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = false;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Completo:";
            // 
            // listViewUsuario
            // 
            this.listViewUsuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdUsuario,
            this.columnNomeCompleto,
            this.columnEmail});
            this.listViewUsuario.HideSelection = false;
            this.listViewUsuario.Location = new System.Drawing.Point(353, 12);
            this.listViewUsuario.Name = "listViewUsuario";
            this.listViewUsuario.Size = new System.Drawing.Size(481, 327);
            this.listViewUsuario.TabIndex = 7;
            this.listViewUsuario.UseCompatibleStateImageBehavior = false;
            this.listViewUsuario.View = System.Windows.Forms.View.Details;
            // 
            // columnIdUsuario
            // 
            this.columnIdUsuario.Text = "Id Usuário";
            // 
            // columnNomeCompleto
            // 
            this.columnNomeCompleto.Text = "Nome Completo";
            this.columnNomeCompleto.Width = 150;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id Usuario:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(113, 13);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(115, 20);
            this.tbId.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 351);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.tbNomeDoUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CADASTRO DE USUÁRIOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNomeDoUsuario;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewUsuario;
        private System.Windows.Forms.ColumnHeader columnIdUsuario;
        private System.Windows.Forms.ColumnHeader columnNomeCompleto;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
    }
}

