using SPMeta2.Definitions;
using SPMeta2.Enumerations;

namespace Isol.TestTask.Defenitions.IA
{
    public static class MyListViews
    {
        public static ListViewDefinition ProjectListViewDefinition = new ListViewDefinition
        {
            Title = "Managed Projects",
            ContentTypeName = MyContentTypes.ProjectContentTypeDefinition.Name,
            IsDefault = true
        };

        public static ListViewDefinition ProjectDocumentsListViewDefinition = new ListViewDefinition
        {
            Title = "Project Documents",
            ContentTypeName = MyContentTypes.DocumentContentTypeDefinition.Name,
            IsDefault = true
        };
    }
}
