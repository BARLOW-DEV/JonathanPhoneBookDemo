using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Acme.PhoneBookDemo.DynamicEntityProperties.Dto;
using Acme.PhoneBookDemo.DynamicEntityPropertyValues.Dto;

namespace Acme.PhoneBookDemo.DynamicEntityProperties
{
    public interface IDynamicEntityPropertyValueAppService
    {
        Task<DynamicEntityPropertyValueDto> Get(int id);

        Task<ListResultDto<DynamicEntityPropertyValueDto>> GetAll(GetAllInput input);

        Task Add(DynamicEntityPropertyValueDto input);

        Task Update(DynamicEntityPropertyValueDto input);

        Task Delete(int id);

        Task<GetAllDynamicEntityPropertyValuesOutput> GetAllDynamicEntityPropertyValues(GetAllDynamicEntityPropertyValuesInput input);
    }
}
