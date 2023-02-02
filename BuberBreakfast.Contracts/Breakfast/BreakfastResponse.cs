using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberBreakfast.Contracts.Breakfast
{
    public record BreakfastResponse(
        Guid id,
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EmdDateTime,
        DateTime LastModifiedDateTime,
        List<string> Savory,
        List<string> Sweet);
}
