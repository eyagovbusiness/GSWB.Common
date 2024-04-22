using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.DTOs.Events
{
    public record EventInformationDTO(string Name, string? Description, DateTime StartDate, TimeSpan ExpectedDuration, Guid[] TagIdList);
}
