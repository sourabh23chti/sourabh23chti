using ConsoleApplication1.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Repositories
{
    class CommandRepository : ICommandReposity
    {
        ICommand _CommandRepo;

        public CommandRepository(ICommand command)
        {
            _CommandRepo = command;
        }
        public void SaveMyData()
        {
            _CommandRepo.SaveData();
        }
    }
}
