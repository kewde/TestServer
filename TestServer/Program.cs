using System;
using Grpc.Core;
using System.Threading.Tasks;
using API;
using System.IO;
using System.Collections.Generic;

namespace TestServer
{
    class Program
    {
        private static Server server = new Server
        {
            Services = { Test.BindService(new TestImpl()) },
            Ports = { new ServerPort("localhost", 50051, ServerCredentials.Insecure) }
        };

        static void Main(string[] args)
        {
            server.Start();

            Console.WriteLine("Service listening...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }

    internal class TestImpl : Test.TestBase
    {
        public override Task<Response> Get(Query query, ServerCallContext context) => Task.FromResult(new Response { Item = "Hello " + query.Item });
    }
}
