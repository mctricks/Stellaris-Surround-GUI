using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SurroundGUIBuilder
{
    public static class FileBuilder
    {
        public static string ReadTemplate(Template template)
        {
            string output;

            var fileStream = new FileStream(@"Templates/" + template.Filename, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                output = streamReader.ReadToEnd();
            }

            return output;
        }
        public static void WriteTemplate(string path, string filename, string contents)
        {
            System.IO.File.WriteAllText(path + filename, contents);
        }

        public static string MakeReplacements(string template, IEnumerable<Replacement> replacements, ReplacementConfiguration config)
        {
            foreach (var replacement in replacements)
            {
                var value = replacement.BaseValue
                    + (config.singleMonitorWidth * replacement.ScreenLengths);
                
                if (replacement.IncludeBevel)
                {
                    value += (config.bevelSize * replacement.ScreenLengths);
                }

                template = template.Replace("[" + replacement.Name + "]", value.ToString());
            }

            return template;
        }

    }
}
