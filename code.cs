static void Main(string[] args)
{
    string indirilecek = "https://www.google.com.tr/logos/2012/shot_put-2012-hp.jpg";
    string klasor = "C:\\";
    string dosyaAdi = "google_logo.jpg";
     
    WebClient webClient = new WebClient();
    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
    webClient.DownloadFileAsync(new Uri(indirilecek), klasor + dosyaAdi);
 
    Console.ReadLine();
}
 
private static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
{
    Console.WriteLine("Dosya indiriliyor: %{0}", e.ProgressPercentage);
}
 
private static void Completed(object sender, AsyncCompletedEventArgs e)
{
    Console.WriteLine("Dosya indirme tamamlandý!");
}