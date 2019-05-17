using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LamastiBotte.Core.Service
{
    /// <summary>
    /// Créer un <see cref="ServiceTool"/>
    /// </summary>
    public static class ServiceTool
    {
        public static string FormatMessage(string inputMessage)
        {
            /// <summary>
            /// Math avec un regex les caractères "^0-9a-zA-Z "
            /// </summary>
            string outputMessage = Regex.Replace(inputMessage, @"[^0-9a-zA-Z ]+", "");

            /// <summary>
            /// Met le message de sortie en lower case
            /// </summary>
            outputMessage = outputMessage.ToLower();

            /// <summary>
            /// Supprime les espaces en début et fin de outputMessage
            /// </summary>
            char[] trimChars = { ' ' };
            outputMessage = outputMessage.TrimEnd(trimChars);
            outputMessage = outputMessage.TrimStart(trimChars);

            return outputMessage;
        }
    }
}
