using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.FireSafety.Mobile.ControlRound.Models
{
    public class DeletePhotoMessage
    {
        public MediaFile PhotoToDelete { get; set; }

        public DeletePhotoMessage(MediaFile photoToDelete)
        {
            PhotoToDelete = photoToDelete;
        }

        

    }
}
