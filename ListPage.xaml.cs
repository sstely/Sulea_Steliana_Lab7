using Sulea_Steliana_Lab7.Models;

namespace Sulea_Steliana_Lab7;

public partial class ListPage : ContentPage
{
    List<Product> displayedProducts;

	public ListPage()
	{
		InitializeComponent();
	}

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShopList)BindingContext;
        slist.Date = DateTime.UtcNow;

        Shop selectedShop = (ShopPicker.SelectedItem as Shop); 
        slist.ShopID = selectedShop.ID; 

        await App.Database.SaveShopListAsync(slist);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShopList)BindingContext;
        await App.Database.DeleteShopListAsync(slist);
        await Navigation.PopAsync();
    }

    async void OnChooseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductPage((ShopList)
        this.BindingContext)
        {
            BindingContext = new Product()
        });
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        var items = await App.Database.GetShopsAsync(); 
        ShopPicker.ItemsSource = (System.Collections.IList)items;
        ShopPicker.ItemDisplayBinding = new Binding("ShopDetails");

        var shopl = (ShopList)BindingContext;

        if (displayedProducts == null)
        {
            displayedProducts = await App.Database.GetListProductsAsync(shopl.ID);
            listView.ItemsSource = displayedProducts;
        }
        else
        {
            listView.ItemsSource = displayedProducts;
        }
    }

    async void OnDeleteItemClicked(object sender, EventArgs e)
    {
        if (listView.SelectedItem != null)
        {
            var selectedProduct = listView.SelectedItem as Product;

            displayedProducts.Remove(selectedProduct);


            listView.ItemsSource = null;
            listView.ItemsSource = displayedProducts;
        }
    }
}