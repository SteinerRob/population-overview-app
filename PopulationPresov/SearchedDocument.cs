using System.Collections.Generic;
using System.Windows.Forms;

namespace PopulationPresov
{
    public class SearchedDocument
    {

        private int Gender { get; set; }
        private int Month { get; set; }

        public List<Day> AllDays { get; set; }
        public List<Day> SearchedDays;

        public SearchedDocument(List<Day> days, ComboBox gender, ComboBox month)
        {
            this.AllDays = days;
            this.Gender = gender.SelectedIndex;
            this.Month = month.SelectedIndex;
        }

        public List<Day> Search()
        {
            foreach (var day in AllDays)
            {
                if (day.Gender == "Muž" && Gender == 0 && day.GetDateTime().Month == Month)
                {
                    SearchedDays.Add(day);
                }

                if (day.Gender == "Žena" && Gender == 1 && day.GetDateTime().Month == Month)
                {
                    SearchedDays.Add(day);
                }
            }
            return SearchedDays;
        }

    }



}








