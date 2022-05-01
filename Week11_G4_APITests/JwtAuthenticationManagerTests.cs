using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week11_G4_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week11_G4_API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Week11_G4_API.Data;
using Week11_G4_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Week11_G4_API.Tests
{
    [TestClass()]
    public class JwtAuthenticationManagerTests
    {
        [TestMethod()]
        public void AuthenticateTest()
        {
            JwtAuthenticationManager manager = new JwtAuthenticationManager("ernvienrynuynvrev");

            User user = new User
            {
                username = "test",
                password = "password"
            };

            var testReturn = manager.Authenticate(user.username, user.password);

            Assert.IsNotNull(testReturn);
        }

        [TestMethod()]
        public void CoursesTest()
        {
            CoursesController hi = new CoursesController("retrtbrtbrtbbrtb");
            var res = hi.GetCourses();

            Assert.IsNotNull(res);
        }

        [TestMethod()]
        public void InstructorsTest()
        {
            //INSERT access
            Instructor addInst = new Instructor();
            addInst.InstructorId = "10";
            addInst.InstructorFirstName = "Coyster";
            addInst.InstructorLastName = "IsTheBest";
            addInst.InstructorEmail = "thisInstructorsEmail@gmail.com";
            addInst.InstructorSalary = 100000;
            InstructorsController hey = new InstructorsController("edverrtbtrbverg");
                
            hey.PutInstructor("5498456",addInst);

            var req = hey.GetInstructor("10");

            hey.DeleteInstructor("10");

            Assert.IsNotNull(req);
        }

        [TestMethod()]
        public void CreditTest()
        {
            //Checks for record with specific ID
            CreditsController hello = new CreditsController("dbrtertbrtbrtbtb");

            var ret = hello.GetCredit("C001");

            Assert.IsNotNull(ret);
        }

        [TestMethod()]
        public void StudentsTest()
        {
            //DELETE access
            StudentsController hola = new StudentsController("trvbrtbrtbrtbrtbbty");

            hola.DeleteStudent("S007");

            Student addStud = new Student();

            addStud.StudentId = "S007";
            addStud.StudentFirstName = "Missy";
            addStud.StudentLastName = "Johnes";
            addStud.StudentEmail = "missyjones@gmail.com";
            addStud.StudentPhoneNumber = "320-623-9284";

            var rep = hola.GetStudent("S007");

            hola.PutStudent("4556456", addStud);

            Assert.IsNotNull(rep);
        }
    }
    [TestClass()]
    public class APITests
    {
        //[Fact]
        //public async Task GET_Coureses()
        //{
        //    await using var app = new WebApplicationFactory<Api.Startup>();
        //}
    }

}