// package: API
// file: Test.proto

import * as Test_pb from "./Test_pb";
import {grpc} from "grpc-web-client";

type TestGet = {
  readonly methodName: string;
  readonly service: typeof Test;
  readonly requestStream: false;
  readonly responseStream: false;
  readonly requestType: typeof Test_pb.Query;
  readonly responseType: typeof Test_pb.Response;
};

export class Test {
  static readonly serviceName: string;
  static readonly Get: TestGet;
}

export type ServiceError = { message: string, code: number; metadata: grpc.Metadata }
export type Status = { details: string, code: number; metadata: grpc.Metadata }
export type ServiceClientOptions = { transport: grpc.TransportConstructor }

interface ResponseStream<T> {
  cancel(): void;
  on(type: 'data', handler: (message: T) => void): ResponseStream<T>;
  on(type: 'end', handler: () => void): ResponseStream<T>;
  on(type: 'status', handler: (status: Status) => void): ResponseStream<T>;
}

export class TestClient {
  readonly serviceHost: string;

  constructor(serviceHost: string, options?: ServiceClientOptions);
  get(
    requestMessage: Test_pb.Query,
    metadata: grpc.Metadata,
    callback: (error: ServiceError, responseMessage: Test_pb.Response|null) => void
  ): void;
  get(
    requestMessage: Test_pb.Query,
    callback: (error: ServiceError, responseMessage: Test_pb.Response|null) => void
  ): void;
}

