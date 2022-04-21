using System.Threading.Tasks;
using Acme.PhoneBookDemo.Views;
using Xamarin.Forms;

namespace Acme.PhoneBookDemo.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
