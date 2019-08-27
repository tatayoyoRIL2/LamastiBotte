using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LamastiBotte.Core.Service
{
    /// <summary>
    /// Créer un <see cref="ServiceTool"/>
    /// </summary>
    public static class ServiceTool
    {
        /// <summary>
        /// Formate le message pour l'insérer en BDD.
        /// </summary>
        /// <param name="inputMessage">Message.</param>
        /// <returns></returns>
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


        /// <summary>
        /// Formate le message pour l'afficher à l'utilisateur.
        /// </summary>
        /// <param name="inputMessage">Message.</param>
        /// <returns></returns>
        public static string FormatOutputMessage(string inputMessage)
        {
            string outputMessage = string.Format(inputMessage[0].ToString().ToUpper() + inputMessage.Substring(1).ToLower());
            outputMessage += '.';

            return outputMessage;
        }

        /// <summary>
        /// Synthétise une voix
        /// </summary>
        /// <param name="inputMessage">Message.</param>
        /// <returns></returns>
        //public static void SpeechSynthesizer(string inputMessage)
        //{
        //    SpeechSynthesizer synth = new SpeechSynthesizer();
        //    synth.SetOutputToDefaultAudioDevice();
        //    synth.Speak(inputMessage);
        //}

    }
}
