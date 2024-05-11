namespace BuildTask.Enums;

public class TaskData
{
    public string Title { get; set; }
    public Difficulty Difficulty { get; set; }
    public string SampleCodeSnippet { get; set; }

    public int ExamplesCount { get; set; }
    public VariableInfo[] Params { get; set; }
    public VariableInfo Return { get; set; }
}

public class VariableInfo
{
    public string Name { get; set; }
    public string Type { get; set; }

    public string[] Examples { get; set; }
}