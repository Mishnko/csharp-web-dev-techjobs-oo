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
            string tempName = this.Name;
            string tempEmployer = EmployerName.Value;
            string tempEmployerLocation = EmployerLocation.Value;
            string tempJobType = JobType.Value;
            string tempJobCoreCompetency = JobCoreCompetency.Value;

            if (tempName == "" && tempEmployer == "" && tempEmployerLocation == "" && tempJobType == "" && tempJobCoreCompetency == "")
            {
                return "OOPS! This job does not seem to exist.";
            }
            if (this.Name == "")
            {
                tempName = "Data not available";
            }
            if (EmployerName.Value == "")
            {
                tempEmployer = "Data not available";
            }
            if (EmployerLocation.Value == "")
            {
                tempEmployerLocation = "Data not available";
            }
            if (JobType.Value == "")
            {
                tempJobType = "Data not available";
            }
            if (tempJobCoreCompetency == "")
            {
                tempJobCoreCompetency = "Data not available";
            }
            return "" +
                "\nID: " + Id +
                "\nName: " + tempName +
                "\nEmployer: " + tempEmployer +
                "\nLocation: " + tempEmployerLocation +
                "\nPosition Type: " + tempJobType +
                "\nCore Competency: " + tempJobCoreCompetency + "\n";
        }
    }
}
