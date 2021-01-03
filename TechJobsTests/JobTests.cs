using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job new_job = new Job();
            Job new_job2 = new Job();
            Assert.IsFalse(new_job.Id == new_job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job new_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", new_job.Name);
            Assert.AreEqual("ACME", new_job.EmployerName.Value);
            Assert.AreEqual("Desert", new_job.EmployerLocation.Value);
            Assert.AreEqual("Quality control", new_job.JobType.Value);
            Assert.AreEqual("Persistence", new_job.JobCoreCompetency.Value);
            Assert.AreEqual(1, new_job.Id);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job new_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job new_job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(new_job.Equals(new_job2));
            Assert.IsFalse(new_job.Id.Equals(new_job2.Id));
        }

        [TestMethod]
        public void TestToStringEmptyLines()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("\n", job1.ToString().Substring(0, 1));
            Assert.IsTrue(job1.ToString().EndsWith("\n"));

        }

        [TestMethod]
        public void TestToStringContainsCorrectData()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string[] labels = job.ToString().Split('\n');
            Assert.AreEqual(labels[1], ("ID: " + job.Id));
            Assert.AreEqual(labels[2], ("Name: " + job.Name));
            Assert.AreEqual(labels[3], ("Employer: " + job.EmployerName));
            Assert.AreEqual(labels[4], ("Location: " + job.EmployerLocation));
            Assert.AreEqual(labels[5], ("Position Type: " + job.JobType));
            Assert.AreEqual(labels[6], ("Core Competency: " + job.JobCoreCompetency));
        }

        [TestMethod]
        public void TestToStringDataNotFound()
        {
            Job job = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
            string[] labels = job.ToString().Split('\n');
            Assert.AreEqual(labels[3], ("Employer: Data not available"));
        }

        [TestMethod]
        public void TestToStringReturnsMessage()
        {
            Job job = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            Assert.AreEqual("OOPS! This job does not seem to exist.", job.ToString());
        }
    }
}
