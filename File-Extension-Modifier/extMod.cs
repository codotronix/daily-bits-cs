/*
 * Author: Suman Barick
*/

using System;
using System.IO;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Running...");
        
        if (args.Length < 3) 
        {
            Console.WriteLine("\n\n 3 params are required \n 1. String_Path_to_target_Directory \n 2. String_target_File_Ending_With \n 3.String_replace_Target_Ending_With");
            
        } 
        else 
        {
            string dirPath = args[0];
            string String_target_File_Ending_With = args[1];
            string String_replace_Target_Ending_With = args[2];
            
            //Console.WriteLine("\n dirPath = {0} \n String_target_File_Ending_With = {1} \n String_replace_Target_Ending_With = {2}", dirPath, String_target_File_Ending_With, String_replace_Target_Ending_With);
            
            if (Directory.Exists(dirPath)) 
            {
                // This path is a directory
                string [] fileEntries = Directory.GetFiles(dirPath);
                
                foreach(string fileName in fileEntries) 
                {
                    //Console.WriteLine(fileName);
                    if(fileName.EndsWith(String_target_File_Ending_With)) 
                    {
                        int extStartPoint = fileName.LastIndexOf(String_target_File_Ending_With);
                        string newName = fileName.Substring(0, extStartPoint) + String_replace_Target_Ending_With;
                        Console.WriteLine("\n\n Converting \n {0} \n to \n {1}", fileName, newName);
                        File.Move(fileName, newName);
                    }
                }
                
                Console.WriteLine("\n\n File Rename Successful...");
            }
            else 
            {
                Console.WriteLine("\n\n The Given Path \"" + dirPath + "\" is not a directory");
            }
        }
        
        Console.WriteLine("\n\n Press any key to exit... \n\n - Thanks \n\n Suman Barick");
		Console.ReadKey();
    }
}
