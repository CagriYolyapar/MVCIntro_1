using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro_1.Controllers
{
    public class HomeController : Controller
    {
        //MVC'de Action'lar cok önemlidir...Cünkü BackEnd işlemlerinizi, HTTP'ye göre yapmak istediginiz tüm işlemlerinizi Controller icerisindeki bu Action'lar yapar...

        //Eger MVC'de bir Action'a HTTP request tipi vermezseniz, Action otomatik olarak HTTPGet yönteminde calısır...

        //MVC'de url'e yazdınız controller yoksa veya controller varsa ama icindeki action yoksa aynı hatayı alırsınız(Resource can not be found)

        //MVC'de projenizin sayfayı size getirebilmesi icin sadece Controller ve Action yetmez...Action'in döndürecegi bir View olması da gerekir..Yani bir sayfa
        public HomeController()
        {
            
        }



        public ActionResult Index()
        {
            //Eger bir View() metodu bir argüman almadan cagrılmıssa icinde bulundugu Action ile aynı isme sahip olan bir View'i döndürmeye calısır...
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}



