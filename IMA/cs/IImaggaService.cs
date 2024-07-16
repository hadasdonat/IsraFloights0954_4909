using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAgent.Imagga
{
    public interface IImaggaService
    {
      
        
        /// <summary>
        /// Checks if the given URL points to an image of an airplane.
        /// </summary>
        /// <param name="url2">The URL of the image to check.</param>
        /// <returns>True if the image is of an airplane, otherwise false.</returns>
        public bool IfIsAirplane(string url2);
       
       
        /// <summary>
        /// Upload a image to the server for further use with any service of Imagga. 
        /// </summary>
        /// <param name="ImageUrl">The location of the image on your device</param>
        /// <returns>upload id identifying the image on the server</returns>
        public string UploadImageToServer(string ImageUrl);

        /// <summary>
        /// use the upload id to delete any image you uploaded to the server.
        /// </summary>
        /// <param name="UploadID"></param>
        public void DeleteImageFromServer(string UploadID);
    }
}
