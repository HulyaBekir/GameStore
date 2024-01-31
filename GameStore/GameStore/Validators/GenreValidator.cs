using FluentValidation;
using GameStore.Models.Models.User;

namespace GameStore.Validators
{
    public class GenreValidator : AbstractValidator<Genre>
    {
        public GenreValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3);
            RuleFor(x => x.Id).NotEmpty().GreaterThan(0);
           
        }
    }
}
