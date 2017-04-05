using System.Collections.Generic;
using Isol.TestTask.Consts;
using SPMeta2.Standard.Definitions.Taxonomy;

namespace Isol.TestTask.Defenitions.Taxonomy
{
    public static class Terms
    {
        public static List<TaxonomyTermDefinition> DepartmentTerms
            => new List<TaxonomyTermDefinition>
            {
                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.Department.SD1
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.Department.SD2
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.Department.MDIS
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.Department.QA
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.Department.HR
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.Department.WD
                }
            };

        public static List<TaxonomyTermDefinition> ProjectStatusTerms
            => new List<TaxonomyTermDefinition>
            {
                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectStatus.Active
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectStatus.Cancelled
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectStatus.PreInit
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectStatus.Rejected
                }
            };

        public static List<TaxonomyTermDefinition> ProjectDocumentTypeTerms
            => new List<TaxonomyTermDefinition>
            {
                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectDocumentType.Contract
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectDocumentType.RFX
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectDocumentType.Requirements
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectDocumentType.TechnicalVision
                }
            };
    }
}
