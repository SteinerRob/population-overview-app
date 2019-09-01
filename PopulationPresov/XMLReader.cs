using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace PopulationPresov
{
    class XMLReader
    {

        static public List<Day> SetDays(string path)
        {
            List<Day> dayList = new List<Day>();
            XmlTextReader reader = new XmlTextReader(path);

            while (reader.Read())
            {
                Day day;
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "row")
                {
                    var date = reader.GetAttribute("col_0");
                    var gender = reader.GetAttribute("col_1");
                    var count = reader.GetAttribute("col_2");
                    day = new Day(date, gender, int.Parse(count));
                    dayList.Add(day);
                    

                }

                

            }
            return dayList;
            
        }

    }
}
