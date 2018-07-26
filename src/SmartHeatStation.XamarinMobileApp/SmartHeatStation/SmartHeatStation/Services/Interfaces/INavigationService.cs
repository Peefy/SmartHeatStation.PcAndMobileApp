using SmartHeatStation.ViewModels;
using System;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartHeatStation.Services
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;

        Task NavigateToAsync(Type viewModelType);

        Task NavigateToAsync(Type viewModelType, object parameter);

        Task NavigateToAsync(Page page);

        Task NavigateBackAsync();

        Task RemoveLastFromBackStackAsync();
    }
}
