//  Алгоритм обхода директория - посмотреть все папки и файлы в папке и во вложенных папкаххи файлах -> тоже папки и файлы

string path = "D:/Евгений/Программирование/Лекции/Закомство с языками программирования/recur/Task02";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo [] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);   
}