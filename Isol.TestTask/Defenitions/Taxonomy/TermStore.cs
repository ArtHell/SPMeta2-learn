using SPMeta2.Standard.Definitions.Taxonomy;

namespace Isol.TestTask.Defenitions.Taxonomy
{
    public static class TermStore
    {
        public static TaxonomyTermStoreDefinition DefaultTermStore => new TaxonomyTermStoreDefinition
        {
            UseDefaultSiteCollectionTermStore = true
        };
    }
}
