# Updated Designs Log for CW2 Project Implementation

*For car purchase web app*

**Project Background Improvements** (Arbaaz): Added clarification that 6 Audi models would be sold on the website, and explained why this brand was chosen. The fact that new cars would only be sold on the website was specified, and not used ones.

**Feature List Improvements** (Mohammed):
Changed feature 12 so now there are two features for customer and staff, customer can see and use discount codes as well as staff and, staff can create the codes when necessary. 



**Use Case Diagram Improvements** (Brian):




**ERD Diagram Improvements** (Arbaaz): For the changes to the ERD diagram, the Login entity was changed to User, where it stores information such as email and password. Various varchar character limits were reduced from 255 to 64 or less depending on the information represented. The IsStaff bit attribute from the Staff entity was removed. The relationship between staff and Person was changed to 1..1. An Address entity replaced the DeliveryAddress entity, and has different types of addresses (e.g., home, billing, delivery) was added, and home address and postcode were removed from the Person Entity. Date of Delivery and Delivery tracking attributes were moved to the Order entity from the previous DeliveryAddress entity. We had trouble with changing the multiplicity relationships with some entities that were not reflected on this updates ERD diagram - realistically many cars would be added to many wishlists, a person may have multiple addresses, and many cars could be added to one order item.

**Class Diagram Improvements** (Arbaaz): The updated class diagram in hindsight reflects some values changed for the ERD diagram, but some attributes are outdated and the DeliveryAddress entity name did not convert properly to Address class as I (Arbaaz) was trying to connect Staff and Person with inheritance, which produced incorrect entity changes in the ERD diagram, and I had to revert to the older version for stability.


