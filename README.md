<img alt="FactSet" src="https://www.factset.com/hubfs/Assets/images/factset-logo.svg" height="56" width="290">

# Enterprise SDK Samples

[![Apache-2 license](https://img.shields.io/badge/license-Apache2-brightgreen.svg)](https://www.apache.org/licenses/LICENSE-2.0)

## Getting Started

Follow this [guide](https://github.com/factset/enterprise-sdk#authentication) to create authentication credentials to be able to run this code samples. If using `Application Credentials (OAuth)` place the config file: `app-config.json` with the generated config in the `root` folder of this repository. Then it is possible to run the samples without modifying the path to the config in the code.

### C# .NET

1. [Install .NET](https://docs.microsoft.com/en-us/dotnet/core/install/).

2. Move to the directory containing the sample you wish to run (e.g. `cd dotnet/PAEngine`).

3. Run the sample. Make any necessary changes to the sample code (e.g. the OAuth 2.0 configuration file path) and run it:

   ```sh
   dotnet run
   ```

### Java

1. [Install Gradle](https://gradle.org/install/).

2. Move to the directory containing the sample you wish to run (e.g. `cd java/PAEngine`).

3. Run the sample. Make any necessary changes to the sample code (e.g. the OAuth 2.0 configuration file path) and run it:

   ```sh
   gradle run
   ```

### Python

1. Install and activate python 3.6+. If you're using [pyenv](https://github.com/pyenv/pyenv):

   ```sh
   pyenv install 3.9.7
   pyenv shell 3.9.7
   ```

2. [Install poetry](https://python-poetry.org/docs/#installation).
3. Install dependencies. Move to the directory containing the sample you wish to run (e.g. `cd python/PAEngine`) and execute:

   ```sh
   poetry install
   ```

4. Run the sample. Make any necessary changes to the sample code (e.g. the OAuth 2.0 configuration file path) and run it:

   ```sh
   poetry run python sample.py
   ```

### TypeScript

1. [Download and install](https://nodejs.org/en/download/) Node.js 14.19 or greater

2. [Install Yarn](https://classic.yarnpkg.com/lang/en/docs/install). If you're using the terminal:

   ```sh
   npm install --global yarn
   ```

3. Move to the directory containing the sample you wish to run (e.g. `cd typescript/PAEngine`). Install dependencies.

   ```sh
   yarn install
   ```

4. Run the sample. Make any necessary changes to the sample code (e.g. the OAuth 2.0 configuration file path) and run it:

   ```sh
   yarn start
   ```

## Contributing

Please refer to the [contributing guide](https://github.com/factset/enterprise-sdk/blob/main/CONTRIBUTING.md).

## Copyright

Copyright 2022 FactSet Research Systems Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
