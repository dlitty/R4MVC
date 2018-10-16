// <auto-generated />
// This file was generated by R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and run the generator tool again.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using R4Mvc;
using AspNetSimple;

namespace AspNetSimple.Controllers
{
    public partial class TestsController
    {
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public TestsController()
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected TestsController(Dummy d)
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(IActionResult result)
        {
            var callInfo = result.GetR4MvcResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<IActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(IActionResult result)
        {
            var callInfo = result.GetR4MvcResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<IActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult Parameters()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Parameters);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ParametersWithDefault()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ParametersWithDefault);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ApiCallWithParams()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ApiCallWithParams);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult TaskApiCallWithParams()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.TaskApiCallWithParams);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ApiCallTypedWithParams()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ApiCallTypedWithParams);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult TaskApiCallTypedWithParams()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.TaskApiCallTypedWithParams);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult LocalViewModel()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.LocalViewModel);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ExternalViewModel()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExternalViewModel);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public TestsController Actions => MVC.Tests;
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Area = "";
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Name = "Tests";
        [GeneratedCode("R4Mvc", "1.0")]
        public const string NameConst = "Tests";
        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionNamesClass s_ActionNames = new ActionNamesClass();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames => s_ActionNames;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string ExtendedPage = "ExtendedPage";
            public readonly string Index = "Index";
            public readonly string ActionResult = "ActionResult";
            public readonly string JsonResult = "JsonResult";
            public readonly string FileResult = "FileResult";
            public readonly string RedirectResult = "RedirectResult";
            public readonly string RedirectToActionResult = "RedirectToActionResult";
            public readonly string RedirectToRouteResult = "RedirectToRouteResult";
            public readonly string TaskIndex = "TaskIndex";
            public readonly string TaskActionResult = "TaskActionResult";
            public readonly string TaskJsonResult = "TaskJsonResult";
            public readonly string TaskFileResult = "TaskFileResult";
            public readonly string TaskRedirectResult = "TaskRedirectResult";
            public readonly string TaskRedirectToActionResult = "TaskRedirectToActionResult";
            public readonly string TaskRedirectToRouteResult = "TaskRedirectToRouteResult";
            public readonly string RequiresHttps = "RequiresHttps";
            public readonly string Parameters = "Parameters";
            public readonly string ParametersWithDefault = "ParametersWithDefault";
            public readonly string ApiCall = "ApiCall";
            public readonly string ApiCallWithParams = "ApiCallWithParams";
            public readonly string TaskApiCall = "TaskApiCall";
            public readonly string TaskApiCallWithParams = "TaskApiCallWithParams";
            public readonly string ApiCallTyped = "ApiCallTyped";
            public readonly string ApiCallTypedWithParams = "ApiCallTypedWithParams";
            public readonly string TaskApiCallTyped = "TaskApiCallTyped";
            public readonly string TaskApiCallTypedWithParams = "TaskApiCallTypedWithParams";
            public readonly string LocalViewModel = "LocalViewModel";
            public readonly string ExternalViewModel = "ExternalViewModel";
            public readonly string OverrideMe = "OverrideMe";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string ExtendedPage = "ExtendedPage";
            public const string Index = "Index";
            public const string ActionResult = "ActionResult";
            public const string JsonResult = "JsonResult";
            public const string FileResult = "FileResult";
            public const string RedirectResult = "RedirectResult";
            public const string RedirectToActionResult = "RedirectToActionResult";
            public const string RedirectToRouteResult = "RedirectToRouteResult";
            public const string TaskIndex = "TaskIndex";
            public const string TaskActionResult = "TaskActionResult";
            public const string TaskJsonResult = "TaskJsonResult";
            public const string TaskFileResult = "TaskFileResult";
            public const string TaskRedirectResult = "TaskRedirectResult";
            public const string TaskRedirectToActionResult = "TaskRedirectToActionResult";
            public const string TaskRedirectToRouteResult = "TaskRedirectToRouteResult";
            public const string RequiresHttps = "RequiresHttps";
            public const string Parameters = "Parameters";
            public const string ParametersWithDefault = "ParametersWithDefault";
            public const string ApiCall = "ApiCall";
            public const string ApiCallWithParams = "ApiCallWithParams";
            public const string TaskApiCall = "TaskApiCall";
            public const string TaskApiCallWithParams = "TaskApiCallWithParams";
            public const string ApiCallTyped = "ApiCallTyped";
            public const string ApiCallTypedWithParams = "ApiCallTypedWithParams";
            public const string TaskApiCallTyped = "TaskApiCallTyped";
            public const string TaskApiCallTypedWithParams = "TaskApiCallTypedWithParams";
            public const string LocalViewModel = "LocalViewModel";
            public const string ExternalViewModel = "ExternalViewModel";
            public const string OverrideMe = "OverrideMe";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
            }
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ViewsClass s_Views = new ViewsClass();
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class R4MVC_TestsController : AspNetSimple.Controllers.TestsController
    {
        public R4MVC_TestsController(): base(Dummy.Instance)
        {
        }

        [NonAction]
        partial void ExtendedPageOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult ExtendedPage()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExtendedPage);
            ExtendedPageOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void IndexOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult Index()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ActionResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult ActionResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ActionResult);
            ActionResultOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void JsonResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_JsonResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.JsonResult JsonResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_JsonResult(Area, Name, ActionNames.JsonResult);
            JsonResultOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void FileResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_FileResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.FileResult FileResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_FileResult(Area, Name, ActionNames.FileResult);
            FileResultOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void RedirectResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_RedirectResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.RedirectResult RedirectResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_RedirectResult(Area, Name, ActionNames.RedirectResult);
            RedirectResultOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void RedirectToActionResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.RedirectToActionResult RedirectToActionResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToActionResult(Area, Name, ActionNames.RedirectToActionResult);
            RedirectToActionResultOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void RedirectToRouteResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToRouteResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.RedirectToRouteResult RedirectToRouteResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToRouteResult(Area, Name, ActionNames.RedirectToRouteResult);
            RedirectToRouteResultOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void TaskIndexOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> TaskIndex()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.TaskIndex);
            TaskIndexOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.IActionResult>(callInfo);
        }

        [NonAction]
        partial void TaskActionResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult> TaskActionResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.TaskActionResult);
            TaskActionResultOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.ActionResult>(callInfo);
        }

        [NonAction]
        partial void TaskJsonResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_JsonResult callInfo);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.JsonResult> TaskJsonResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_JsonResult(Area, Name, ActionNames.TaskJsonResult);
            TaskJsonResultOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.JsonResult>(callInfo);
        }

        [NonAction]
        partial void TaskFileResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_FileResult callInfo);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.FileResult> TaskFileResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_FileResult(Area, Name, ActionNames.TaskFileResult);
            TaskFileResultOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.FileResult>(callInfo);
        }

        [NonAction]
        partial void TaskRedirectResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_RedirectResult callInfo);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.RedirectResult> TaskRedirectResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_RedirectResult(Area, Name, ActionNames.TaskRedirectResult);
            TaskRedirectResultOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.RedirectResult>(callInfo);
        }

        [NonAction]
        partial void TaskRedirectToActionResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToActionResult callInfo);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.RedirectToActionResult> TaskRedirectToActionResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToActionResult(Area, Name, ActionNames.TaskRedirectToActionResult);
            TaskRedirectToActionResultOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.RedirectToActionResult>(callInfo);
        }

        [NonAction]
        partial void TaskRedirectToRouteResultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToRouteResult callInfo);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.RedirectToRouteResult> TaskRedirectToRouteResult()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToRouteResult(Area, Name, ActionNames.TaskRedirectToRouteResult);
            TaskRedirectToRouteResultOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.RedirectToRouteResult>(callInfo);
        }

        [NonAction]
        partial void RequiresHttpsOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult RequiresHttps()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.RequiresHttps, "https");
            RequiresHttpsOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ParametersOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, int id, string name);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult Parameters(int id, string name)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Parameters);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "name", name);
            ParametersOverride(callInfo, id, name);
            return callInfo;
        }

        [NonAction]
        partial void ParametersWithDefaultOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, int id, string name);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult ParametersWithDefault(int id, string name)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ParametersWithDefault);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "name", name);
            ParametersWithDefaultOverride(callInfo, id, name);
            return callInfo;
        }

        [NonAction]
        partial void ApiCallTypedOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product> ApiCallTyped()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ApiCallTyped);
            ApiCallTypedOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ApiCallTypedWithParamsOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, int id);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product> ApiCallTypedWithParams(int id)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ApiCallTypedWithParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            ApiCallTypedWithParamsOverride(callInfo, id);
            return callInfo;
        }

        [NonAction]
        partial void TaskApiCallTypedOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product>> TaskApiCallTyped()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.TaskApiCallTyped);
            TaskApiCallTypedOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product>>(callInfo);
        }

        [NonAction]
        partial void TaskApiCallTypedWithParamsOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, int id);
        [NonAction]
        public override System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product>> TaskApiCallTypedWithParams(int id)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.TaskApiCallTypedWithParams);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            TaskApiCallTypedWithParamsOverride(callInfo, id);
            return System.Threading.Tasks.Task.FromResult<Microsoft.AspNetCore.Mvc.ActionResult<AspNetSimple.Models.Product>>(callInfo);
        }

        [NonAction]
        partial void LocalViewModelOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, AspNetSimple.Models.ErrorViewModel model);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult LocalViewModel(AspNetSimple.Models.ErrorViewModel model)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.LocalViewModel);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            LocalViewModelOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void ExternalViewModelOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo, SampleModels.TestViewModel model);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult ExternalViewModel(SampleModels.TestViewModel model)
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExternalViewModel);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ExternalViewModelOverride(callInfo, model);
            return callInfo;
        }

        [NonAction]
        partial void OverrideMeOverride(R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult callInfo);
        [NonAction]
        public override Microsoft.AspNetCore.Mvc.IActionResult OverrideMe()
        {
            var callInfo = new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.OverrideMe);
            OverrideMeOverride(callInfo);
            return callInfo;
        }
    }
}
#pragma warning restore 1591, 3008, 3009, 0108
