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
            Id = Guid.NewGuid(),
        };

        public static FieldDefinition DocumentType = new TaxonomyFieldDefinition()
        {
            Title = "Document Type",
            InternalName = "doc_DocumentType",
            Group = Const.Groups.DefaultFieldsGroup,
            Id = Guid.NewGuid(),
            IsMulti = false,
            TermSetName = Const.TermSets.ProjectDocumentType
        };

        public static FieldDefinition ExpirationDate = new FieldDefinition
        {
            Title = "Expiration Date",
            InternalName = "doc_ExpirationDate",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = Guid.NewGuid(),
        };

        public static FieldDefinition BelongToProject = new LinkFieldDefinition()
        {
            Title = "Belong To Project",
            InternalName = "doc_BelongToProject",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = MyContentTypes.ProjectContentTypeDefinition.ToString(),
            Id = Guid.NewGuid()
        };

        public static FieldDefinition DocumentResponsible = new FieldDefinition
        {
            Title = "Document Responsible",
            InternalName = "doc_DocumentResponsible",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.User,
            Id = Guid.NewGuid(),
        };
    }
}
