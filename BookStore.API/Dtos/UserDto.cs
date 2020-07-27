using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Dtos
{
    public class UserDto
    {
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "Your password is limited to {2} to {1} characters",MinimumLength=6)]
        public string Password { get; set; }
    }

    public class UserForLoginResponse
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }

    public class UserForRegistration
    {

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