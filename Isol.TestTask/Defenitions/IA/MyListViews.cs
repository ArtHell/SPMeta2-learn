using System.Collections.ObjectModel;
using Isol.TestTask.Consts;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;

namespace Isol.TestTask.Defenitions.IA
{
    public static class MyListViews
    {
        public static ListViewDefinition ProjectListViewDefinition = new ListViewDefinition
        {
            Title = "Managed Projects",
            IsDefault = true,
            Fields = new Collection<string>
            {
                Const.FieldNames.ProjectFields.Title,
                Const.FieldNames.ProjectFields.ProjectStatus,
                Const.FieldNames.ProjectFields.StartDate,
                Const.FieldNames.ProjectFields.EndDate,
                Const.FieldNames.ProjectFields.ProjectManager,
                Const.FieldNames.ProjectFields.Team,
                Const.FieldNames.ProjectFields.Department,
                Const.FieldNames.ProjectFields.ProjectValue
            }
        };

        public static ListViewDefinition ProjectDocumentsListViewDefinition = new ListViewDefinition
        {
            Title = "Project Documents",
            IsDefault = true,
            Fields = new Collection<string>
            {
                Const.FieldNames.ProjectDocumentFields.Title,
                Const.FieldNames.ProjectDocumentFields.DocumentType,
                Const.FieldNames.ProjectDocumentFields.ExpirationDate,
                Const.FieldNames.ProjectDocumentFields.BelongToProject,
                Const.FieldNames.ProjectDocumentFields.DocumentResponsible
            }
        };
    }
}
