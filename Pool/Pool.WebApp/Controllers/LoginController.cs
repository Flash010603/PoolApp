using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pool.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;


namespace Pool.WebApp.Controllers
{
    public class LoginController : Controller
    {
        UrlPeticion cadena = new UrlPeticion();
       

        /*public IActionResult Index()
        {

            return View();
        }*/

        public async Task<ActionResult> Index(LoginModel lm)
        {
            int pet = (HttpContext.Session.GetString("contador") == null ) ? 0 :Convert.ToInt32(HttpContext.Session.GetString("contador"));

            pet = pet + 1;
            HttpContext.Session.SetString("contador", pet.ToString());

            User data_res = null;
            string url = cadena.url_user + "/" + lm.Username + "&" + lm.Password;
            bool error = false;
            try
            {
                
                    var client = new HttpClient();
                    LoginModel loginmodel = new LoginModel();
                    loginmodel.Password = lm.Username;
                    loginmodel.Username = lm.Password;

                    var data = JsonConvert.SerializeObject(loginmodel);
                    HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        data_res = JsonConvert.DeserializeObject<User>(result);
                                                

                        if(data_res == null)
                        {

                            ViewData["error"] = "error login";
                            
                            error = true;
                        }
                        else
                        {

                            HttpContext.Session.SetString("user", data_res.Id.ToString());

                            ViewData["user"] = data_res;
                            ViewBag.Data = data_res;
                            TempData["user"] = data_res.ToString();
                        }

                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        ViewData["error"] = "error login";

                        error = true;
                    }
                    else
                    {
                        if  (pet > 1)
                            {

                                ViewData["error"] = "campo vacio";
                            HttpContext.Session.Remove("contador");
                        }
                        error = true;

                    }
                }

                
                
                

                if (error)
                {
                    return View();
                }
                else
                {
                    if (data_res == null)
                    {
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                
            }
            catch (Exception exp)
            {
                return View();
            }

           
        }
        

        













    }
}
