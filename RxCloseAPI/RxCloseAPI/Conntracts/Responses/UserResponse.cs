namespace RxCloseAPI.Conntracts.Responses;

public record UserResponse(
        int Id,
        int PhoneNumber,
        string Name,
        string UserName,
        string Password,
        string Email,
        string Location
    );