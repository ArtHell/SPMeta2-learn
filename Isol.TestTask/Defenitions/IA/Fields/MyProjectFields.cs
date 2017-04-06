using System;
using Isol.TestTask.Consts;
using Isol.TestTask.Defenitions.Taxonomy;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;
using SPMeta2.Standard.Definitions.Fields;

namespace Isol.TestTask.Defenitions.IA.Fields
{
    public static class MyProjectFields
    {
        public static TaxonomyFieldDefinition ProjectStatus = new TaxonomyFieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.ProjectStatus,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.ProjectStatus,
            Group = Const.Groups.DefaultFieldsGroup,
            Id = new Guid("e9a6044a-980d-4a2c-8486-0e4f77e7952d"),
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
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.StartDate.Trim(),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = new Guid("a4f6eea2-af6a-4926-b960-5fb8f493b5ff")
        };

        public static FieldDefinition EndDate = new FieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.EndDate,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.EndDate.Trim(),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = new Guid("6d50b5b8-72fe-4564-bf4d-6ecf5e5234b7")
        };

        public static FieldDefinition ProjectManager = new FieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.ProjectManager,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.ProjectManager.Trim(),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.User,
            Id = new Guid("7bbe75eb-8998-4efe-b014-8e4b090251d2")
        };

        public static FieldDefinition Team = new FieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.Team,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.Team.Trim(),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.UserMulti,
            Id = new Guid("ebf0f236-6e1e-4744-8d17-d049343a0513")
        };

        public static TaxonomyFieldDefinition Department = new TaxonomyFieldDefinition
        {
            Title = Const.FieldNames.ProjectFields.Department,
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.Department.Trim(),
            Group = Const.Groups.DefaultFieldsGroup,
            Id = new Guid("e1714942-213e-4087-b8e5-d68aa92014f0"),
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
            InternalName = Const.InternalPrefixes.Project + Const.FieldNames.ProjectFields.ProjectValue.Trim(),
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.Note,
            Id = new Guid("dd7f51f6-119e-4854-8597-5009f1e08a9e")
        };
    }
}
