#!/bin/bash


#  TAG=$1
#  DOCKER_USERNAME=$2
#  DOCKER_PASSWORD=$3

# echo $1

# # Create publish artifact
# dotnet publish -c Release 


# # Build the Docker images
 docker build .
#  docker tag repository/project:$TAG repository/project:latest

# # # # Login to Docker Hub and upload images
#  docker login -u="$DOCKER_USERNAME" -p="$DOCKER_PASSWORD"
#  docker push repository/project:$TAG
#  docker push repository/project:latest