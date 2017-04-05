using System;
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
                    Name = Const.Terms.Department.SD1,
                    Id = new Guid("977a53e8-08be-4a6d-a9c0-d6cea651349d")
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.Department.SD2,
                    Id = new Guid("0d9486d6-4062-430f-93fd-4b663105cab9")
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.Department.MDIS,
                    Id = new Guid("6ceb6e31-f15d-4f0c-b9ee-bb7cb65d3bbd")
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.Department.QA,
                    Id = new Guid("5fd0faea-3a2d-4f1c-b420-f2954af498ee")
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.Department.HR,
                    Id = new Guid("dd77f2b3-a16a-4e58-844d-cb80306957ac")
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.Department.WD,
                    Id = new Guid("22fa2214-72a2-49c8-aa28-cd075551f63c")
                }
            };

        public static List<TaxonomyTermDefinition> ProjectStatusTerms
            => new List<TaxonomyTermDefinition>
            {
                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectStatus.Active,
                    Id = new Guid("bd14f645-1d60-4b5d-8a92-3ad943f2944f")
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectStatus.Cancelled,
                    Id = new Guid("1b2ace72-d235-449b-be5a-ef226ee526ea")
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectStatus.PreInit,
                    Id = new Guid("747585b0-e630-407c-a953-a4835ae6a918")
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectStatus.Rejected,
                    Id = new Guid("1b64dae5-2e03-45eb-a235-36458e80f957")
                }
            };

        public static List<TaxonomyTermDefinition> ProjectDocumentTypeTerms
            => new List<TaxonomyTermDefinition>
            {
                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectDocumentType.Contract,
                    Id = new Guid("daf8b0e9-42eb-4932-953a-77b23d2f5890")
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectDocumentType.RFX,
                    Id = new Guid("b649b0e5-bcbd-4bab-9098-6dedcbccefa3")
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectDocumentType.Requirements,
                    Id = new Guid("b800304d-e16a-4650-8556-487f569feb07")
                },

                new TaxonomyTermDefinition
                {
                    Name = Const.Terms.ProjectDocumentType.TechnicalVision,
                    Id = new Guid("b0b5ce18-eb59-4ee9-8cd1-7e81981bf64a")
                }
            };
    }
}
