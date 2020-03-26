using Panama.Standard.Entities;
using System.Collections.Generic;

namespace Panama.Standard.Commands
{
    public interface IValidation
    {
        bool IsValid(List<IModel> data);
        string Message();
    }
}
