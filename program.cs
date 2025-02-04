// See https://aka.ms/new-console-template for more information

//DAta containters
using System.Reflection;

Task task1 = new Task("Complete Homework", "Finish math homework before the weekend", false);

//Operations 
TaskManager taskOperator=new TaskManager(); //initialize the object
while (true)
{ 
    Console.WriteLine("Type 1 to view tasks\ntype 2 to add a task\ntype 3 to delete a task\ntype 4 to terminate the program");
    int option=int.Parse(Console.ReadLine());
    if(option==1)
    {
        taskOperator.DisplayTasks();
    }
    else if(option==2)
    {
        Console.WriteLine("Enter title of the task: ");
        string title=Console.ReadLine();
        Console.WriteLine("Enter description of the tasks: ");
        string description=Console.ReadLine();
        Console.WriteLine("Enter status of the tasks: (Enter \"true\" or \"false\") ");
        bool iscomplete=bool.Parse(Console.ReadLine());

        Task ourtask=new Task(title,description,iscomplete);
        taskOperator.AddTask(ourtask);
    }
    else if (option==3) //remove a task
    {
        taskOperator.DisplayTasks();
        Console.WriteLine("enter the index to index of the task");
        int index=int.Parse(Console.ReadLine());
        taskOperator.RemoveTask(taskOperator.Tasklist[index]);
    }
    else if (option==4)
    {
        break;
    }

}


