# Course: ISTA-320
## Lesson Plan: 01
### Name: Tyler Reed
#### Date: 17 October 2017

1. List two reasons for multitasking, and explain the rationale for them.

	-To improve responsivness and scalability.  A long-running operation may involve tasks that do not
require processor time.  If an operation is CPU bound, you can improve scalability by making
efficient use of the processing resources available and using these resources to reduce the
time required to execute the operation.
2. Explain Moore's law. What does Moore's law have to do with multitasking?

	-Cramming More Components onto Integrated Circuits.  This led to the ability to pass data between them
more quickly. 
3. In UWP, what namespace is used as the container for the multitasking methods?

	-Multithreading? Windows Runtime (WinRT)
4. What is the difference between tasks and threads? Explain.

	-The Task provides a powerful abstraction for threading.  Distinguishes between the degree of parallelization in an application (the tasks) and the units of parallelization (the threads).
5. What is the ThreadPool?

	-Implements a number of optimizations and uses a work-stealing algorithm to ensure that threads are scheduled efficiently.
6. What parameters does the Task() constructor take?

	-Action<object> parameter
7. How do you start a thread?

	-Create an instance of either the ThreadStart delegate or the ParameterizedThreadStart delegate, and pass that into the constructor for Thread.
8. What is the difference between the Start() and Run() methods?

	-The Start method is overloaded, and you can optionally specify a TaskCreationOptions object to provide hints about how to schedule and run the task.  The Run method takes an Action delegate specifying the operation to perform (like the Task constructor), but starts the task running immediately.
9. What is the difference between creating independent tasks with Tasks and paralleliztion with Parallel?
Explain.

	-The Task parallelization reduces the time taken for the application to run by spreading the computations across multiple processor cores.
10. Explain how manual cancellation works using a cancellation token.

	-A cancellation token is a structure that represents a request to cancel one or more tasks.  An application that wants to cancel the task sets the Boolean IsCancellationRequested property of this parameter to true. The method running in the task can query this property at various points  during its processing.