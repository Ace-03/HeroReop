using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomExtension
{
    public static class StringExtension
    {
        public static void FancyDebug(this string str)
        {
            Debug.LogFormat("This string contains {0} chacters.", str.Length);
        }
    }
}
