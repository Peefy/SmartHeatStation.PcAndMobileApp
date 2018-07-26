using Qiniu.Util;
using Qiniu.Http;
using Qiniu.Storage;

using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

using static SmartHeatStationServiceV2.QiniuStorage.Settings;
using SmartHeatStationServiceV2.Helpers;


namespace SmartHeatStationServiceV2.QiniuStorage
{
    public class UpLoad
    {
        public void DoUpLoad()
        {
            //string AK = "ACCESS_KEY";
            //string SK = "SECRET_KEY";
            // 目标空间名
            //string bucket = "TARGET_BUCKET";
            // 目标文件名
            string saveKey = "stations" + TimeHelper.GetUpLoadTime() + ".txt";
            // 本地文件
            string localFile = Path.Combine(Application.StartupPath, "stations.txt");
            // 上传策略
            PutPolicy putPolicy = new PutPolicy();
            // 设置要上传的目标空间
            putPolicy.Scope = Bucket;
            // 上传策略的过期时间(单位:秒)
            putPolicy.SetExpires(3600);
            // 文件上传完毕后，在多少天后自动被删除
            putPolicy.DeleteAfterDays = 1;
            // 请注意这里的Zone设置(如果不设置，就默认为华东机房)
            // var zoneId = Qiniu.Common.AutoZone.Query(AK,BUCKET);
            // Qiniu.Common.Config.ConfigZone(zoneId);
            Mac mac = new Mac(AccessKey, SecretKey); // Use AK & SK here
            // 生成上传凭证
            string token = Auth.createUploadToken(putPolicy, mac);
            UploadOptions uploadOptions = null;
            // 上传完毕事件处理
            UpCompletionHandler uploadCompleted = new UpCompletionHandler(OnUploadCompleted);
            // 方式1：使用UploadManager
            //默认设置 Qiniu.Common.Config.PUT_THRESHOLD = 512*1024;
            //可以适当修改,UploadManager会根据这个阈值自动选择是否使用分片(Resumable)上传    
            UploadManager um = new UploadManager();
            um.uploadFile(localFile, saveKey, token, uploadOptions, uploadCompleted);
        }

        private static void OnUploadCompleted(string key, ResponseInfo respInfo, string respJson)
        {
            // respInfo.StatusCode
            // respJson是返回的json消息，示例: { "key":"FILE","hash":"HASH","fsize":FILE_SIZE }
        }

    }
}
