/*========== INHERITANCE (Topic 8) ==========

Definition:
Inheritance allows a class (child) to reuse fields and methods from another class (parent).

Syntax:
class ChildClass : ParentClass { ... }

Key points:
- The child class automatically gets all public/protected members of the parent.
- Parent class = Base class, Super class.
- Child class = Derived class, Sub class.
- No code duplication: common things go in parent.

Real-world example:
Person → name, age
Student is a Person → adds marks
Teacher is a Person → adds salary

Benefits:
1. Reusability
2. Logical hierarchy
3. Easier maintenance

In C#:
- A class can inherit from only ONE parent (single inheritance).
- But a parent can have many children.
- The parent does NOT know about its children.
