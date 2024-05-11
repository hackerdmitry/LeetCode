using BuildTask.Responses;

namespace BuildTask.Requests;

public class QuestionContentRequest : BaseRequest<QuestionContent>
{
    protected override string OperationName => "questionContent";

    protected override string Query => @"
        query questionContent($titleSlug: String!) {
          question(titleSlug: $titleSlug) {
            content
            mysqlSchemas
            dataSchemas
          }
        }
    ";

    private readonly string titleSlug;

    public QuestionContentRequest(string titleSlug)
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