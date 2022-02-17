import com.factset.sdk.PAEngine.ApiClient;
import com.factset.sdk.PAEngine.ApiException;
import com.factset.sdk.PAEngine.api.CurrenciesApi;
import com.factset.sdk.PAEngine.api.FrequenciesApi;
import com.factset.sdk.PAEngine.models.CurrencyRoot;
import com.factset.sdk.PAEngine.models.FrequencyRoot;
import com.factset.sdk.utils.authentication.ConfidentialClient;
import com.factset.sdk.utils.exceptions.AuthServerMetadataContentException;
import com.factset.sdk.utils.exceptions.AuthServerMetadataException;
import com.factset.sdk.utils.exceptions.ConfigurationException;

public class Sample {
  public static void main(String[] args) {
    ConfidentialClient confidentialClient;

    try {
      confidentialClient = new ConfidentialClient("../../app-config.json");
    } catch (AuthServerMetadataContentException | AuthServerMetadataException | ConfigurationException e) {
      e.printStackTrace();
      return;
    }

    ApiClient apiClient = new ApiClient(confidentialClient);

    FrequenciesApi frequenciesApi = new FrequenciesApi(apiClient);
    CurrenciesApi currenciesApi = new CurrenciesApi(apiClient);

    try {
      FrequencyRoot frequencyRoot = frequenciesApi.getPAFrequencies();
      CurrencyRoot currencyRoot = currenciesApi.getCurrencies();

      System.out.println(frequencyRoot.getData());
      System.out.println(currencyRoot.getData());
    } catch (ApiException e) {
      e.printStackTrace();
    }
  }
}
