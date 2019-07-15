using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XML_Element_Search
{
	class Program
	{
		static void Main(string[] args)
		{
			XmlReader xRead = new XmlReader();
			xRead.FindElements();
		}
		
	}
}
