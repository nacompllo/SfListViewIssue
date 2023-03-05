using Mopups.Pages;

namespace SfListViewIssue;

public partial class OtherPopup : PopupPage
{
	public OtherPopup()
	{
		InitializeComponent();
		BindingContext = new OtherPopupViewModel();

    }
}