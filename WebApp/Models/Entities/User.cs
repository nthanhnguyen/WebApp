using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Entities
{
    public partial class User
    {

        [DisplayName("Mã nhân viên")]
        public string? UserID { get; set; }

        [Required]
        [DisplayName("Tên Nhân viên")]
        public required string UserName { get; set; }

        [Required]
        [DisplayName("Mật khẩu")]
        public required string Password { get; set; }

        [Required]
        [DisplayName("Email")]
        public required string Email { get; set; }

        [Required]
        [DisplayName("Số điện thoại")]
        public required string Tel { get; set; }
    }
}
