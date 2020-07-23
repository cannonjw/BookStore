namespace BookStore.API.Dtos
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserForLoginResponse
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
/*
    "id": "9731c0d3-99b0-4c2d-a9d6-6adad8ed9697",
    "userName": "customer",
    "normalizedUserName": "CUSTOMER",
    "email": "customer@kahnsoft.com",
    "normalizedEmail": "CUSTOMER@KAHNSOFT.COM",
    "emailConfirmed": false,
    "passwordHash": "AQAAAAEAACcQAAAAENpNs1YHZ6oyUj+VfOupbyYass6dj95JEKPuDJcezZkmyFoGWE/hZkDxZN/+bH2wzQ==",
    "securityStamp": "57XO5ISGERZ7FTNPX6LTWC5OMCZDKW2J",
    "concurrencyStamp": "d29a0d4a-da83-442c-8700-c9a4c8aa877e",
    "phoneNumber": null,
    "phoneNumberConfirmed": false,
    "twoFactorEnabled": false,
    "lockoutEnd": null,
    "lockoutEnabled": true,
    "accessFailedCount": 0
    */