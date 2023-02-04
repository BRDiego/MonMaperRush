using System;
using System.Windows.Forms;
using Model;
using DataAcessLayer;
using Model.Utilities;
using MonMaperRush.InterfaceUtilities;
using System.Collections.Generic;

namespace MonMaperRush
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }
        private void Btn_FecharSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConfigureForm()
        {
            Cmb_Tipo.Items.Clear();
            Cmb_Tipo.Items.Add("");
            Cmb_Tipo.Items.Add("Ganho");
            Cmb_Tipo.Items.Add("Gasto");

            Txt_Valor.LostFocus += UIX.MonetaryTextBox;
            Txt_Valor.Leave += UIX.MonetaryTextBox;

            Txt_DataTransferencia.LostFocus += UIX.DateTextBox;
            Txt_DataTransferencia.Leave += UIX.DateTextBox;

            DTP_DataTransferencia.MaxDate = DateTime.Now;

            Grid_Transferencias.ReadOnly = false;

            foreach (DataGridViewColumn column in Grid_Transferencias.Columns)
            {
                column.ReadOnly = true;
            }
            Grid_Transferencias.Columns["select"].ReadOnly = false;
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigureForm();

                Txt_DataTransferencia.Text = DateTime.Now.ToString("dd/MM/yyyy");

                RefreshTransferencesList();
            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao Iniciar formulário", UIX.DisplayInteraction.Critical, "", err.ToString());
            }
        }

        private void Lbl_IdTransference_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)GenericFunctions.Val(Lbl_IdTransference.Text);
                Lbl_IdTransference.Visible = id > 0;
                Btn_Cancelar.Enabled = id > 0;
                Tag = id;
            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao configurar transferência atual", UIX.DisplayInteraction.Critical, "", err.ToString());
            }
        }

        private void RefreshTransferencesList()
        {
            try
            {
                Grid_Transferencias.Rows.Clear();

                var list = new TransferenceDAO().ListTransferences();

                Lbl_ResultadoPesquisa.Text = list.Count.ToString() + " registros";

                if (list.Count > 0)
                {
                    foreach (Transference transferece in list)
                    {
                        int rowIndex = Grid_Transferencias.Rows.Add();

                        Grid_Transferencias.Rows[rowIndex].Cells["id"].Value = transferece.Id;
                        Grid_Transferencias.Rows[rowIndex].Cells["select"].Value = false;
                        Grid_Transferencias.Rows[rowIndex].Cells["date"].Value = transferece.Date.ToString("dd/MM/yyyy");
                        Grid_Transferencias.Rows[rowIndex].Cells["amount"].Value = UIX.FormatMonetary(transferece.Amount);
                        Grid_Transferencias.Rows[rowIndex].Cells["kind"].Value = transferece.TranslateKind(transferece.Kind);
                        Grid_Transferencias.Rows[rowIndex].Cells["source"].Value = transferece.Source.Description;
                        Grid_Transferencias.Rows[rowIndex].Cells["details"].Value = transferece.Details;
                        Grid_Transferencias.Rows[rowIndex].Cells["insertDate"].Value = transferece.CreationDate.ToString("dd/MM/yyyy");
                        Grid_Transferencias.Rows[rowIndex].Cells["updateDate"].Value = transferece.UpdateDate.ToString("dd/MM/yyyy");
                    }
                }
            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao atualizar a lista de Transferências", UIX.DisplayInteraction.Critical, "", err.ToString());
            }
        }

        private void Grid_Transferencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                    return;
                EditTransference(Grid_Transferencias.Rows[e.RowIndex].Cells["id"].Value);

            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao acessar registro", UIX.DisplayInteraction.Critical, "", err.ToString());
            }
        }

        private void EditTransference(object id)
        {
            try
            {
                var transference = new TransferenceDAO().Read((short)GenericFunctions.Val(id));

                if (transference == null || transference.Id == 0)
                {
                    UIX.Alert("Não foi possível acessar o registro!", UIX.DisplayInteraction.Exclamation);
                    return;
                }
                EditTransferenceRegister(transference);

            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao Preencher formulário com a trasnferência", UIX.DisplayInteraction.Critical, "", err.ToString());
            }
        }

        private void Grid_Transferencias_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    var grid = (DataGridView)sender;

                    EditTransference(Grid_Transferencias.Rows[grid.CurrentCell.RowIndex].Cells["id"].Value);
                }

            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao Acessar transferência (Enter)", UIX.DisplayInteraction.Critical, "", err.ToString());
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (UIX.Alert("Deseja cancelar a edição?", UIX.DisplayInteraction.Question) == DialogResult.Yes)
            {
                CleanInputArea();
            }
        }

        private void CleanInputArea()
        {
            try
            {
                foreach (Control control in Group_DadosPagamento.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Text = String.Empty;
                    }
                    else if (control is ComboBox)
                    {
                        ((ComboBox)control).SelectedIndex = 0;
                    }
                }

                Lbl_IdTransference.Text = "";
                Lbl_IdTransference.Text = "0";
            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao Limpar formulário", UIX.DisplayInteraction.Critical, "", err.ToString());
            }
        }

        private void EditTransferenceRegister(Transference transference)
        {
            try
            {
                CleanInputArea();

                Lbl_IdTransference.Text = transference.Id.ToString();
                Txt_DataTransferencia.Text = UIX.DisplayDate(transference.Date);
                Txt_Valor.Text = UIX.FormatMonetary(transference.Amount);
                Cmb_Tipo.SelectedIndex = (int)transference.Kind;
                Txt_Origem.Text = transference.Source.Description ;
                Txt_Detalhes.Text = transference.Details;
            }
            catch (Exception)
            {
                UIX.Alert("Não foi possível acessar o registro!", UIX.DisplayInteraction.Exclamation);
            }
        }

        private bool ValidateInputs()
        {
            try
            {
                if (!GenericFunctions.IsDate(Txt_DataTransferencia.Text))
                {
                    UIX.Alert("Data da Transferência não preenchida corretamente!", UIX.DisplayInteraction.Exclamation);
                    return false;
                }

                if (GenericFunctions.Val(Txt_Valor.Text) <= 0)
                {
                    UIX.Alert("Valor da Transferência não preenchido corretamente!", UIX.DisplayInteraction.Exclamation);
                    return false;
                }

                if (Cmb_Tipo.SelectedIndex < 1)
                {
                    UIX.Alert("Tipo de Transferência não preenchido corretamente!", UIX.DisplayInteraction.Exclamation);
                    return false;
                }

                if (string.IsNullOrEmpty(Txt_Origem.Text))
                {
                    UIX.Alert("Origem da Transferência não preenchida corretamente!", UIX.DisplayInteraction.Exclamation);
                    return false;
                }
                return true;
            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao validar os dados inseridos:", UIX.DisplayInteraction.Critical, "", err.ToString());
                return false;
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputs())
                {
                    if (UIX.Alert("Salvar transferência?", UIX.DisplayInteraction.Question) == DialogResult.Yes)
                    {
                        Transference transference = new Transference();

                        transference.Id = (short)GenericFunctions.Val(Lbl_IdTransference.Text);
                        transference.Date = DateTime.Parse(Txt_DataTransferencia.Text);
                        transference.Amount = GenericFunctions.Val(Txt_Valor.Text);
                        transference.Kind = (TransferenceKind)Cmb_Tipo.SelectedIndex;
                        transference.Source.Description = Txt_Origem.Text;
                        transference.Details = Txt_Detalhes.Text;

                        int result = new TransferenceDAO().Save(transference);

                        switch (result)
                        {
                            case 1:
                                UIX.Alert("Inserido com sucesso!", UIX.DisplayInteraction.Information);
                                break;
                            case 2:
                                UIX.Alert("Atualizado com sucesso!", UIX.DisplayInteraction.Information);
                                break;
                        }

                        CleanInputArea();
                        RefreshTransferencesList();
                    }
                }
            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao Salvar Trasnferência", UIX.DisplayInteraction.Critical, "", err.ToString());
            }
        }

        private void DTP_DataTransferencia_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Txt_DataTransferencia.Text = DTP_DataTransferencia.Value.ToString("dd/MM/yyyy");
            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao validar data inserida", UIX.DisplayInteraction.Critical, "", err.ToString());
            }
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> registers = new List<int>();

                for (int i = 0; i < Grid_Transferencias.Rows.Count; i++)
                {
                    if ((bool)Grid_Transferencias["select", i].Value)
                    {
                        registers.Add((int)Grid_Transferencias["id", i].Value);
                    }
                }

                if (registers.Count == 0)
                {
                    UIX.Alert("Nenhum registro selecionado!", UIX.DisplayInteraction.Exclamation);
                    return;
                }

                if (UIX.Alert("Todos os registros selecionados serão excluídos PERMANENTEMENTE!" +
                    Environment.NewLine + Environment.NewLine +
                    "Deseja continuar?", UIX.DisplayInteraction.Confirmation) == DialogResult.OK)
                {
                    var access = new TransferenceDAO();
                    uint deleted = 0;

                    foreach (int id in registers)
                    {
                        if (access.Delete((short)id))
                            deleted++;
                        else
                        {
                            UIX.Alert($"Não foi possível excluir o registro {id}!", UIX.DisplayInteraction.Exclamation);
                            break;
                        }
                    }

                    UIX.Alert($"Foram excluídos {deleted} registros dos {registers.Count} selecionados.", UIX.DisplayInteraction.Information);
                }

                CleanInputArea();

                RefreshTransferencesList();

            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao validar Transferências selecionadas:", UIX.DisplayInteraction.Critical, "", err.ToString());
            }
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshTransferencesList();
            }
            catch (Exception err)
            {
                UIX.Alert("Falha ao Atualizar formulário", UIX.DisplayInteraction.Critical, "", err.ToString());
            }
        }
    }
}
