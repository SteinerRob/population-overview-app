using System;

namespace PopulationPresov
{
    public class Day
    {
        private DateTime Date;
        public string Gender { get; set; }
        public int Count { get; set; }

        public Day(string dayInMonth, string gender, int count)
        {
            SetDate(dayInMonth);
            this.Gender = gender;
            this.Count = count;
        }
        private void SetDate(string day)
        {
            var splitedDate = day.Split('.');
            var month = splitedDate[1].TrimStart();
            switch (month)
            {
                case "január":
                    Date = new DateTime(2016, 01, int.Parse(splitedDate[0]));
                    break;
                case "február":
                    Date = new DateTime(2016, 02, int.Parse(splitedDate[0]));
                    break;
                case "marec":
                    Date = new DateTime(2016, 03, int.Parse(splitedDate[0]));
                    break;
                case "apríl":
                    Date = new DateTime(2016, 04, int.Parse(splitedDate[0]));
                    break;
                case "máj":
                    Date = new DateTime(2016, 05, int.Parse(splitedDate[0]));
                    break;
                case "jún":
                    Date = new DateTime(2016, 06, int.Parse(splitedDate[0]));
                    break;
                case "júl":
                    Date = new DateTime(2016, 07, int.Parse(splitedDate[0]));
                    break;
                case "august":
                    Date = new DateTime(2016, 08, int.Parse(splitedDate[0]));
                    break;
                case "sptember":
                    Date = new DateTime(2016, 09, int.Parse(splitedDate[0]));
                    break;
                case "október":
                    Date = new DateTime(2016, 10, int.Parse(splitedDate[0]));
                    break;
                case "november":
                    Date = new DateTime(2016, 11, int.Parse(splitedDate[0]));
                    break;
                case "december":
                    Date = new DateTime(2016, 12, int.Parse(splitedDate[0]));
                    break;
            }
        }
        public DateTime GetDateTime()
        {
            return Date;
        }
        public double GetDoubleTime()
        {
            double time = 0;
            var timeString = this.Date.ToShortDateString();
            var temp = timeString.Split('.');


            return time=Double.Parse(temp[1]);
        }
    }
}
