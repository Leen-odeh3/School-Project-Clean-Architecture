using FluentValidation;
using UniversityProject.Core.Feature.Student.Command.Models;
using UniversityProject.Services.Abstracts;
using UniversityProject.Services.Implementation;

namespace UniversityProject.Core.Feature.Student.Command.Validations;

public class AddStudentValidation : AbstractValidator<AddStudentCommand>
{
    private readonly IStudentService _studentService;

    public AddStudentValidation(IStudentService studentService)
    {
        ApplyCustomValidationRuels();
        ApplyValidationsRules();
        _studentService = studentService;
    }
    public void ApplyValidationsRules()
    {
        RuleFor(x => x.Name)
             .NotEmpty().WithMessage("Name must not be empty")
             .NotNull()
             .MaximumLength(100);

        RuleFor(x => x.Address)
            .NotEmpty()
            .NotNull().WithMessage("address must not be null")
            .MaximumLength(100);

        RuleFor(x => x.DepartmentID)
             .NotEmpty().WithMessage("deptID must not be empty")
             .NotNull();

        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("phone must not be empty")
            .NotNull();
    }

    public void ApplyCustomValidationRuels()
    {
        RuleFor(x => x.Name)
                       .MustAsync(async (Key, CancellationToken) => !await _studentService.IsNameExist(Key))
                       .WithMessage("");
       
    }

}
