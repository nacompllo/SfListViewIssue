using Mopups.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SfListViewIssue
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public ICommand NavigateToPopupCommand => new Command(async () => await NavigateToPopup());

        public async Task NavigateToPopup()
        {
            await MopupService.Instance.PushAsync(new PopupSample());
        }
    }
}