using System;
using Isol.TestTask.Consts;
using SPMeta2.Standard.Definitions.Taxonomy;

namespace Isol.TestTask.Defenitions.Taxonomy
{
    public static class TermGroups
    {
        public static TaxonomyTermGroupDefinition MyGroupDefinition = new TaxonomyTermGroupDefinition
        {
            Name = Const.TermGroups.MyTermGroup,
            Id = new Guid("6e1019ee-236c-421d-9282-6d2a595069a7")
        };
    }
}
