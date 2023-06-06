namespace MyApp2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        ShowItems();
    }

    private void ShowItems()
    {
        itemsCollection.ItemsSource=App.Db.GetItems();
    }
    private async void AddItemButton(object sender, EventArgs e)
	{
		//отримуємо усі дані
		string title = titleField.Text.Trim();
        string desc = descField.Text.Trim();
        int price = Convert.ToInt32(priceField.Text);
		//чи все коректно
		if (title.Length < 5)
		{
			await DisplayAlert("Error", "Title min 5", "OK");
			return;
		}

        else if (desc.Length < 10)
        {
            await DisplayAlert("Error", "Desc min 10", "OK");
            return;
        }

       

        else if (price < 1)
        {
            await DisplayAlert("Error", "Price min 1", "OK");
            return;
        }

        Item item = new Item
        {
            Title = title,
            Desc = desc,
            Price = price,
        };


        //зберігаємо товар в базі даних
        App.Db.SaveItem(item);
        ShowItems();
        titleField.Text = "";
        descField.Text = "";
        priceField.Text = "";
    }

}

