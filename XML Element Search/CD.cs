using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Element_Search
{
	public class CD
	{
		private double price;
		[XmlElement("TITLE")]
		public string Title { get; set; }
		[XmlElement("ARTIST")]
		public string Artist { get; set; }
		[XmlElement("COUNTRY")]
		public string Country { get; set; }
		[XmlElement("COMPANY")]
		public string Company { get; set; }
		[XmlElement("PRICE")]
		public double Price
		{
			get
			{
				return price;
			}
			set
			{
				price = value;
				price = Math.Round(price,2);
			}
		}
		[XmlElement("YEAR")]
		public int Year { get; set; }
	}
}
