using Constants;
using Newtonsoft.Json.Converters;

namespace Models
{
    //Specify how datetime should be converter when serializing to SignalR
    public class DateTimeSignalRConverter : IsoDateTimeConverter
    {
        public DateTimeSignalRConverter()
        {
            DateTimeFormat = ChatConstants.DateFormatString;
        }
    }
}
