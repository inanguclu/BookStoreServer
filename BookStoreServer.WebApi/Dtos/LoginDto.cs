namespace BookStoreServer.WebApi.Dtos;

public sealed record LoginDto(
    string UserNameOrEmail,
    string Password);