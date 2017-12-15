using System;

namespace CSharpDemos
{
    class ThrowExpressionsDemo
    {
        public static void Show()
        {
            
        }

        #region old
        private string P1 { get; set; }
        private int? P2 { get; set; }
        public void OldWay(string param1, int? param2)
        {
            if (param1 == null) throw new ArgumentNullException(nameof(param1));
            if (param2 == null) throw new ArgumentNullException(nameof(param2));
            P1 = param1;
            P2 = param2;
        }
        #endregion

        #region new

        public void NewWay(string param1, int? param2)
        {
            P1 = param1 ?? throw new ArgumentNullException(nameof(param1));
            P2 = param2 ?? throw new ArgumentNullException(nameof(param2));
        }
        #endregion
    }
}
