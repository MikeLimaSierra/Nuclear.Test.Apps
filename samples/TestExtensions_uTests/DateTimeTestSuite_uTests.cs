using System;
using System.Collections.Generic;

using Nuclear.TestSite;

namespace TestExtensions {
    class DateTimeTestSuite_uTests {

        #region IsWeekend

        [TestMethod]
        [TestData(nameof(IsWeekendData))]
        void IsWeekend(DateTime input1, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.DateTime().IsWeekend(input1),
                (count, result, message), "Test.If.DateTime.IsWeekend");

        }

        IEnumerable<Object[]> IsWeekendData() {
            return new List<Object[]>() {
                new Object[] { new DateTime(2021, 1, 4), 1, false, "[Date = '01/04/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 5), 2, false, "[Date = '01/05/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 6), 3, false, "[Date = '01/06/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 7), 4, false, "[Date = '01/07/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 8), 5, false, "[Date = '01/08/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 9), 6, true, "[Date = '01/09/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 10), 7, true, "[Date = '01/10/2021 00:00:00']" },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsWeekendData))]
        void NotIsWeekend(DateTime input1, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.DateTime().IsWeekend(input1),
                (count, result, message), "Test.IfNot.DateTime.IsWeekend");

        }

        IEnumerable<Object[]> NotIsWeekendData() {
            return new List<Object[]>() {
                new Object[] { new DateTime(2021, 1, 4), 1, true, "[Date = '01/04/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 5), 2, true, "[Date = '01/05/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 6), 3, true, "[Date = '01/06/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 7), 4, true, "[Date = '01/07/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 8), 5, true, "[Date = '01/08/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 9), 6, false, "[Date = '01/09/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 10), 7, false, "[Date = '01/10/2021 00:00:00']" },
            };
        }

        #endregion

        #region IsWorkDay

        [TestMethod]
        [TestData(nameof(IsWorkDayData))]
        void IsWorkDay(DateTime input1, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.If.DateTime().IsWorkDay(input1),
                (count, result, message), "Test.If.DateTime.IsWorkDay");

        }

        IEnumerable<Object[]> IsWorkDayData() {
            return new List<Object[]>() {
                new Object[] { new DateTime(2021, 1, 4), 1, true, "[Date = '01/04/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 5), 2, true, "[Date = '01/05/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 6), 3, true, "[Date = '01/06/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 7), 4, true, "[Date = '01/07/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 8), 5, true, "[Date = '01/08/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 9), 6, true, "[Date = '01/09/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 10), 7, false, "[Date = '01/10/2021 00:00:00']" },
            };
        }

        [TestMethod]
        [TestData(nameof(NotIsWorkDayData))]
        void NotIsWorkDay(DateTime input1, Int32 count, Boolean result, String message) {

            Statics.DDTResultState(() => DummyTest.IfNot.DateTime().IsWorkDay(input1),
                (count, result, message), "Test.IfNot.DateTime.IsWorkDay");

        }

        IEnumerable<Object[]> NotIsWorkDayData() {
            return new List<Object[]>() {
                new Object[] { new DateTime(2021, 1, 4), 1, false, "[Date = '01/04/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 5), 2, false, "[Date = '01/05/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 6), 3, false, "[Date = '01/06/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 7), 4, false, "[Date = '01/07/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 8), 5, false, "[Date = '01/08/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 9), 6, false, "[Date = '01/09/2021 00:00:00']" },
                new Object[] { new DateTime(2021, 1, 10), 7, true, "[Date = '01/10/2021 00:00:00']" },
            };
        }

        #endregion

    }
}
