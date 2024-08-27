using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tp2.api.Services;
using tp2.models;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        usuariosService service = new usuariosService();

        [TestMethod]
        public void TestMethod1()
        {
            Usuario user = new Usuario();
            user.Nombre = "Francisco";
            user.Dni = "1234";
            user.Email = "frdeaf@gmail.com";

            bool result = service.PostUser(user);

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Usuario user = new Usuario();
            user.Nombre = "Juancho";
            user.Dni = "1234";
            user.Email = "frdeaf@gmail.com";
            user.Id = 20;
            string id = Convert.ToString(user.Id);
            bool result = false;
            if (service.GetUsersById(id) != "")
            {
                result = true;
            }
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void TestMethod3()
        {
            Usuario user = new Usuario();
            user.Nombre = "peterPan";
            user.Dni = "1234";
            user.Email = "frdeaf@gmail.com";
            //user.Id = 20;

            bool result = service.UpdateUser(user);
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void TestMethod4()
        {
            Usuario user = new Usuario();
            user.Nombre = "Juancho";
            user.Dni = "1234";
            user.Email = "frdeaf@gmail.com";
            user.Id = 20;
            string id = Convert.ToString(user.Id);
            bool result = false;
            if (service.DeleteUser(id))
            {
                result = true;
            }

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void TestMethod5()
        {
            Usuario user = new Usuario();
            bool result = false;
            if (service.GetUsers() != "")
            {
                result = true;
            }
            Console.WriteLine(service.GetUsers());
            Assert.IsTrue(result);
        }
    }
}
