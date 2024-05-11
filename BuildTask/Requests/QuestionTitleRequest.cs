using BuildTask.Responses;

namespace BuildTask.Requests;

public class QuestionTitleRequest : BaseRequest<QuestionTitle>
{
    protected override string OperationName => "questionTitle";

    protected override string Query => @"
        query questionTitle($titleSlug: String!) {
          question(titleSlug: $titleSlug) {
            questionId
            questionFrontendId
            title
            titleSlug
            isPaidOnly
            difficulty
            likes
            dislikes
          }
        }
    ";

    private readonly string titleSlug;

    public QuestionTitleRequest(string titleSlug)
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