namespace MyFirstApi.Communication.Requests;

public class RequestChangePasswordJson
{
    public string CurrentPassword { get; set; } = string.Empty; // valor padrao ""
    public string NewPassword { get; set; } = string.Empty;
}