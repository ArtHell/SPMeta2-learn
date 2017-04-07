using System.Collections.Generic;
using Isol.TestTask.Defenitions.IA;
using Isol.TestTask.Defenitions.IA.Fields;
using SPMeta2.Definitions.ContentTypes;
using SPMeta2.Enumerations;
using SPMeta2.Models;
using SPMeta2.Syntax.Default;

namespace Isol.TestTask.Models
{
    public static class MyWebModel
    {
        public static ModelNode GetProjectModel()
        {
            var model = SPMeta2Model.NewWebModel(web =>
            {
                web.AddList(MyLists.ProjectListDefinition, list =>
                {
                    list.AddHideContentTypeLinks(MyContentTypes.HideContentTypeLinksDefinition);
                    list.AddContentTypeLink(MyContentTypes.ProjectContentTypeDefinition);
                    list.AddListView(MyListViews.ProjectListViewDefinition);
                });
            });

            return model;
        }

        public static ModelNode GetDocumentModel()
        {
            var model = SPMeta2Model.NewWebModel(web =>
            {
                web.AddList(MyLists.ProjectDocumentsListDefinition, list =>
                {
                    list.AddHideContentTypeLinks(MyContentTypes.HideContentTypeLinksDefinition);
                    list.AddListFieldLink(MyDocumentFields.BelongToProject);
                    list.AddContentTypeLink(MyContentTypes.DocumentContentTypeDefinition);
                    list.AddListView(MyListViews.ProjectDocumentsListViewDefinition);
                });
            });

            return model;
        }
    }
}