using System;
using Isol.TestTask.Consts;
using Isol.TestTask.Defenitions.Taxonomy;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;
using SPMeta2.Standard.Definitions.Fields;
using SPMeta2.Syntax.Default;

namespace Isol.TestTask.Defenitions.IA.Fields
{
    public static class MyDocumentFields
    {
        public static TaxonomyFieldDefinition DocumentType = new TaxonomyFieldDefinition()
        {
            Title = Const.FieldNames.ProjectDocumentFields.DocumentType,
            InternalName = Const.InternalPrefixes.ProjectDocument + Const.FieldNames.ProjectDocumentFields.DocumentType,
            Group = Const.Groups.DefaultFieldsGroup,
            Id = new Guid("ba562d6b-7e59-492b-8677-aadf31887033"),
            IsMulti = false,
            UseDefaultSiteCollectionTermStore = true,
            TermGroupName = TermGroups.MyGroupDefinition.Name,
            TermSetName = TermSets.ProjectDocumentTypeSet.Name,
            TermGroupId = TermGroups.MyGroupDefinition.Id,
            TermSetId = TermSets.ProjectDocumentTypeSet.Id
        };

        public static FieldDefinition ExpirationDate = new FieldDefinition
        {
            Title = Const.FieldNames.ProjectDocumentFields.ExpirationDate,
            InternalName = Const.InternalPrefixes.ProjectDocument + Const.FieldNames.ProjectDocumentFields.ExpirationDate,
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = new Guid("47ff2a80-de24-4289-b80f-52ec3d826cb3")
        };

        public static FieldDefinition BelongToProject = new FieldDefinition
        {
            Title = Const.FieldNames.ProjectDocumentFields.BelongToProject,
            InternalName = Const.InternalPrefixes.ProjectDocument + Const.FieldNames.ProjectDocumentFields.BelongToProject,
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.Lookup,
            Id = new Guid("3f821c2b-e60c-40b8-8bee-c39bed085641")
        };

        public static FieldDefinition DocumentResponsible = new FieldDefinition
        {
            Title = Const.FieldNames.ProjectDocumentFields.DocumentResponsible,
            InternalName = Const.InternalPrefixes.ProjectDocument + Const.FieldNames.ProjectDocumentFields.DocumentResponsible,
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.User,
            Id = new Guid("db4b1422-762a-4be7-bcbe-40e657a733f1")
        };
    }
}
