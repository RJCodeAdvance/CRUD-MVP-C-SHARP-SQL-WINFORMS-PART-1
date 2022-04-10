using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUDWinFormsMVP.Models
{
    public class PetModel
    {
        //Fields
        private int id;
        private string name;
        private string type;
        private string colour;

        //Properties - Validations
        [DisplayName("Pet ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Pet Name")]
        [Required(ErrorMessage ="Pet name is requerid")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Pet name must be between 3 and 50 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet type is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet type must be between 3 and 50 characters")]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        [DisplayName("Pet Colour")]
        [Required(ErrorMessage = "Pet colour is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet colour must be between 3 and 50 characters")]
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}
