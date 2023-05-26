using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Eight_prac_C_sharp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string theme;
        private static string language;

        public static string Language
        {
            get { return language; }
            set { language = value;
                var lang = new ResourceDictionary { Source = new Uri($"pack://application:,,,/LanguageLib;component/Themes/{value}.xaml", UriKind.RelativeOrAbsolute)};
                Current.Resources.MergedDictionaries.RemoveAt(1);
                Current.Resources.MergedDictionaries.Insert(1, lang);
            }
        }


        public static string Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                var dict = new ResourceDictionary { Source = new Uri($"pack://application:,,,/CustomLib;component/Themes/{value}.xaml", UriKind.RelativeOrAbsolute)};
                Current.Resources.MergedDictionaries.RemoveAt(0);
                Current.Resources.MergedDictionaries.Insert(0,dict);

            }
        }
    }
}
