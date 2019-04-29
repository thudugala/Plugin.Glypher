using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace GlyphFieldsGenerator
{
    public class FieldGenerator
    {
        private static readonly Lazy<FieldGenerator> _mySingleton = new Lazy<FieldGenerator>(() => new FieldGenerator(), LazyThreadSafetyMode.PublicationOnly);

        public static FieldGenerator Current => _mySingleton.Value;

        public void WriteDisable1591(StreamWriter file)
        {
            file.WriteLine($"#pragma warning disable 1591");
        }

        public void WriteRestore1591(StreamWriter file)
        {
            file.WriteLine($"#pragma warning restore 1591");
        }

        public void WriteLine(StreamWriter file, string listName, List<GlyphField> list)
        {
            if (list is null || list.Any() == false)
            {
                return;
            }
            
            if (string.IsNullOrWhiteSpace(listName) == false)
            {
                file.WriteLine($"// {listName}");
            }

            foreach (var item in list)
            {
                file.WriteLine(item);
            }
            file.WriteLine("");
        }
    }
}
