namespace Projeto99Pet
{
    partial class ConsultaAnimal
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
            this.lstAnimais2 = new System.Windows.Forms.ListView();
            this.IdAnimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.Sexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Especie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Peso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Idade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Raca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Observacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstAnimais2
            // 
            this.lstAnimais2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdAnimal,
            this.Nome,
            this.Sexo,
            this.Especie,
            this.Peso,
            this.Idade,
            this.Tipo,
            this.Raca,
            this.Observacao});
            this.lstAnimais2.FullRowSelect = true;
            this.lstAnimais2.GridLines = true;
            this.lstAnimais2.Location = new System.Drawing.Point(17, 46);
            this.lstAnimais2.MultiSelect = false;
            this.lstAnimais2.Name = "lstAnimais2";
            this.lstAnimais2.Size = new System.Drawing.Size(582, 200);
            this.lstAnimais2.TabIndex = 0;
            this.lstAnimais2.UseCompatibleStateImageBehavior = false;
            this.lstAnimais2.View = System.Windows.Forms.View.Details;
            // 
            // IdAnimal
            // 
            this.IdAnimal.Text = "ID";
            this.IdAnimal.Width = 31;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meus Pet";
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(204, 268);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(323, 268);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // Sexo
            // 
            this.Sexo.Text = "Sexo";
            this.Sexo.Width = 61;
            // 
            // Especie
            // 
            this.Especie.Text = "Espécie";
            this.Especie.Width = 65;
            // 
            // Peso
            // 
            this.Peso.Text = "Peso";
            this.Peso.Width = 44;
            // 
            // Idade
            // 
            this.Idade.Text = "Idade";
            this.Idade.Width = 43;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            // 
            // Raca
            // 
            this.Raca.Text = "Raça";
            // 
            // Observacao
            // 
            this.Observacao.Text = "Observação";
            this.Observacao.Width = 112;
            // 
            // ConsultaAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 306);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAnimais2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ConsultaAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Animais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstAnimais2;
        private System.Windows.Forms.ColumnHeader IdAnimal;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.ColumnHeader Sexo;
        private System.Windows.Forms.ColumnHeader Especie;
        private System.Windows.Forms.ColumnHeader Peso;
        private System.Windows.Forms.ColumnHeader Idade;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Raca;
        private System.Windows.Forms.ColumnHeader Observacao;
    }
}