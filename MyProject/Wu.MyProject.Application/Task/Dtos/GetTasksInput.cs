using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Wu.MyProject.Tasks;

namespace Wu.MyProject.Task.Dtos
{
    public class GetTasksInput : IInputDto
    {
        public TaskState? State { get; set; }

        public int? AssignedPersonId { get; set; }
    }
}
