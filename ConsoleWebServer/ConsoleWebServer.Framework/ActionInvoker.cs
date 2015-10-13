namespace ConsoleWebServer.Framework
{
    using System;
    using System.Linq;

    public class ActionInvoker
    {
        public IActionResult InvokeAction(Controller controller, ActionDescriptor actionDescriptor)
        {
            var methodWithIntParameter =
                controller.GetType()
                    .GetMethods()
                    .FirstOrDefault(
                        x =>
                        x.Name == actionDescriptor.ActionName && x.GetParameters().Length == 1
                        && x.GetParameters()[0].ParameterType == typeof(string)
                        && x.ReturnType == typeof(IActionResult));
            if (methodWithIntParameter == null)
            {
                throw new Exception(
                    string.Format(
                        "Expected method with signature IActionResult {0}(string) in class {1}",
                        actionDescriptor.ActionName,
                        actionDescriptor.ControllerName));
            }

            var actionResult =
                (IActionResult)methodWithIntParameter.Invoke(controller, new object[] { actionDescriptor.Parameter });
            return actionResult;
        }
    }
}
