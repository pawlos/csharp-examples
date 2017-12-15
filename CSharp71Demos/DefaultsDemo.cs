using System;
using System.Collections.Generic;

namespace CSharp71Demos
{
    class DefaultsDemo
    {
        public static void Show()
        {
            {
                int zm1 = default(int);
                Dictionary<string, Func<Action<string>>> dict = default(Dictionary<string, Func<Action<string>>>);
            }

            #region new

            {
                int zm2 = default;
                Dictionary<string, Func<Action<string>>> dict = default;
            }

            #endregion
        }
    }
}
