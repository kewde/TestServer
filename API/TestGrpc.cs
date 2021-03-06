// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Test.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace API {
  public static partial class Test
  {
    static readonly string __ServiceName = "API.Test";

    static readonly grpc::Marshaller<global::API.Query> __Marshaller_Query = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::API.Query.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::API.Response> __Marshaller_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::API.Response.Parser.ParseFrom);

    static readonly grpc::Method<global::API.Query, global::API.Response> __Method_Get = new grpc::Method<global::API.Query, global::API.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_Query,
        __Marshaller_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::API.TestReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Test</summary>
    public abstract partial class TestBase
    {
      public virtual global::System.Threading.Tasks.Task<global::API.Response> Get(global::API.Query request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Test</summary>
    public partial class TestClient : grpc::ClientBase<TestClient>
    {
      /// <summary>Creates a new client for Test</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TestClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Test that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TestClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TestClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TestClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::API.Response Get(global::API.Query request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::API.Response Get(global::API.Query request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::API.Response> GetAsync(global::API.Query request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::API.Response> GetAsync(global::API.Query request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TestClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TestClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TestBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Get, serviceImpl.Get).Build();
    }

  }
}
#endregion
