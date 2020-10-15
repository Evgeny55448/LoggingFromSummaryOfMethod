using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingFromSummaryOfMethod
{
    /// <summary />
    [LogCall]
    public class TestClass
    {
        /// <summary>
        /// method GetValue
        /// </summary>
        /// <returns>int value</returns>
        public int GetValue()
        {
            return 100500;
        }

        /// <summary>
        /// method Show
        /// </summary>
        public void Show()
        {

        }
    }
}
