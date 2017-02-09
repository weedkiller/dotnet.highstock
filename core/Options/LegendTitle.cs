using System;
using Windows.UI;
using DotNet.HighStock.Enums;
using DotNet.HighStock.Attributes;
using DotNet.HighStock.Helpers;

namespace DotNet.HighStock.Options
{
	/// <summary>
	/// A title to be added on top of the legend.
	/// </summary>
	public class LegendTitle
	{
		/// <summary>
		/// Generic CSS styles for the legend title. Defaults to:<pre>style: {   fontWeight: 'bold'}</pre>
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

		/// <summary>
		/// A text or HTML string for the title. 
		/// Default: null
		/// </summary>
		public string Text { get; set; }

	}

}