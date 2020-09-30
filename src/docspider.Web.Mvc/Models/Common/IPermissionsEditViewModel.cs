using System.Collections.Generic;
using docspider.Roles.Dto;

namespace docspider.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}