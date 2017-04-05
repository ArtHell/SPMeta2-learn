using System;
using Isol.TestTask.Consts;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;
using SPMeta2.Standard.Definitions.Fields;
using SPMeta2.Syntax.Default;

namespace Isol.TestTask.Defenitions.IA.Fields
{
    public static class MyDocumentFields
    {
        public static FieldDefinition Title = new FieldDefinition
        {
            Title = "Title",
            InternalName = "doc_Title",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.Text,
            Id = new Guid("43e8fa0c-c2d1-4c7d-b187-fa753afea580")
        };

        public static FieldDefinition DocumentType = new TaxonomyFieldDefinition()
        {
            Title = "Document Type",
            InternalName = "doc_DocumentType",
            Group = Const.Groups.DefaultFieldsGroup,
            Id = new Guid("ba562d6b-7e59-492b-8677-aadf31887033"),
            IsMulti = false,
            TermSetName = Const.TermSets.ProjectDocumentType
        };

        public static FieldDefinition ExpirationDate = new FieldDefinition
        {
            Title = "Expiration Date",
            InternalName = "doc_ExpirationDate",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = new Guid("47ff2a80-de24-4289-b80f-52ec3d826cb3")
        };

        public static FieldDefinition BelongToProject = new FieldDefinition
        {
            Title = "Belong To Project",
            InternalName = "doc_BelongToProject",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = MyContentTypes.ProjectContentTypeDefinition.Name,
            Id = new Guid("3f821c2b-e60c-40b8-8bee-c39bed085641")
        };

        public static FieldDefinition DocumentResponsible = new FieldDefinition
        {
            Title = "Document Responsible",
            InternalName = "doc_DocumentResponsible",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.User,
            Id = new Guid("db4b1422-762a-4be7-bcbe-40e657a733f1")
        };
    }
}
