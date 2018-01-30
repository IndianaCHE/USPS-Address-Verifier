## USPS Address Verifier

### Table of Contents

1. [Address Class](#address-class)
2. [CsvWriter Class](#csvwriter-class)
3. [GlobalVariables Class](#globalvariables-class)
4. [ScanResults Class](#scanresults-class)
5. [USPS_ID Class](#usps_id-class)
6. [ValidateCsv Class](#validatecsv-class)
7. [Validator Class](#validator-class)
8. [ValidatorUI Class](#validatorui-class)

----

### Address Class

[Address class](Address.cs) defines an address object. Also contains a function to return address from an XML object.

```
public class Address
```

#### Constructors
|             |                                                 |
|-------------|-------------------------------------------------|
| `Address()` | Initializes a new instance of the Address class.|

#### Properties
|            |                                                     |
|------------|-----------------------------------------------------|
| `FirmName` | Gets or sets the value of the firm or company.      |
| `Address1` | Gets or sets the value of the Apartment/Box info.   |
| `Address2` | Gets or sets the value of the Street address.       |
| `City`     | Gets or sets the value of the City information.     |
| `State`    | Gets or sets the value of the State information.    |
| `Zip`      | Gets or sets the value of the Zip code information. |
| `ZipPlus4` | Gets or sets the value of the Zip code extension.   |
| `modified` | States whether address has been modified. Default is `false`. |

#### Methods
|           |                                                     |
|-----------|-----------------------------------------------------|
| `FromXml(string)`  | Returns a dictionary object representing an address from a XML string. |
| `ToXml()` | Returns the XML representation of the address object. |
| `ModifyAddress()`  | Modifies an address to the correct form.      |

----

### CsvWriter Class

[CsvWriter class](CsvWriter.cs) is a helper class to write data into csv files.

```
public class CsvWriter
```

#### Constructors
|           |                                                 |
|-----------|-------------------------------------------------|
| `CsvWriter(string filename)` | Initializes a new instance of the CsvWriter class. |

#### Properties
|            |                                                     |
|------------|-----------------------------------------------------|
| `filename` | Name of the csv file to write to. Creates a new file if it does not already exist. |

#### Methods
|                           |                                      |
|---------------------------|--------------------------------------|
| `WriteHeader(List<string>)` | Writes the header in the csv file. |
| `AppendRow(List<string>)`  | Appends a row to the csv file.      |

----

### GlobalVariables Class

[GlobalVariables class](GlobalVariables.cs) is a static class which holds and manages the global stats values for every run.

```
public static class GlobalVariables
```

#### Constructors
|           |                                                    |
|-----------|----------------------------------------------------|
| `GlobalVariables()` | Stores the default values for the stats. |

#### Properties
|                 |                                               |
|-----------------|-----------------------------------------------|
| `TimeElapsed`   | Gets or sets the values for time elapsed.     |
| `TotalScanned`  | Gets or sets the values for time number of items scanned. |
| `TotalErrors`   | Gets or sets the values for total number of errors encountered. |
| `TotalActionReq`| Gets or sets the values for total number of items with actions required. |

#### Methods
|                   |                                         |
|-------------------|-----------------------------------------|
| `SetAllDefault()` | Resets all stat values back to default. |

----

### ScanResults Class

----

### USPS_ID Class

----

### ValidateCsv Class

----

### Validator Class

----

### ValidatorUI Class
