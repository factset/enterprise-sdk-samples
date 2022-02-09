import com.factset.sdk.PAEngine.ApiClient;
import com.factset.sdk.PAEngine.ApiException;
import com.factset.sdk.PAEngine.api.FrequenciesApi;
import com.factset.sdk.PAEngine.auth.HttpBasicAuth;
import com.factset.sdk.PAEngine.models.FrequencyRoot;

public class ApiKey {
    public static void main(String[] args) {
        ApiClient apiClient = new ApiClient();

        HttpBasicAuth FactSetApiKey = (HttpBasicAuth) apiClient.getAuthentication("FactSetApiKey");
        FactSetApiKey.setUsername("USERNAME-SERIAL");
        FactSetApiKey.setPassword("API-KEY");

        FrequenciesApi frequenciesApi = new FrequenciesApi(apiClient);

        try {
            FrequencyRoot frequencyRoot = frequenciesApi.getPAFrequencies();
            System.out.println(frequencyRoot.getData());
        } catch (ApiException e) {
            e.printStackTrace();
        }
    }
}
