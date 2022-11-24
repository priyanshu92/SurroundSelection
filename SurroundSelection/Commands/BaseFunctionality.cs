using Microsoft.VisualStudio.Shell;
using IAsyncServiceProvider = Microsoft.VisualStudio.Shell.IAsyncServiceProvider;
using OLEMSGICON = Microsoft.VisualStudio.Shell.Interop.OLEMSGICON;
using OLEMSGBUTTON = Microsoft.VisualStudio.Shell.Interop.OLEMSGBUTTON;
using OLEMSGDEFBUTTON = Microsoft.VisualStudio.Shell.Interop.OLEMSGDEFBUTTON;

namespace SurroundSelection.Commands
{
    public class BaseFunctionality
    {
        /// <summary>
        /// Shows dialog box to user.
        /// </summary>
        /// <param name="serviceProvider">The service Provider</param>
        /// <param name="title">Title to show</param>
        /// <param name="message">Message to show</param>
        public static void ShowMessage(IAsyncServiceProvider serviceProvider, string title, string message)
        {
            if (title is null)
                title = "Surround Selection";
            VsShellUtilities.ShowMessageBox(
                        serviceProvider as AsyncPackage,
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
            if (!string.IsNullOrWhiteSpace(text))
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
            if (!string.IsNullOrWhiteSpace(text))
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
            if (!string.IsNullOrWhiteSpace(text))
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
            if (!string.IsNullOrWhiteSpace(text))
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
            if (!string.IsNullOrWhiteSpace(text))
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
            if (!string.IsNullOrWhiteSpace(text))
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
            if (!string.IsNullOrWhiteSpace(text))
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

        /// <summary>
        /// Toggles multiline comment in the selected text
        /// </summary>
        /// <param name="text">The selected text</param>
        /// <returns>Toggled text</returns>
        public static string ToggleMultilineComment(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                if (text.StartsWith("/*") && text.EndsWith("*/"))
                {
                    text = text.Substring(2, text.Length - 3).Trim();
                }
                else
                {
                    text = $"/* {text} */";
                }
            }
            return text;
        }

        /// <summary>
        /// Toggles hash in the selected text
        /// </summary>
        /// <param name="text">The selected text</param>
        /// <returns>Toggled text</returns>
        public static string ToggleHash(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                if (text.StartsWith("#") && text.EndsWith("#"))
                {
                    text = text.Substring(1, text.Length - 2);
                }
                else
                {
                    text = $"#{text}#";
                }
            }
            return text;
        }
    }
}