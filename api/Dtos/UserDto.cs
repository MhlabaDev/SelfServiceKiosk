

namespace api.DTOs
{
    public class UserDto
    {
        public int UserId { get; set; }

        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }



        public WalletDto Wallet { get; set; }
        public ICollection<CartDto> Carts { get; set; }
        public ICollection<TransactionDto> Transactions { get; set; }
        public bool IsActive { get; set; } 
    }
}
