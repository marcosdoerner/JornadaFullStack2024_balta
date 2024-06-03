using System.Text.Json.Serialization;

namespace FinaFlow.Core.Responses;

public class Response<TData>
{

    // Http Status Code
    private int _code = Configuration.DefaultStatusCode;

    public Response(TData? data,
    int code = Configuration.DefaultStatusCode,
    string? message = null)
    {
        Data = data;
        Message = message;
        _code = code;
    }

    [JsonConstructor]
    public Response() => _code = Configuration.DefaultStatusCode;

    public TData? Data { get; set; }
    public string? Message {get; set; }

    [JsonIgnore]
    public bool IsSuccess => _code is >= 200 and <= 299;
}
