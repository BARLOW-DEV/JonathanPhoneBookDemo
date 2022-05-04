using System.Threading.Tasks;
using LibraryDemo.UiCustomization;

namespace LibraryDemo.Test.Base.UiCustomization
{
    public class NullUiThemeCustomizerFactory : IUiThemeCustomizerFactory
    {
        public Task<IUiCustomizer> GetCurrentUiCustomizer()
        {
            return Task.FromResult(new NullThemeUiCustomizer() as IUiCustomizer);
        }

        public IUiCustomizer GetUiCustomizer(string theme)
        {
            return new NullThemeUiCustomizer();
        }
    }
}
