﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using AtomHealth.Models;

namespace AtomHealth.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[BindProperty]
        //public Email sendmail { get; set; }
        //[HttpPost]
        //public async Task OnPost()
        //{
        //    string To = sendmail.To;
        //    string From = sendmail.From;
        //    string Message = sendmail.Message;
        //    MailMessage mailmessage = new MailMessage();
        //    mailmessage.To.Add(To);
        //    //mailmessage.From = From;
        //    mailmessage.Body = Message;
        //    //mailmessage.Sender = From;
        //    mailmessage.IsBodyHtml = false;
        //    mailmessage.From = new MailAddress("ghimirebibhuti@gmail.com");



        //}
        [HttpPost]
        public IActionResult Index(Email em)
        {
            string to = em.To;
            string subject = em.Subject;
            string body = em.Body;
            MailMessage mm = new MailMessage();
            mm.To.Add(to);
            mm.Subject = subject;
            mm.Body = body;
            mm.From = new MailAddress("ghimirebibhuti@gmail.com");
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("ghimirebibhuti@gmail.com", "Ghimire1$");
            smtp.Send(mm);
            ViewBag.mailsentmessage = "Your message has been received. Thanks";

            return RedirectToAction("Index");

        }
    }
}