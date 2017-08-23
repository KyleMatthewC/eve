using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Eve.Models;
using Eve.Web.ViewModels;
using System.Net.Http;
using System.Net.Http.Headers;
using Eve.DataClass;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eve.Web.Controllers
{
    public class FillUpEvaluationFormController : Controller
    {
        // GET: FillUpEvaluation
        public ActionResult NewEvaluation()
        {
            var viewModel = new FillUpEvaluationFormViewModel();
            //viewModel.Roles = new FillUpEvaluationModel().GetJobRoles();
            //viewModel.Periods = new FillUpEvaluationModel().GetReviewPeriods();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64458/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var getTask = client.GetAsync("EvaluationForm/GetRoles");
                getTask.Wait();

                var result = getTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<JobRole>>();
                    readTask.Wait();

                    viewModel.Roles = readTask.Result;
                }

                else
                {
                    viewModel.Roles = null;
                }

                getTask = client.GetAsync("EvaluationForm/GetPeriods");
                getTask.Wait();

                result = getTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<ReviewPeriod>>();
                    readTask.Wait();

                    viewModel.Periods = readTask.Result;
                }

                else
                {
                    viewModel.Periods = null;
                }
            };

            return View("FillUpEvaluationForm", viewModel);
        }

        public PartialViewResult LoadEvaluationForm(int jobRoleID)
        {
            var viewModel = new PartialEvaluationFormViewModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:64458/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var getTask = client.GetAsync("EvaluationForm/GetEvaluationFormItems/" + jobRoleID);
                getTask.Wait();

                var result = getTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<CriteriaAttribute>>();
                    readTask.Wait();

                    viewModel.CriteriaAttribute = readTask.Result;
                }

                else
                {
                    viewModel.CriteriaAttribute = null;
                }
            };

            return PartialView("_partialFormView", viewModel);
        }
    }
}