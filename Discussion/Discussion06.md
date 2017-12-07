# Course: ISTA-422
## Lesson Plan: 06
### Name: Tyler Reed
#### Date: 07 December 2017

1. Can a UWP app directly access a relational database by using technologies provided by Microsoft?

	-They cannot
Why or why not?

	-Primarily, it eliminates dependencies that a UWP app might have on external resources, making the app a standalone item that can be easily packaged and downloaded from the Windows Store without requiring users to install and configure a database-management system on their computer.
1. Describe how the Entity Framework works.

	-It can reduce the amount of code that most developers need to write to add data access capabilities to an app.
1. What is the dfference between the codefirst and the databasefirst approaches to developing UWP
apps?

	-The database-first approach to entity modeling. In this approach, the Entity Framework generates classes based on the definitions of tables in the database. The Entity Framework also provides a code-first approach; that strategy can generate a set of tables in a database based on classes that you have implemented in your app.
1. What is a partial class? Why would we want to create partial classes?

	-A partial class is a class in which the code is split across one or more source files./This approach is useful for tools such as the Entity Framework because it enables you to add your own code without the risk of having it accidentally overwritten if the Entity Framework code is regenerated at some point in the future.
1. Describe a RESTful web api. (Not in book.) Write a brief description of Representational State
Transfer. What problem was it designed to solve?

	-REST stands for ‘Representational State Transfer’ and it is an architectural pattern for creating an API that uses HTTP as its underlying communication method. REST was originally conceived by Roy Fielding in his 2000 dissertation paper entitled ‘Architectural Styles and the Design of Network-based Software Architectures’
1. Give a brief description of the functionalities of these HTTP commands: GET, POST, PUT, DELETE.

	-GET,Retrieves the document specified in the URL property (use GetHeader to retrieve header information and GetChunk to get the rest of the information) / POST, Sends data to the server / PUT,  Replaces the page specified in the URL property with the specified data / DELETE, Deletes the data