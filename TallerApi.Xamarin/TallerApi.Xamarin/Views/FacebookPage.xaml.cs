using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerApi.Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FacebookPage : ContentPage
	{
		public FacebookPage ()
		{
			InitializeComponent ();
            CargarPublicaciones();
		}

        private async void CargarPublicaciones()
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("http://172.16.58.174");

            var request = await cliente.GetAsync("/TallerApis/api/Publicacion");
            if(request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync();
                var listado = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);
            }
        }
    }
}