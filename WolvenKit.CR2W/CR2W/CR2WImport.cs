using System.IO;
using System.Runtime.InteropServices;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.CR2W
{
    /// IMPORT FLAGS
    [System.Flags]
    public enum EImportFlags
    {
        Default = 0x0,      // done
        Obligatory = 0x1,   
        Template = 0x2,     // done
        Soft = 0x4,         // done
        HashedPath = 0x8,       
        Inplace = 0x10,     // done
    };



    /// <summary>
    /// 
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CR2WImport
    {
        [FieldOffset(0)]
        public uint depotPath;

        [FieldOffset(4)]
        public ushort className;

        [FieldOffset(6)]
        public ushort flags;
    }

    public class CR2WImportWrapper : ICR2WImport
    {
        private CR2WImport _import;
        public CR2WImport Import => _import;

        private readonly CR2WFile _cr2w;

        public uint DepotPath => _import.depotPath;
        public ushort ClassName => _import.className;
        public ushort Flags => _import.flags;

        public string DepotPathStr => _cr2w.StringDictionary[_import.depotPath];
        public string ClassNameStr => _cr2w.Names[_import.className].Str;

        public CR2WImportWrapper(CR2WImport import, CR2WFile cr2w)
        {
            _import = import;
            _cr2w = cr2w;
        }

        public override string ToString() => DepotPathStr;
    }
}
