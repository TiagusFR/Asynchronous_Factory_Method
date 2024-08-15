Asynchronous Factory Method simple example. In this first approach is by convention.

Constructor's body is syncrhonous. A constructor always return the type of the constructed object. Can't return Task or Task<T>. But, if needed, it can be initialized in asynchronous way.

Foo: is set already as an async Task 

Program: then the client will recognize this member and'll remember to call it.
