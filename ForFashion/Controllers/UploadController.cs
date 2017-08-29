using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

public class UploadController : ApiController
{
    public static Image photo;
    public static byte[] photoB;
    public UploadController()
    {
        
    }

    public async Task<HttpResponseMessage> PostFormData()
    {
        // Check if the request contains multipart/form-data.
        if (!Request.Content.IsMimeMultipartContent())
        {
            throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
        }

        string root = HttpContext.Current.Server.MapPath("~/App_Data");
        //var  provider = new MultipartFormDataStreamProvider(root);
        
        try
        {
            var provider = new MultipartMemoryStreamProvider();
            await Request.Content.ReadAsMultipartAsync(provider);
            var f = provider.Contents[0];
            var buffer = await f.ReadAsByteArrayAsync();
            File.WriteAllBytes(root + "/A.GIF", buffer);
            photoB = buffer;
            Stream stream  = new MemoryStream(buffer);
            photo = System.Drawing.Image.FromStream(stream);


            await Request.Content.ReadAsMultipartAsync(provider);
           
            // This illustrates how to get the file names.
            //foreach (MultipartFileData file in provider.FileData)
            //{
            //    Trace.WriteLine(file.Headers.ContentDisposition.FileName);
            //    Trace.WriteLine("Server file path: " + file.LocalFileName);
            //}
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        catch (System.Exception e)
        {
            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
        }
    }

}