namespace Greedy___Activity_Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a raw list of unsorted activities
            List<Activity> activities = new List<Activity>
        {
            new Activity("Task A", 1, 4),
            new Activity("Task B", 3, 5),
            new Activity("Task C", 0, 6),
            new Activity("Task D", 5, 7),
            new Activity("Task E", 3, 8),
            new Activity("Task F", 5, 9),
            new Activity("Task G", 6, 10),
            new Activity("Task H", 8, 11),
            new Activity("Task I", 8, 12),
            new Activity("Task J", 2, 13),
            new Activity("Task K", 12, 14)
        };

            // 2. Sort activities in ascending order based on their Finish time (Greedy Strategy)
            activities.Sort((x, y) => x.Finish.CompareTo(y.Finish)); // the list is already sorted 

            Console.WriteLine("Selected Activities for Maximum Throughput:");
            Console.WriteLine("------------------------------------------");

            // 3. The first activity in the sorted list always gets selected
            Activity lastSelected = activities[0];
            Console.WriteLine($"{lastSelected.Name} (Starts: {lastSelected.Start}, Finishes: {lastSelected.Finish})");

            // 4. Iterate through the rest of the sorted activities
            for (int i = 1; i < activities.Count; i++)
            {
                // If the start time of the current activity is greater than or equal
                // to the finish time of the last selected activity, select it
                if (activities[i].Start >= lastSelected.Finish)
                {
                    Console.WriteLine($"{activities[i].Name} (Starts: {activities[i].Start}, Finishes: {activities[i].Finish})");

                    // Update the pointer to track the newly selected activity
                    lastSelected = activities[i];
                }
            }
        }
    }
}
