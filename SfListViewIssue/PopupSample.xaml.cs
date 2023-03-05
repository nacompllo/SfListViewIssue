using Mopups.Pages;

namespace SfListViewIssue;

public partial class PopupSample : PopupPage
{
    public PopupSample()
    {
        InitializeComponent();
        BindingContext = new PopupSampleViewModel();
    }
}