using FluentValidation;
using Microsoft.Extensions.Localization;
using UniversityProject.Core.Feature.Student.Command.Models;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Core.Feature.Student.Command.Validations;

public class EditStudentValidator : AbstractValidator<EditStudentCommand>
{
    #region Fields
    private readonly IStudentService _studentService;
    #endregion

    #region Constructors
    public EditStudentValidator(IStudentService studentService
                                )
    {
        _studentService = studentService;
        ApplyValidationsRules();
        ApplyCustomValidationsRules();
    }
    #endregion

    #region Actions
    public void ApplyValidationsRules()
    {
        RuleFor(x => x.Name)
             .NotEmpty()
             .NotNull()
             .MaximumLength(100);

        RuleFor(x => x.Address)
            .NotEmpty()
            .NotNull()
            .MaximumLength(100);
    }

    public void ApplyCustomValidationsRules()
    {
        RuleFor(x => x.Name)
            .MustAsync(async (model, Key, CancellationToken) => !await _studentService.IsNameExistExcludeSelf(Key, model.StudentID))
            .WithMessage("");
     
    }

    #endregion
}
