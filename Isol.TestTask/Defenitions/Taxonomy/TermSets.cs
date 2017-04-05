using Isol.TestTask.Consts;
using SPMeta2.Standard.Definitions.Taxonomy;

namespace Isol.TestTask.Defenitions.Taxonomy
{
    public static class TermSets
    {
        public static TaxonomyTermSetDefinition DepartmentSet => new TaxonomyTermSetDefinition
        {
            Name = Const.TermSets.Department
        };

        public static TaxonomyTermSetDefinition ProjectStatusSet => new TaxonomyTermSetDefinition
        {
            Name = Const.TermSets.ProjectStatus
        };

        public static TaxonomyTermSetDefinition ProjectDocumentTypeSet => new TaxonomyTermSetDefinition
        {
            Name = Const.TermSets.ProjectDocumentType
        };
    }
}
