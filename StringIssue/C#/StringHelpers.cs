using System.Collections.Generic;
using System.Text;

namespace StringIssue
{
    public static class StringHelpers
	{
		/// <summary>
		/// Method that does not perform well.
		/// </summary>
		/// <param name="strs"></param>
		/// <returns></returns>
		public static string MergeStrings(IEnumerable<string> strs)
		{
            var builder = new StringBuilder();
			foreach (var str in strs)
			{
			    builder.Append(str);
			}
			return builder.ToString();
		}
	}
}

/* Explain why your solution is faster below this line
    This is the good old string concatenation problem. This is a problem as you using the initial implementation with string concatenation keep making space on the heap during each iteration and using time on copying it into that space
    A Stringbuilder instead maintains an array and stuffs new things into it as necessary, and only when it is being built, copies the total string into the heap. I believe it is obvious that during this one time is faster than during it n times
*/
