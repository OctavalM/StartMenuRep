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
using System.Windows.Shapes;

namespace StartMenu
{
	/// <summary>
	/// Логика взаимодействия для AppWindow.xaml
	/// </summary>
	public partial class AppWindow : Window
	{
		private ApplicationItem contextApp = new ApplicationItem();

		public AppWindow(ApplicationItem postApp)
		{
			InitializeComponent();
			contextApp = postApp; 
			DataContext = contextApp; 
		} 
	}
}
