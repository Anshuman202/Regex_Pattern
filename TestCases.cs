using RejexAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UseCase1()
        {
            string name = "Anand";
            bool expected = true;
            Program program = new Program();
            bool actual = program.val(name);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase2()
        {
            string lastname = "Kumar";
            bool expected = true;
            Program program = new Program();
            bool actual = program.val(lastname);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase3()
        {
            string email = "abc.zxy@al.co.in";
            bool expected = true;
            Program program = new Program();
            bool actual = program.val(email);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase4()
        {
            string mb = "91 7345689101";
            bool expected = true;
            Program program = new Program();
            bool actual = program.val(mb);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UseCase5()
        {
            string password = "Orange";
            bool expected = true;
            Program program = new Program();
            bool actual = program.val(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase6()
        {
            string password = "Orange1";
            bool expected = true;
            Program program = new Program();
            bool actual = program.val(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase7()
        {
            string password = "Orange2";
            bool expected = true;
            Program program = new Program();
            bool actual = program.val(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase8()
        {
            string password = "Orange89";
            bool expected = true;
            Program program = new Program();
            bool actual = program.val(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseCase9()
        {
            string email1 = "abc.xyz@gmail.com";
            bool expected = true;
            Program program = new Program();
            bool actual = program.val(email1);
            Assert.AreEqual(expected, actual);
        }
    }
}