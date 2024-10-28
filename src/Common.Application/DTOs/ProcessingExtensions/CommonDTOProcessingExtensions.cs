using Common.Application.DTOs.Members;
using Common.Application.DTOs.Roles;
using Common.Domain.ValueObjects;

namespace Common.Application.DTOs.ProcessingHelpers
{
    public static class CommonDTOProcessingExtensions
    {
        public static RoleDTO? GetHighestRole(this MemberDetailDTO aMemberDetailDTO)
            => aMemberDetailDTO.Roles.Where(role => role.Type == RoleTypesEnum.ApplicationRole).MaxBy(role => role.Position);
        public static PermissionsEnum GetPermissions(this MemberDetailDTO aMemberDetailDTO)
            => aMemberDetailDTO.GetHighestRole()?.Permissions ?? default;
    }
}
