using LabInheritance;

public class Dog : Pet //: is extends/impliments
{   /// <summary>
    /// Cat pet communicates with a unique sound 
    /// </summary>
    public Dog(string name) : base(name)
    {
    }

    public override string Communicate()
    {
        return "bark bark!";
    }

    public string Fetch() 
    {   
        return $"{this.Name} fetches a ball";
    }
}