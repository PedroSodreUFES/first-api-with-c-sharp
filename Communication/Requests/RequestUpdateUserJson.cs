namespace MyFirstApi.Communication.Requests;

public class RequestUpdateUserJson
{
    public string Name { get; set; } = string.Empty; // valor padrao ""
    public string Email { get; set; } = string.Empty;
}