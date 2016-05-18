using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesNm.Jes.Dto
{
    [AutoMapFrom(typeof(Chapter))]
    public class ChapterListDto : EntityDto
    {
        public string ChapterName { get; set; }
    }
}
