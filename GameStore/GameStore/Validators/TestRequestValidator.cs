using FluentValidation;
using GameStore.Models.Models.Request;

namespace GameStore.Validators
{
    public class GetGamesByGenreRequestValidator : AbstractValidator<GetGamesByGenreRequest>
    {
        public GetGamesByGenreRequestValidator() 
        {
            RuleFor(test => test.GenreId).NotEmpty().GreaterThan(0).LessThan(10);
            RuleFor(test => test.AfterDate).NotNull().NotEmpty()
                .LessThan(new DateTime(2022, 06, 29));
        }    

    }
}
