FROM alpine

RUN apk update && apk add protobuf && apk add nodejs && npm install -g ts-protoc-gen

WORKDIR /root

CMD ["protoc", "--plugin=protoc-gen-ts=/usr/bin/protoc-gen-ts", "--js_out=import_style=commonjs,binary:/root", "--ts_out=service=true:/root", "./Test.proto"]