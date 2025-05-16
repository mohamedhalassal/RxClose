namespace RxCloseAPI.Conntracts.Requests;
public record CreatUserRequest(
        int PhoneNumber,
        string Name,
        string UserName,
        string Password,
        string Email,
        string Location
    );