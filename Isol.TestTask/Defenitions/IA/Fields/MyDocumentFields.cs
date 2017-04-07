using System;
using Isol.TestTask.Consts;
using Isol.TestTask.Defenitions.Taxonomy;
using SPMeta2.Definitions;
using SPMeta2.Definitions.Fields;
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
            InternalName = Const.InternalPrefixes.ProjectDocument + Const.FieldNames.ProjectDocumentFields.DocumentType.Replace(" ", string.Empty),
            Group = Const.Groups.DefaultFieldsGroup,
            Id = new Guid("eede532b-5f53-4992-9148-30b99fddc1dd"),
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
            InternalName = Const.InternalPrefixes.ProjectDocument + Const.FieldNames.ProjectDocumentFields.ExpirationDate.Replace(" ", string.Empty),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = new Guid("2375c1ca-7749-4c51-98e2-6c9ec46a7754")
        };

        public static FieldDefinition BelongToProject = new LookupFieldDefinition
        {
            Title = Const.FieldNames.ProjectDocumentFields.BelongToProject,
            InternalName = Const.InternalPrefixes.ProjectDocument + Const.FieldNames.ProjectDocumentFields.BelongToProject.Replace(" ", string.Empty),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.Lookup,
            Id = new Guid("7dfb97bf-c5a9-4e5b-96f0-b0a3711c1a29"),
            LookupListTitle = MyLists.ProjectListDefinition.Title
        };

        public static FieldDefinition DocumentResponsible = new FieldDefinition
        {
            Title = Const.FieldNames.ProjectDocumentFields.DocumentResponsible,
            InternalName = Const.InternalPrefixes.ProjectDocument + Const.FieldNames.ProjectDocumentFields.DocumentResponsible.Replace(" ", string.Empty),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.User,
            Id = new Guid("814cfbd6-9769-4d9c-ab17-175a8b5cb4da")
        };
    }
}
