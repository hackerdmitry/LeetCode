using System.Threading.Tasks;
using BuildTask.Responses;
using GraphQL;
using GraphQL.Client.Http;

namespace BuildTask.Requests;

public abstract class BaseRequest<TResponse>
{
    protected abstract string OperationName { get; }
    protected abstract string Query { get; }

    public GraphQLRequest GetRequest()
    {
        return new GraphQLRequest
        {
            OperationName = OperationName,
            Query = Query,
            Variables = BuildVariables(),
        };
    }

    public async Task<TResponse> GetResponse(GraphQLHttpClient graphQLClient)
    {
        var graphQlRequest = GetRequest();
        var graphQlResponse = await graphQLClient.SendQueryAsync<Data<TResponse>>(graphQlRequest);
        return graphQlResponse.Data.Question;
    }

    protected virtual object BuildVariables() => null;
}