using System;
using System.Linq.Expressions;

namespace LinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<Students, bool>> isTeenagerExpr = s => s.Age > 12 && s.Id == 2644;
            var isTeenager = isTeenagerExpr.Compile();

            bool result = isTeenager(new Students { Age = 13, Name = "Özgür", Id = 2643 });
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
