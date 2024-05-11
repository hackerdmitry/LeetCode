using BuildTask.Responses;

namespace BuildTask.Requests;

public class QuestionEditorDataRequest : BaseRequest<QuestionEditorData>
{
    protected override string OperationName => "questionEditorData";

    protected override string Query => @"
        query questionEditorData($titleSlug: String!) {
          question(titleSlug: $titleSlug) {
            questionId
            questionFrontendId
            codeSnippets {
              lang
              langSlug
              code
            }
            envInfo
            enableRunCode
          }
        }
    ";

    private readonly string titleSlug;

    public QuestionEditorDataRequest(string titleSlug)
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