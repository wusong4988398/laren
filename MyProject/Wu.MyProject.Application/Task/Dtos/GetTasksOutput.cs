using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace Wu.MyProject.Task.Dtos
{
    public class GetTasksOutput : IOutputDto
    {
        public List<TaskDto> Tasks { get; set; } 
    }
}
