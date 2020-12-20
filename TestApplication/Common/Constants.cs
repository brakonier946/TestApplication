namespace TestApplication.Core.Common
{
    public static class Constants
    {
        public static class Rest
        {
            public const string BaseAddress = "https://uxcandy.com/~shapoval/test-task-backend/v2";

            public static class Login
            {
                // Note: Without parameter "developer=1" I can't sign in.
                public const string Auth = "/login?developer=1";
            }

            public static class Tasks
            {
                public const string ListOfTasks = "/?sort_field={0}&sort_direction={1}&page={2}";
                public const string CreateTask = "/create";
                public const string EditTask = "/edit/{0}";
            }
        }
    }
}
