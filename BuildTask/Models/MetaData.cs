namespace BuildTask.Models;

public class MetaData
{
    public string Name { get; set; }
    public Param[] Params { get; set; }
    public Return Return { get; set; }
    public bool Manual { get; set; }
}

public class Param
{
    public string Name { get; set; }
    public string Type { get; set; }
}

public class Return
{
    public string Type { get; set; }
    public int? Size { get; set; }
}