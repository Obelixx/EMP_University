- Allways think about:
	- testability
	- reusability
	- performance
	- multithreading (Tiers/Interfaces/models etc…)
	- Chrome, Firefox, IE11, Safari - check them
	- Put business logic to models. (about MVC and SoC)
	- Data validations.
	- Where to put some extension method(s).
	

- Tasks:
	- [x] Draw initial thoughts on SQL Diagram.
	- [x] Draw/think about "testability, reusability, performance, multithreading (Tiers/Interfaces/models etc…)"
	- [x] Create new MVC Project with default Authentication.
	- [x] Create git repository.
	- [x] Move database related code to separate project.
	- [x] Write database models.
	- [x] (Add migrations.) They are on by default.
	- [x] Create methods to fill demo data.
	- [ ] Add "service" methods that provide data (for example: Courses lists with paging).
	- [ ] A bit front-end - 4 tabs, two lists.


- Check this:
	- Error handling. (no unhanded exceptions)
	
	
- Assumptions:
	- Only students log in. No Roles - preventing more complexity.
	- Document your code - where necessary.
	- Use latest .Net Core MVC -> .Net 5.0
	- Tiers in brackets - it is important. Create many tiers. Consider clean architecture.
	- No "Domain" project needed, or maybe a slim one.
	- Demo data users: 
		- 5 users with user/pass format:
		- test{0}@example.com / Pass@word{0}
		- For Example: test1@example.com / Pass@word1
	
	