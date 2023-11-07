namespace Cadastro_de_Material
{
    partial class MostraPesquisa
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
            this.components = new System.ComponentModel.Container();
            this.familiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRPFAKEDataSet = new Cadastro_de_Material.ERPFAKEDataSet();
            this.familiaTableAdapter = new Cadastro_de_Material.ERPFAKEDataSetTableAdapters.familiaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.NovaDescricaoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultdataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.Familia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NovaFamiliaComboBox = new System.Windows.Forms.ComboBox();
            this.NovaSubFamiliaComboBox = new System.Windows.Forms.ComboBox();
            this.eRPFAKEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eRPFAKEDataSet3 = new Cadastro_de_Material.ERPFAKEDataSet3();
            this.subfamiliaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subfamiliaTableAdapter = new Cadastro_de_Material.ERPFAKEDataSet3TableAdapters.SubfamiliaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subfamiliaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // familiaTableAdapter
            // 
            this.familiaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(20, 102);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(63, 20);
            this.SearchBox.TabIndex = 1;
            // 
            // NovaDescricaoTextBox
            // 
            this.NovaDescricaoTextBox.Location = new System.Drawing.Point(20, 157);
            this.NovaDescricaoTextBox.Name = "NovaDescricaoTextBox";
            this.NovaDescricaoTextBox.Size = new System.Drawing.Size(259, 20);
            this.NovaDescricaoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mercadoria";
            // 
            // ResultdataGridView
            // 
            this.ResultdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultdataGridView.Location = new System.Drawing.Point(297, 49);
            this.ResultdataGridView.Name = "ResultdataGridView";
            this.ResultdataGridView.Size = new System.Drawing.Size(463, 376);
            this.ResultdataGridView.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(111, 389);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Atualizar";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Familia
            // 
            this.Familia.AutoSize = true;
            this.Familia.Location = new System.Drawing.Point(17, 208);
            this.Familia.Name = "Familia";
            this.Familia.Size = new System.Drawing.Size(39, 13);
            this.Familia.TabIndex = 8;
            this.Familia.Text = "Familia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sub Familia";
            // 
            // NovaFamiliaComboBox
            // 
            this.NovaFamiliaComboBox.DataSource = this.familiaBindingSource;
            this.NovaFamiliaComboBox.DisplayMember = "descricao";
            this.NovaFamiliaComboBox.FormattingEnabled = true;
            this.NovaFamiliaComboBox.Location = new System.Drawing.Point(20, 224);
            this.NovaFamiliaComboBox.Name = "NovaFamiliaComboBox";
            this.NovaFamiliaComboBox.Size = new System.Drawing.Size(138, 21);
            this.NovaFamiliaComboBox.TabIndex = 12;
            this.NovaFamiliaComboBox.ValueMember = "descricao";
            // 
            // NovaSubFamiliaComboBox
            // 
            this.NovaSubFamiliaComboBox.DataSource = this.subfamiliaBindingSource;
            this.NovaSubFamiliaComboBox.DisplayMember = "descricao";
            this.NovaSubFamiliaComboBox.FormattingEnabled = true;
            this.NovaSubFamiliaComboBox.Location = new System.Drawing.Point(20, 281);
            this.NovaSubFamiliaComboBox.Name = "NovaSubFamiliaComboBox";
            this.NovaSubFamiliaComboBox.Size = new System.Drawing.Size(138, 21);
            this.NovaSubFamiliaComboBox.TabIndex = 13;
            this.NovaSubFamiliaComboBox.ValueMember = "descricao";
            // 
            // eRPFAKEDataSetBindingSource
            // 
            this.eRPFAKEDataSetBindingSource.DataSource = this.eRPFAKEDataSet;
            this.eRPFAKEDataSetBindingSource.Position = 0;
            // 
            // eRPFAKEDataSet3
            // 
            this.eRPFAKEDataSet3.DataSetName = "ERPFAKEDataSet3";
            this.eRPFAKEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subfamiliaBindingSource
            // 
            this.subfamiliaBindingSource.DataMember = "Subfamilia";
            this.subfamiliaBindingSource.DataSource = this.eRPFAKEDataSet3;
            // 
            // subfamiliaTableAdapter
            // 
            this.subfamiliaTableAdapter.ClearBeforeFill = true;
            // 
            // MostraPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NovaSubFamiliaComboBox);
            this.Controls.Add(this.NovaFamiliaComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Familia);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ResultdataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NovaDescricaoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label1);
            this.Name = "MostraPesquisa";
            this.Text = "MostraPesquisa";
            this.Load += new System.EventHandler(this.MostraPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPFAKEDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subfamiliaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ERPFAKEDataSet eRPFAKEDataSet;
        private System.Windows.Forms.BindingSource familiaBindingSource;
        private ERPFAKEDataSetTableAdapters.familiaTableAdapter familiaTableAdapter;
        private System.Windows.Forms.TextBox SearchBox;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NovaDescricaoTextBox;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ResultdataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.Label Familia;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NovaFamiliaComboBox;
        private System.Windows.Forms.ComboBox NovaSubFamiliaComboBox;
        private System.Windows.Forms.BindingSource eRPFAKEDataSetBindingSource;
        private ERPFAKEDataSet3 eRPFAKEDataSet3;
        private System.Windows.Forms.BindingSource subfamiliaBindingSource;
        private ERPFAKEDataSet3TableAdapters.SubfamiliaTableAdapter subfamiliaTableAdapter;
    }
}