using BuildTask.Responses;

namespace BuildTask.Requests;

public class ConsolePanelConfigRequest : BaseRequest<ConsolePanelConfig>
{
    protected override string OperationName => "consolePanelConfig";

    protected override string Query => @"
        query consolePanelConfig($titleSlug: String!) {
          question(titleSlug: $titleSlug) {
            questionId
            questionFrontendId
            questionTitle
            enableDebugger
            enableRunCode
            enableSubmit
            enableTestMode
            exampleTestcaseList
            metaData
          }
        }
    ";

    private readonly string titleSlug;

    public ConsolePanelConfigRequest(string titleSlug)
    {
        this.titleSlug = titleSlug;
    }

    protected override object BuildVariables()
    {
        return new
        {
            titleSlug,
        };
    }
}