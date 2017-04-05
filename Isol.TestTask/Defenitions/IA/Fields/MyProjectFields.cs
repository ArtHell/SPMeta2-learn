using System;
using Isol.TestTask.Consts;
using SPMeta2.Definitions;
using SPMeta2.Enumerations;
using SPMeta2.Standard.Definitions.Fields;

namespace Isol.TestTask.Defenitions.IA.Fields
{
    public static class MyProjectFields
    {
        public static FieldDefinition Title = new FieldDefinition
        {
            Title = "Title",
            InternalName = "proj_Title",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.Text,
            Id = Guid.NewGuid(),
        };

        public static FieldDefinition ProjectStatus = new TaxonomyFieldDefinition
        {
            Title = "Project Status",
            InternalName = "proj_ProjectStatus",
            Group = Const.Groups.DefaultFieldsGroup,
            Id = Guid.NewGuid(),
            IsMulti = false,
            TermSetName = Const.TermSets.ProjectStatus
        };

        public static FieldDefinition StartDate = new FieldDefinition
        {
            Title = "Start Date",
            InternalName = "proj_StartDate",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = Guid.NewGuid(),
        };

        public static FieldDefinition EndDate = new FieldDefinition
        {
            Title = "End Date",
            InternalName = "proj_EndDate",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = Guid.NewGuid(),
        };

        public static FieldDefinition ProjectManager = new FieldDefinition
        {
            Title = "Project Manager",
            InternalName = "proj_ProjectManager",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.User,
            Id = Guid.NewGuid(),
        };

        public static FieldDefinition Team = new FieldDefinition
        {
            Title = "Team",
            InternalName = "proj_Team",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.UserMulti,
            Id = Guid.NewGuid(),
        };

        public static FieldDefinition Department = new TaxonomyFieldDefinition
        {
            Title = "Department",
            InternalName = "proj_Department",
            Group = Const.Groups.DefaultFieldsGroup,
            Id = Guid.NewGuid(),
            IsMulti = false,
            TermSetName = Const.TermSets.Department
        };

        public static FieldDefinition ProjectValue = new FieldDefinition
        {
            Title = "ProjectValue",
            InternalName = "proj_ProjectValue",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.Note,
            Id = Guid.NewGuid(),
        };
    }
}
