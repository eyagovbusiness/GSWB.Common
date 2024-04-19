using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.DTOs.Events
{
    public record EventManagersDTO(Guid EventId, IEnumerable<Guid> MemberIdList);
}
