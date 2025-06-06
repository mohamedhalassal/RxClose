﻿namespace RxCloseAPI.Entities;

public sealed class Pharmecy
{
    public int Id { get; set; }
    public int PhoneNumber { get; set; }
    public string Name { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;

}
