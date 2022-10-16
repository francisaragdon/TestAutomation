Feature: AddtoCart

User Clicks on Add to Cart button 


Scenario: User adds a product to cart
	Given User is in the product details page
	When User clicks on add to cart
	Then product is added to cart
