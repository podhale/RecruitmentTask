using RecruitmentTask.Core.Entities;

namespace RecruitmentTask.Core.Seed
{
    public static class DirectorySeed
    {
        public static readonly Directory[] DirectoriesSeed= new Directory[]
        {
            new Directory() {Id = 1, Name = "Directory 1"},
            new Directory() {Id = 2, Name = "Directory 2"}
        };
    }
}
