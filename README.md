# TreeFriend

> Inspired by The Trillion Tree Campaign, TreeFriend is a gaming concept that aims to facilitate a relationship between the players and the trees that they live with and/or have planted themselves. This is done by having the players catalogue trees that are not in the database, to disseminate information about cataloged trees to players, and to assist the players to track the development of trees, especially those that they have planted, over time. The hope is not only to encourage players to plant trees themselves and to educate players about their environment but also to develop a friendship with trees special to them and a custodial kind of attitude towards the maintenance of trees.

# Structure

Assets:file_folder:

- Animator:file_folder:
  - Fade_in_Animation
  - Fade_out : Animation for fade out to menu scene
  - Fade_outAcc : Animation for fade out to personal account scene
  - Fade_outDC : Animation for fade out to DailyChallenge scene
  - Fade_outMap : Animation for fade out to world scene
  - Fade_outTree : Animation for fade out to Tree scene
  - LevelChanger (script) : provides scene change methods 
  - LevelChanger (object)
 
 - Scripts:file_folder: : Holds majority of our code
    - GeoTree : Defines the stucture of the Tree
    - Singleton : Allows for only one instance of a class
    - Tree : holds the Tree imfomation that is contained on the map
    - TreeFactory : Populates the map with the trees
    - TreeTypes : Contains lists of tree types and names for testing use
  - MongoDB :file_folder:
    - MongoDBManager : Handles connection between client and MongoDB
  - Tree :file_folder:
    - GeoTree : Defines the stucture of the Tree
    - Singleton : Allows for only one instance of a class
    - Tree : holds the Tree imfomation that is contained on the map
    - TreeFactory : Populates the map with the trees
    - TreeTypes : Contains lists of tree types and names for testing use
  - SceneNav :file_folder:
    - Dalay : Provides a delay
    - toDailyChallenge : Move to a different scene. Trigger transition fade sequence
    - toMainMap : Move to a different scene. Trigger transition fade sequence
    - toMainMenu : Move to a different scene. Trigger transition fade sequence
    - toPersonalAccount : Move to a different scene. Trigger transition fade sequence
    - toTree : Move to a different scene. Trigger transition fade sequence
  - Plugins:file_folder: : Holds nessisary dll files for MongoDB
  - Depricated:file_folder: : Code that is no longer useful


## Credits 
- [Mapbox](https://www.mongodb.com/cloud/atlas/ "Mapbox") for location data and map SDK
- [DevilsGarage](https://www.devilsgarage.com "DevilsGarage") for Low-Poly-Pixel-Styled-RPG Game Asset Pack which was used for its trees and player assets.
- [Blue Cartoon GUI Skin](https://assetstore.unity.com/packages/2d/gui/blue-cartoon-gui-skin-19535m "Blue Cartoon GUI Skin") For some GUI elements such as buttons.
- [MongoDB Cloud Atlas](https://www.mongodb.com/cloud/atlas/ "MongoDB Cloud Atlas") for there free database hosting aswell as there C# wrapper files.
- [One Tree Planted](https://onetreeplanted.org/ "MongoDB Cloud Atlas") for there logo for use for donations.

## Original Authors
 ## Project coordinator 
 - Aras Balali Moghaddam
 ## Development Team
- Michael O’Neill
- Drew Weber
- Rui Wang

## Donations 

 We do not ask for personal donations but you can help us make a greener Canada! 
Donate to contibute to plant trees in British Columbia 
<p align="center">
  <a href="https://onetreeplanted.org/collections/canada/products/british-columbia-forests">
    <img src="https://raw.githubusercontent.com/DrewPDWeber/site/master/imgs/opensource/onetreeplanted.png" alt="OneTreePlanted" width="80" height="80">
  </a>
 

# Know issues
- [ ] Mapbox map elements only precise up to 5 decimal places, making close trees stack together

# License
[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)
