# WebApi Deploy

## Requisites

#### Visual Studio Workloads
- ASP.NET and web development
- Azure development
- .NET Core cross-platform development

![Requisites](/screenshots/webapi/1-requisites.png)

## Steps

### Deploy the Web Api

1. Open the SourdoughBakery solution on Visual Studio 2017
2. Right click on Sourdough.WebApi project and select Publish

![Publish](/screenshots/webapi/2-publish.png)

3. Create a new profile and create a new Azure App Service

4. Add an app name, select your subscription, resource group, hosting plan (S1 in your region is a good option) and finally, add an Application Insights. You should end up with something similar to this:

![Create App Service](/screenshots/webapi/3-createappservice.png)

5. Click publish and your Web Api will be deployed

![Deploy](/screenshots/webapi/4-deploy.png)

6. You can now test your Api by accessing the Site URL. You should be presented with a Swagger UI

![Swagger](/screenshots/webapi/5-swagger.png)

7. Test your api by sending a request to one of the available methods. To do that click on of the available methods, Try it out and then on Execute

![Execute](/screenshots/webapi/6-execute.png)

## Guides

##### [1 - WebApi Deploy](/AzureWebinarSeries-WebApi.md)
##### [2 - WebApi Docker container support](/AzureWebinarSeries-Docker.md)
##### [3 - Azure Functions Deploy](/AzureWebinarSeries-Functions.md)