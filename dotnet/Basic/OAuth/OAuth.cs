using System;
using FactSet.SDK.Utils.Authentication;
using FactSet.SDK.PAEngine.Api;
using FactSet.SDK.PAEngine.Model;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Factset.SDK.Sample.Basic.Oauth
{
    class Oauth
    {
        static readonly CancellationTokenSource cts = new CancellationTokenSource();

        static async Task Main(string[] args)
        {
            FactSet.SDK.PAEngine.Client.Configuration configuration = new FactSet.SDK.PAEngine.Client.Configuration();
            ConfidentialClient confidentialClient = await ConfidentialClient.CreateAsync("../../../app-config.json");
            configuration.OAuth2Client = confidentialClient;

            FrequenciesApi frequenciesApi = new FrequenciesApi(configuration);

            try
            {
                cts.CancelAfter(5000);

                FrequencyRoot frequencyRoot = await frequenciesApi.GetPAFrequenciesAsync(cts.Token);

                foreach (var pair in frequencyRoot.Data)
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
                cts.Dispose();
            }
        }
    }
}
