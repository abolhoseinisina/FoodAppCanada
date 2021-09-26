using System.Collections.Generic;
using System.IO;

namespace FoodApp.Persistance.Data
{
    public class DataReader
    {
        public static List<string[]> readServingCSV()
        {
            var servingValues = new List<string[]>();
            int lineNumber = 0;
            using (var reader = new StreamReader(@"Persistance\Data\servings_per_day-en_ONPP.csv"))
            {
                while (!reader.EndOfStream)
                {
                    lineNumber++;
                    if (lineNumber == 1)
                        continue;

                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    servingValues.Add(values);
                }
            }
            return servingValues;
        }

        public static List<string[]> readFoodCSV()
        {
            var foodValues = new List<string[]>();
            int lineNumber = 0;
            using (var reader = new StreamReader(@"Persistance\Data\foods-en_ONPP_rev.csv"))
            {
                while (!reader.EndOfStream)
                {
                    lineNumber++;
                    if (lineNumber == 1)
                        continue;

                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    foodValues.Add(values);
                }
            }
            return foodValues;
        }

        public static List<string[]> readFoodGroupCSV()
        {
            var foodGroupValues = new List<string[]>();
            int lineNumber = 0;
            using (var reader = new StreamReader(@"Persistance\Data\foodgroups-en_ONPP.csv"))
            {
                while (!reader.EndOfStream)
                {
                    lineNumber++;
                    if (lineNumber == 1)
                        continue;

                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    foodGroupValues.Add(values);
                }
            }
            return foodGroupValues;
        }

        public static List<string[]> ReadStatementCSV()
        {
            var statementValues = new List<string[]>();
            int lineNumber = 0;
            using (var reader = new StreamReader(@"Persistance\Data\fg_directional_satements-en_ONPP.csv"))
            {
                while (!reader.EndOfStream)
                {
                    lineNumber++;
                    if (lineNumber == 1)
                        continue;

                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    statementValues.Add(values);
                }
            }
            return statementValues;
        }
    }
}
