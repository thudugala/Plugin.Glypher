using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Plugin.Glypher
{
    /// <summary>
    /// Glyph Register
    /// </summary>
    public class GlyphRegister
    {
        private static readonly Lazy<GlyphRegister> _mySingleton = new Lazy<GlyphRegister>(() => new GlyphRegister(), LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Gets the lazily initialized value of the current instance.
        /// </summary>
        public static GlyphRegister Current => _mySingleton.Value;

        private GlyphRegister()
        {
            _glyphDictionary = new Dictionary<string, GlyphInfo>();
        }

        /// <summary>
        /// Setup Glyphs
        /// </summary>
        /// <param name="glyphModuleType"></param>
        public void Init(Type glyphModuleType)
        {
            if (glyphModuleType is null)
            {
                return;
            }
            
            var glyphList = glyphModuleType.GetFields()
                                           .Where(f => f.IsStatic)
                                           .Select(f => f.GetValue(null) as GlyphInfo)
                                           .ToList();
            if (glyphList.Any() == false)
            {
                return;
            }
            
            foreach (var glyph in glyphList)
            {
                glyph.Name = glyph.Name.ToLowerInvariant();
                if (_glyphDictionary.ContainsKey(glyph.Name))
                {
                    continue;
                }
                _glyphDictionary.Add(glyph.Name, glyph);
            }
        }

        private readonly Dictionary<string, GlyphInfo> _glyphDictionary;

        /// <summary>
        /// get Glyph by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public GlyphInfo GetGlyph(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            name = name.ToLowerInvariant();
            return !_glyphDictionary.ContainsKey(name) ? null : _glyphDictionary[name];
        }
    }
}