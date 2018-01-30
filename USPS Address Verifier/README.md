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

### 1. Address Class<a name="address-class" />

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
| `modified` | States whether address has been modified. Default value is `false`. |

#### Methods
|           |                                                     |
|-----------|-----------------------------------------------------|
| `FromXml(string xml)`  | Returns a dictionary object representing an address from a XML string. |
| `ToXml()` | Returns the XML representation of the address object. |
| `ModifyAddress()`  | Modifies an address to the correct form.     |

----

### 2. CsvWriter Class<a name="csvwriter-class" />

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
|                            |                                     |
|----------------------------|-------------------------------------|
| `WriteHeader(List<string> headers)`| Writes the header in the csv file.  |
| `AppendRow(List<string> row)`  | Appends a row to the csv file.      |

----

### 3. GlobalVariables Class<a name="globalvariables-class" />

[GlobalVariables class](GlobalVariables.cs) is a static class which holds and manages the global stats values for every run.

```
public static class GlobalVariables
```

#### Constructors
|                     |                                          |
|---------------------|------------------------------------------|
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

### 4. ScanResults Class<a name="scanresults-class" />

[ScanResults class](ScanResults.cs) displays the results of the csv file scan. It is inherited from System.Windows.Form class.

```
public partial class ScanResults : Form
```

#### Constructors
|                 |                                          |
|-----------------|------------------------------------------|
| `ScanResults()` | Initializes a new instance of the ScanResults class. |

#### Events
|                   |                                         |
|-------------------|-----------------------------------------|
| `okButton_Click(object sender, EventArgs e)` | Closes the form on press of 'OK' button. |

----

### 5. USPS_ID Class<a name="usps_id-class" />

[USPS_ID class](USPS_ID.cs) displays the window form to edit/save the user's USPS Id. It is inherited from System.Windows.Form class.

```
public partial class USPS_ID : Form
```

#### Constructors
|                 |                                          |
|-----------------|------------------------------------------|
| `USPS_ID()` | Initializes a new instance of the USPS_ID class. |

#### Events
|                   |                                         |
|-------------------|-----------------------------------------|
| `uspsIdDescription3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)` | Opens the link to the USPS Id registration page when clicked on the label. |
| `idEditButton_Click(object sender, EventArgs e)` | Enables Id text box and the Save button for editing. |
| `idSaveButton_Click(object sender, EventArgs e)` | Saves the new Id and disables the text box and Save button. |
| `idDoneButton_Click(object sender, EventArgs e)` | Closes the window form on Done button press. |

----

### 6. ValidateCsv Class<a name="validatecsv-class" />

[ValidateCsv class](ValidateCsv.cs) utilizes [CsvReader](LumenWorks.Framework.IO/Csv/CsvReader.cs) and [Validator](Validator.cs) classes to read through a csv file and retrieve proper address fields and validate them against the USPS database.

```
public class ValidateCsv
```

#### Constructors
|                 |                                          |
|-----------------|------------------------------------------|
| `ValidateCsv(string USPSWebtoolUserID, string file, string outPath)` | Initializes a new instance of the ValidateCsv class. |

#### Properties
|                 |                                               |
|-----------------|-----------------------------------------------|
| `file`   | File path for input file.     |
| `outPath`  | Output files directory. |
| `USPSWebtoolUserID`   | USPS Web tools user ID. |

#### Methods
|                   |                                         |
|-------------------|-----------------------------------------|
| `Validate(Dictionary<string,Tuple<string,int>> fileHeaders, int numberOfRecords, BackgroundWorker worker, DoWorkEventArgs e)` | Goes through the specified csv file, reads the address fields based on fileHeaders, and writes files for correct addresses, incorrect addresses, as well as ones that require attention. |

----

### 7. Validator Class<a name="validator-class" />

[Validator class](Validator.cs) Checks the validity of an address using USPS API.

```
public class Validator
```

#### Constructors
|                 |                                          |
|-----------------|------------------------------------------|
| `Validator(string USPSWebtoolUserID)` | Initializes a new instance of the Validator class on production URI. |
| `Validator(string USPSWebtoolUserID, bool testmode)` | Initializes a new instance of the Validator class with user specified URI. |

#### Properties
|                 |                                               |
|-----------------|-----------------------------------------------|
| `ProductionUrl`   | Production URI for USPS Web Tools API.     |
| `TestingUrl`  | Testing URI for USPS Web Tools API. |
| `web`   | Webclient instance to send and receive data from the API URI. |
| `userid`  | USPS Web Tools API User ID. |
| `TestMode`   | Gets or sets the test mode to `true` or `false`. |

#### Methods
|                   |                                         |
|-------------------|-----------------------------------------|
| `GetURL()` | Gets the URI depending on value of TestMode. |
| `Dictionary<string,string> ValidateAddress(Address address)` | Validates an address and returns a dictionary representing the properly formatted address and/or error messages. |

----

### 8. ValidatorUI Class<a name="validatorui-class" />

[ValidatorUI class](ValidatorUI.cs) displays the window form to retrieve input file, set output directory, select column headers, and run the validation process. It is inherited from System.Windows.Form class.

```
public partial class ValidatorUI : Form
```

#### Constructors
|                 |                                          |
|-----------------|------------------------------------------|
| `ValidatorUI()` | Initializes a new instance of the ValidatorUI class. |

#### Properties
|                 |                                               |
|-----------------|-----------------------------------------------|
| `ProductionUrl`   | Production URI for USPS Web Tools API.     |
| `TestingUrl`  | Testing URI for USPS Web Tools API. |
| `web`   | Webclient instance to send and receive data from the API URI. |
| `userid`  | USPS Web Tools API User ID. |
| `TestMode`   | Gets or sets the test mode to `true` or `false`. |

#### Methods
|                   |                                         |
|-------------------|-----------------------------------------|
| `toggleInteractivity(bool enable)` | Toggles the 'Enabled' property of various UI components. |

#### Events
|                   |                                         |
|-------------------|-----------------------------------------|
| `browseButton_Click(object sender, EventArgs e)` | Opens Windows File Open Dialog window on button press. Also loads up the file and its header information upon file selection. |
| `browseButton2_Click(object sender, EventArgs e)` | Opens Windows Folder Browser window on button press. Called to select an output directory.  |
| `validateButton_Click(object sender, EventArgs e)` | Sets an output directory if not chosen by the user and starts the validation process in the background. |
| `cancelButton_Click(object sender, EventArgs e)` | Cancels the validation async task on button press. Opens a Dialog window to confirm the action before cancelling operation. |
| `backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)` | Starts a background worker to carry out the asynchronous task of validating a csv file. |
| `backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)` | Handles actions on completion of the asynchronous task. |
| `backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)` | Handles actions on change of progress of the background worker. |
| `OnFormClosing(FormClosingEventArgs e)` | Handles event when user clicks the close button. |
