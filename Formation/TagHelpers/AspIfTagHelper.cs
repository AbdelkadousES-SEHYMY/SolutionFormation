using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Formation.TagHelpers
{

    [HtmlTargetElement(Attributes =nameof(Condition))]
    public class AspIfTagHelper:TagHelper
    {
        public bool Condition { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condition) 
                output.SuppressOutput();
        }
    }
}
