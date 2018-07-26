
using System.IO;
using Android.Content;
using Android.Graphics;
using Android.Text;

using Com.Tencent.MM.Sdk.Modelmsg;
using Com.Tencent.MM.Sdk.Openapi;

namespace WeChatSDK.Droid
{
    public class WechatShareManager
    {
        private const int THUMB_SIZE = 150;
        public const int WECHAT_SHARE_TYPE_TALK = SendMessageToWX.Req.WXSceneSession;  //会话  
        public const int WECHAT_SHARE_TYPE_FRENDS = SendMessageToWX.Req.WXSceneTimeline; //朋友圈  
        //public const string WECHAT_APP_ID = "Your WeChat APP_ID";

        IWXAPI mWXApi;
        Context mContext;

        public WechatShareManager(Context context,string yourWeChatAppId)
        {
            this.mContext = context;
            //初始化数据  
            //初始化微信分享代码  
            initWechatShare(context,yourWeChatAppId);
        }

        void initWechatShare(Context context, string yourWeChatAppId)
        {
            if (mWXApi == null)
            {
                mWXApi = WXAPIFactory.CreateWXAPI(context, yourWeChatAppId, true);
            }
            mWXApi.RegisterApp(yourWeChatAppId);
        }

        /// <summary>
        /// 分享一段文字
        /// </summary>
        /// <param name="shareContent">参数array注释</param>
        /// <param name="isWXSceneTimeline">true:分享到朋友圈;false:分享给好友</param>
        /// <returns>无</returns>
        public void ShareText(string shareContent,bool isWXSceneTimeline)
        {
            if (!TextUtils.IsEmpty(shareContent))
            {
                WXTextObject textObj = new WXTextObject()
                {
                    Text = shareContent,
                };
                WXMediaMessage msg = new WXMediaMessage()
                {
                    MyMediaObject = textObj,
                    Description = shareContent,
                };
                SendMessageToWX.Req req = new SendMessageToWX.Req()
                {
                    Transaction = buildTransaction("text"),
                    Message = msg,
                    Scene = isWXSceneTimeline ? WECHAT_SHARE_TYPE_FRENDS
                        : WECHAT_SHARE_TYPE_TALK,
                };               
                mWXApi.SendReq(req);
            }
        }

        /// <summary>
        /// 分享一个网页
        /// </summary>
        /// <param name="httpUrl">网页链接</param>
        /// <param name="isWXSceneTimeline">true:分享到朋友圈;false:分享给好友</param>
        /// <param name="icon">链接显示的图标</param>
        /// <param name="title">别人看到的标题</param>
        /// <param name="description">别人看到的描述</param>
        /// <returns>无</returns>
        public void ShareWebPage(string httpUrl, bool isWXSceneTimeline, Bitmap icon, string title, string description)
        {
            WXWebpageObject webpage = new WXWebpageObject()
            {
                WebpageUrl = httpUrl,
            };
            WXMediaMessage msg = new WXMediaMessage(webpage)
            {
                Title = title,
                Description = description,
            };
            using (MemoryStream stream = new MemoryStream())
            {
                icon.Compress(Bitmap.CompressFormat.Png, 100, stream);
                msg.ThumbData = stream.ToArray();  //设置缩略图  
            }
            SendMessageToWX.Req req = new SendMessageToWX.Req()
            {
                Transaction = buildTransaction("webpage"),
                Message = msg,
                Scene = isWXSceneTimeline ? WECHAT_SHARE_TYPE_FRENDS
                               : WECHAT_SHARE_TYPE_TALK,
            };
            mWXApi.SendReq(req);
        }

        /// <summary>
        /// 分享一张图片
        /// </summary>
        /// <param name="shareBitmap">网页链接</param>
        /// <param name="isWXSceneTimeline">true:分享到朋友圈;false:分享给好友</param>
        /// <returns>无</returns>
        public void ShareImage(Bitmap shareBitmap, bool isWXSceneTimeline)
        {
            WXImageObject imgObj = new WXImageObject(shareBitmap);
            WXMediaMessage msg = new WXMediaMessage();
            msg.MyMediaObject = imgObj;

            Bitmap thumbBmp = Bitmap.CreateScaledBitmap(shareBitmap, THUMB_SIZE, THUMB_SIZE, true);
            using (MemoryStream stream = new MemoryStream())
            {
                shareBitmap.Compress(Bitmap.CompressFormat.Png, 100, stream);
                msg.ThumbData = stream.ToArray();  //设置缩略图  
            }
            SendMessageToWX.Req req = new SendMessageToWX.Req()
            {
                Transaction = buildTransaction("img"),
                Message = msg,
                Scene = isWXSceneTimeline ? WECHAT_SHARE_TYPE_FRENDS
                         : WECHAT_SHARE_TYPE_TALK,
            };
            mWXApi.SendReq(req);
        }

        /// <summary>
        /// 分享一段音乐
        /// </summary>
        /// <param name="musicUrl">音乐链接</param>
        /// <param name="isWXSceneTimeline">true:分享到朋友圈;false:分享给好友</param>
        /// <param name="showImgResId">链接显示的图标</param>
        /// <param name="title">别人看到的标题</param>
        /// <param name="description">别人看到的描述</param>
        /// <returns>无</returns>
        public void ShareMusic(string musicUrl, bool isWXSceneTimeline, 
            int showImgResId,string title, string description)
        {
            WXMusicObject musciObj = new WXMusicObject();
            musciObj.MusicUrl = musicUrl;
            WXMediaMessage msg = new WXMediaMessage();
            msg.MyMediaObject = musciObj;
            msg.Title = title;
            msg.Description = description;

            Bitmap thumbBmp = BitmapFactory.DecodeResource(mContext.Resources, showImgResId);
            using (MemoryStream stream = new MemoryStream())
            {
                thumbBmp.Compress(Bitmap.CompressFormat.Png, 100, stream);
                msg.ThumbData = stream.ToArray();  //设置缩略图  
            }

            SendMessageToWX.Req req = new SendMessageToWX.Req()
            {
                Transaction = buildTransaction("music"),
                Message = msg,
                Scene = isWXSceneTimeline ? WECHAT_SHARE_TYPE_FRENDS
                         : WECHAT_SHARE_TYPE_TALK,
            };
            mWXApi.SendReq(req);
        }

        /// <summary>
        /// 分享一段视频
        /// </summary>
        /// <param name="videoUrl">音乐链接</param>
        /// <param name="isWXSceneTimeline">true:分享到朋友圈;false:分享给好友</param>
        /// <param name="showImgResId">链接显示的图标</param>
        /// <param name="title">别人看到的标题</param>
        /// <param name="description">别人看到的描述</param>
        /// <returns>无</returns>
        public void ShareVideo(string videoUrl, bool isWXSceneTimeline,
            int showImgResId,string title, string description)
        {
            WXVideoObject musciObj = new WXVideoObject();
            musciObj.VideoUrl = videoUrl;
            WXMediaMessage msg = new WXMediaMessage();
            msg.MyMediaObject = musciObj;
            msg.Title = title;
            msg.Description = description;

            Bitmap thumbBmp = BitmapFactory.DecodeResource(mContext.Resources, showImgResId);
            using (MemoryStream stream = new MemoryStream())
            {
                thumbBmp.Compress(Bitmap.CompressFormat.Png, 100, stream);
                msg.ThumbData = stream.ToArray();  //设置缩略图  
            }

            SendMessageToWX.Req req = new SendMessageToWX.Req()
            {
                Transaction = buildTransaction("video"),
                Message = msg,
                Scene = isWXSceneTimeline ? WECHAT_SHARE_TYPE_FRENDS
                         : WECHAT_SHARE_TYPE_TALK,
            };
            mWXApi.SendReq(req);
        }

        private string buildTransaction(string type)
        {
            return (type == null) ? Java.Lang.String.ValueOf(Java.Lang.JavaSystem.CurrentTimeMillis()) : type + Java.Lang.JavaSystem.CurrentTimeMillis();
        }

    }
}