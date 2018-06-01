import { TestClient } from "./generated/Test_pb_service";
import { Query } from "./generated/Test_pb";

const client = new TestClient("http://localhost:8080")
console.log(client)

const query = new Query()

query.setItem("Alex")

client.get(query, function(err, response) {
    if (err) {
        console.log(err)
    } else {
        console.log(response)
    }
})
