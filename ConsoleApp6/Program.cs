﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anil", "Sharma", "Abdullah",
                       "Imran", "Siva", "Naresh",
                       "Suresh", "Suman" };
            //UsingLINQtoXmlAddNode()
            UsingLINQtoXmlAddNode();
        }

        private static void UsingLINQtoXmlAddNode()
        {
            string myXML = @"<Departments>
                         <Department>Account</Department>
                         <Department>Sales</Department>
                         <Department>Pre-Sales</Department>
                         <Department>Marketing</Department>
                         </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //Add new Element
            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

            //Add new Element at First
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
