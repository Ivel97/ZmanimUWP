using System;
using ZmanimUWP.Utilities;

namespace ZmanimUWP
{
    /// <summary>
    /// A simple implementation of ITimeZoneDateTime.
    /// </summary>
    public class DateWithLocation : IShallowCloneable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateWithLocation"/> class.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="location"></param>
        public DateWithLocation(DateTime date, GeoLocation location)
        {
            Date = date;
            Location = location;
        }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>The location.</value>
        public GeoLocation Location { get; set; }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        public object ShallowClone()
        {
            return MemberwiseClone();
        }
    }
}