using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemos
{
    class LocalFunctions
    { 
        #region old - private

        private static string PrivateFunction()
        {
            return "Local function";
        }

        public static void Show()
        {
            string localFunction =  PrivateFunction();
            Console.WriteLine(localFunction);
        }
        #endregion

        #region old - lambda

        public void Show2()
        {
            Func<string> lambdaFunc = () => "Local function";
            Console.WriteLine(lambdaFunc());
        }
        #endregion

        #region new

        public void Show3()
        {
            string Show2()
            {
                string LocalFunction2() => "function";
                return "Local" + LocalFunction2();
            }

            Console.WriteLine(Show2());
        }
        #endregion

        public void ShowTest()
        {
            
        }
    }
}
