using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Graphlax.Validators
{   
      public interface IValidator
    {
        Task<ValidatorResult> ValidAsync(object obj);
        // IValidator RuleFor<TModel,TProperty>(Expression<Func<TModel,TProperty>> property)
    }
}