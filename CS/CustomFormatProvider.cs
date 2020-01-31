using System;
using DevExpress.Mvvm;

namespace DXGridSample {
    public class CustomFormatProvider : IFormatProvider, ICustomFormatter {
        public TimeSpan Zoom { get; }
        public CustomFormatProvider(TimeSpan zoom) {
            Zoom = zoom;
        }
        public object GetFormat(Type formatType) {
            if (typeof(ICustomFormatter) == formatType)
                return this;
            else
                return null;
        }
        public string Format(string format, object arg, IFormatProvider formatProvider) {
            var range = arg as DateTimeRange?;
            if (!range.HasValue)
                return null;
            if (Zoom.Hours > 2)
                return range.Value.Start.ToString("MMM");
            return string.Format("{0:MMMM yyyy} - {1:MMMM yyyy}", range.Value.Start, range.Value.End);
        }
    }
}