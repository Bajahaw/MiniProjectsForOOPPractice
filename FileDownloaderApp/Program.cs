using System;
using System.ComponentModel;
using System.Net;
using System.Threading.Tasks;

class FileDownloader
{
    private readonly string localFilePath;
    private readonly string webURLFile;

    public FileDownloader(string webURLFile, string localFilePath)
    {
        this.webURLFile = webURLFile;
        this.localFilePath = localFilePath;
    }

    public async void StartFileDownload()
    {
        Console.WriteLine("Download started...");
        await DownloadFileAsync(this.webURLFile, this.localFilePath);
        Console.WriteLine("File successfully downloaded.");
    }

    private async Task DownloadFileAsync(string url, string localPath)
    {
        using (var client = new WebClient())
        {
            client.DownloadProgressChanged += DownloadProgressChanged;
            client.DownloadFileCompleted += Completed;

            await client.DownloadFileTaskAsync(new Uri(url), localPath);
        }
    }

    private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
    {
        Console.WriteLine($"{e.ProgressPercentage} % | {e.BytesReceived} bytes out of {e.TotalBytesToReceive} bytes retrieved");
    }

    private void Completed(object sender, AsyncCompletedEventArgs e)
    {
        if (e.Error != null)
        {
            Console.WriteLine($"Error: {e.Error.Message}");
            return;
        }

        if (e.Cancelled)
        {
            Console.WriteLine("Download cancelled.");
            return;
        }

        // Handle completion here
    }
}

class Program
{
    static void Main(string[] args)
    {
        var fileDownloader = new FileDownloader("https://youtu.be/H68bD6DV9m", "C:\\myfile.mp4");
        fileDownloader.StartFileDownload();
    }
}
