using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Repositories
{
    public class QueriesRepository : IQueriesRepository
    {
        Queries.Queries _queries;
        public QueriesRepository(Queries.Queries quries)
        {
            _queries = quries;
        }
        public void GetMyData()
        {
            _queries.ReadData();
        }
    }
}
