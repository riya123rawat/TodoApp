namespace TodoApp.Data
{

    public static class TodoSequencer
    {
        // Private static field
        private static int TodoId;

        // Public static method to increment and return the next personId value
        public static int NextTodoId()
        {
            return ++TodoId;
        }

        // Public static method to reset personId to 0
        public static void Reset()
        {
            TodoId = 0;
        }
    }
}
