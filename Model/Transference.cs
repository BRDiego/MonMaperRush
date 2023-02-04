
using System;

namespace Model
{

    public enum TransferenceKind
    {
        Income = 1,
        Expenditure = 2
    }
    public class Transference
    {
        public short Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public TransferenceKind Kind { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Source Source { get; set; } = new Source();

        public Transference()
        {
        }

        public Transference(int kind)
        {
            Kind = (TransferenceKind)kind;
        }

        public string TranslateKind(TransferenceKind kind)
        {
            switch (kind)
            {
                case TransferenceKind.Income:
                    return "Ganho";
                case TransferenceKind.Expenditure:
                    return "Gasto";
                default:
                    return "";
            }
        }

        public void SetKind(short kind)
        {
            switch (kind)
            {
                case 1:
                    Kind = TransferenceKind.Income;
                    break;
                case 2:
                    Kind = TransferenceKind.Expenditure;
                    break;
            }
        }
    }
}
