using Common.Domain.ValueObjects;

namespace Common.Application.DTOs.ProcessingHelpers
{
    public static class CommonDTOProcessingExtensions
    {
        public static RoleDTO? GetHighestRole(this MemberDTO aMemberDTO)
            => aMemberDTO.Roles.Where(role => role.Type == RoleTypesEnum.ApplicationRole).MaxBy(role => role.Position);
        public static PermissionsEnum GetPermissions(this MemberDTO aMemberDTO)
            => aMemberDTO.GetHighestRole()?.Permissions ?? default;
    }
}
