using Mopups.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SfListViewIssue
{
    public class PopupSampleViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public ICommand OpenOtherPopupCommand => new Command(async () => await OpenOtherPopup());

        public async Task OpenOtherPopup()
        {
            await MopupService.Instance.PushAsync(new OtherPopup());
        }
    }
}