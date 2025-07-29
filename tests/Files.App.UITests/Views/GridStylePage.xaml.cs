using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.ObjectModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Files.App.UITests.Views
{
	public class MyItem
	{
		public string Name { get; set; }
		public SolidColorBrush Color { get; set; }
	}

	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class GridStylePage : Page
	{
		public ObservableCollection<MyItem> Items { get; set; }

		public GridStylePage()
		{
			InitializeComponent();
			
			GridView sampleGrid = (GridView)this.FindName("SampleGridView");


			if ( sampleGrid != null )
			{
				Items = new ObservableCollection<MyItem>
				{
					new MyItem { Name = "Item 1", Color = new SolidColorBrush(Colors.Red) },
					new MyItem { Name = "Item 2", Color = new SolidColorBrush(Colors.Green) },
					new MyItem { Name = "Item 3", Color = new SolidColorBrush(Colors.Blue) },
					new MyItem { Name = "Item 4 with really long text to check how wrapping and resizing works.", Color = new SolidColorBrush(Colors.Yellow) },
					new MyItem { Name = "Item 5", Color = new SolidColorBrush(Colors.Magenta) },
					new MyItem { Name = "Item 6", Color = new SolidColorBrush(Colors.Cyan) }
				};

				sampleGrid.DataContext = this;
			}
		}		

		private void Page_Loaded(object sender , RoutedEventArgs e)
		{
			
		}

		private void sideComboboxGridSelectionMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			GridView sampleGrid = (GridView)this.FindName("SampleGridView");

			if ( sampleGrid != null )
			{
				string selectionName = e.AddedItems[0].ToString();
				switch ( selectionName )
				{
					case "None":
						sampleGrid.SelectionMode = ListViewSelectionMode.None;
						break;
					case "Single":
						sampleGrid.SelectionMode = ListViewSelectionMode.Single;
						break;
					case "Multiple":
						sampleGrid.SelectionMode = ListViewSelectionMode.Multiple;
						break;
					case "Extended":
						sampleGrid.SelectionMode = ListViewSelectionMode.Extended;
						break;
					default:
						break;
				}
			}
		}
	}
}
