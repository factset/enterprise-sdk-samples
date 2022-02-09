import { ApiClient, FrequenciesApi, CurrenciesApi } from '@factset/sdk-paengine';
import { ConfidentialClient } from '@factset/sdk-utils';

async function paengine() {
    const confidentialClient = new ConfidentialClient("../../app-config.json");


    const client = new ApiClient();
    client.factsetOauth2Client = confidentialClient;

    const frequenciesApi = new FrequenciesApi(client);
    const currenciesApi = new CurrenciesApi(client);

    const responses = await Promise.all([
        frequenciesApi.getPAFrequencies(),
        currenciesApi.getCurrencies()
    ]);

    console.log(responses[0].data);
    console.log(responses[1].data);
}

paengine();
