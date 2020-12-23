using Sport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtremeSports.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }//Pk

        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [StringLength(20)]////attributes
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public string Password { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d{3}-\d{3}-\d{2}-\d{2}$")]
        //,(ErrorMessage = "Tr Phone num")]
        [Display(Name = "Telephone")]

        public string Tel { get; set; }
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public Gender Gender { get; set; }

        public City City { get; set; }
        public Country Country { get; set; }
        ////public string FullName

        /*public int? SportId { get; set; }

        [ForeignKey("SportId")]
        public Sports Sports { get; set; }
        */
        ////////public ICollection<Sports> Sport { get; set; } bu database i zorlar onun yerine linq kullansak daha iyi
    }
}
