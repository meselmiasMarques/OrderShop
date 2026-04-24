namespace OrderManagement.Core.Responses;

public class Response<T>
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
    public List<string> Errors { get; set; }

    public Response()
    {
        Errors = new List<string>();
    }

    public Response(T data, string message = null)
    {
        Success = true;
        Message = message;
        Data = data;
        Errors = new List<string>();
    }

    public Response(string message, List<string> errors = null)
    {
        Success = false;
        Message = message;
        Errors = errors ?? new List<string>();
    }

    public static Response<T> Ok(T data, string message = null)
    {
        return new Response<T>(data, message);
    }

    public static Response<T> Fail(string message, List<string> errors = null)
    {
        return new Response<T>(message, errors);
    }
}