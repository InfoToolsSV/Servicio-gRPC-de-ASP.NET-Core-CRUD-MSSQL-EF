// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/library.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace LibraryGrpcService.Protos {
  public static partial class LibraryService
  {
    static readonly string __ServiceName = "library.LibraryService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LibraryGrpcService.Protos.CreateBookRequest> __Marshaller_library_CreateBookRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LibraryGrpcService.Protos.CreateBookRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LibraryGrpcService.Protos.CreateBookResponse> __Marshaller_library_CreateBookResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LibraryGrpcService.Protos.CreateBookResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LibraryGrpcService.Protos.GetBookRequest> __Marshaller_library_GetBookRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LibraryGrpcService.Protos.GetBookRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LibraryGrpcService.Protos.GetBookResponse> __Marshaller_library_GetBookResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LibraryGrpcService.Protos.GetBookResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LibraryGrpcService.Protos.UpdateBookRequest> __Marshaller_library_UpdateBookRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LibraryGrpcService.Protos.UpdateBookRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LibraryGrpcService.Protos.UpdateBookResponse> __Marshaller_library_UpdateBookResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LibraryGrpcService.Protos.UpdateBookResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LibraryGrpcService.Protos.DeleteBookRequest> __Marshaller_library_DeleteBookRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LibraryGrpcService.Protos.DeleteBookRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LibraryGrpcService.Protos.DeleteBookResponse> __Marshaller_library_DeleteBookResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LibraryGrpcService.Protos.DeleteBookResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LibraryGrpcService.Protos.ListBooksRequest> __Marshaller_library_ListBooksRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LibraryGrpcService.Protos.ListBooksRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::LibraryGrpcService.Protos.ListBooksResponse> __Marshaller_library_ListBooksResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::LibraryGrpcService.Protos.ListBooksResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LibraryGrpcService.Protos.CreateBookRequest, global::LibraryGrpcService.Protos.CreateBookResponse> __Method_CreateBook = new grpc::Method<global::LibraryGrpcService.Protos.CreateBookRequest, global::LibraryGrpcService.Protos.CreateBookResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateBook",
        __Marshaller_library_CreateBookRequest,
        __Marshaller_library_CreateBookResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LibraryGrpcService.Protos.GetBookRequest, global::LibraryGrpcService.Protos.GetBookResponse> __Method_GetBook = new grpc::Method<global::LibraryGrpcService.Protos.GetBookRequest, global::LibraryGrpcService.Protos.GetBookResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBook",
        __Marshaller_library_GetBookRequest,
        __Marshaller_library_GetBookResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LibraryGrpcService.Protos.UpdateBookRequest, global::LibraryGrpcService.Protos.UpdateBookResponse> __Method_UpdateBook = new grpc::Method<global::LibraryGrpcService.Protos.UpdateBookRequest, global::LibraryGrpcService.Protos.UpdateBookResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateBook",
        __Marshaller_library_UpdateBookRequest,
        __Marshaller_library_UpdateBookResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LibraryGrpcService.Protos.DeleteBookRequest, global::LibraryGrpcService.Protos.DeleteBookResponse> __Method_DeleteBook = new grpc::Method<global::LibraryGrpcService.Protos.DeleteBookRequest, global::LibraryGrpcService.Protos.DeleteBookResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteBook",
        __Marshaller_library_DeleteBookRequest,
        __Marshaller_library_DeleteBookResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::LibraryGrpcService.Protos.ListBooksRequest, global::LibraryGrpcService.Protos.ListBooksResponse> __Method_ListBooks = new grpc::Method<global::LibraryGrpcService.Protos.ListBooksRequest, global::LibraryGrpcService.Protos.ListBooksResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListBooks",
        __Marshaller_library_ListBooksRequest,
        __Marshaller_library_ListBooksResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::LibraryGrpcService.Protos.LibraryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LibraryService</summary>
    [grpc::BindServiceMethod(typeof(LibraryService), "BindService")]
    public abstract partial class LibraryServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LibraryGrpcService.Protos.CreateBookResponse> CreateBook(global::LibraryGrpcService.Protos.CreateBookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LibraryGrpcService.Protos.GetBookResponse> GetBook(global::LibraryGrpcService.Protos.GetBookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LibraryGrpcService.Protos.UpdateBookResponse> UpdateBook(global::LibraryGrpcService.Protos.UpdateBookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LibraryGrpcService.Protos.DeleteBookResponse> DeleteBook(global::LibraryGrpcService.Protos.DeleteBookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::LibraryGrpcService.Protos.ListBooksResponse> ListBooks(global::LibraryGrpcService.Protos.ListBooksRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(LibraryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateBook, serviceImpl.CreateBook)
          .AddMethod(__Method_GetBook, serviceImpl.GetBook)
          .AddMethod(__Method_UpdateBook, serviceImpl.UpdateBook)
          .AddMethod(__Method_DeleteBook, serviceImpl.DeleteBook)
          .AddMethod(__Method_ListBooks, serviceImpl.ListBooks).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, LibraryServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateBook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LibraryGrpcService.Protos.CreateBookRequest, global::LibraryGrpcService.Protos.CreateBookResponse>(serviceImpl.CreateBook));
      serviceBinder.AddMethod(__Method_GetBook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LibraryGrpcService.Protos.GetBookRequest, global::LibraryGrpcService.Protos.GetBookResponse>(serviceImpl.GetBook));
      serviceBinder.AddMethod(__Method_UpdateBook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LibraryGrpcService.Protos.UpdateBookRequest, global::LibraryGrpcService.Protos.UpdateBookResponse>(serviceImpl.UpdateBook));
      serviceBinder.AddMethod(__Method_DeleteBook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LibraryGrpcService.Protos.DeleteBookRequest, global::LibraryGrpcService.Protos.DeleteBookResponse>(serviceImpl.DeleteBook));
      serviceBinder.AddMethod(__Method_ListBooks, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::LibraryGrpcService.Protos.ListBooksRequest, global::LibraryGrpcService.Protos.ListBooksResponse>(serviceImpl.ListBooks));
    }

  }
}
#endregion