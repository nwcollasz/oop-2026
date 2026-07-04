string path = @"F:\source\repos\cursoUdemy\exercicios\arquivos-io\path-ex\myfolder\file1.txt";

Console.WriteLine("\nDirectorySeparatorChar: " + Path.DirectorySeparatorChar);

Console.WriteLine("\nPathSeparator: " + Path.PathSeparator);

Console.WriteLine("\nGetDirectoryName: " + Path.GetDirectoryName(path));

Console.WriteLine("\nGetFileName: " + Path.GetFileName(path));

Console.WriteLine("\nGetExtension: " + Path.GetExtension(path));

Console.WriteLine("\nGetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));

Console.WriteLine("\nGetFullPath: " + Path.GetFullPath(path));

Console.WriteLine("\nGetTempPath: " + Path.GetTempPath());













