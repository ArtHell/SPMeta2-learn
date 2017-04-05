using Isol.TestTask.Consts;
using SPMeta2.Standard.Definitions.Taxonomy;

namespace Isol.TestTask.Defenitions.Taxonomy
{
    public static class TermGroups
    {
        public static TaxonomyTermGroupDefinition MyGroupDefinition => new TaxonomyTermGroupDefinition
        {
            Name = Const.TermGroups.MyTermGroup
        };
    }
}
