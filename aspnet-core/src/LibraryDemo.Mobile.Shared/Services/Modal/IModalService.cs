using System.Threading.Tasks;
using LibraryDemo.Views;
using Xamarin.Forms;

namespace LibraryDemo.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
