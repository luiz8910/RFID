using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadTagsSync
{
    class randomString
    {
        public randomString()
        { 
            
        }

        public string RandomString()
        {
            Random random = new Random();
            string input = "abcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < 15; i++)
            {
                ch = input[random.Next(0, input.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}
