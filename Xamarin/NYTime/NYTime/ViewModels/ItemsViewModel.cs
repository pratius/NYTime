using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using NYTime.Models;
using NYTime.Views;
using NYTime.Services;
using System.Net.Http;
using Newtonsoft.Json;
using NYTime.Common;

namespace NYTime.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
       
        WebServiceMapper WebServiceMapper;

        public ItemsViewModel()
        {
            WebServiceMapper = new WebServiceMapper();
            ExecuteLoadItems();
        }

        private ObservableCollection<NewInfo> contentList;
        public ObservableCollection<NewInfo> ContentList
        { 
            get 
            {
                return contentList ;
            }
            set 
            {
                contentList=value;OnPropertyChanged(); 
            } 
        }
        async void ExecuteLoadItems()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                var resposeResult =await WebServiceMapper.GetResponseFromHttpRequest(Constants.API_URL, HttpMethod.Get);
                if (!string.IsNullOrWhiteSpace(resposeResult))
                {
                    var response = JsonConvert.DeserializeObject<Content>(resposeResult);
                    ContentList=new ObservableCollection<NewInfo>(response.results);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}