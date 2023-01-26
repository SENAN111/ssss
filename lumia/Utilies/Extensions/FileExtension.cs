using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace lumia.Utilies.Extensions
{
    public static class FileExtension
    {
        public static bool CheckMemory(this IFormFile file, int kb) => 1024 * kb > file.Length;
        public static bool CheckType(this IFormFile file, string type)=> file.ContentType.Contains(type);
        public static string ChangeName(string Oldname)
        {
            string extensions= Oldname.Substring(Oldname.LastIndexOf(".") );
            if(Oldname.Length<32)
            {
                Oldname= Oldname.Substring(0,Oldname.LastIndexOf("."));
            }
            else
            {
                Oldname = Oldname.Substring(0, 32);
            }
            return Guid.NewGuid + extensions + Oldname;
        }
        public static string SaveFile(this IFormFile file, string path)
        {
            string filename = ChangeName(file.FileName);
            using (FileStream stream = new FileStream(Path.Combine(path, filename), FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return filename;
        }
        public static string CheckValidate(this IFormFile file, int kb, string type)
        {
            string result = "";
            if(!file.CheckMemory(kb))
            {
                result += $"bu olcude{kb} fayl olmamalidir";
            }
            if(!file.CheckType(type))
            {
                result += $"bele {file} file olmamalidir";
            }
            return result;


        }
        public static void DeleteFile(this string fileName, string root , string Folder) 
        {
            string path=Path.Combine(root,Folder,fileName);
            if(File.Exists(path))
            {
                File.Delete(path);
            }

        }
    }
   
}
