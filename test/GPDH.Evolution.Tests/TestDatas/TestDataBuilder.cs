using System;
using GPDH.Evolution.Core.Tasks;
using GPDH.Evolution.EntityFrameworkCore;

namespace GPDH.Evolution.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly EvolutionDbContext _context;

        public TestDataBuilder(EvolutionDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            _context.Tasks.AddRange(
                new Task("Follow the white rabbit", "Follow the white rabbit in order to know the reality."),
                new Task("Clean your room") { State = TaskState.Completed }
                );
        }
    }
}
