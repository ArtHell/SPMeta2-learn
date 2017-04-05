using System;
using Isol.TestTask.Consts;
using SPMeta2.Standard.Definitions.Taxonomy;

namespace Isol.TestTask.Defenitions.Taxonomy
{
    public static class TermSets
    {
        public static TaxonomyTermSetDefinition DepartmentSet => new TaxonomyTermSetDefinition
        {
            Name = Const.TermSets.Department,
            Id = new Guid("bb94664d-4bae-41ed-a15f-e817235013d8")
        };

        public static TaxonomyTermSetDefinition ProjectStatusSet => new TaxonomyTermSetDefinition
        {
            Name = Const.TermSets.ProjectStatus,
            Id = new Guid("86069e5e-34ab-4e1e-a59a-48c4f4ddc55a")
        };

        public static TaxonomyTermSetDefinition ProjectDocumentTypeSet => new TaxonomyTermSetDefinition
        {
            Name = Const.TermSets.ProjectDocumentType,
            Id = new Guid("034c6ed8-d948-4d9c-8ba2-a73366cff919")
        };
    }
}
