using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

internal class OppLOne
{
    static void Main(string[] args)
    {
        var diskC = new Drive();
        diskC.TotalSize = 23456;

        var diskCTotalSize = diskC.TotalSize;

        var items = new List<IFileSystemElement>();

        items.Add(new Drive()
        {
            Name = "C:",
            Items = new List<IFileSystemElement>
            {
                new File() { Name = "Program1.py"},
                new Directory()
                {
                    Name = "TEMP",
                    Items = new List<IFileSystemElement>()
                    {
                        new File() {Name = "readme.txt"},
                        new File() {Name = "hello.txt"}

                    }
                }

            }
        });

    }
}

public class Drive : IFileSystemElement
{
    public string Name { get; set; }
    public List<IFileSystemElement> Items { get; set; }
    //public int TotalSize {  get; set; }

    private int totalSize;

    public int TotalSize
    {
        get
        {
            return totalSize;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }

            totalSize = value;
        }
    }

    public int GetSize()
    {
        return FileSystemHelper.GetSize(Items);
    }

    public void Format()
    {
        // форматируем диск
    }
}

public class File : IFileSystemElement
{
    public string Name { get; set; }
    protected int _size;
   
    public int GetSize()
    {
        return _size;
    }
}


public class Directory : IFileSystemElement
{
    public string Name { get; set; }
    public List<IFileSystemElement> Items {  get; set; }

    public int GetSize()
    {
        return FileSystemHelper.GetSize(Items);
    }
}

public static class FileSystemHelper
{
    public static int GetSize(List<IFileSystemElement> items)
    {
        var totalSize = 0;

        foreach (var item in items)
        {
            totalSize += item.GetSize();
        }

        return totalSize;
    }
}

/// <summary>
/// абстрактный элемент ф.с.
/// </summary>
public abstract class FileSystemElement
{
    public abstract string GetSomeText();

    public void TryToInstance()
    {
        var fse = new Drive();
    }

    public void SuperNewMethod(int value,  string name)
    {

    }
   
}

public abstract class BaseFileSystemElement
{
    public static int GetSize(List<IFileSystemElement> items)
    {
        var totalSize = 0;

        foreach (var item in items)
        {
            totalSize += item.GetSize();
        }

        return totalSize;
    }
}

public interface IFileSystemElement
{
    public string Name { get; set; }

    public int GetSize();
}