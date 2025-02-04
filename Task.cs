using System.Reflection;

public class Task
{
    //fields
    private string title;
    private string description;
    private bool iscomplete;
    //Constructor to take the info from the user and initialize it
    //constructor takes no return and just initiliaze inputs
    public Task (string title,string description,bool iscomplete)
    {
        this.title=title;
        this.description=description;
        this.iscomplete=iscomplete;
    }
        public string Title //getters and setters does Return to the world or take anything as well only each variable interactable
    {
        get {return title;}
        set {title=value;}

    }

    public string Description
    {
        get {return description;}
        set {description=value;}
    }

    public bool Iscomplete
    {
        get {return iscomplete;} //outside world reads the field variable
        set {iscomplete=value;} //outside world store the value in the field variable
    }
       public override string ToString()
    {
        return $"Title: {title}, Description: {description}, Is Complete: {iscomplete}";
    }
    

}