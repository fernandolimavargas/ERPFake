namespace Cadastro_de_Material
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
            this.components = new System.ComponentModel.Container();
            this.Cod_Box = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.FamiliaComboBox = new System.Windows.Forms.ComboBox();
            this.familiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRPFAKEDataSet = new Cadastro_de_Material.ERPFAKEDataSet();
            this.SubFamiliaComboBox = new System.Windows.Forms.ComboBox();
            this.subfamiliaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRPFAKEDataSet2 = new Cadastro_de_Material.ERPFAKEDataSet2();
            this.unidadeBox = new System.Windows.Forms.ComboBox();
            this.Des_Box = new System.Windows.Forms.TextBox();
            this.familiaTableAdapter = new Cadastro_de_Material.ERPFAKEDataSetTableAdapters.familiaTableAdapter();
            this.eRPFAKEDataSet1 = new Cadastro_de_Material.ERPFAKEDataSet1();
            this.familiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.familiaTableAdapter1 = new Cadastro_de_Material.ERPFAKEDataSet1TableAdapters.FamiliaTableAdapter();
            this.subfamiliaTableAdapter = new Cadastro_de_Material.ERPFAKEDataSet2TableAdapters.SubfamiliaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subfamiliaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cod_Box
            // 
            this.Cod_Box.Location = new System.Drawing.Point(162, 102);
            this.Cod_Box.Name = "Cod_Box";
            this.Cod_Box.ReadOnly = true;
            this.Cod_Box.Size = new System.Drawing.Size(39, 20);
            this.Cod_Box.TabIndex = 0;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(113, 105);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(43, 13);
            this.lbCodigo.TabIndex = 2;
            this.lbCodigo.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Familia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "SubFamilia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Unidade de Medida:";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(126, 314);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "Inserir";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(224, 314);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Atualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(325, 314);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Excluir";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(427, 314);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Pesquisar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(523, 314);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FamiliaComboBox
            // 
            this.FamiliaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.familiaBindingSource, "descricao", true));
            this.FamiliaComboBox.DataSource = this.familiaBindingSource;
            this.FamiliaComboBox.DisplayMember = "descricao";
            this.FamiliaComboBox.FormattingEnabled = true;
            this.FamiliaComboBox.Location = new System.Drawing.Point(162, 175);
            this.FamiliaComboBox.Name = "FamiliaComboBox";
            this.FamiliaComboBox.Size = new System.Drawing.Size(137, 21);
            this.FamiliaComboBox.TabIndex = 12;
            this.FamiliaComboBox.ValueMember = "descricao";
            this.FamiliaComboBox.SelectedIndexChanged += new System.EventHandler(this.FamiliaComboBox_SelectedIndexChanged);
            // 
            // familiaBindingSource
            // 
            this.familiaBindingSource.DataMember = "familia";
            this.familiaBindingSource.DataSource = this.eRPFAKEDataSet;
            // 
            // eRPFAKEDataSet
            // 
            this.eRPFAKEDataSet.DataSetName = "ERPFAKEDataSet";
            this.eRPFAKEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SubFamiliaComboBox
            // 
            this.SubFamiliaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subfamiliaBindingSource, "descricao", true));
            this.SubFamiliaComboBox.DataSource = this.subfamiliaBindingSource;
            this.SubFamiliaComboBox.DisplayMember = "descricao";
            this.SubFamiliaComboBox.FormattingEnabled = true;
            this.SubFamiliaComboBox.Location = new System.Drawing.Point(162, 217);
            this.SubFamiliaComboBox.Name = "SubFamiliaComboBox";
            this.SubFamiliaComboBox.Size = new System.Drawing.Size(137, 21);
            this.SubFamiliaComboBox.TabIndex = 13;
            this.SubFamiliaComboBox.ValueMember = "descricao";
            this.SubFamiliaComboBox.SelectedIndexChanged += new System.EventHandler(this.SubFamiliaComboBox_SelectedIndexChanged);
            // 
            // subfamiliaBindingSource
            // 
            this.subfamiliaBindingSource.DataMember = "Subfamilia";
            this.subfamiliaBindingSource.DataSource = this.eRPFAKEDataSet2;
            // 
            // eRPFAKEDataSet2
            // 
            this.eRPFAKEDataSet2.DataSetName = "ERPFAKEDataSet2";
            this.eRPFAKEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unidadeBox
            // 
            this.unidadeBox.FormattingEnabled = true;
            this.unidadeBox.Items.AddRange(new object[] {
            "Milímetros",
            "Centímetros",
            "Metros"});
            this.unidadeBox.Location = new System.Drawing.Point(162, 258);
            this.unidadeBox.Name = "unidadeBox";
            this.unidadeBox.Size = new System.Drawing.Size(137, 21);
            this.unidadeBox.TabIndex = 14;
            // 
            // Des_Box
            // 
            this.Des_Box.Location = new System.Drawing.Point(162, 136);
            this.Des_Box.MaxLength = 100;
            this.Des_Box.Name = "Des_Box";
            this.Des_Box.Size = new System.Drawing.Size(436, 20);
            this.Des_Box.TabIndex = 1;
            // 
            // familiaTableAdapter
            // 
            this.familiaTableAdapter.ClearBeforeFill = true;
            // 
            // eRPFAKEDataSet1
            // 
            this.eRPFAKEDataSet1.DataSetName = "ERPFAKEDataSet1";
            this.eRPFAKEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // familiaBindingSource1
            // 
            this.familiaBindingSource1.DataMember = "Familia";
            this.familiaBindingSource1.DataSource = this.eRPFAKEDataSet1;
            // 
            // familiaTableAdapter1
            // 
            this.familiaTableAdapter1.ClearBeforeFill = true;
            // 
            // subfamiliaTableAdapter
            // 
            this.subfamiliaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 377);
            this.Controls.Add(this.unidadeBox);
            this.Controls.Add(this.SubFamiliaComboBox);
            this.Controls.Add(this.FamiliaComboBox);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.Des_Box);
            this.Controls.Add(this.Cod_Box);
            this.Name = "Form1";
            this.Text = "Cadastro de Material";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subfamiliaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cod_Box;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox FamiliaComboBox;
        private System.Windows.Forms.ComboBox SubFamiliaComboBox;
        private System.Windows.Forms.ComboBox unidadeBox;
        private System.Windows.Forms.TextBox Des_Box;
        private ERPFAKEDataSet eRPFAKEDataSet;
        private System.Windows.Forms.BindingSource familiaBindingSource;
        private ERPFAKEDataSetTableAdapters.familiaTableAdapter familiaTableAdapter;
        private ERPFAKEDataSet1 eRPFAKEDataSet1;
        private System.Windows.Forms.BindingSource familiaBindingSource1;
        private ERPFAKEDataSet1TableAdapters.FamiliaTableAdapter familiaTableAdapter1;
        private ERPFAKEDataSet2 eRPFAKEDataSet2;
        private System.Windows.Forms.BindingSource subfamiliaBindingSource;
        private ERPFAKEDataSet2TableAdapters.SubfamiliaTableAdapter subfamiliaTableAdapter;
    }
}

