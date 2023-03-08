

using ImageResizer;

string fileName = Guid.NewGuid().ToString() + ".jpg";
string fullPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

Console.WriteLine("Enter the height :");
string height = Console.ReadLine();

Console.WriteLine("Enter the width :");
string width = Console.ReadLine();

try
{
    using (var stream = File.OpenRead(fullPath))
    {
        Image img = Image.Load(stream);
        string newSize = Resizer.Resize(img, int.Parse(height), int.Parse(width));
        string[] aSize = newSize.Split(",");

        img.Mutate(i => i.Resize(int.Parse(aSize[1]), int.Parse(aSize[0])));

        img.Save(fullPath);
    }
    Console.WriteLine("Image resized!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}