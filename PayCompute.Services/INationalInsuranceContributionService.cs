using System;
using System.Collections.Generic;
using System.Text;

namespace PayCompute.Services
{
    public interface INationalInsuranceContributionService
    {
        decimal NIContribution(decimal totalAmount);
    }
}
