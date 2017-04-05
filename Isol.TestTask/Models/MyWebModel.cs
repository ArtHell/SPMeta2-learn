using Isol.TestTask.Defenitions.IA;
using SPMeta2.Models;
using SPMeta2.Syntax.Default;

namespace Isol.TestTask.Models
{
    public static class MyWebModel
    {
        public static ModelNode GetModel()
        {
            var model = SPMeta2Model.NewWebModel(web =>
            {
                web.AddList(MyLists.ProjectListDefinition, list =>
                {
                    list.AddContentTypeLink(MyContentTypes.ProjectContentTypeDefinition);
                    list.AddListView(MyListViews.ProjectListViewDefinition);
                });

                web.AddList(MyLists.ProjectDocumentsListDefinition, list =>
                {
                    list.AddContentTypeLink(MyContentTypes.DocumentContentTypeDefinition);
                    list.AddListView(MyListViews.ProjectDocumentsListViewDefinition);
                });
            });

            return model;
        }
    }
}