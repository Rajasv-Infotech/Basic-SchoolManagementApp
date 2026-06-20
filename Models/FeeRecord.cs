namespace SchoolManagementApp.Models
{
    public class FeeRecord
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string StudentId { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string StudentClass { get; set; } = string.Empty;
        public string RollNumber { get; set; } = string.Empty;

        // Session / Class Section Mapping
        public string SessionId { get; set; } = string.Empty;
        public string SessionName { get; set; } = string.Empty;
        public string ClassSectionId { get; set; } = string.Empty;
        public string ClassSectionName { get; set; } = string.Empty;

        // Fee Details
        public string AcademicYear { get; set; } = DateTime.Now.Year.ToString();
        public string FeeHeadId { get; set; } = string.Empty;
        public string FeeType { get; set; } = string.Empty; // Fee head name: Tuition, Transport, Library, etc.
        public string FeeMonth { get; set; } = string.Empty; // For monthly fees
        public string ChargeType { get; set; } = "Student"; // Common or Student
        public string CommonFeeRuleId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public decimal LateFee { get; set; } = 0;
        public decimal Discount { get; set; } = 0;
        public decimal TotalAmount => Amount + LateFee - Discount;

        // Payment Details
        public DateTime DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Paid, Overdue, Partial
        public string PaymentMethod { get; set; } = string.Empty; // Cash, Card, Online, Cheque
        public string TransactionId { get; set; } = string.Empty;
        public string ReceiptNumber { get; set; } = string.Empty;

        // Additional Info
        public decimal PaidAmount { get; set; } = 0;
        public decimal BalanceAmount => TotalAmount - PaidAmount;
        public string Remarks { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastUpdated { get; set; }
    }
}
