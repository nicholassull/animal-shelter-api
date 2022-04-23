# _Animal Shelter API_

#### By _**Nick Sullivan**_

#### _An API to track our soon-to-be homed companions._

## Technologies Used

* _C#_
* _ASP.NET Core_
* _Swagger_
* _Entity Framework Core_
* _MySQL Workbench_

## Description

_This API is designed to offer animal shelter managers a straightforward way to store records of the sheltered animals, as well as provide potential adoptees an easy way to search for a new companion. An entered animal can be given a name, age, type (cat or dog), sex, and a general description. By using the different endpoints, explained below, users can add new animals to the API and search by the different parameters. Along with these features, users can update existing entries as well as delete entries once an animal finds a home._

---
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
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=[YOUR-PASSWORD];"
  }
}
  * Replace [YOUR-PASSWORD] with the password you created within MySQL Workbench and make sure the port matches your own.
* _Navigate to ~/AnimalShelter in your terminal._
* _Run the commands below_
>dotnet tool install --global dotnet-ef --version 3.0.0

>dotnet ef database update

>dotnet build

>dotnet run
---
## Using the API
* This API uses [Swagger](https://swagger.io/) to make experimentation and use simple, as well as documentation of the different endpoints.
* Once the above commands have been executed, the terminal should provide with you URL bellow.
> http://localhost:5000/
* Copy this URL into your browser to be directed to the swagger documentation page.
  * If you receive an error, try http://localhost:5001/ instead.
* By clicking the large Animals button, a list of different endpoints will be shown. These endpoints are the different ways a user can interact with the API.
### Example 1 - GET All
* We want to get a list of all animals currently at the shelter. How would we do that?
* Click the first GET endpoint with the URL '/Animals'. This will show a dropdown menu with the various possible search parameters. Since we want a list of all animals in the shelter, we can ignore the parameters for now.
* Click the 'Try it out' button. Then, click 'Execute'.
* In the 'Response Body' bellow, we can now see the details on each animal currently registered within the database.
* Experiment further by filling in the different search parameters, like maximum age, sex, and type (cat or dog).
### Example 2 - POST
* As the manager of the shelter, we'll want to know how to add new animals with the API.
* This time, we will click the POST endpoint with the URL of '/Animals'.
* By clicking 'Try it out' a new menu will appear. Here, you can see the template that's required for entering a new animal. 
  * However, its recommended that you remove the first row that defines the animalID. This will be automatically generated when an animal is added.
* Copy and paste the text bellow to see how a new animal is added.
>{
  "name": "Tiptoe",
  "type": "Dog",
  "age": 1,
  "sex": "Female",
  "description": "A cute puppy!"
}
* Click 'Execute' and the new animal will be registered, along with a response that contains the details of the animal you just added.
## Known Bugs

* _No known bugs at this time._

---
## License

Copyright (c) _04/23/2022_ _by Nick Sullivan_


_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._