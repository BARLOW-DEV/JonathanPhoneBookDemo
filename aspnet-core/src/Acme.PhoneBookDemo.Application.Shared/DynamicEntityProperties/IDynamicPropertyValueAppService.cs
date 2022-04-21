using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Acme.PhoneBookDemo.DynamicEntityProperties.Dto;

namespace Acme.PhoneBookDemo.DynamicEntityProperties
{
    public interface IDynamicPropertyValueAppService
    {
        Task<DynamicPropertyValueDto> Get(int id);

        Task<ListResultDto<DynamicPropertyValueDto>> GetAllValuesOfDynamicProperty(EntityDto input);

        Task Add(DynamicPropertyValueDto dto);

        Task Update(DynamicPropertyValueDto dto);

        Task Delete(int id);
    }
}
