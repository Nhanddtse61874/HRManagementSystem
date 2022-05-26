using HRManagementSystem.Interface;

namespace HRManagementSystem.Model
{
    public class Invoice : Payable
    {
        public string PartNumber { get; set; }

        public string PartDescription { get; set; }

        public int Quantity { get; set; }

        public double PricePerItem { get; set; }

        public Invoice(string partNumber, string partDescription , int quantity, double pricePerItem)
        {
            PartDescription = partDescription;
            PartNumber = partNumber;
            Quantity = quantity;
            PricePerItem = pricePerItem;
        }

        public double GetPaymentAmount()
        => PricePerItem * Quantity;
    }
}
