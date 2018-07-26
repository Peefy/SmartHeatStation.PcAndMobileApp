using System.Threading.Tasks;

namespace SmartHeatStation.Services
{
    public interface IDialogService
    {
        Task ShowAlertAsync(string message, string title, string buttonLabel);
        Task ShowAlertAsync(string message);
        Task<bool> ShowAlertAsync(string title,string quest);
        void Toast(string message);
    }
}
