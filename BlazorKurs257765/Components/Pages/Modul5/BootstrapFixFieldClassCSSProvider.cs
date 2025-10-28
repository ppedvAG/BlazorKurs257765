using Microsoft.AspNetCore.Components.Forms;

namespace BlazorKurs257765.Components.Pages.Modul5
{
    public class BootstrapFixFieldClassCSSProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            var isInvalid = editContext.GetValidationMessages(fieldIdentifier).Any();
            return  isInvalid ? "is-invalid" : "is-valid";
        }
    }
}
