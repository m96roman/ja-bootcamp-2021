using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Shyptur_Task8HW
{
    class Task1
    {
        public void task1()
        {
            var api = new Api();
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/post");
            api.CallEndpoint("/controller/get");
            api.CallEndpoint("/controller/put");
            api.CallEndpoint("/controller/delete");
        }
    }
}
[AttributeUsage(AttributeTargets.Method)]
public class RouteAttribute : Attribute
{
    public string Name { get; set; }
}
public class Controller
{
    public string Name { get; set; }

    [Route(Name = "/controller/get")]
    public int Get()
    {
        return 8;
    }

    [Route(Name = "/controller/post")]
    public void Post()
    {
        Console.WriteLine($"Post method executed in {Name} controller");
    }

    [Route(Name = "/controller/put")]
    public void Put()
    {
        Console.WriteLine($"Put method executed in {Name} controller");
    }

    [Route(Name = "/controller/delete")]
    public void Delete()
    {
        Console.WriteLine($"Delete method execute in {Name} controller");
    }
}

public class Api
{
    public Controller controller { get; set; }

    public Api()
    {
        controller = new Controller();
    }

    public void CallEndpoint(string route)
    {
        controller.Name = route;
        var type = controller.GetType();
        var colectionsAtribue = type
            .GetMethods()
            .Select(s => new
            {
                method = s,
                atribute = s.GetCustomAttribute<RouteAttribute>()
            })
            .Where(p => p.atribute != null)
            .ToList();

        var currentMethod = colectionsAtribue.FirstOrDefault(atr => atr.atribute.Name == route);

        Console.WriteLine(currentMethod.method.Invoke(controller, null));
    }
}
