using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wox.Plugin;

namespace UnitConverter
{
    public class Main : IPlugin
    {
        public List<Result> Query(Query query)
        { 
            List<Result> results = new List<Result>();

           
            UnitConverter unitConverter = new UnitConverter();

            string[] q = query.RawQuery.Split(' ');

            string distance = q[1];
            string convertFrom = q[2];
            string convertTo = q[3];

            unitConverter.unitBase = Convert.ToDouble(distance);
            unitConverter.unitConvert(convertFrom);
            unitConverter.unitFinal(convertTo);

            Result r = new Result();
            r.Title = "Unit Converter";
            r.SubTitle = ""+unitConverter.unitConverted;
            results.Add(r);

            return results;
        }

        public void Init(PluginInitContext context)
        {
            
        }
    }
}
