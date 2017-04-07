namespace Isol.TestTask.Consts
{
    public class Const
    {
        public static class Views
        {
            public static string ProjectTitle = "Projects";

            public static string ProjectDescription = "Projects";

            public static string ProjectViewTitle = "Managed Projects";

            public static string ProjectURL = "Projects";

            public static string DocumentTitle = "Project Documents";

            public static string DocumentDescription = "Project Documents";

            public static string DocumentViewTitle = "Project Documents";

            public static string DocumentURL = "Documents";
        }

        public static class InternalPrefixes
            {
                public static string Project = "proj_";

                public static string ProjectDocument = "doc_";
            }

        public static class FieldNames
        {
            public static class ProjectFields
            {
                public static string Title = "Title";

                public static string ProjectStatus = "Project Status";

                public static string StartDate = "Start Date";

                public static string EndDate = "End Date";

                public static string ProjectManager = "Project Manager";

                public static string Team = "Team";

                public static string Department = "Department";

                public static string ProjectValue = "ProjectValue";
            }

            public static class ProjectDocumentFields
            {
                public static string Title = "Title";

                public static string Name = "Name";

                public static string DocumentType = "Document Type";

                public static string ExpirationDate = "Expiration Date";

                public static string BelongToProject = "Belong To Project";

                public static string DocumentResponsible = "Document Responsible";
            }
            
        }

        public static class ContentTypes
        {
            public static string DocumentContentType = "Document CT";  
                      
            public static string ProjectContentType = "Project CT";            
        }

        public static class Groups
        {
            public static string DefaultFieldsGroup = "defaultFieldsGroup";
        }

        public static class TermGroups
        {
            public static string MyTermGroup = "A_Taxonomy_A";
        }

        public static class TermSets
        {
            public static string ProjectStatus = "ProjectStatus";

            public static string ProjectDocumentType = "ProjectDocumentType";

            public static string Department = "Department";
        }

        public static class Terms
        {
            public static class ProjectStatus
            {
                public static string PreInit = "Pre-init phase";

                public static string Active = "Active";

                public static string Rejected = "Rejected";

                public static string Cancelled = "Cancelled";
            }

            public static class ProjectDocumentType
            {
                public static string RFX = "RFX";

                public static string TechnicalVision = "Technical vision";

                public static string Contract = "Contract";

                public static string Requirements = "Requirements";
            }

            public static class Department
            {
                public static string SD1 = "SD1";

                public static string SD2 = "SD2";

                public static string WD = "WD";

                public static string MDIS = "MDIS";
                
                public static string QA = "QA";

                public static string HR = "HR";
            }
        }
    }
}
