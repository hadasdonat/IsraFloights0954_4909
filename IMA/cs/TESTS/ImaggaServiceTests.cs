using NUnit.Framework;
using System;

namespace ServiceAgent.Imagga.Tests
{
    [TestFixture]
    public class ImaggaSeֶrviceTests
    {
        private ImaggaService imaggaService;

        [SetUp]
        public void Setup()
        {
            // תחילה, יצירת מופע של ImaggaService
            imaggaService = new ImaggaService();
        }

        public static string TestUploadImage(IImaggaService imaggaService)
        {
            string uploadId = imaggaService.UploadImageToServer(@"C:\Users\HP\Documents\TESTIMAGEFORAIRPLANE\AIRPLANE1.jpg");
            Console.WriteLine(uploadId);

            return uploadId;
        }

        public static void TestDeleteImage(IImaggaService imaggaService, string uploadId)
        {
            imaggaService.DeleteImageFromServer(uploadId);
            Console.WriteLine("Successfully Deleted");
        }

        [Test]
        public void IfIsAirplane_Should_Return_True_For_Airplane_Image()
        {
            // Arrange
            string airplaneImageUrl = @"C:\Users\HP\Documents\TESTIMAGEFORAIRPLANE\AIRPLANE1.jpg";

            // Act
            bool result = imaggaService.IfIsAirplane(airplaneImageUrl);

            // Assert
            Assert.IsTrue(result, "Expected the image to be identified as an airplane");
        }

        [Test]
        public void IfIsAirplane_Should_Return_False_For_Non_Airplane_Image()
        {
            // Arrange
            string nonAirplaneImageUrl = @"C:\Users\HP\Documents\TESTIMAGEFORAIRPLANE\NON_AIRPLANE.jpg";

            // Act
            bool result = imaggaService.IfIsAirplane(nonAirplaneImageUrl);

            // Assert
            Assert.IsFalse(result, "Expected the image to not be identified as an airplane");
        }
    }
}
