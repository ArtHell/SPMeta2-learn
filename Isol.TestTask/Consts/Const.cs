namespace Isol.TestTask.Consts
{
    public class Const
    {
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
