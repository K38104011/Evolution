using System;
using GPDH.Evolution.Core.Tasks;

namespace GPDH.Evolution.Application.Tasks.Dto
{
    public class GetAllTasksInput
    {
        public TaskState? State { get; set; }
    }
}
