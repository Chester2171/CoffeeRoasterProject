## <div align="center">Night Sights Coffee Roasters</div>
## <div align="center">![Night Sights Coffee Roasters](https://github.com/Chester2171/CoffeeRoasterProject/blob/master/Wireframe/Night%20Sights%20logo%202.PNG)</div>

## [Table of Contents](#table-of-contents)
1) [Inspiration](#inspiration)
2) [Concept](#concept)
3) [Wire-Frames (DRAFT)](#wire-frames)
4) [Database Diagram](#database-diagram)
5) [Entity Relationship Diagram (ERD)](#entity-relationship-diagram)
6) [User Stories](#user-stories)
7) [Use Cases](#use-cases)
8) [Use Case Diagram](#use-case-diagram)
9) [Requirements](#requirements)
10) [Requirements Table](#requirements-table)
11) [Test Case Table](#test-case-table)


## <div align="center">Inspiration</div>
[(back to top)](#table-of-contents)

The inspiration for this project was born while my wife and I did a local coffee crawl in San Diego and had trouble finding some of the roasters on the coffee map. The websites we found for several of the smaller very popular coffee roasters were unhelpful and lacked the ability to order their roasted coffee beans. I hope to create an application that could be used by a local coffee roasters to reach a larger audience and give the ability for those who cannot phyiscally visit thier locations the ability to order from the roasters.

## <div align="center">Concept</div>
[(back to top)](#table-of-contents)

The idea of this project is to create a simple, user friendly tool to order locally roasted coffee. I want this app to be extremely easy to and provide the user with a feeling of broswing through coffee at their local coffee shop. I want it to be aesthetically appealing and functional.

## <div align="center">Wire-Frames</div>
[(back to top)](#table-of-contents)

**These are only drafts**

The Login Page would be the first thing that a user is presented with. The user would have the option to enter their User Name and Password, have the option to select forgot password, and sign up for an acount if they don't already have one.

![Login Page](https://github.com/Chester2171/CoffeeRoasterProject/blob/master/Wireframe/LoginPage.PNG)

Once logged in the user would be directed to the Featured page which will have the featured roast for that month. Each featured monthly roast will have a picture of the bag of beans, a short description with the size and price, and the ability to add the monthly roast to the cart. underneath the monthly roast there will be a scroller of the coffees for the previous twelve months so you can see which coffees have been featured moving backword.

![Featured Page](https://github.com/Chester2171/CoffeeRoasterProject/blob/master/Wireframe/FeaturedLink.PNG)

If the user presses one of the links in the top menu they will be directed to that page. I only made a wireframe for one of the links, as each one of the links will direct the user to a similar page just with different products depending on the link that they clicked. The user simiply scrolls through the list of coffess like Instagram and clicks the picture to bring the user to a page similar to the Featured Page where there is a discription of the coffee and the ability to order that particualr roast.

![Espresso Page](https://github.com/Chester2171/CoffeeRoasterProject/blob/master/Wireframe/EspressoLinks.PNG)

Finally once the user has made there selections they can go to the cart and checkout. Once they click the checkout button they will be directed to a third party site that would finish the payment and send an email to both the roastery and the customer with the details and shipping information.

![Checkout Page](https://github.com/Chester2171/CoffeeRoasterProject/blob/master/Wireframe/CheckoutPage.PNG)

## <div align="center">Database Diagram</div>
[(back to top)](#table-of-contents)


**Initial database diagram draft**

![Database Diagram](https://github.com/Chester2171/CoffeeRoasterProject/blob/master/Wireframe/DatabaseDiagram.PNG)


## <div align="center">Entity Relationship Diagram</div>
[(back to top)](#table-of-contents)


**Initial Draft of the Entity Relationship Diagram.**

![ERD](https://github.com/Chester2171/CoffeeRoasterProject/blob/master/Wireframe/Cody%20Chester%20Project%204%20Snip.PNG)

## <div align="center">User Stories</div>
[(back to top)](#table-of-contents)

**1.** As a user, I need to login or register for an account.

**2.** As a user, I need to input the coffee beans I would like to purchase in the shopping cart.

**3.** As a user, I need to see the items in my cart along with the total price including taxes and shipping.

**4.** As the employee, I need to be able to see the orders associated with the customer login.

**5.** As an administrator, I need to be able to see the current on/hand inventories and have the ability to prevent users from purchasing coffee that is currently at zero on/hand.

## <div align="center">Use Cases</div>
[(back to top)](#table-of-contents)

**1.** Given the user is on the login page, when the user inputs their Username and Password, they are directed to the Featured page.

**2.** Given the user is on the Featured tab, when the user selects a link to any of the roasted coffee bean variants, they are directed to that page. 

**3.** Given that the user has selected a roasted coffee beans, when they select the roasted coffee beans, they can see a description of the coffee the size in ounces and the price of that particular roast.

**4.** Given that the user has added the roasted coffee beans to their cart, when they checkout, they can see the quantity of roasted coffee beans selected, the size and the price, and their total including taxes and shipping. 

## <div align="center">Use Case Diagram</div>
[(back to top)](#table-of-contents)

![Use Case Diagram](https://github.com/Chester2171/CoffeeRoasterProject/blob/master/Wireframe/Diagram.PNG)


## <div align="center">Requirements</div>
[(back to top)](#table-of-contents)

* 1.0\. System shall request users to log in to enter the website.
   * 1.1.0\. System shall verify users input for Username and Password.
    * 1.1.1\. System shall display error message if the Username and Password does not match the database. 
    * 1.1.2\. System shall allow user to reset their password through their email if they have forgotten.

* 2.0\. User shall be able to swipe through the featured roasted coffee beans on the featured page.
   * 2.1.0\. User shall be able to scroll through all featured coffee beans from the last year.
   * 2.2.0\. User shall be able to select the featured roast from the featured page and add it to their cart.

* 3.0\. User shall be able to select the links to each type of roasted coffee beans offered.
   * 3.1.0\. User shall be able to select individual roasts from the available coffees and see a description as well as the size and price of each roast in each section.

* 4.0\. User shall be able to add coffee roasts to their cart.
   * 4.1.0\. User shall be able to select the cart while they are logged in and see their current selections.
   * 4.2.0\. User shall be able to see their previous orders while logged in and on the cart page.
   * 4.3.0\. User shall be able to leave the application and upon relogging in their cart will still be the same as when they left the application.

## <div align="center">Requirements Table</div>
[(back to top)](#table-of-contents)

| Requirement ID 	| Requirement Description                                                                                                                                      	| Test Method   	| Test ID 	|
|----------------	|--------------------------------------------------------------------------------------------------------------------------------------------------------------	|---------------	|---------	|
| 1.0            	| System shall request users log in to enter the website                                                                                                       	| Inspection    	| TC001   	|
| 1.1.0          	| System shall verify users input for Username and Password.                                                                                                   	| Test          	| TC001   	|
| 1.1.1          	| System shall display error message if the Username and Password does not match the database.                                                                 	| Demonstration 	| TC002   	|
| 1.1.2          	| System shall allow user to reset their password through their email if they have forgotten.                                                                  	| Demonstration 	| TC002   	|
| 2.0            	| User shall be able to swipe through the featured roasted coffee beans on the featured page.                                                                  	| Demonstration 	| TC003   	|
| 2.1.0          	| User shall be able to scroll through all featured coffee beans from the last year.                                                                           	| Demonstration 	| TC003   	|
| 2.2.0          	| User shall be able to select the featured roast from the featured page and add it to their cart.                                                             	| Demonstration 	| TC003   	|
| 3.0            	| User shall be able to select the links to each type of roasted coffee beans offered.                                                                         	| Inspection    	| TC004   	|
| 3.1.0          	| User shall be able to select individual roasts from the available coffees and see a description as well as the size and price of each roast in each section. 	| Inspection    	| TC004   	|
| 4.0            	| User shall be able to add coffee roasts to their cart.                                                                                                       	| Demonstration 	| TC005   	|
| 4.1.0          	| User shall be able to select the cart while they are logged in and see their current selections.                                                             	| Test          	| TC006   	|
| 4.2.0          	| User shall be able to see their previous orders while logged in and on the cart page.                                                                        	| Inspection    	| TC006   	|
| 4.3.0          	| User shall be able to leave the application and upon relogging in their cart will still be the same as when they left the application.                       	| Inspection    	| TC006   	|

## <div align="center">Test Case Table</div>
[(back to top)](#table-of-contents)

| Test ID 	| Req. ID            	| Test Procedure                                                                                                 	| Current Status 	| Time Stamp 	|
|---------	|--------------------	|----------------------------------------------------------------------------------------------------------------	|----------------	|------------	|
| TC001   	| 1.0, 1.1.0         	| System shall request and verify username and password for log in                                               	| Inspection     	|            	|
| TC002   	| 1.1.1, 1.1.2       	| Display error message if the username and password in incorrect, send an email to reset username and password. 	| Inspection     	|            	|
| TC003   	| 2.0, 2.1.0 2.2.0   	| User should be able to scroll through Featured Coffee Roasts and  add them to their cart.                      	| Inspection     	|            	|
| TC004   	| 3.0, 3.1.0         	| The links should take the user to the proper link and the link to coffees should display the description.      	| Inspection     	|            	|
| TC005   	| 4.0                	| User should be able to select roasts and add it to their cart.                                                 	| Inspection     	|            	|
| TC006   	| 4.1.0, 4.2.0 4.3.0 	| Users car should be reflective of their selections including after they leave the website and return.          	| Inspection     	|            	|
