# _Animal Shelter API_

#### By _**Nick Sullivan**_

#### _An API to track our soon-to-be homed companions._

## Technologies Used

* _C#_
* _ASP.NET Core_
* _Swagger_
* _Postman_
* _Entity Framework Core_
* _MySQL Workbench_

## Description

_This API is designed to offer animal shelter managers a straightforward way to store records of the sheltered animals, as well as provide potential adoptees an easy way to search for a new companion. An entered animal can be given a name, age, type (cat or dog), sex, and a general description. By using the different endpoints, explained below, users can add new animals to the API and search by the different parameters. Along with these features, users can update existing entries as well as delete entries once an animal finds a home._

## Setup Instructions

* _Open your terminal and navigate to the folder you'd like to download the files into._
* _Run the command below_
> git clone https://github.com/nicholassull/animal-shelter-api.git
* _Download [MySQL Workbench](https://www.mysql.com/products/workbench/) and use it to create a local instance and an associated password._
* Within the directory ~/AnimalShelter, create a file named appsettings.json and input the lines of code bellow.
> {
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=epicodus;"
  }
}
  * Replace [YOUR-PASSWORD] with the password you created within MySQL Workbench and make sure the port matches your own.
* _Navigate to ~/AnimalShelter in your terminal._
* _Run the commands below_
>dotnet tool install --global dotnet-ef --version 3.0.0

>dotnet ef database update

>dotnet build

>dotnet run

## Using the API
* Add instructions on using Postman
### Endpoints

## Known Bugs

* _No known bugs at this time._

## License

Copyright (c) _04/21/2022_ _by Nick Sullivan_


_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._