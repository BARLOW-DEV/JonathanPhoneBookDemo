using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryDemo.Install.Dto;

namespace LibraryDemo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}