using Newtonsoft.Json.Converters;

namespace message360.Utilities
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}