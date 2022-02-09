import { ApiClient, FrequenciesApi, CurrenciesApi } from '@factset/sdk-paengine';
import { ConfidentialClient } from '@factset/sdk-utils';

async function apikey() {
    const client = new ApiClient();
    
   const factSetApiKey = client.authentications['FactSetApiKey'];
   factSetApiKey.username = 'USERNAME-SERIAL';
   factSetApiKey.password = 'API-KEY';

    const frequenciesApi = new FrequenciesApi(client);
    const result = await frequenciesApi.getPAFrequencies();
   
    console.log(result.data);
}

apikey();
