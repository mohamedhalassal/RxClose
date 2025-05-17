namespace RxCloseAPI.Conntracts.Requests;
public record UserRequest(
        int PhoneNumber,
        string Name,
        string UserName,
        string Password,
        string Email,
        string Location
    );