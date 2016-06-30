# Docker Swarm Talk Using .NET Core Example Application

This talk among many things demostrates:
- Running a container
- Swarm features native to the Docker Engine (1.12RC+)
    - Creating a service
    - Scaling a service
    - Rolling update
- publishing an application to Docker Hub

Note - Currently this talk is written for use on Linux / OS X. I have however provided a Dockerfile named DockerfileWindows for the ASP.NET Core demo application and plan to add a build-vbox.ps1 script once Windows swarms are natively supported.


## Credits

buildswarm-vbox.sh has been modified but is originally from https://github.com/docker/labs