# mluvii Public Api Models
## Usage
Include this repository as a submodule in your source tree and reference the csproj from your main project.

To add this repository as a submodule, execute following command in directory of your choice inside your source tree:

``
git submodule add https://github.com/mluvii/mluvii.ApiModels.git
``

## Serialization
### Enumerations
All enumerations must be sent as strings. Special value UNKNOWN must be avoided as it is only used for deserialization.

Enumerations may change by adding new values to them.
Api consumers should ignore unknown values when deserializing and translate these unknown values using UNKNOWN special value that is present in all enumerations.
See the [sample code](https://github.com/mluvii/apiintegrationsamplecs)
that uses [customized Newtonsoft.Json settings](https://github.com/mluvii/apiintegrationsamplecs/tree/master/ApiIntegrationSample/mluvii.ApiIntegrationSample.Web/Serialization)
to automatically handle unknown values.
