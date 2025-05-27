using Microsoft.Build.Framework;

namespace API.DTOs;

public class ForgotPasswordDto
{
    [Required]
    public string Email { get; set; } = "";
}
