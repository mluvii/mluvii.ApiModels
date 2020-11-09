# mluvii Public Api Models
## Usage
Include this repository as a submodule in your source tree and reference the csproj from your main project.
To add this repository as a submodule, execute following command in directory of your choice inside your source tree:
``
git submodule add git@github.com:mluvii/mluvii.ApiModels.git
``

## Deserialization
### Enumerations
Enumerations may change by adding new values to them. Api consumers should ignore unknown values when deserializing.
See also [this SO question](https://stackoverflow.com/questions/22752075/how-can-i-ignore-unknown-enum-values-during-json-deserialization).
