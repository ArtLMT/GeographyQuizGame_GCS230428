using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographyQuizGame.Services
{
    public static class Validator
    {
        public static bool isNullOrEmpty(string input)
        {
            return string.IsNullOrEmpty(input);
        }
    }
}
