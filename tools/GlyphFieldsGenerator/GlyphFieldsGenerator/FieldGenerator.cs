using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GlyphFieldsGenerator
{
    public static class FieldGenerator
    {
        public static void Write(string folderPath, string glyphListName, string libName, string libNamespace, List<GlyphField> iconList)
        {
            using (var file = new StreamWriter($"{folderPath}\\GlyphList{glyphListName}.cs"))
            {
                WriteHeader(file, glyphListName, libName, libNamespace);
                WriteLine(file, iconList);
                WriteFooter(file);
            }
        }

        private static void WriteFooter(StreamWriter file)
        {
            file.WriteLine($"#pragma warning restore CA1707");
            file.WriteLine($"#pragma warning restore 1591");
            file.WriteLine($"    }}");
            file.WriteLine($"}}");
        }

        private static void WriteHeader(StreamWriter file, string glyphListName, string libName, string libNamespace)
        {
            file.WriteLine($"namespace Plugin.Glypher.{libNamespace}");
            file.WriteLine($"{{");
            file.WriteLine($"    /// <summary>");
            file.WriteLine($"    /// {libName}");
            file.WriteLine($"    /// </summary>");
            file.WriteLine($"    public static class GlyphList{glyphListName}");
            file.WriteLine($"    {{");
            file.WriteLine($"#pragma warning disable 1591");
            file.WriteLine($"#pragma warning disable CA1707");
        }

        private static void WriteLine(StreamWriter file, List<GlyphField> list)
        {
            if (list is null || list.Any() == false)
            {
                return;
            }

            foreach (var item in list)
            {
                file.WriteLine(item);
            }
            file.WriteLine("");
        }
    }
}