using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SurroundGUIBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach(var template in StellarisReplacementData.Templates)
            {
                System.Console.WriteLine("Working on " + template.Filename +  "...");
                
                var templateText = FileBuilder.ReadTemplate(template);

                var result = FileBuilder.MakeReplacements(
                    templateText,
                    template.Replacements,
                    StellarisReplacementData.ReplacementConfiguration
                );

                FileBuilder.WriteTemplate(StellarisReplacementData.modPath, template.Filename, result);
            }

            System.Console.WriteLine("Complete");
        }
    }
}
