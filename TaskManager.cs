public class TaskManager
{
                                        //applying composition principle
    List<Task> tasklist= new List<Task>(); //created an object from the previous class and exploit methods to it
    public List<Task> Tasklist //getters and setters does Return to the world or take anything as well only each variable interactable
    {
        get {return Tasklist;} //shows the field variable to the world
        set {tasklist=value;} //saves the value in the field vairable

    }

    public void AddTask (Task atask)
    {
        tasklist.Add(atask);
    }
    public void RemoveTask(Task atask)
    {
        tasklist.Remove(atask);
    }
    public void DisplayTasks()
    {
        foreach(var atask in tasklist)
        {
            Console.WriteLine(atask);
        }
        
    }
    

}
