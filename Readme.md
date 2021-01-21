# CSharp-Yml-Reader
### How to use:

First: Load Dalk.Yml
```csharp
using Dalk.Yml;
```
### Create a YmlCode
```csharp
// From a string
YmlCode ymlFromString = new YmlCode("text for document here");

// From a file
YmlCode ymlFromFile = new YmlCode(new YmlFile("filename of file"));

//Loading a string
YmlCode ymlloadString = new YmlCode();
yml.Load("text for document here");

//Loading a file
YmlCode ymlLoadFile = new YmlCode();
yml.Load(new YmlFile("filename of file"));
```

### Read Values

Int from Document
```csharp
YmlCode yml = new YmlCode(new YmlFile("filename of file"));
int result = yml.GetInt("int´s name");
```

String from Document
```csharp
YmlCode yml = new YmlCode(new YmlFile("filename of file"));
string result = yml.GetString("string´s name");
```

Bool from Document
```csharp
YmlCode yml = new YmlCode(new YmlFile("filename of file"));
string result = yml.GetBool("bool´s name");
```
