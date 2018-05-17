// package: API
// file: Test.proto

var Test_pb = require("./Test_pb");
var grpc = require("grpc-web-client").grpc;

var Test = (function () {
  function Test() {}
  Test.serviceName = "API.Test";
  return Test;
}());

Test.Get = {
  methodName: "Get",
  service: Test,
  requestStream: false,
  responseStream: false,
  requestType: Test_pb.Query,
  responseType: Test_pb.Response
};

exports.Test = Test;

function TestClient(serviceHost, options) {
  this.serviceHost = serviceHost;
  this.options = options || {};
}

TestClient.prototype.get = function get(requestMessage, metadata, callback) {
  if (arguments.length === 2) {
    callback = arguments[1];
  }
  grpc.unary(Test.Get, {
    request: requestMessage,
    host: this.serviceHost,
    metadata: metadata,
    transport: this.options.transport,
    onEnd: function (response) {
      if (callback) {
        if (response.status !== grpc.Code.OK) {
          callback(Object.assign(new Error(response.statusMessage), { code: response.status, metadata: response.trailers }), null);
        } else {
          callback(null, response.message);
        }
      }
    }
  });
};

exports.TestClient = TestClient;

