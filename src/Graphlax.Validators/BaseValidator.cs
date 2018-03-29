using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace Graphlax.Validators
{
    public abstract class BaseValidator<TModel>
        : AbstractValidator<TModel>, IValidator where TModel : class
    {

        // public abstract ValidatorResult Valid(object obj);
        public async Task<ValidatorResult> ValidAsync(object obj)
        {
            FluentValidation.Results.ValidationResult validationResult= await base.ValidateAsync((TModel)obj);
            return new ValidatorResult(){
                IsValid=validationResult.IsValid,
                Errors=validationResult.Errors.Select(x=> new ErrorModel(){
                    Code=x.ErrorCode,
                    UserMessage=x.ErrorMessage,
                    DeveloperMessage=string.Empty
                }).ToList()
            };
        }
    }
}