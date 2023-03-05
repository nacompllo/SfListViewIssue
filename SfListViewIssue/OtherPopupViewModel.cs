using Mopups.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SfListViewIssue
{
    public class OtherPopupViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        public OtherPopupViewModel()
        {
            Items = new ObservableCollection<Item>();

            for (var i = 0; i < 20; i++)
            {
                Items.Add(new Item
                {
                    Name = $"Item {i}"
                });
            }
        }

        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                RaiseOnPropertyChanged();
            }
        }

        public ICommand ClosePopupCommand => new Command(async () => await ClosePopup());


        public async Task ClosePopup()
        {
            await MopupService.Instance.PopAsync();
        }
    }
}