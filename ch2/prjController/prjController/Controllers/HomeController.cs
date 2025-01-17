﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string ShowAry()
        {
            int[] score = new int[] { 78, 99, 20, 100, 66 };
            string show = "";

            int sum = 0;

            foreach (var i in score)
            {
                show += i + ",";
                sum += i;
            }

            show += "<br />";
            show += "Total:" + sum;

            return show;
        }

        public string ShowImages()
        {
            string show = "";

            for (int i = 1; i <= 8; i += 1)
            {
                show += string.Format("<img src='../images/{0}.jpg' width='150'>", i);
            }

            return show;
        }

        public string ShowImageIndex(int index)
        {
            string show = "";
            string[] name = new string[] { "櫻桃鴨", "鴨油高麗菜", "鴨油麻婆豆腐", "櫻桃鴨握壽司", "片皮鴨卷三星蔥", "三杯鴨", "櫻桃鴉片肉", "慢火白菜燉鴨湯" };

            show = string.Format("<p align='center'><img src='../images/{0}.jpg'><br />{1}</p>", index, name[index - 1]);
            return show;
        }
    }
}