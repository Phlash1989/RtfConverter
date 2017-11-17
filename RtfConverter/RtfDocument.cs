using System;
using System.Collections.Generic;
using System.Text;

namespace RtfConverter
{
    /// <summary>
    /// Represents an RTF document
    /// </summary>
    public class RtfDocument
    {
        /// <summary>
        /// The header of the RTF document.
        /// </summary>
        public RtfHeader Header { get; private set; }

        /// <summary>
        /// Loads the RTF document from the specified file.
        /// </summary>
        /// <param name="filename">File containing the RTF document to load.</param>
        public void Load(string filename)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads the RTF document from the specified string.
        /// </summary>
        /// <param name="rtf">String containing the RTF document to load.</param>
        public void LoadRtf(string rtf)
        {
            throw new NotImplementedException();
        }
    }
}
