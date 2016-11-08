using System;

namespace Assignment2
{
    /// <summary>
    /// IPayable interface, to bring commonality to the classes.
    /// </summary>
    public interface IPayable
    {
        decimal GetPaymentAmount(); // calculate payment; no implementation
        string GetLastName();
        String GetSsnNumber();
    }
}
