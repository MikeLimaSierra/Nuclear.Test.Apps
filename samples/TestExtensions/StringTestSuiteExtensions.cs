using System;
using System.Runtime.CompilerServices;

using Nuclear.Extensions;
using Nuclear.TestSite.TestSuites;

namespace TestExtensions {
    public static class StringTestSuiteExtensions {

        public static void IsHelloWorld(this StringTestSuite _this, String @string,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            if(@string == null) {
                _this.InternalFail($"Parameter '{nameof(@string)}' is null.", _file, _method);
                return;
            }

            _this.InternalTest(@string == "Hello World!", $"[String = {@string.Format()}]", customMessage, _file, _method);
        }

    }
}
