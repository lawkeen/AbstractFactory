using System;
using System.IO;

namespace Task4
{
    /// <summary>
    /// Main class basic variables
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Name of an app
        /// </summary>
        private static readonly string _appName = "versta.html";

        /// <summary>
        /// Extension of an app
        /// </summary>
        private static readonly string Extension = Path.GetExtension(_appName);

        /// <summary>
        /// Main method
        /// </summary>
        public static void Main()
        {
            Parametres par;
            if (Extension == ".html")
            {
                par = new Parametres(new HTMLFactory());
                par.Output();
            }
            else if (Extension == ".cs")
            {
                par = new Parametres(new cSharpFactory());
                par.Output();
            }
            else if (Extension == ".sql")
            {
                par = new Parametres(new SQLFactory());
                par.Output();
            }
            else
            {
                Console.WriteLine("There is no parameters for this extension of an app");
            }
        }
    }

    /// <summary>
    /// The main AppFactory with has all methods we will override
    /// </summary>
    abstract class AppFactory
    {
        /// <summary>
        /// Get Color
        /// </summary>
        /// <returns>string with parameter of color</returns>
        public abstract string Color();

        /// <summary>
        /// Get Cursor
        /// </summary>
        /// <returns>string with parameter of cursor</returns>
        public abstract string Cursor();

        /// <summary>
        /// Get height
        /// </summary>
        /// <returns>string with parameter of height</returns>
        public abstract string Height();

        /// <summary>
        /// Get width
        /// </summary>
        /// <returns>string with parameter of width</returns>
        public abstract string Width();

        /// <summary>
        /// Get resolution
        /// </summary>
        /// <returns>string with parameter of resolution</returns>
        public abstract string Resolution();

        /// <summary>
        /// Get display
        /// </summary>
        /// <returns>string with parameter of Display</returns>
        public abstract string Display();

        /// <summary>
        /// Get codeInsight
        /// </summary>
        /// <returns>string with parameter of Insight of Code</returns>
        public abstract string CodeInsight();

        /// <summary>
        /// Get consoleOn
        /// </summary>
        /// <returns>string with parameter of Console</returns>
        public abstract string ConsoleOn();

        /// <summary>
        /// Get autoCorrect
        /// </summary>
        /// <returns>string with parameter of AutoCorrection</returns>
        public abstract string AutoCorrect();

        /// <summary>
        /// Get forms
        /// </summary>
        /// <returns>string with parameter of Forms</returns>
        public abstract string Forms();
    }

    /// <summary>
    /// Factory for an applacation of C#
    /// </summary>
    class cSharpFactory : AppFactory
    {
        /// <summary>
        /// Get Color
        /// </summary>
        /// <returns>string with parameter of color</returns>
        public override string Color()
        {
            return "red";
        }

        /// <summary>
        /// Get height
        /// </summary>
        /// <returns>string with parameter of height</returns>
        public override string Height()
        {
            return "200";
        }

        /// <summary>
        /// Get width
        /// </summary>
        /// <returns>string with parameter of width</returns>
        public override string Width()
        {
            return "200";
        }

        /// <summary>
        /// Get resolution
        /// </summary>
        /// <returns>string with parameter of resolution</returns>
        public override string Resolution()
        {
            return "2160p";
        }

        /// <summary>
        /// Get Cursor
        /// </summary>
        /// <returns>string with parameter of cursor</returns>
        public override string Cursor()
        {
            return "no";
        }

        /// <summary>
        /// get forms
        /// </summary>
        /// <returns>string with parameter of Forms</returns>
        public override string Forms()
        {
            return "b,a,c";
        }

        /// <summary>
        /// Get codeInsight
        /// </summary>
        /// <returns>string with parameter of Insight of Code</returns>
        public override string CodeInsight()
        {
            return "no";
        }

        /// <summary>
        /// Get autoCorrect
        /// </summary>
        /// <returns>string with parameter of AutoCorrection</returns>
        public override string AutoCorrect()
        {
            return "on";
        }

        /// <summary>
        /// Get consoleOn
        /// </summary>
        /// <returns>string with parameter of Console</returns>
        public override string ConsoleOn()
        {
            return "no";
        }

        /// <summary>
        /// Get display
        /// </summary>
        /// <returns>string with parameter of Display</returns>
        public override string Display()
        {
            return "on";
        }
    }

    /// <summary>
    /// Factory for an applacation of SQL
    /// </summary>
    class SQLFactory : AppFactory
    {
        /// <summary>
        /// Get Color
        /// </summary>
        /// <returns>string with parameter of color</returns>
        public override string Color()
        {
            return "deep blue";
        }

        /// <summary>
        /// Get height
        /// </summary>
        /// <returns>string with parameter of height</returns>
        public override string Height()
        {
            return "4190";
        }

        /// <summary>
        /// Get width
        /// </summary>
        /// <returns>string with parameter of width</returns>
        public override string Width()
        {
            return "4190";
        }

        /// <summary>
        /// Get resolution
        /// </summary>
        /// <returns>string with parameter of resolution</returns>
        public override string Resolution()
        {
            return "8196p";
        }

        /// <summary>
        /// Get Cursor
        /// </summary>
        /// <returns>string with parameter of cursor</returns>
        public override string Cursor()
        {
            return "on";
        }

        /// <summary>
        /// get forms
        /// </summary>
        /// <returns>string with parameter of Forms</returns>
        public override string Forms()
        {
            return "c,a,b";
        }

        /// <summary>
        /// Get codeInsight
        /// </summary>
        /// <returns>string with parameter of Insight of Code</returns>
        public override string CodeInsight()
        {
            return "yes";
        }

        /// <summary>
        /// Get autoCorrect
        /// </summary>
        /// <returns>string with parameter of AutoCorrection</returns>
        public override string AutoCorrect()
        {
            return "no";
        }

        /// <summary>
        /// Get consoleOn
        /// </summary>
        /// <returns>string with parameter of Console</returns>
        public override string ConsoleOn()
        {
            return "yes";
        }

        /// <summary>
        /// Get display
        /// </summary>
        /// <returns>string with parameter of Display</returns>
        public override string Display()
        {
            return "no";
        }
    }

    /// <summary>
    /// Factory for an applacation of HTML
    /// </summary>
    class HTMLFactory : AppFactory
    {
        /// <summary>
        /// Get Color
        /// </summary>
        /// <returns>string with parameter of color</returns>
        public override string Color()
        {
            return "blue";
        }

        /// <summary>
        /// Get height
        /// </summary>
        /// <returns>string with parameter of height</returns>
        public override string Height()
        {
            return "100";
        }

        /// <summary>
        /// Get width
        /// </summary>
        /// <returns>string with parameter of width</returns>
        public override string Width()
        {
            return "100";
        }

        /// <summary>
        /// Get resolution
        /// </summary>
        /// <returns>string with parameter of resolution</returns>
        public override string Resolution()
        {
            return "1080p";
        }

        /// <summary>
        /// Get Cursor
        /// </summary>
        /// <returns>string with parameter of cursor</returns>
        public override string Cursor()
        {
            return "on";
        }

        /// <summary>
        /// get forms
        /// </summary>
        /// <returns>string with parameter of Forms</returns>
        public override string Forms()
        {
            return "a,b,c";
        }

        /// <summary>
        /// Get codeInsight
        /// </summary>
        /// <returns>string with parameter of Insight of Code</returns>
        public override string CodeInsight()
        {
            return "yes";
        }

        /// <summary>
        /// Get autoCorrect
        /// </summary>
        /// <returns>string with parameter of AutoCorrection</returns>
        public override string AutoCorrect()
        {
            return "on";
        }

        /// <summary>
        /// Get consoleOn
        /// </summary>
        /// <returns>string with parameter of Console</returns>
        public override string ConsoleOn()
        {
            return "no";
        }

        /// <summary>
        /// Get display
        /// </summary>
        /// <returns>string with parameter of Display</returns>
        public override string Display()
        {
            return "on";
        }
    }

    /// <summary>
    /// The constructor to all factories
    /// </summary>
    class Parametres
    {
        private string _color;

        private string _display;

        private string _forms;

        private string _autoCorrect;

        private string _consoleOn;

        private string _codeInsight;

        private string _cursor;

        private string _resolution;

        private string _width;

        private string _height;

        /// <summary>
        /// Method to override variables
        /// </summary>
        /// <param name="factory">the element of abstract factory</param>
        public Parametres(AppFactory factory)
        {
            _color = factory.Color();
            _display = factory.Display();
            _forms = factory.Forms();
            _autoCorrect = factory.AutoCorrect();
            _consoleOn = factory.ConsoleOn();
            _codeInsight = factory.CodeInsight();
            _cursor = factory.Cursor();
            _resolution = factory.Resolution();
            _width = factory.Width();
            _height = factory.Height();
        }

        /// <summary>
        /// Method to output parameters of factory
        /// </summary>
        public void Output()
        {
            Console.WriteLine("Color = " + _color +
                              "\n Display = " + _display +
                              "\n Forms = " + _forms +
                              "\n AutoCorrect = " + _autoCorrect +
                              "\n ConsoleOn = " + _consoleOn +
                              "\n CodeInsight = " + _codeInsight +
                              "\n Cursor = " + _cursor +
                              "\n Resolution = " + _resolution +
                              "\n Width = " + _width +
                              "\n Height = " + _height
            );
        }
    }
}