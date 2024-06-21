using exam.controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExamUnitTestProject
{
    [TestClass]
    public class AutorizateControllerUnitTest
    {
        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void FindUserByLoginAndPassword_EmptyLogin_ThrowException()
        //{
        //    AutorizateController autorizateController = new AutorizateController();
        //    autorizateController.FindUserByLoginAndPassword("", "pass");
        //}
        //[TestMethod]
        //public void FindUserByLoginAndPassword_EmptyPassword_ThrowException_WithErrorParse()
        //{
        //    AutorizateController autorizateController = new AutorizateController();

        //    string expected = "Пароль не заполнен !";
        //    string actual = "";
        //    try
        //    {
        //    autorizateController.FindUserByLoginAndPassword("login1", "");
        //    }
        //    catch(Exception ex)
        //    {
        //        actual = ex.Message;
        //    }
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void FindUserByLoginAndPassword_UserNotFound_ThrowException()
        //{
        //    AutorizateController autorizateController = new AutorizateController();
        //    autorizateController.FindUserByLoginAndPassword("1", "1");
        //}
        //FindUserByLoginAndPassword_EmptyLogin_ThrowException
        //FindUserByLoginAndPassword_EmptyPassword_ThrowException_WithErrorParse
        //FindUserByLoginAndPassword_UserNotFound_ThrowException

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FindUserByLoginAndPassword_EmptyLogin_ThrowException()
        {
            AutorizateController autorizateController = new AutorizateController();
            autorizateController.FindUserByLoginAndPassword("", "pass");
        }
        [TestMethod]
        public void FindUserByLoginAndPassword_EmptyPassword_ThrowException_WithErrorParse()
        {
            AutorizateController autorizateController = new AutorizateController();
            string expected = "Пароль не заполнен !";
            string actual = "";
            try
            {
                autorizateController.FindUserByLoginAndPassword("login1", "");
            }
            catch (Exception ex)
            {

                actual = ex.Message;
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FindUserByLoginAndPassword_UserNotFound_ThrowException()
        {
            AutorizateController autorizateController = new AutorizateController();
            autorizateController.FindUserByLoginAndPassword("", "");
        }
    }
}
