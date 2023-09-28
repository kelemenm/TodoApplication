Project Plan:

TODO1: Create Todo domain in seperate class library project
    - Create TodoApplication.Domain project
    - Create Entity base class
        - Guid Id
        - DateTime Created
    -Create PriorityLevel enum
        - Normal
        - Important
        - Critical
    - Create Todo class
        - required string Title
        - string? Descreption
        - PriorityLevel Priority
    - Create User class
        - required string Email
