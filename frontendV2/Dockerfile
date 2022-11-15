#Pulling a node's latest image to act as base image for the project.
FROM node:latest

#Setting up the work directory.
WORKDIR /app

#Copying all the project's dependencies including package.json.
COPY . .

#Exposing port 4200 to internet to access frontend.
EXPOSE 4200

#Installing angular/cli package seperately to ensure that is installed. (ng command)
RUN npm install -g @angular/cli

#Install all the dependencies globally mentioned in the package.json file.
RUN npm install

#Setting up the entrypoint command, as it will be executed after the container is started.
CMD ng serve --host 0.0.0.0