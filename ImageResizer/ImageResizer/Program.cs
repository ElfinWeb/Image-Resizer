using ImageResizer;

string fileName = "example.jpg";
string fullPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

Console.WriteLine("Enter the height :");
string height = Console.ReadLine();

Console.WriteLine("Enter the width :");
string width = Console.ReadLine();

try
{
    Image img;
    using (var stream = File.OpenRead(fullPath))
    { 
        img = Image.Load(stream);
    }
    Resizer.ResizeImage(img, double.Parse(width), double.Parse(height));
    img.Save(fullPath);
    Console.WriteLine("Image resized!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}