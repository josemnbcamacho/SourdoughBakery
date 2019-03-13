## Steps

### Add Docker Container support

1. Right click on Sourdough.WebApi project and select Add and then Docker Support

![Publish](/screenshots/docker/1-addcontainersupport.png)

2. Select your desired container OS runtime. Remember, Docker Daemon must be set to the OS runtime you select on this step.

![Docker](/screenshots/docker/2-targetos.png)

3. You will now have a Dockerfile and a new Docker run Task that will help you run your Api locally inside a container.

![Docker](/screenshots/docker/3-dockerfile.png)


### Add Docker Container to Azure Container Registry

1. Right click on Sourdough.WebApi project and select Publish

![Publish](/screenshots/webapi/2-publish.png)

2. Select the Container Registry tab and Create a New Azure Container Registry


3. Give the Registry a DNS Name, Resource Group, SKU (Standard), and Location and click create. Publishing the Docker Image will build the Dockerfile and send the binaries to Azure Container Registry

![Create Registry](/screenshots/docker/4-createregistry.png)

4. On Azure Container Registry you should see a new image repository with our binaries

![Registry](/screenshots/docker/5-registry.png)

5. You can now deploy the sourdoughbakerywebapi:latest image by clicking on the ellipsis button and select either Run Instance to run the image on Azure Container Instances or Deploy to web app to run the image on an App Service

## Guides

##### [1 - WebApi Deploy](/AzureWebinarSeries-WebApi.md)
##### [2 - WebApi Docker container support](/AzureWebinarSeries-Docker.md)
##### [3 - Azure Functions Deploy](/AzureWebinarSeries-Functions.md)