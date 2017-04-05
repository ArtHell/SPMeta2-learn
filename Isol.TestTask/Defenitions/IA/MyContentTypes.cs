using System;
using Isol.TestTask.Consts;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;

namespace Isol.TestTask.Defenitions.IA
{
    public static class MyContentTypes
    {
        public static ContentTypeDefinition ProjectContentTypeDefinition
            = new ContentTypeDefinition
            {
                Name = "Project CT",
                Id = new Guid("ba382db3-573c-4dc2-a4f6-e22fd6370bf7"),
                ParentContentTypeId = BuiltInContentTypeId.Item,
                Group = Const.Groups.DefaultFieldsGroup
            };

        public static ContentTypeDefinition DocumentContentTypeDefinition
            = new ContentTypeDefinition
            {
                Name = "Document CT",
                Id = new Guid("e7b4f367-abe3-4e6b-b47e-52a986058588"),
                ParentContentTypeId = BuiltInContentTypeId.Document,
                Group = Const.Groups.DefaultFieldsGroup
            };
    }
}
