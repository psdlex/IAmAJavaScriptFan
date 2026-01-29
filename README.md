## Uh.. well, just... Lets say you are unlikely to pass the interview test.
```csharp
string value = GetValueFromMyImaginaryMethod();

if (value)
{
    ...
}
```

## You can also use a ternary operator 
```csharp
string value = GetValueFromMyImaginaryMethod();

bool result = value ? true : false;
```
Unforunately though, this approach cannot implicitely nor explicitely cast the object to a boolean object, but it still works on conditional operators. 

## Nuget
#### https://www.nuget.org/profiles/flightlex/IAmAJavaScriptFan