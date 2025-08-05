using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using MyLibrary;

namespace ImplementationOfExtension
{
    public static class ArrayHelperExtension
    {
  

        public static void RotateArray(this ArrayHelper helper, int k)
        {
            void Reserve()
        {
            int end = helper.Values[helper.Length-1];
            for (int i = helper.Length - 1; i > 0; i--)
            {
                    helper.Values[i] = helper.Values[i - 1];
            }
                helper.Values[0] = end;
        }

            for(int i = 0; i < k; i++)
            {
                Reserve();
            }
        }
    }
}
