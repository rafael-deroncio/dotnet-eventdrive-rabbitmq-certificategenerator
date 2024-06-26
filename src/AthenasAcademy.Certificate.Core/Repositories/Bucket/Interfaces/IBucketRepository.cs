namespace AthenasAcademy.Certificate.Core.Repositories.Bucket.Interfaces;

public interface IBucketRepository
{
    Stream GetFile(string bucket, string key);
    Task<Stream> GetFileAsync(string bucket, string key);
    void UploadFile(Stream stream, string bucket, string key);
    Task UploadFileAsync(Stream stream, string bucket, string key);
    void DeleteFile(string bucket, string key);
    Task DeleteFileAsync(string bucket, string key);
    string GetDownloadLink(string bucket, string key, int BucketLinkDownloadExpires = 3600);
    Task<string> GetDownloadLinkAsync(string bucket, string key, int BucketLinkDownloadExpires = 3600);
}
