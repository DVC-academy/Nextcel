namespace Nextcel;

public partial class GridPage : ContentPage
{

	public GridPage()
	{
		InitializeComponent();
		CreateExcelTable();
	}

	private void CreateExcelTable()
	{
		Grid excelGrid = new()
		{
			BackgroundColor = Colors.LightGray
		};

		for (int i = 0; i < 5; i++)
		{
			excelGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });

			for (int j = 0; j < 5; j++)
			{
				if (i == 0)
					excelGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

				Entry entry = new()
				{
					Placeholder = $"{i + 1},{j + 1}"
				};

				Grid.SetRow(entry, i);
				Grid.SetColumn(entry, j);
				excelGrid.Children.Add(entry);
			}
		}

		Content = new StackLayout
		{
			Children = {
				new Label {
					Text = "Excel Tábla",
					HorizontalOptions = LayoutOptions.Center
				},
				excelGrid
			}
		};
	}
}
