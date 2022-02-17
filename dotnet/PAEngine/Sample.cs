using System;
using FactSet.SDK.Utils.Authentication;
using FactSet.SDK.PAEngine.Api;
using FactSet.SDK.PAEngine.Model;
using System.Threading;
using System.Threading.Tasks;

namespace Factset.SDK.Sample.PAEngine
{
    class Sample
    {

        static readonly CancellationTokenSource s_cts = new CancellationTokenSource();

        static async Task Main(string[] args)
        {
            FactSet.SDK.PAEngine.Client.Configuration configuration = new FactSet.SDK.PAEngine.Client.Configuration();
            ConfidentialClient confidentialClient = await ConfidentialClient.CreateAsync("../../app-config.json");
            configuration.OAuth2Client = confidentialClient;

            FrequenciesApi frequenciesApi = new FrequenciesApi(configuration);
            CurrenciesApi currenciesApi = new CurrenciesApi(configuration);

            try
            {
                s_cts.CancelAfter(5000);

                FrequencyRoot frequencyRoot = await frequenciesApi.GetPAFrequenciesAsync(s_cts.Token);
                CurrencyRoot currencyRoot = await currenciesApi.GetCurrenciesAsync(s_cts.Token);

                foreach (var pair in frequencyRoot.Data)
                {
                    Console.WriteLine($"{pair.Key} : {pair.Value}");
                }

                foreach (var pair in currencyRoot.Data)
                {
                    Console.WriteLine($"{pair.Key} : {pair.Value}");
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("\nTasks cancelled: timed out.\n");
            }
            finally
            {
                s_cts.Dispose();
            }
        }
    }
}
