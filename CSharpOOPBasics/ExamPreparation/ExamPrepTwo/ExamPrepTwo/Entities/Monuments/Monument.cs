public abstract class Monument
{
    private string name;

    protected Monument(string name)
    {
        this.name = name;   
    }
    
    public abstract int GetAffinity();

    public override string ToString()
    {
        string monumentType = this.GetType().Name;
        int typeEnd = monumentType.IndexOf("Monument");
        monumentType = monumentType.Insert(typeEnd, " ");

        return $"{monumentType}: {this.name}";
    }
}