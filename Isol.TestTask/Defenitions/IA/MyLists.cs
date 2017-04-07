using Isol.TestTask.Consts;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;

namespace Isol.TestTask.Defenitions.IA
{
    public static class MyLists
    {
        public static ListDefinition ProjectListDefinition = new ListDefinition
        {
            Title = Const.Views.ProjectTitle,
            Description = Const.Views.ProjectDescription,
            TemplateType = BuiltInListTemplateTypeId.GenericList,
            CustomUrl = Const.Views.ProjectURL,
            ContentTypesEnabled = true,
        };

        public static ListDefinition ProjectDocumentsListDefinition = new ListDefinition
        {
            Title = Const.Views.DocumentTitle,
            Description = Const.Views.DocumentDescription,
            TemplateType = BuiltInListTemplateTypeId.GenericList,
            CustomUrl = Const.Views.DocumentURL,
            ContentTypesEnabled = true
        };
    }
}
