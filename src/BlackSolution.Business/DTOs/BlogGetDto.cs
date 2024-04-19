using BlackSolution.Business.DTOValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSolution.Business.DTOs
{
    public class BlogGetDto : BlogDtoValidator
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDeleted { get; set; }



        
    }
}
