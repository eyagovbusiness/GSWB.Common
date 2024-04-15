using Common.Application.DTOs.Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.DTOs.Events
{
    public record CreateEventDTO(EventInformationDTO EventInformation, IEnumerable<Guid> EventRoleList, CategoryChannelTemplateDTO DiscordChannelsSetup, Guid MemberIdCreator);
}
