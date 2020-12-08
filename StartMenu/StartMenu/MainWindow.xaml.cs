using StartMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StartMenu
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			AppsLV.ItemsSource = Models.ApplicationItem.GetApps();

			CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(AppsLV.ItemsSource);
			PropertyGroupDescription groupDescription = new PropertyGroupDescription("FirstLetter");
			view.GroupDescriptions.Add(groupDescription); 
		}  

		private void AppsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var selectedApp = AppsLV.SelectedItem as ApplicationItem;

			if (e.AddedItems.Count > 0)
			{ 
				AppWindow window = new AppWindow(selectedApp);
				window.Show();
			}
				
			if (selectedApp != null) 
				AppsLV.SelectedItem = null; 
		}
	}
}
