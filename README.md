# DockerCaptains
Sample .NET Core solution to accompany Docker blog, [Deploying Dockerized .NET Apps Without Being a DevOps Guru](dockr.ly/2MfvsLn) published Aug 13, 2019

The solution itself is a result of an article series in MSDN Magazine (April, May, June 2019 issues) called "EF Core in a Docker Containerized App".

Read the entire series:   
[EF Core in a Docker Containerized App, Part 1](https://msdn.microsoft.com/en-us/magazine/mt833405)  
[EF Core in a Docker Containerized App, Part 2](https://msdn.microsoft.com/magazine/mt833438)  
[EF Core in a Docker Containerized App, Part 3](https://msdn.microsoft.com/en-us/magazine/mt833457)  

The blog post then shows how to use tooling in Visual Studio (on Windows) to publish the app's image to Docker Hub, then using the Azure CLI and docker-machine, create a new Linux VM on Azure, copy the docker-file from the solution into the VM and then run the docker-file, which spin up the relevant containers and run the app.

I am a dev, not a DevOps person and I was surprised how simple it turned out to accomplish the deployment wiht a little research and learning some new tools. The blog post will help reduced the effort of discovering all of the information since it's all in one place for you!

Hope it helps.
