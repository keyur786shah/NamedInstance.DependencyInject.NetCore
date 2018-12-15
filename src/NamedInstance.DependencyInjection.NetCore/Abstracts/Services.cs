using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NamedInstance.DependencyInjection.NetCore.Abstracts
{
    public interface IService {
        string ServiceName { get; }
    }
    public class ServiceA : IService
    {
        public string ServiceName => "ServiceA";
    }
    public class ServiceB : IService {
        public string ServiceName => "ServiceB";
    }
    public class ServiceC : IService {
        public string ServiceName => "ServiceC";
    }
}
