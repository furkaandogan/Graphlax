using System.Collections.Generic;

namespace Graphlax.Validators
{
    public class ValidatorResult
    {
        public bool IsValid { get; set; }
        public ICollection<ErrorModel> Errors { get; set; }
        
        public static implicit operator bool(ValidatorResult validatorResult)
        {
            return validatorResult.IsValid;
        }
    }
}