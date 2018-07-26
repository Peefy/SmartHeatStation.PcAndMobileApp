using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartHeatStation.ViewModels;
using Xamarin.Forms;

namespace SmartHeatStation.Services
{
    public class NavigationService : INavigationService
    {
        public Task InitializeAsync()
        {
            return Task.Run(() =>
            {

            });
        }

        public Task NavigateBackAsync()
        {
            return Task.Run(() =>
            {

            });
        }

        public Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase
        {
            return Task.Run(() =>
            {

            });
        }

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            return Task.Run(() =>
            {

            });
        }

        public Task NavigateToAsync(Type viewModelType)
        {
            return Task.Run(() =>
            {

            });
        }

        public Task NavigateToAsync(Type viewModelType, object parameter)
        {
            return Task.Run(() =>
            {

            });
        }

        public Task NavigateToAsync(Page page)
        {
            throw new NotImplementedException();
        }

        public Task RemoveLastFromBackStackAsync()
        {
            return Task.Run(() =>
            {

            });
        }
    }
}
