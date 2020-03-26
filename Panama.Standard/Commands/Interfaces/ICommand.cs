using Panama.Standard.Entities;
using System.Collections.Generic;

namespace Panama.Standard.Commands
{
    public interface ICommand
    {
        void Execute(List<IModel> data);
    }
}
