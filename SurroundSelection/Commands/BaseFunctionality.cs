using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurroundSelection
{
    public class BaseFunctionality
    {
        /// <summary>
        /// Shows dialog box to user.
        /// </summary>
        /// <param name="serviceProvider">The service Provider</param>
        /// <param name="title">Title to show</param>
        /// <param name="message">Message to show</param>
        public static void ShowMessage(IServiceProvider serviceProvider, string title, string message)
        {
            VsShellUtilities.ShowMessageBox(
                        serviceProvider,
                        message,
                        title,
                        OLEMSGICON.OLEMSGICON_INFO,
                        OLEMSGBUTTON.OLEMSGBUTTON_OK,
                        OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
        }


        /// <summary>
        /// Toggles double quotes in the selected text
        /// </summary>
        /// <param name="text">The selected text</param>
        /// <returns>Toggled text</returns>
        public static string ToggleDoubleQuotes(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (text.StartsWith("\"") && text.EndsWith("\""))
                {
                    text = text.Substring(1, text.Length - 2);
                }
                else
                {
                    text = $"\"{text}\"";
                }                
            }
            return text;
        }

        /// <summary>
        /// Toggles single quotes in the selected text
        /// </summary>
        /// <param name="text">The selected text</param>
        /// <returns>Toggled text</returns>
        public static string ToggleSingleQuotes(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (text.StartsWith("'") && text.EndsWith("'"))
                {
                    text = text.Substring(1, text.Length - 2);
                }
                else
                {
                    text = $"'{text}'";
                }                
            }
            return text;
        }

        /// <summary>
        /// Toggles braces in the selected text
        /// </summary>
        /// <param name="text">The selected text</param>
        /// <returns>Toggled text</returns>
        public static string ToggleBraces(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (text.StartsWith("{") && text.EndsWith("}"))
                {
                    text = text.Substring(1, text.Length - 2);
                }
                else
                {
                    text = $"{{{text}}}";
                }
            }
            return text;
        }

        /// <summary>
        /// Toggles square brackets in the selected text
        /// </summary>
        /// <param name="text">The selected text</param>
        /// <returns>Toggled text</returns>
        public static string ToggleSquareBrackets(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (text.StartsWith("[") && text.EndsWith("]"))
                {
                    text = text.Substring(1, text.Length - 2);
                }
                else
                {
                    text = $"[{text}]";
                }
            }
            return text;
        }

        /// <summary>
        /// Toggles angular brackets in the selected text
        /// </summary>
        /// <param name="text">The selected text</param>
        /// <returns>Toggled text</returns>
        public static string ToggleAngularBrackets(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (text.StartsWith("<") && text.EndsWith(">"))
                {
                    text = text.Substring(1, text.Length - 2);
                }
                else
                {
                    text = $"<{text}>";
                }
            }
            return text;
        }

        /// <summary>
        /// Toggles asterisk in the selected text
        /// </summary>
        /// <param name="text">The selected text</param>
        /// <returns>Toggled text</returns>
        public static string ToggleAsterisk(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (text.StartsWith("*") && text.EndsWith("*"))
                {
                    text = text.Substring(1, text.Length - 2);
                }
                else
                {
                    text = $"*{text}*";
                }
            }
            return text;
        }

        /// <summary>
        /// Toggles parentheses in the selected text
        /// </summary>
        /// <param name="text">The selected text</param>
        /// <returns>Toggled text</returns>
        public static string ToggleParentheses(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (text.StartsWith("(") && text.EndsWith(")"))
                {
                    text = text.Substring(1, text.Length - 2);
                }
                else
                {
                    text = $"({text})";
                }
            }
            return text;
        }
    }
}
