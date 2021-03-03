using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcJqueryMobile.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SinglePage()
        {
            ViewBag.Header = "LOL 英雄人物 -- 齊天大聖 悟空";
            ViewBag.Footer = "鬪戰勝佛 孫悟空";
            ViewBag.Image = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/MonkeyKing_0.jpg";
            ViewBag.Introduction = "孫悟是一隻由石頭中蹦出來的猴子、天產靈石孕育而生，自封花果山美猴王、齊天大聖。他吸取日月之精華，並學習仙術，法力及武藝高強，伴隨唐三藏前往西天取經，沿路斬妖伏魔。取經後為如來佛祖授為鬪戰勝佛。";

            return View();
        }
    }
}