# AnimalAdaption

AUTH

POST || */auth/register

request type : json

request :

{

"name" : "fbfbfb",

"email" : "admin",

"password" : "1907"

}

POST || */auth/login

request type : json

request :

{

"email" : "admin",

"password" : "1907"

}



-Animal Operation

request type : json

request :
{
            "animalTypeId": 2,
            "address": "KDZ eregli",
            "animalName": "sila",
            "animalGender": "disi",
            "animalAge": "1"
        }



GET || */api/animals/getallbyanimaltypesid?id=2 // animal type id si 2 olan tum animal ları getirir

GET || */api/animals/getall

GET ||  /api/animals/getbyid?id=2 // id 2 olan animalı getirir

POST || */api/animals/add

PATCH || *api/animals/update

Delete || /api/animals/deletebyid



-AnimalType

request type : json

request :
{
            "animalTypeId": 1,
            "animalTypeName": "kedi",
            "description": "van kedisi"
        }


GET || */api/animaltypes/getall

GET ||  /api/animaltypes/getbyid?id=x               /animaltypes/getbyid?id=1
	
POST || */api/animaltypes/add

Delete || /api/animaltype/deletebyid


-Advertisement OPERATIONS

request type : json

request :
{
            "animalId": 2,
            "userId": 1
      }

GET || */api/advertisements/getall

GET ||  /api/advertisements/getbyid

POST || */api/advertisements/add

Delete || /api/advertisements/deletebyid



-Answer Operations

request type : json

request :
{
            "questionId": 1,
            "userId": 2,
            "content": "Cevap"
        }

GET || */api/answers/getall 

GET ||  /api/answers/getbyid?id=x

POST || */api/answers/add 

Delete || /api/answers/deletebyid


-Question OPERATİON

request type : json

request :

{
            "userId": 2,
            "title": "soru1",
            "content": "deneme"
        }

GET || */api/questions/getall 

GET ||  /api/questions/getbyid?id=1

POST || */api/questions/add 

PATCH || *api/questions/update

Delete || /api/questions/deletebyid
