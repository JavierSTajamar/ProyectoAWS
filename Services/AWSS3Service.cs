using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProyectoAWS.Services
{
    public class AWSS3Service
    {
        private String bucketName;
        private IAmazonS3 awsClient;
        private string url = "https://bucketproyaws.s3.amazonaws.com/";

        public AWSS3Service(IAmazonS3 awsclient,
            IConfiguration configuration)
        {
            this.awsClient = awsclient;
            this.bucketName = configuration["AWSS3:BucketName"];
        }

       
        public async Task<bool> UploadFileAsync(Stream stream
            , String fileName)
        {

            PutObjectRequest request = new PutObjectRequest()
            {
                InputStream = stream,
                Key = fileName,
                BucketName = this.bucketName
            };
            PutObjectResponse response =
                await this.awsClient.PutObjectAsync(request);
            if (response.HttpStatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<String>> GetFilesAsync()
        {
            ListVersionsResponse response =
                await this.awsClient.ListVersionsAsync(this.bucketName);
            return response.Versions.Select(x => x.Key).ToList();
        }

        public async Task<bool> DeleteFileAsync(string fileName)
        {
            DeleteObjectResponse response =
                await this.awsClient.DeleteObjectAsync
                (this.bucketName, fileName);
            if (response.HttpStatusCode == HttpStatusCode.NoContent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Stream> GetFileAsync(String fileName)
        {
            GetObjectResponse response =
                await this.awsClient.GetObjectAsync(this.bucketName, fileName);
            if (response.HttpStatusCode == HttpStatusCode.OK)
            {
                return response.ResponseStream;
            }
            else
            {
                return null;
            }
        }
        public string GetUrl(string filename)
        {
            return url + filename;
        }
    }
}
