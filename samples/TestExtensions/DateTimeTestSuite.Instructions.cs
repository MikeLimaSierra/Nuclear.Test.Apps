using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Nuclear.Extensions;
using Nuclear.TestSite.TestSuites.Base;

namespace TestExtensions {

    public partial class DateTimeTestSuite : ChildTestSuite {

        #region IsWeekend

        public void IsWeekend(DateTime dateTime,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            IList<DayOfWeek> days = new List<DayOfWeek>() { DayOfWeek.Saturday, DayOfWeek.Sunday };

            InternalTest(days.Contains(dateTime.DayOfWeek), $"[Date = {dateTime.Format()}]", customMessage, _file, _method);
        }

        #endregion

        #region IsWorkDay

        public void IsWorkDay(DateTime dateTime,
            String customMessage = null, [CallerFilePath] String _file = null, [CallerMemberName] String _method = null) {

            IList<DayOfWeek> days = new List<DayOfWeek>() { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday };

            InternalTest(days.Contains(dateTime.DayOfWeek), $"[Date = {dateTime.Format()}]", customMessage, _file, _method);
        }

        #endregion

    }
}
