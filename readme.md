# Welcome to ClioOrg!

This repository seeks to create an easy org chart for Clio.
When run the organization data will be printed in json on the site.


# Methods
In this sample repo I have chosen to use InMemory data, which is being seeded on initial run. This makes it easy and fast to prototype and preserve data state, and I don't have to setup a database.

There's 4 main methods here:

## Get full organization overview
Go to [Organizations/GetEntireOrg](http://localhost:56052/organizations/getentireorg) when the code has been build in visual studio. You will see the enitre organization, in a flat json structure

## Get nodes of a given parent
[GetChildNodesFrom/4](http://localhost:56052/organizations/GetChildNodesFrom/4) 
This will give you all the people under the person with Id = 4

## Add node to any level
When adding a node to the dataset we will need to have PostMan installed
1. Open postman and press + for starting a new request.
2. Paste in http://localhost:56052/organizations and change the type from Get to Post
3. Press on the Body tab and select the raw radiobutton:
4. Paste in:
`{"id":100,"name":"Christian Mortensen","parent":4,"orgHeight":3,"title":7,"description":"dotnet"}`
5. Press send.
6. Go back to your browser and point to [Organizations/GetEntireOrg](http://localhost:56052/organizations/getentireorg) again and see the new entry. 

## Change parent level of given node

When changing a nodes parent we will need to have PostMan installed
1. Open postman and press + for starting a new request.
2. Paste in http://localhost:56052/organizations/changeparent and change the type from Get to Post
3. Press on the Body tab and select the raw radiobutton:
4. Paste in:
`{"node":100,"toparent":3}`
This will change the node we created in the previous paragraph to parent 3.
5. Press send.
6. Go back to your browser and refresh [Organizations/GetEntireOrg](http://localhost:56052/organizations/getentireorg) again and see the updated entry. 
