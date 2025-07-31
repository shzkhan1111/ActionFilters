namespace ActionFilters.Models
{
    public class GetUserRequest
    {
        public int UserId { get; set; }
    }
    public class CreateUserRequest
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
    }
    public class ResetPasswordRequest
    {
        public int UserId { get; set; }
        public string NewPassword { get; set; } = "";
    }
}
