import { ApiClient, FrequenciesApi, CurrenciesApi } from '@factset/sdk-paengine';
import { ConfidentialClient } from '@factset/sdk-utils';

async function oauth() {
    const client = new ApiClient();
    client.factsetOauth2Client = new ConfidentialClient("../../../app-config.json");

    const frequenciesApi = new FrequenciesApi(client);
    const result = await frequenciesApi.getPAFrequencies();

    console.log(result.data);
}

oauth();
