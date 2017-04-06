using Isol.TestTask.Defenitions.IA;
using Isol.TestTask.Defenitions.IA.Fields;
using Isol.TestTask.Defenitions.Taxonomy;
using SPMeta2.Extensions;
using SPMeta2.Models;
using SPMeta2.Standard.Syntax;
using SPMeta2.Syntax.Default;

namespace Isol.TestTask.Models
{
    public static class MySiteModel
    {
        public static ModelNode GetModel()
        {
            var model = SPMeta2Model.NewSiteModel(site =>
            {
                site
                .AddHostTaxonomyTermStore(TermStore.DefaultTermStore, store =>
                {
                    store.AddTaxonomyTermGroup(TermGroups.MyGroupDefinition, group =>
                    {
                        group
                        .AddTaxonomyTermSet(TermSets.DepartmentSet, termSet =>
                        {
                            termSet.AddTaxonomyTerms(Terms.DepartmentTerms);
                        })
                        .AddTaxonomyTermSet(TermSets.ProjectDocumentTypeSet, termSet =>
                        {
                            termSet.AddTaxonomyTerms(Terms.ProjectDocumentTypeTerms);
                        })
                        .AddTaxonomyTermSet(TermSets.ProjectStatusSet, termSet =>
                        {
                            termSet.AddTaxonomyTerms(Terms.ProjectStatusTerms);
                        });
                    });
                })
                .AddTaxonomyField(MyProjectFields.ProjectStatus)
                .AddTaxonomyField(MyProjectFields.Department)
                .AddTaxonomyField(MyDocumentFields.DocumentType)
                .AddField(MyProjectFields.StartDate)
                .AddField(MyProjectFields.EndDate)
                .AddField(MyProjectFields.ProjectManager)
                .AddField(MyProjectFields.Team)
                .AddField(MyProjectFields.ProjectValue)
                .AddContentType(MyContentTypes.ProjectContentTypeDefinition,
                        contentType =>
                        {
                            contentType
                                .AddContentTypeFieldLink(MyProjectFields.ProjectStatus)
                                .AddContentTypeFieldLink(MyProjectFields.StartDate)
                                .AddContentTypeFieldLink(MyProjectFields.EndDate)
                                .AddContentTypeFieldLink(MyProjectFields.ProjectManager)
                                .AddContentTypeFieldLink(MyProjectFields.Team)
                                .AddContentTypeFieldLink(MyProjectFields.Department)
                                .AddContentTypeFieldLink(MyProjectFields.ProjectValue);
                        })
                .AddField(MyDocumentFields.ExpirationDate)
                .AddField(MyDocumentFields.BelongToProject)
                .AddField(MyDocumentFields.DocumentResponsible)
                .AddContentType(MyContentTypes.DocumentContentTypeDefinition,
                        contentType =>
                        {
                            contentType
                                .AddContentTypeFieldLink(MyDocumentFields.DocumentType)
                                .AddContentTypeFieldLink(MyDocumentFields.ExpirationDate)
                                .AddContentTypeFieldLink(MyDocumentFields.BelongToProject)
                                .AddContentTypeFieldLink(MyDocumentFields.DocumentResponsible);
                        });
            });

            return model;
        }
    }
}
