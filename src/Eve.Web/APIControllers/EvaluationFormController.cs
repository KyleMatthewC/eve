using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Eve.DataClass;
using Eve.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eve.Web.APIControllers
{
    [Route("api/[controller]")]
    public class EvaluationFormController : Controller
    {
        [HttpGet]
        [Route("GetRoles")]
        public async Task<IActionResult> GetRoles()
        {
            IList<JobRole> list = new FillUpEvaluationModel().GetJobRoles();
            return Ok(list);
        }

        [HttpGet]
        [Route("GetPeriods")]
        public async Task<IActionResult> GetPeriods()
        {
            IList<ReviewPeriod> list = new FillUpEvaluationModel().GetReviewPeriods();
            return Ok(list);
        }

        [HttpGet]
        [Route("GetEvaluationFormItems/{jobRoleID}")]
        public async Task<IActionResult> GetEvaluationFormItems(int jobRoleID)
        {
            IList<CriteriaAttribute> list = new FillUpEvaluationModel().GetCriteriaItems(jobRoleID);
            return Ok(list);
        }
    }
}
