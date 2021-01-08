using System;

using Nuclear.TestSite;

namespace TestExtensions {
    class StringTestSuiteExtensions_uTests {

        #region IsHelloWorld

        [TestMethod]
        [TestParameters(null, 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 2, false, "[String = '']")]
        [TestParameters(" ", 3, false, "[String = ' ']")]
        [TestParameters("Not Hello World!", 4, false, "[String = 'Not Hello World!']")]
        [TestParameters("Hello World!", 5, true, "[String = 'Hello World!']")]
        void IsHelloWorld(String input1, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.String.IsHelloWorld(input1),
                (count, result, message), "Test.If.String.IsHelloWorld");

        }

        [TestMethod]
        [TestParameters(null, 1, false, "Parameter 'string' is null.")]
        [TestParameters("", 2, true, "[String = '']")]
        [TestParameters(" ", 3, true, "[String = ' ']")]
        [TestParameters("Not Hello World!", 4, true, "[String = 'Not Hello World!']")]
        [TestParameters("Hello World!", 5, false, "[String = 'Hello World!']")]
        void NotIsHelloWorld(String input1, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.String.IsHelloWorld(input1),
                (count, result, message), "Test.IfNot.String.IsHelloWorld");

        }

        #endregion

    }
}
