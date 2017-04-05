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
                Id = Guid.NewGuid(),
                ParentContentTypeId = BuiltInContentTypeId.Item,
                Group = Const.Groups.DefaultFieldsGroup
            };

        public static ContentTypeDefinition DocumentContentTypeDefinition
            = new ContentTypeDefinition
            {
                Name = "Docuemnt CT",
                Id = Guid.NewGuid(),
                ParentContentTypeId = BuiltInContentTypeId.Document,
                Group = Const.Groups.DefaultFieldsGroup
            };
    }
}
