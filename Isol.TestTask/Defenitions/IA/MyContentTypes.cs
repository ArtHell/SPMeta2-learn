using System;
using System.Collections.Generic;
using Isol.TestTask.Consts;
using SPMeta2.Definitions;
using SPMeta2.Definitions.ContentTypes;
using SPMeta2.Enumerations;

namespace Isol.TestTask.Defenitions.IA
{
    public static class MyContentTypes
    {
        public static ContentTypeDefinition ProjectContentTypeDefinition
            = new ContentTypeDefinition
            {
                Name = Const.ContentTypes.ProjectContentType,
                Id = new Guid("0cfcd711-0880-4b47-9d8e-ee0be53d8b80"),
                ParentContentTypeId = BuiltInContentTypeId.Item,
                Group = Const.Groups.DefaultFieldsGroup
            };

        public static ContentTypeDefinition DocumentContentTypeDefinition
            = new ContentTypeDefinition
            {
                Name = Const.ContentTypes.DocumentContentType,
                Id = new Guid("40a775c6-b8b6-4731-92d0-017fc9a1376e"),
                ParentContentTypeId = BuiltInContentTypeId.Document,
                Group = Const.Groups.DefaultFieldsGroup
            };

        public static HideContentTypeLinksDefinition
            HideContentTypeLinksDefinition = new HideContentTypeLinksDefinition
            {
                ContentTypes =
                    new List<ContentTypeLinkValue>
                    {
                        new ContentTypeLinkValue
                        {
                            ContentTypeName =
                                BuiltInContentTypeNames.Item
                        },
                        new ContentTypeLinkValue
                        {
                            ContentTypeName =
                                BuiltInContentTypeNames.Link
                        }
                    }
            };
    }
}
