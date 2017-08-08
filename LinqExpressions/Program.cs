using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<Students, bool>> isTeenagerExpr = s => s.Age > 12;
            var isTeenager = isTeenagerExpr.Compile();

            bool result = isTeenager(new Students { Age = 13 });
            Console.WriteLine(result);
        }
    }

    class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
