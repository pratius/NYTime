using System;

using NYTime.Models;

namespace NYTime.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public ItemDetailViewModel(NewInfo item = null)
        {
            Description = item.Description;
            Image = item.thumbnail_standard;
        }

        string description;
        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }

        string image;
        public string Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

    }
}
