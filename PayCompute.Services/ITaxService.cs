using System;
using System.Collections.Generic;
using System.Text;

namespace PayCompute.Services
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}
