using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Element_Search
{
	[XmlRoot("CATALOG")]
	public class Catalog
	{
		
		public Catalog()
		{
			Items = new List<CD>();
		}
		[XmlElement("CD")]
		public List<CD> Items { get; set; }
	}

}
