using Qiniu.Util;
using Qiniu.Storage.Persistent;
using Qiniu.Storage;
using Qiniu.Http;
using System.IO;
using System.Collections.Generic;

namespace QiniuYun
{
    class UpLoad
    {

        public void resumeUploadTest()
        {

            Mac mac = new Mac(Settings.AccessKey, Settings.SecretKey);

            ResumeRecorder recorder = new ResumeRecorder("dir");
            string token = "<token>";
            ResumeUploader target = new ResumeUploader(recorder, "test.txt", "F:\\test.txt", "test.txt", token, null, null);
            target.uploadFile();

        }

        public void RefreshFile()
        {
            Mac mac = new Mac(Settings.AccessKey, Settings.SecretKey);
            BucketManager bm = new BucketManager(mac);
            List<string> urls = new List<string> {"https://portal.qiniu.com/bucket/dugu/resource" };
            List<string> dirs = new List<string> { "test.txt"};
            bm.cdnRefresh(urls, dirs);
        }
    
        public void uploadStreamTest()
        {


            try
            {

                Mac mac = new Mac(Settings.AccessKey, Settings.SecretKey);

                UploadManager target = new UploadManager();

                string key = "s" + SmartHeatStationParaInfo.TimeHelper.GetUpLoadTime() + ".txt";
                string filePath = "stations.txt";
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                PutPolicy putPolicy = new PutPolicy();
                putPolicy.Scope = Settings.Bucket + ":" + key;
                putPolicy.SetExpires(3600);
                putPolicy.DeleteAfterDays = 1;
                string token = Auth.createUploadToken(putPolicy, mac);
                UploadOptions uploadOptions = null;

                UpCompletionHandler upCompletionHandler = new UpCompletionHandler(delegate (string fileKey, ResponseInfo respInfo, string response)
                {

                });
                target.uploadStream(fs, key, token, uploadOptions, upCompletionHandler);
            }
            catch 
            {

            }

        }

        public void uploadStreamTest(string _key,string _filePath)
        {

            Mac mac = new Mac(Settings.AccessKey, Settings.SecretKey);
    
            UploadManager target = new UploadManager();

            string key = _key;
            string filePath = _filePath;

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            PutPolicy putPolicy = new PutPolicy();
            putPolicy.Scope = Settings.Bucket + ":" + key;
            putPolicy.SetExpires(3600);
            putPolicy.DeleteAfterDays = 1;
            string token = Auth.createUploadToken(putPolicy, mac);
            UploadOptions uploadOptions = null;

            UpCompletionHandler upCompletionHandler = new UpCompletionHandler(delegate (string fileKey, ResponseInfo respInfo, string response)
            {

            });
            target.uploadStream(fs, key, token, uploadOptions, upCompletionHandler);
        }

    }
}
