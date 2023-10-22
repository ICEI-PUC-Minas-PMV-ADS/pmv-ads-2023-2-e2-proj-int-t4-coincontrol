namespace coincontrol.Models.Transaction
{
    public class Expense
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public float Amount { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

    }
}
