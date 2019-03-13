# Azure Functions Deploy

## Steps

### Deploy the Web Api

1. Open the SourdoughBakery solution on Visual Studio 2017
   
2. Right click on Sourdough.AzureFunctions project and select Publish

3. Create a new Azure Function App and select Publish

4. Add an app name, select your subscription, resource group, hosting plan (Y1 in your region is a good option) and a Storage Account. You should end up with something similar to this

![Publish](/screenshots/azurefunctions/1-publish.png)

5. 5. Click publish and your Azure Functions will be deployed

![Deploy](/screenshots/azurefunctions/2-deploy.png)

6. You can now test your Api by accessing the Site URL. Test your api by sending a request to one of the available methods

## Guides

##### [1 - WebApi Deploy](/AzureWebinarSeries-WebApi.md)
##### [2 - WebApi Docker container support](/AzureWebinarSeries-Docker.md)
##### [3 - Azure Functions Deploy](/AzureWebinarSeries-Functions.md)