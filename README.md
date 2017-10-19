# ArgenSearch
Esta librería es un cliente en C# para las búsqueda de personas en AFIP

[![Build status](https://ci.appveyor.com/api/projects/status/25uumr70366ulp2c?svg=true)](https://ci.appveyor.com/project/matiasdieguez/argensearch)

## Instalación

```
install-package argensearch
```

## Ejemplos

```csharp
using ArgenSearch;

var persona = await ArgenSearchClient.Search(123456);

var id = persona.Data[0];

var datos = await ArgenSearchClient.Detail(id);
```