using System;

namespace CQRS.Models.Payment
{
    public interface IPayment
    {
        int StudentId { get; set; }
        string CourseName { get; set; }
        DateTime TransactionDate { get; set; }
        double Amount { get; set; }
    }
}
