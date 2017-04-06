using SPMeta2.Definitions;
using SPMeta2.Enumerations;

namespace Isol.TestTask.Defenitions.IA
{
    public static class MyLists
    {
        public static ListDefinition ProjectListDefinition = new ListDefinition
        {
            Title = "Projects",
            Description = "Projects",
            TemplateType = BuiltInListTemplateTypeId.GenericList,
            CustomUrl = "Projects",
            ContentTypesEnabled = true,
            
        };

        public static ListDefinition ProjectDocumentsListDefinition = new ListDefinition
        {
            Title = "Project Documents",
            Description = "Project Documents",
            TemplateType = BuiltInListTemplateTypeId.GenericList,
            CustomUrl = "Documents",
            ContentTypesEnabled = true
        };
    }
}
