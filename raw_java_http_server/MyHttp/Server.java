package MyHttp;
import java.io.FileNotFoundException;
import java.net.URI;
import java.net.http.*;
import java.net.http.HttpRequest.BodyPublishers;
import java.net.http.HttpResponse.BodyHandlers;
import java.nio.file.Paths;
import java.time.Duration;

public class Server {
    HttpClient.Builder client;
    HttpRequest request;
    public Server() throws FileNotFoundException {
        //httpclient = HttpClient.newBuilder();
        
        
    }

    public void BuildRequest() throws FileNotFoundException{
        request = HttpRequest.newBuilder()
        .uri(URI.create("https://localhost/"))
        .timeout(Duration.ofSeconds(5))
        .header("Content-Type", "application/json")
        .POST(BodyPublishers.ofFile(Paths.get("file.json")))
        .build();
    }

    public void SendRequest() throws FileNotFoundException {
        BuildRequest();
        ((HttpClient) client).sendAsync(request, BodyHandlers.ofString())
        .thenApply(HttpResponse::body)
        .thenAccept(System.out::println);  
    }
    
}

