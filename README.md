# Food App Canada
This web application is developed to provide an online service that can guide users to eat better and more healthy. 
It gives you serving per day for each food group (Vegetables and Fruits, Grains, Milk and Alternatives, Meat and Alternatives).
This guide system is working based on your age and gender. It also gives you the ability to get information for you and your family.
Following technologies are used to develop this tool:
<ul>
    <li>ASP.NET Core for server-side code</li>
    <li>React for client-side code</li>
    <li>Bootstrap for styling</li>
    <li>SQL Server Express LocalDB for storing data</li>
</ul>

## Data
The data used in this tool is from the Canada Food Guide and stored in the `Persistance/Data`. The data is in `csv` format. After creating the migration files to import the data from the `csv` files into database, we don't need the `csv` files anymore. Also, you can omit line 31 in `FoodAppContext.cs`. 

## Individual daily menu
Individually, you can enter your age and gender and get a daily menu with food examples.

## Family daily menu
As a family, you can enter the age and gender of all the members of your family and get a family daily menu with food examples.

## Demo
You can see the Demo of this tool in this <a href="http://canadafoodapp.somee.com/">link</a> and here is the <a href="https://drive.google.com/file/d/1AoxpOPZCVvi8bTCqb3HSQvbdY9w4FVE6/view?usp=sharing">Video Demo</a>.
* Note: This Demo is deployed on <a href="https://somee.com/">somee.com</a> free hosting plan. The SQL Server is also hosted in this website. They may expire due to low number of visitations. In this case, you should change the `ConnectionString` in `FoodAppContext.cs` (line 25) to address another a SQL Server on another server.You can also use `MSSQLLocalDB` by passing the following `ConnectionString`. `MSSQLLocalDB` normally works on IISExpress.

`optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=FoodAppDB;Trusted_Connection=True;MultipleActiveResultSets=true");`

## Deploying the application on IISExpress
You need the following programs to host the application on Windows 10.
1. Visual Studio 2019
2. Node.js <a href="https://nodejs.org/en/">download</a>

Use the following steps to build the application:
1. Clone the project.
2. Go to the cloned folder and run the `FoodApp.sln`.
3. From the top toolbar, choose `IISExpress`. You can also press `F5`.
4. Your browser will open and show you the app.

## Deploying the application in IIS on Windows 10
You need the following programs to host the application on Windows 10.
1. IIS
2. Dot Net Core Windows Hosting Bundle <a href="https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-aspnetcore-5.0.10-windows-hosting-bundle-installer">donwload</a>
3. Visual Studio 2019
4. Node.js <a href="https://nodejs.org/en/">download</a>

Follow the next steps to deploy the application in IIS.

1. Open IIS and create an application pool. Give the application Pool .NET CLR version: to No Managed Code Manage and pipeline mode: to Integrated.
2. Create a Web site beneath "Sites". Assigned the application pool from the previous step to this site. Also, choose a port number other than 80 (e.g. 8009).
3. Right click on sites and choose Add site. Give the Site name, select the Application pool you've created, choose the path to the `wwwroot/FoodApp` folder. Also give it a port number (e.g. 8009). You should give it a proper physical path (e.g. `C:\inetpub\wwwroot\FoodApp`). 
* Note: remeber the physical path.

Now the IIS is ready. We have to build the application with Visual Studio 2019 into the physical path. Use the following steps to build the application:
1. Clone the project.
2. Go to the cloned folder and run the `FoodApp.sln`.
3. Right click on the `FoodApp` project in the solution explorer and choose `publish`.
4. Choose publish to `folder` and choose the physical path from the previous steps.
5. Click `Publish` and wait for it.
6. After a successful build, open your browser and navigate to `http://localhose:8009`

For more information you can refer to this <a href="https://www.c-sharpcorner.com/article/how-to-deploy-asp-net-core-5-0-application-in-windows-server-iis/">website</a>.
