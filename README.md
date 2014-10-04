FlowPost - early pre-alpha(basically nonexistent)
========

1. Things to research and add to project and/or modify:
  a.	Fluent validation for Entities. Reasons for this include:
  			1.	Fluent makes entities code less obtrusive (preety obvious once you take a look at some Data Annotations ridden code)
  			2.	From what I've gathered unit testing is much more easier to maintain, rather than with Data Annotations
  			3.	Conditional validation on multiple properties or on just one yields much better results in terms of time/frustraion
  				(using Data Annotations validation in the past has already proven this)
  		
  b.	3-tier architecture
  			ASP.NET MVC for Client Presentation Layer
  			Business Layer based on Repository pattern, 
  			Data Access Layer built on top of Entity Framework.
  			
  			I've decided to not structure the application using more sophisticated architecture(such as 4-Tier complete) and omitted 
  			Persistance Layer for two reasons:
  				1.	On this level of my progress it seems quite intimidating to build it on my own.
  				2.	I do not forsee (... yet ...) any other application of this project rather than a web-page.
  					Should I ever consider creating a mobile applicability of this project, the project restructuring to 4-tier might be
  					imminent.
  					
  c.	Integration of ASP.NET Identity 2.0 into existing Entities schema
  			Already thouroughly researched.
  			Got the know-how but what is missing at this point is elbow grease.
    
