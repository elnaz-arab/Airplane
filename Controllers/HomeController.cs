using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MD.PersianDateTime.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersianDate;
using Airplane.Models;

namespace Airplane.Controllers
{
    public class HomeController : Controller
    {
        public static int id;
        private readonly connect _connect;

        public HomeController(connect connect)
        {
            _connect = connect;
        }
        public IActionResult Index()
        {
            List<Vm_Flight_name> VMFList = new List<Vm_Flight_name>();
            foreach (var item in _connect.Flight_Names)
            {
                PersianDateShamsi PD = new PersianDateShamsi();
                Vm_Flight_name VMF = new Vm_Flight_name();
                VMF.Company = item.Company;
                VMF.Source = item.Source;
                VMF.Destination = item.Destination;
                VMF.Flight_date = item.Flight_date.ToShamsiDate();
                VMF.Flight_time = item.Flight_time.ToString("hh':'mm");
                VMF.Duty = item.Duty;
                VMFList.Add(VMF);
            }

            return View(VMFList);
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult check(string cod, string pas, string bil)
        {
            var a = _connect.Users.Where(b => b.Codmeli == cod && b.Password == pas).SingleOrDefault();
            if (a != null)
            {
                id = a.Id_User;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Login");
        }
        public IActionResult SearchDate(string Date)
        {
            List<Vm_Flight_name> VmfList = new List<Vm_Flight_name>();
            DateTime d = _connect.ConvertShamsiToMiladi(Date);
            var a = _connect.Flight_Names.Where(b => b.Flight_date == d).ToList();
            foreach (var item in a)
            {
                PersianDateShamsi PD = new PersianDateShamsi();
                Vm_Flight_name Vmf = new Vm_Flight_name();
                Vmf.Company = item.Company;
                Vmf.Source = item.Source;
                Vmf.Destination = item.Destination;
                Vmf.Flight_date = item.Flight_date;
                Vmf.Flight_time = item.Flight_time;
                Vmf.Duty = item.Duty;
                VmfList.Add(Vmf);
            }
            return View(VmfList);
        }

    }

}
