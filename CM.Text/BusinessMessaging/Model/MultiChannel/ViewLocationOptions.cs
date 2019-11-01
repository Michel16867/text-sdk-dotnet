﻿using JetBrains.Annotations;
using Newtonsoft.Json;

namespace CM.Text.BusinessMessaging.Model.MultiChannel
{
    /// <summary>
    ///     The options for a <see cref="ViewLocationSuggestion" /> in <see cref="Channel.RCS" />.
    /// </summary>
    [PublicAPI]
    public class ViewLocationOptions
    {
        /// <summary>
        ///     Optional: The label to display at the pin
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        ///     The latitude in degrees
        /// </summary>
        /// <example>51.603802</example>
        /// <remarks>Either Latitude and <see cref="Longitude" /> or <see cref="SearchQuery" /> is required </remarks>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        ///     The longitude in degrees
        /// </summary>
        /// <example>4.770821</example>
        /// <remarks>Either <see cref="Latitude" /> and Longitude or <see cref="SearchQuery" /> is required </remarks>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        ///     Search for this location instead of using the latitude/longitude.
        /// </summary>
        /// <remarks>
        ///     Either <see cref="Latitude" /> and <see cref="Longitude" /> or SearchQuery is required.
        ///     For other connections both may be required.
        /// </remarks>
        [JsonProperty("searchQuery")]
        public string SearchQuery { get; set; }

        /// <summary>
        /// Can be used in some <see cref="Channel.RCS"/> connections to display a radius instead of only a pointer
        /// </summary>
        [JsonProperty("radius")]
        public int? Radius { get; set; }
    }
}
