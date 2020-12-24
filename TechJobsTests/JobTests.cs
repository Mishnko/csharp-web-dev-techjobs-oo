using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

        //Arrange the variables your test requires
        //Act on the methods your test requires
        //Assert the anticipated comparison of the expected and actual values

        [TestMethod]
        public void TestSettingJobId()
        {
            Job new_job = new Job();
            Job new_job2 = new Job();
            Assert.IsFalse(new_job.Id == new_job2.Id);
        }

        //Use Assert statements to test that the constructor correctly assigns the value of each field.
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job new_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            //Assert.AreEqual(expected, actual);
            Assert.AreEqual("Product tester", new_job.Name);
            Assert.AreEqual("ACME", new_job.EmployerName.Value);
            Assert.AreEqual("Desert", new_job.EmployerLocation.Value);
            Assert.AreEqual("Quality control", new_job.JobType.Value);
            Assert.AreEqual("Persistence", new_job.JobCoreCompetency.Value);
            Assert.AreEqual(1, new_job.Id);
        }

      //  Generate two Job objects that have identical field values EXCEPT for id. Test that Equals() returns false.
        [TestMethod] //MUST RETURN FALSE
        public void TestJobsForEquality()
        {
            Job new_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job new_job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(new_job.Equals(new_job2));
        }
        [TestMethod]
        public void

    }
}
