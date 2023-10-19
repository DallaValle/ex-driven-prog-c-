# Why Exception driven programming is an anti-pattern

## 1 Mathematical point of view

A function y=f(x) should be pure.

In mathematics and computer science, a function is considered "pure" if it satisfies the properties of a mathematical function. A pure function, also known as a deterministic function, has two main characteristics:

Deterministic: For a given input, a pure function will always produce the same output, regardless of the context in which it is called or the number of times it is called. This property ensures predictability and reliability in the behavior of the function.

No Side Effects: A pure function does not have any side effects, meaning it does not modify any external state or variables outside its scope. It operates only on its input parameters and returns a value. This property makes pure functions easier to understand, test, and reason about because they don't have unexpected interactions with other parts of a program.

Ensuring that functions are pure is crucial in functional programming paradigms. Pure functions facilitate referential transparency, which means that a function call can be replaced with its resulting value without changing the program's behavior. This property enables optimizations, caching, and reasoning about the code's behavior, making it easier to maintain and debug.

By adhering to these principles and designing functions to be pure, programmers can create more reliable, predictable, and maintainable software systems.

## 2 Readability point of view

Obscured Control Flow: Exceptions can obscure the normal flow of control within a program. When exceptions are used for flow control, it becomes challenging to understand the logical path of the program. This can make the code less readable and more difficult to follow, especially for someone new to the codebase.

Implicitness: Exception handling can hide errors and exceptional cases implicitly. When errors are handled through exceptions, it might not be immediately obvious what kind of errors can occur and where. Explicit error handling through return values or other mechanisms can make error conditions more explicit and easier to understand.

Debugging Complexity: When exceptions are thrown in various parts of the code, tracking down the origin of the exception and understanding the context in which it was thrown can be challenging. This complexity can make debugging more difficult and time-consuming.

Maintenance Challenges: Code that relies heavily on exceptions for error handling can be difficult to maintain, especially as the codebase grows. Modifying parts of the code can inadvertently break exception handling logic elsewhere, leading to subtle bugs that are hard to identify and fix.

## 3 Performance

Exceptions can be computationally expensive. Throwing and catching exceptions involves additional overhead compared to other error-handling mechanisms. In performance-critical applications, this overhead can be a concern.

Please see [benchmark output](BenchmarkDotNet.Artifacts/results/ex_driven_prog.ResponseHandler-report-github.md)
