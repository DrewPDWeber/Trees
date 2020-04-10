# TreeFriend

- Inspired by The Trillion Tree Campaign, TreeFriend is a gaming concept that aims to facilitate a relationship between the players and the trees that they live with and/or have planted themselves. This is done by having the players catalogue trees that are not in the database, to disseminate information about cataloged trees to players, and to assist the players to track the development of trees, especially those that they have planted, over time. The hope is not only to encourage players to plant trees themselves and to educate players about their environment but also to develop a friendship with trees special to them and a custodial kind of attitude towards the maintenance of trees.


# Structure
Assets:file_folder:
 - Scripts:file_folder: : Holds majority of our code
    - GeoTree : Defines the stucture of the Tree
    - Singleton : Allows for only one instance of a class
    - Tree : holds the Tree imfomation that is contained on the map
    - TreeFactory : Populates the map with the trees
    - TreeTypes : Contains lists of tree types and names for testing use
  - MongoDB :file_folder:
    - MongoDBManager : Handles connection between client and MongoDB
  - Plugins:file_folder: : Holds nessisary dll files for MongoDB
  - Depricated:file_folder: : Code that is no longer useful

#MongoDB
Free database used from  [MongoDB Cloud Atlas](https://www.mongodb.com/cloud/atlas/ "MongoDB Cloud Atlas")
