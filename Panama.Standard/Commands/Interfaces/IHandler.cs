using Panama.Standard.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Panama.Standard.Commands
{
    public interface IHandler
    {
        List<ICommand> Commands { get; set; }
        List<IModel> Data { get; set; }
        List<IValidation> Validators { get; set; }
        IHandler Command<Command>() where Command : ICommand;
        IHandler Validate<Validator>() where Validator : IValidation;
        IHandler Add(IModel data);
        IResult Invoke();
        Task<IResult> InvokeAsync();
    }
}
