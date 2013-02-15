using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HSDemo.Framework;

namespace HSDemo.Utils
{
    public class NumberGenerator
    {
        public ResponseObject GenerateNumberList(Dictionary<int, string> dicPossibleValues)
        {
            return GenerateNumberListInternal(1, 100, dicPossibleValues);
        }

        public ResponseObject GenerateNumberList(Dictionary<int, string> dicPossibleValues, int minVal, int maxVal)
        {
            return GenerateNumberListInternal(minVal, maxVal, dicPossibleValues);
        }

        private ResponseObject GenerateNumberListInternal(int minValue, int maxValue, Dictionary<int, string> dicNumberToMessage)
        {
            int countPrintedValues = 0;
            try
            {
                for (int i = minValue; i <= maxValue; i++)
                {
                    var sbMessage = new StringBuilder();

                    if (dicNumberToMessage != null)
                        foreach (KeyValuePair<int, string> kvp in dicNumberToMessage)
                        {
                            if (i % kvp.Key == 0)
                                sbMessage.Append(kvp.Value).Append(" ");
                        }

                    if (sbMessage.ToString() == String.Empty) sbMessage.Append(i.ToString());

                    Console.WriteLine(sbMessage.ToString().Trim());
                    countPrintedValues++;
                }

                return new ResponseObject() { CountPrintedValues = countPrintedValues, IsSuccess = true };
            }
            catch (Exception ex)
            {
                //Return a response object with the caugth excetion, success indicator and the number of values
                //that were printed before the exception happened.
                return new ResponseObject() { CountPrintedValues = countPrintedValues, IsSuccess = false, Exception = ex };
            }
        }
    }
}
