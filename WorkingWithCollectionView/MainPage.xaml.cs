using BindingToObject.Models;
using System.Collections.ObjectModel;
using WorkingWithCollectionView.ViewModel;

namespace WorkingWithCollectionView;

public partial class MainPage : ContentPage
{
    

    public MainPage()
    {
        
       
        //נקשר את הדף שלנו לאובייקט המכיל את הקוד שלו
        this.BindingContext = new MainPageViewModel();       
        InitializeComponent();
       
	}

    

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void SwipeItem_Clicked(object sender, EventArgs e)
    {
       
    }
    private void SwipeItem_ClickedCopy(object sender, EventArgs e)
    {
        
    }

}

