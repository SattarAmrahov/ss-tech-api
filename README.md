# SS Tech

To run the service locally you must have a SQL Server database. If you have a local SQL Server you can use it. 
If you don't have a local SQL Server then you can run it in docker with the help of the following command:
```sh
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Database!123" -p 14333:1433 --name sqlserver2019 -d mcr.microsoft.com/mssql/server:2019-latest
```
As you see, password will be Database!123. But you can change it in command to use your desired password.
Add connection string into the **appsettings.json** file.

To run, select **SS.Alteration.API** project as a startup and then you can run it with Visual Studio.

Swagger is installed and to test the steps it can be used.

Code first approach is used to create tables. There are 5 tables. Default data are inserted into OrderStatuses table when the service starts to run.

The followings are the main functionalities:
- Create Suit
- Create Order
- Payment for order
- Start Alteration
- Finish Alteration



### Create Suit
To create a suit "Code" needs to be added. It can be any string (SS001, SS002, etc.).
Endpoint: POST /api/Suits

To see all suits:
Endpoint: GET /api/Suits

### Create Order
To create an order SuitId should be used in request body.
Amount is the price of alteration service.
Instructions array can have maximum 2 items.
Endpoint: POST /api/Orders

### Pay Order
To pay an order use OrderId and Amount in request body.

### Start Alteration
With StartAlteration request, order status will be changed from Received to InProgress. It means tailor is working on the suit

### Finish Alteration
With FinishAlteration request, order status will be changed from InProgress to Ready. It means tailor finished the job.

When FinishAlteration is triggered, at the end of the process new OrderFinished message is published to **Azure Message Bus**
OrderFinished consumer consumes the message and Notification is sent to the customer.



## Tech

The following technologies and design patterns are used in the project:

- Clean Architecture
- Repositor Pattern
- CQRS
- Mediator Pattern (with mediatr)
- Azure Message Bus
- SQL Server


