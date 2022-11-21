namespace MonMaperRush
{
    partial class PaginaInicial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_FecharSistema = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_IdTransference = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Lbl_DadosPagamento = new System.Windows.Forms.Label();
            this.Group_DadosPagamento = new System.Windows.Forms.GroupBox();
            this.Cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.Txt_DataTransferencia = new System.Windows.Forms.TextBox();
            this.DTP_DataTransferencia = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Detalhes = new System.Windows.Forms.Label();
            this.Lbl_Origem = new System.Windows.Forms.Label();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Lbl_Data = new System.Windows.Forms.Label();
            this.Txt_Origem = new System.Windows.Forms.TextBox();
            this.Txt_Detalhes = new System.Windows.Forms.TextBox();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Grid_Transferencias = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_AreaDePesquisa = new System.Windows.Forms.Label();
            this.Btn_SelecionarTodos = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Lbl_ResultadoPesquisa = new System.Windows.Forms.Label();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Group_DadosPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Transferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_FecharSistema
            // 
            this.Btn_FecharSistema.BackColor = System.Drawing.Color.Red;
            this.Btn_FecharSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_FecharSistema.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_FecharSistema.ForeColor = System.Drawing.Color.White;
            this.Btn_FecharSistema.Location = new System.Drawing.Point(1242, 0);
            this.Btn_FecharSistema.Name = "Btn_FecharSistema";
            this.Btn_FecharSistema.Size = new System.Drawing.Size(22, 24);
            this.Btn_FecharSistema.TabIndex = 7;
            this.Btn_FecharSistema.Text = "X";
            this.Btn_FecharSistema.UseVisualStyleBackColor = false;
            this.Btn_FecharSistema.Click += new System.EventHandler(this.Btn_FecharSistema_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Lbl_IdTransference);
            this.panel1.Controls.Add(this.Btn_Cancelar);
            this.panel1.Controls.Add(this.Btn_Salvar);
            this.panel1.Controls.Add(this.Lbl_DadosPagamento);
            this.panel1.Controls.Add(this.Group_DadosPagamento);
            this.panel1.Location = new System.Drawing.Point(31, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 125);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_IdTransference
            // 
            this.Lbl_IdTransference.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_IdTransference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Lbl_IdTransference.Location = new System.Drawing.Point(233, 6);
            this.Lbl_IdTransference.Name = "Lbl_IdTransference";
            this.Lbl_IdTransference.Size = new System.Drawing.Size(100, 30);
            this.Lbl_IdTransference.TabIndex = 1;
            this.Lbl_IdTransference.Text = "0";
            this.Lbl_IdTransference.TextChanged += new System.EventHandler(this.Lbl_IdTransference_TextChanged);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cancelar.FlatAppearance.BorderSize = 2;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancelar.Location = new System.Drawing.Point(1064, 48);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(101, 50);
            this.Btn_Cancelar.TabIndex = 4;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Salvar.FlatAppearance.BorderSize = 2;
            this.Btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salvar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.Btn_Salvar.Location = new System.Drawing.Point(938, 48);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(101, 50);
            this.Btn_Salvar.TabIndex = 3;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Lbl_DadosPagamento
            // 
            this.Lbl_DadosPagamento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_DadosPagamento.ForeColor = System.Drawing.Color.White;
            this.Lbl_DadosPagamento.Location = new System.Drawing.Point(-4, 6);
            this.Lbl_DadosPagamento.Name = "Lbl_DadosPagamento";
            this.Lbl_DadosPagamento.Size = new System.Drawing.Size(441, 35);
            this.Lbl_DadosPagamento.TabIndex = 0;
            this.Lbl_DadosPagamento.Text = "Dados do Pagamento";
            // 
            // Group_DadosPagamento
            // 
            this.Group_DadosPagamento.Controls.Add(this.Cmb_Tipo);
            this.Group_DadosPagamento.Controls.Add(this.Txt_DataTransferencia);
            this.Group_DadosPagamento.Controls.Add(this.DTP_DataTransferencia);
            this.Group_DadosPagamento.Controls.Add(this.Lbl_Detalhes);
            this.Group_DadosPagamento.Controls.Add(this.Lbl_Origem);
            this.Group_DadosPagamento.Controls.Add(this.Lbl_Tipo);
            this.Group_DadosPagamento.Controls.Add(this.Lbl_Valor);
            this.Group_DadosPagamento.Controls.Add(this.Lbl_Data);
            this.Group_DadosPagamento.Controls.Add(this.Txt_Origem);
            this.Group_DadosPagamento.Controls.Add(this.Txt_Detalhes);
            this.Group_DadosPagamento.Controls.Add(this.Txt_Valor);
            this.Group_DadosPagamento.Location = new System.Drawing.Point(3, 33);
            this.Group_DadosPagamento.Name = "Group_DadosPagamento";
            this.Group_DadosPagamento.Size = new System.Drawing.Size(906, 80);
            this.Group_DadosPagamento.TabIndex = 2;
            this.Group_DadosPagamento.TabStop = false;
            // 
            // Cmb_Tipo
            // 
            this.Cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Tipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cmb_Tipo.FormattingEnabled = true;
            this.Cmb_Tipo.Location = new System.Drawing.Point(276, 42);
            this.Cmb_Tipo.Name = "Cmb_Tipo";
            this.Cmb_Tipo.Size = new System.Drawing.Size(121, 29);
            this.Cmb_Tipo.TabIndex = 6;
            // 
            // Txt_DataTransferencia
            // 
            this.Txt_DataTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_DataTransferencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_DataTransferencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_DataTransferencia.Location = new System.Drawing.Point(6, 42);
            this.Txt_DataTransferencia.Name = "Txt_DataTransferencia";
            this.Txt_DataTransferencia.Size = new System.Drawing.Size(100, 29);
            this.Txt_DataTransferencia.TabIndex = 1;
            this.Txt_DataTransferencia.Text = "22/10/2022";
            // 
            // DTP_DataTransferencia
            // 
            this.DTP_DataTransferencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTP_DataTransferencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DataTransferencia.Location = new System.Drawing.Point(6, 42);
            this.DTP_DataTransferencia.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.DTP_DataTransferencia.Name = "DTP_DataTransferencia";
            this.DTP_DataTransferencia.Size = new System.Drawing.Size(132, 29);
            this.DTP_DataTransferencia.TabIndex = 2;
            this.DTP_DataTransferencia.ValueChanged += new System.EventHandler(this.DTP_DataTransferencia_ValueChanged);
            // 
            // Lbl_Detalhes
            // 
            this.Lbl_Detalhes.AutoSize = true;
            this.Lbl_Detalhes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Detalhes.ForeColor = System.Drawing.Color.White;
            this.Lbl_Detalhes.Location = new System.Drawing.Point(574, 20);
            this.Lbl_Detalhes.Name = "Lbl_Detalhes";
            this.Lbl_Detalhes.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Detalhes.TabIndex = 9;
            this.Lbl_Detalhes.Text = "Detalhes";
            // 
            // Lbl_Origem
            // 
            this.Lbl_Origem.AutoSize = true;
            this.Lbl_Origem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Origem.ForeColor = System.Drawing.Color.White;
            this.Lbl_Origem.Location = new System.Drawing.Point(399, 20);
            this.Lbl_Origem.Name = "Lbl_Origem";
            this.Lbl_Origem.Size = new System.Drawing.Size(59, 20);
            this.Lbl_Origem.TabIndex = 7;
            this.Lbl_Origem.Text = "Origem";
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Tipo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Tipo.Location = new System.Drawing.Point(272, 20);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(39, 20);
            this.Lbl_Tipo.TabIndex = 5;
            this.Lbl_Tipo.Text = "Tipo";
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Valor.ForeColor = System.Drawing.Color.White;
            this.Lbl_Valor.Location = new System.Drawing.Point(141, 20);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(43, 20);
            this.Lbl_Valor.TabIndex = 3;
            this.Lbl_Valor.Text = "Valor";
            // 
            // Lbl_Data
            // 
            this.Lbl_Data.AutoSize = true;
            this.Lbl_Data.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Data.ForeColor = System.Drawing.Color.White;
            this.Lbl_Data.Location = new System.Drawing.Point(2, 20);
            this.Lbl_Data.Name = "Lbl_Data";
            this.Lbl_Data.Size = new System.Drawing.Size(41, 20);
            this.Lbl_Data.TabIndex = 0;
            this.Lbl_Data.Text = "Data";
            // 
            // Txt_Origem
            // 
            this.Txt_Origem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_Origem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Origem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Origem.Location = new System.Drawing.Point(403, 42);
            this.Txt_Origem.Name = "Txt_Origem";
            this.Txt_Origem.Size = new System.Drawing.Size(169, 29);
            this.Txt_Origem.TabIndex = 8;
            // 
            // Txt_Detalhes
            // 
            this.Txt_Detalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_Detalhes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Detalhes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Detalhes.Location = new System.Drawing.Point(578, 42);
            this.Txt_Detalhes.Multiline = true;
            this.Txt_Detalhes.Name = "Txt_Detalhes";
            this.Txt_Detalhes.Size = new System.Drawing.Size(319, 29);
            this.Txt_Detalhes.TabIndex = 10;
            this.Txt_Detalhes.WordWrap = false;
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Txt_Valor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Valor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt_Valor.Location = new System.Drawing.Point(144, 42);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(126, 29);
            this.Txt_Valor.TabIndex = 4;
            // 
            // Grid_Transferencias
            // 
            this.Grid_Transferencias.AllowUserToAddRows = false;
            this.Grid_Transferencias.AllowUserToDeleteRows = false;
            this.Grid_Transferencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Grid_Transferencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid_Transferencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Transferencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Transferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Transferencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.select,
            this.date,
            this.kind,
            this.amount,
            this.source,
            this.details,
            this.insertDate,
            this.updateDate});
            this.Grid_Transferencias.Location = new System.Drawing.Point(31, 211);
            this.Grid_Transferencias.Name = "Grid_Transferencias";
            this.Grid_Transferencias.ReadOnly = true;
            this.Grid_Transferencias.RowHeadersVisible = false;
            this.Grid_Transferencias.RowTemplate.Height = 25;
            this.Grid_Transferencias.Size = new System.Drawing.Size(1196, 447);
            this.Grid_Transferencias.TabIndex = 6;
            this.Grid_Transferencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Transferencias_CellDoubleClick);
            this.Grid_Transferencias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Grid_Transferencias_KeyUp);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // select
            // 
            this.select.HeaderText = "x";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // kind
            // 
            this.kind.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kind.HeaderText = "Tipo";
            this.kind.Name = "kind";
            this.kind.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amount.HeaderText = "Valor";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // source
            // 
            this.source.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.source.HeaderText = "Origem";
            this.source.Name = "source";
            this.source.ReadOnly = true;
            // 
            // details
            // 
            this.details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.details.HeaderText = "Detalhes";
            this.details.Name = "details";
            this.details.ReadOnly = true;
            // 
            // insertDate
            // 
            this.insertDate.HeaderText = "Inserido";
            this.insertDate.Name = "insertDate";
            this.insertDate.ReadOnly = true;
            // 
            // updateDate
            // 
            this.updateDate.HeaderText = "Atualizado";
            this.updateDate.Name = "updateDate";
            this.updateDate.ReadOnly = true;
            // 
            // Lbl_AreaDePesquisa
            // 
            this.Lbl_AreaDePesquisa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_AreaDePesquisa.ForeColor = System.Drawing.Color.White;
            this.Lbl_AreaDePesquisa.Location = new System.Drawing.Point(28, 177);
            this.Lbl_AreaDePesquisa.Name = "Lbl_AreaDePesquisa";
            this.Lbl_AreaDePesquisa.Size = new System.Drawing.Size(205, 32);
            this.Lbl_AreaDePesquisa.TabIndex = 1;
            this.Lbl_AreaDePesquisa.Text = "Área de Pesquisa";
            // 
            // Btn_SelecionarTodos
            // 
            this.Btn_SelecionarTodos.BackColor = System.Drawing.Color.Transparent;
            this.Btn_SelecionarTodos.FlatAppearance.BorderSize = 2;
            this.Btn_SelecionarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SelecionarTodos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_SelecionarTodos.ForeColor = System.Drawing.Color.White;
            this.Btn_SelecionarTodos.Location = new System.Drawing.Point(921, 167);
            this.Btn_SelecionarTodos.Name = "Btn_SelecionarTodos";
            this.Btn_SelecionarTodos.Size = new System.Drawing.Size(184, 38);
            this.Btn_SelecionarTodos.TabIndex = 4;
            this.Btn_SelecionarTodos.Text = "Selecionar todos";
            this.Btn_SelecionarTodos.UseVisualStyleBackColor = false;
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Excluir.FlatAppearance.BorderSize = 2;
            this.Btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.Btn_Excluir.Location = new System.Drawing.Point(1111, 167);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(116, 38);
            this.Btn_Excluir.TabIndex = 5;
            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.UseVisualStyleBackColor = false;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Lbl_ResultadoPesquisa
            // 
            this.Lbl_ResultadoPesquisa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ResultadoPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Lbl_ResultadoPesquisa.Location = new System.Drawing.Point(239, 178);
            this.Lbl_ResultadoPesquisa.Name = "Lbl_ResultadoPesquisa";
            this.Lbl_ResultadoPesquisa.Size = new System.Drawing.Size(100, 30);
            this.Lbl_ResultadoPesquisa.TabIndex = 2;
            this.Lbl_ResultadoPesquisa.Text = "0";
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Atualizar.FlatAppearance.BorderSize = 2;
            this.Btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Atualizar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Atualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Atualizar.Location = new System.Drawing.Point(788, 167);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(127, 38);
            this.Btn_Atualizar.TabIndex = 3;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = false;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Lbl_ResultadoPesquisa);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_SelecionarTodos);
            this.Controls.Add(this.Lbl_AreaDePesquisa);
            this.Controls.Add(this.Grid_Transferencias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_FecharSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimizeBox = false;
            this.Name = "PaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MONMAPER - Money Management Helper";
            this.Load += new System.EventHandler(this.PaginaInicial_Load);
            this.panel1.ResumeLayout(false);
            this.Group_DadosPagamento.ResumeLayout(false);
            this.Group_DadosPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Transferencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_FecharSistema;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Label Lbl_DadosPagamento;
        private System.Windows.Forms.GroupBox Group_DadosPagamento;
        private System.Windows.Forms.DataGridView Grid_Transferencias;
        private System.Windows.Forms.Label Lbl_AreaDePesquisa;
        private System.Windows.Forms.Button Btn_SelecionarTodos;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Label Lbl_IdTransference;
        private System.Windows.Forms.Label Lbl_Detalhes;
        private System.Windows.Forms.Label Lbl_Origem;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Label Lbl_Data;
        private System.Windows.Forms.TextBox Txt_DataTransferencia;
        private System.Windows.Forms.TextBox Txt_Origem;
        private System.Windows.Forms.TextBox Txt_Detalhes;
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.DateTimePicker DTP_DataTransferencia;
        private System.Windows.Forms.ComboBox Cmb_Tipo;
        private System.Windows.Forms.Label Lbl_ResultadoPesquisa;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn source;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDate;
    }
}