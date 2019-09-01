using System
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopulationPresov
{
    public class Document
    {
        protected  string Path { get; private set; }
        public  List<Day> _totalDays= new List<Day>();
         

        public Document(string path, Label label)
        {
            this.Path = path;
            TotalDays();
            label.Text = UIView.GetNameFomPath(Path);
        }
        public void TotalDays()
        {
            _totalDays = XMLReader.SetDays(Path);
        }
        
    }
}
