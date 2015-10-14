namespace ConsoleWebServer.Framework
{
    using System.Linq;

    using ConsoleWebServer.Framework.ActionResults;

    public class ActionInvoker
    {
        public IActionResult InvokeAction(Controller controller, ActionDescriptor actionDescriptor)
        {
            var methodWithIntParameter =
                controller.GetType()
                    .GetMethods()
                    .FirstOrDefault(
                        x =>
                        x.Name.ToLower() == actionDescriptor.ActionName.ToLower() && x.GetParameters().Length == 1
                        && x.GetParameters()[0].ParameterType == typeof(string)
                        && x.ReturnType == typeof(IActionResult));
            if (methodWithIntParameter == null)
            {
                throw new HttpNotFoundException(
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
