from fds.sdk.PAEngine import ApiClient, ApiException, Configuration
from fds.sdk.PAEngine.api.frequencies_api import FrequenciesApi

conf = Configuration(
    username='USERNAME-SERIAL',
    password='API-KEY'
)

with ApiClient(conf) as api_client:
    frequenciesApi = FrequenciesApi(api_client)

    try:
        frequencyRoot = frequenciesApi.get_pa_frequencies()
        print(frequencyRoot.data)
    except ApiException as e:
        print("Error calling API: %s\n" % e)
