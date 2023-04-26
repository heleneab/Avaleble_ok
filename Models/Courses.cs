using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace test_4.Models
{

    public class Courses
    {
        public Courses()
        {
        }

        public Courses(string firstName, string fag)
        {
            FirstName = firstName;
            Fag = fag;
        }

        public int Id { get; set; }

        [Microsoft.Build.Framework.Required]
        [StringLength(100)]
        [DisplayName("First name")]
        public string FirstName { get; set; } = string.Empty;

        [Microsoft.Build.Framework.Required]
        [StringLength(100)]
        [DisplayName("Fag")]
        public string Fag { get; set; } = string.Empty;

    }
}