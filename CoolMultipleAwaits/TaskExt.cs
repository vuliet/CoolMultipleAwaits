using System.Diagnostics;

namespace CoolMultipleAwaits;

public class TaskExt
{
    public static async Task<T[]> WhenAll<T>(params Task<T>[] tasks)
    {
        var allTasks = Task.WhenAll(tasks);

        try
        {
            return await allTasks;
        }
        catch (Exception)
        {
            //ignore
        }

        throw allTasks.Exception ??
              throw new UnreachableException("AggregateException of all tasks was null. What the hell.");


    }
}
