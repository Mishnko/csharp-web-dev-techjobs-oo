using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job (string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency ) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;

        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if (Value == "")
            {
                EmployerName.Value = "Data not found";
            }
                return " " +
                "\nID: " + Id +
                "\nName: " + Name +
                "\nEmployer: " + EmployerName +
                "\nLocation: " + EmployerLocation +
                "\nPosition Type: " + JobType +
                "\nCore Competency: " + JobCoreCompetency;
        }
        //TODO: make sure it returns "Data not available" if theres no data
    }
}
