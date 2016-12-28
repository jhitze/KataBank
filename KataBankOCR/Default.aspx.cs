using KataBankOCR.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KataBankOCR
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (ocrFileUpload.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(ocrFileUpload.FileName);
                    var ocrFile = ocrFileUpload.FileContent;
                    
                    // Display results back to user?
                    uploadStatus.Text = "Upload status: File uploaded!";
                }
                catch (Exception ex)
                {
                    uploadStatus.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }
        }
    }
}