using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace XML_Element_Search
{
	public class XmlReader
	{
		public void FindElements()
		{

			XmlSerializer xml = new XmlSerializer(typeof(Catalog));
			try
			{
				using (StreamReader reader = new StreamReader("cd_catalog.xml"))
				{
					//Book book = (Book)(xml.Deserialize(reader));
					Catalog catalog = (Catalog)(xml.Deserialize(reader));
					foreach (CD cd in catalog.Items)
					{
						Console.WriteLine("TITLE: " + cd.Title + " ARTIST: " + cd.Artist +
							" COUNTRY: " + cd.Country + " COMPANY: " + cd.Company +
							" PRICE: " + "$" + String.Format("{0:0.00}", cd.Price) + " YEAR: " + cd.Year);
					}

				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}
	}
}
