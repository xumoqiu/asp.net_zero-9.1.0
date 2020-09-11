using Abp.Application.Services.Dto;
using GraphQL.Types;
using DynasysSolution.Dto;

namespace DynasysSolution.Types
{
    public class UserPagedResultGraphType : ObjectGraphType<PagedResultDto<UserDto>>
    {
        public UserPagedResultGraphType()
        {
            Field(x => x.TotalCount);
            Field(x => x.Items, type: typeof(ListGraphType<UserType>));
        }
    }
}