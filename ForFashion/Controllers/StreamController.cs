using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace ForFashion.Controllers
{

    public class StreamController : ApiController
    {
        public HttpResponseMessage Get()
        {

            //var img = UploadController.photo;
            //using (MemoryStream ms = new MemoryStream(UploadController.photoB))
            //{
            //    img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            //    HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            //    //result.Content = new ByteArrayContent(ms.ToArray());
            //    result.Content = new ByteArrayContent(UploadController.photoB);
            //    result.Content.Headers.ContentType = new MediaTypeHeaderValue("image/gif");
            //    return result;

            //}
            if (UploadController.photoB != null)
            {
                HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
                //result.Content = new ByteArrayContent(ms.ToArray());
                result.Content = new ByteArrayContent(UploadController.photoB);
                result.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                return result;

                //string root = HttpContext.Current.Server.MapPath("~/App_Data");
                //File.WriteAllBytes(root + "/A.Jpeg", UploadController.photoB);
                //return "data:image/jpeg;base64," + System.Convert.ToBase64String(UploadController.photoB);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
            //return "";
        }
    }
}
