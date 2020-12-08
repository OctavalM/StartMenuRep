using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartMenu.Models
{
	public class ApplicationItem
	{
		public string Image { get; set; }
		public string AppName { get; set; }
		public string FirstLetter
		{
			get
			{
				return AppName.Substring(0,1);
			} 
		}
		public string Color { get; set; }

		public static IEnumerable<ApplicationItem> GetApps()
		{
			return new ApplicationItem[]
			{
				new ApplicationItem
				{
					Image = "/Images/access.png",
					AppName = "Access",
					Color = "#FF404040"
				},
				new ApplicationItem
				{
					Image = "/Images/adobeIllustrator.png",
					AppName = "Adobe Illustrator 2020",
					Color = "#FF0078D7"
				},
				new ApplicationItem
				{
					Image = "/Images/discord.png",
					AppName = "Discord",
					Color = "#FF0078D7"
				},
				new ApplicationItem
				{
					Image = "/Images/excel.png",
					AppName = "Excel",
					Color = "#FF404040"
				},
				new ApplicationItem
				{
					Image = "/Images/powerpoint.png",
					AppName = "PowerPoint",
					Color = "#FF404040"
				},
				new ApplicationItem
				{
					Image = "/Images/visio.png",
					AppName = "Visio",
					Color = "#FF404040"
				},
				new ApplicationItem
				{
					Image = "/Images/visualStudio.png",
					AppName = "Visual Studio 2019",
					Color = "#2D2D30"
				},
				new ApplicationItem
				{
					Image = "/Images/word.png",
					AppName = "Word",
					Color = "#FF404040"
				},
				new ApplicationItem
				{
					Image = "/Images/zoom.png",
					AppName = "Zoom",
					Color = "#FF0078D7"
				}
			};
		}
	}
}
