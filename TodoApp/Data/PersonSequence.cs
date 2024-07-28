namespace TodoApp.Data
{

    public static class PersonSequencer
    {
        // Private static field
        private static int personId;

        // Public static method to increment and return the next personId value
        public static int NextPersonId()
        {
            return ++personId;
        }

        // Public static method to reset personId to 0
        public static void Reset()
        {
            personId = 0;
        }
    }
}
