using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class SimpleFileCopy
    {
        public static void CopiarArchivo_1()
        {
            string fileName = "obito.jpg";
            string sourcePath = @"C:\Users\Usuario\Pictures";
            string targetPath = @"C:\Users\Usuario\Pictures\SubDir";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder.
            // If the directory already exists, this method does not create a new directory.
            System.IO.Directory.CreateDirectory(targetPath);

            // To copy a file to another location and
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);

            // To copy all the files in one directory to another directory.
            // Get the files in the source folder. (To recursively iterate through
            // all subfolders under the current directory, see
            // "How to: Iterate Through a Directory Tree.")
            // Note: Check for target path was performed previously
            //       in this code example.
            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }
            // Keep console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        public static void CopiarArchivo_2()
        {
            string fileName = "obito.jpg";
            string sourceFile = @"C:\Users\Usuario\Pictures\" + fileName;
            string createPath = @"C:\Users\Usuario\Pictures\SubDir";
            string targetPath = @"C:\Users\Usuario\Pictures\SubDir\" + fileName;

            System.IO.Directory.CreateDirectory(createPath);

            // To move a file or folder to a new location:
            if (System.IO.Directory.Exists(createPath))
            {
                System.IO.File.Copy(sourceFile, targetPath);
            } else
            {
                System.IO.Directory.CreateDirectory(createPath);
                System.IO.File.Copy(sourceFile, targetPath, true);
            }

            // To move an entire directory. To programmatically modify or combine
            // path strings, use the System.IO.Path class.
            //System.IO.Directory.Move(@"C:\Users\Public\public\test\", destinationFile);
        }
    }
}
