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
            Id = new Guid("f199e102-4529-4198-bd80-30120e404761"),
        };

        public static FieldDefinition ProjectStatus = new TaxonomyFieldDefinition
        {
            Title = "Project Status",
            InternalName = "proj_ProjectStatus",
            Group = Const.Groups.DefaultFieldsGroup,
            Id = new Guid("e9a6044a-980d-4a2c-8486-0e4f77e7952d"),
            IsMulti = false,
            TermSetName = Const.TermSets.ProjectStatus
        };

        public static FieldDefinition StartDate = new FieldDefinition
        {
            Title = "Start Date",
            InternalName = "proj_StartDate",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = new Guid("a4f6eea2-af6a-4926-b960-5fb8f493b5ff")
        };

        public static FieldDefinition EndDate = new FieldDefinition
        {
            Title = "End Date",
            InternalName = "proj_EndDate",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.DateTime,
            Id = new Guid("6d50b5b8-72fe-4564-bf4d-6ecf5e5234b7")
        };

        public static FieldDefinition ProjectManager = new FieldDefinition
        {
            Title = "Project Manager",
            InternalName = "proj_ProjectManager",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.User,
            Id = new Guid("7bbe75eb-8998-4efe-b014-8e4b090251d2")
        };

        public static FieldDefinition Team = new FieldDefinition
        {
            Title = "Team",
            InternalName = "proj_Team",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.UserMulti,
            Id = new Guid("ebf0f236-6e1e-4744-8d17-d049343a0513")
        };

        public static FieldDefinition Department = new TaxonomyFieldDefinition
        {
            Title = "Department",
            InternalName = "proj_Department",
            Group = Const.Groups.DefaultFieldsGroup,
            Id = new Guid("e1714942-213e-4087-b8e5-d68aa92014f0"),
            IsMulti = false,
            TermSetName = Const.TermSets.Department
        };

        public static FieldDefinition ProjectValue = new FieldDefinition
        {
            Title = "ProjectValue",
            InternalName = "proj_ProjectValue",
            Group = Const.Groups.DefaultFieldsGroup,
            FieldType = BuiltInFieldTypes.Note,
            Id = new Guid("dd7f51f6-119e-4854-8597-5009f1e08a9e")
        };
    }
}
