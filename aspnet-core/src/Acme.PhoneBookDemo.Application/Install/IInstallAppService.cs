using System.Threading.Tasks;
using Abp.Application.Services;
using Acme.PhoneBookDemo.Install.Dto;

namespace Acme.PhoneBookDemo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}