
using Nuclear.TestSite.TestSuites;

namespace TestExtensions {
    public static class TestSuiteCollectionExtensions {

        public static DateTimeTestSuite DateTime(this TestSuiteCollection _this) => new DateTimeTestSuite(_this);

    }
}
