using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesNm.Jes
{
   [Table("Chapter")]
   public partial class Chapter : Entity    
   {
       public string ChapterName { get; set; }
   }
}
