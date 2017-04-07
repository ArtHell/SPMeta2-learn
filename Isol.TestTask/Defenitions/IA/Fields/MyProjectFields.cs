using System;
using Isol.TestTask.Consts;
using Isol.TestTask.Defenitions.Taxonomy;
using SPMeta2.Definitions;
using SPMeta2.Definitions.Fields;
using SPMeta2.Enumerations;
using SPMeta2.Standard.Definitions.Fields;

namespace Isol.TestTask.Defenitions.IA.Fields
{
    public static class MyProjectFields
    {
        public static TaxonomyFieldDefinition ProjectStatus = new TaxonomyFieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.ProjectStatus,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.ProjectStatus.Replace(" ", string.Empty),
            Group = Const.Groups.DefaultFieldsGroup,
            Id = new Guid("c02d28b8-3724-4061-81a1-abe654ec9a2f"),
            IsMulti = false,
            UseDefaultSiteCollectionTermStore = true,
            TermGroupName = TermGroups.MyGroupDefinition.Name,
            TermSetName = TermSets.ProjectStatusSet.Name,
            TermGroupId = TermGroups.MyGroupDefinition.Id,
            TermSetId = TermSets.ProjectStatusSet.Id
        };

        public static FieldDefinition StartDate = new FieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.StartDate,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.StartDate.Replace(" ", string.Empty),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = new Guid("825e3463-0f64-4476-96a2-fbf490e8ae5e")
        };

        public static FieldDefinition EndDate = new FieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.EndDate,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.EndDate.Replace(" ", string.Empty),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = new Guid("e65da880-9e6b-41ae-a0ad-e9100e169cde")
        };

        public static FieldDefinition ProjectManager = new FieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.ProjectManager,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.ProjectManager.Replace(" ", string.Empty),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.User,
            Id = new Guid("93588c96-0836-4ac2-a648-3ab20d8df52c")
        };

        public static FieldDefinition Team = new UserFieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.Team,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.Team.Replace(" ", string.Empty),
            Group = Const.Groups.DefaultFieldsGroup,
            AllowMultipleValues = true,
            Id = new Guid("ed861b93-feb7-4e46-89a7-ccbb77473b90")
        };

        public static TaxonomyFieldDefinition Department = new TaxonomyFieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.Department,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.Department.Replace(" ", string.Empty),
            Group = Const.Groups.DefaultFieldsGroup,
            Id = new Guid("d008f33f-0fc3-43ea-9679-835b1aca3021"),
            IsMulti = false,
            UseDefaultSiteCollectionTermStore = true,
            TermGroupName = TermGroups.MyGroupDefinition.Name,
            TermSetName = TermSets.DepartmentSet.Name,
            TermGroupId = TermGroups.MyGroupDefinition.Id,
            TermSetId = TermSets.DepartmentSet.Id
        };

        public static FieldDefinition ProjectValue = new FieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.ProjectValue,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.ProjectValue.Replace(" ", string.Empty),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.Note,
            Id = new Guid("a487a737-59bd-4092-afa9-5093d5dbf8b7")
        };
    }
}
