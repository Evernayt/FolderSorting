using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FolderSorting.models
{
    public class IMonth
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private List<IMonth> months = new List<IMonth>();

        public void initialize()
        {
            string[] names = DateTimeFormatInfo.CurrentInfo.MonthNames;
            for (int i = 0; i < names.Length - 1; i++)
            {
                int id = names.Length - 1 - i;
                IMonth month = new IMonth
                {
                    Id = id,
                    Name = names[i]
                };

                months.Add(month);
            }
        }

        public bool isMonthFolder(string folderName)
        {
            return months.Any((month) => folderName.ToLower().Contains(month.Name.ToLower()));
        }

        public int getMonthId(string monthName)
        {
            return months.Find(month => month.Name.ToLower() == monthName.ToLower()).Id;
        }
    }
}
