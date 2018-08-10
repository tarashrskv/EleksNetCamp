﻿using Microsoft.AspNetCore.Http;

namespace BusinessLogicLayer.Utilities
{
    public interface IImageUploader
    {
        // this method uploads image on hosting and returns its url
        string UploadImageFromForm(IFormFile imageFile);
    }
}