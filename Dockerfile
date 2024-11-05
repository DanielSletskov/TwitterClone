FROM node:16
WORKDIR /app
COPY paclage* .json ./
RUN npm install
COPY . .
EXPOSE 3000
CMD [ "npm", " start" ]
