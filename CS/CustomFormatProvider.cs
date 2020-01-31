using System;
using DevExpress.Mvvm;

namespace DXGridSample {
    public class CustomFormatProvider : IFormatProvider, ICustomFormatter {
        public static CustomFormatProvider GetFormatProvider(TimeSpan zoom) {
            return new CustomFormatProvider(zoom.Hours > 2 ? "{0:MMM}" : "{0:MMMM yyyy} - {1:MMMM yyyy}");
        }

        public string FormatString { get; }

        public CustomFormatProvider(string formatString) {
            FormatString = formatString;
        }
        public object GetFormat(Type formatType) {
            if (typeof(ICustomFormatter) == formatType)
                return this;
            else
                return null;
        }
        public string Format(string format, object arg, IFormatProvider formatProvider) {
            var range = arg as DateTimeRange?;
            return range.HasValue ? string.Format(FormatString, range.Value.Start, range.Value.End) : null;
        }
    }
}