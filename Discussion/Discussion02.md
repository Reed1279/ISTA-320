# Course: ISTA-320
## Lesson Plan: 02
### Name: Tyler Reed
#### Date: 23 October 2017

1. What is an asynchronous method? When the book talks about a contract, what is the contract and
who is it with?

	-A method that does not block the current thread on which it starts to run./ When an application invokes an asynchronous method, an implied contract expects the method to return control to the calling environment quite quickly and to perform its work on a separate thread.
1. What can be the problem with decomposing a series of discrete method calls into a set of tasks, such
as we saw in chapter 23?

	-The user interface can become unresponsive until this method completes.
1. What can be the problem with decomposing a series of discrete method calls into a set of continuations?
When does the last continuation \complete" as compared to the previous continuations? What problem
might this cause?

	-The Task object that instigated the continuation is passed as a parameter to a continuation method./ The issue with this second point
is that although the Start method initiates a Task, it does not wait for it to complete, so the message appears while the processing is being performed rather than when it has finished.
1. What might be the problem with implementing te previous solution as a continuation passing a dele-
gate? What would be your interpretation with this error message: \The application called an interface
that was marshaled for a different thread."?

	-It blocks the thread executing the slowMethod method and obviates the purpose of using a Task in the first place.
1. The book suggests a solution using a continuation delegate calling another continuation delegate via
an anonymous function. What does the book ientify as a problem with this suggested solution?

	-Generates a System.Exception exception
1. What does the async modiffer do? What does the await operator do?

	-Indicates that a method contains functionality that can be run
asynchronously.
1. What is an awaitable object? Be speciffc.

	-The await operator specifies the points at which this asynchronous functionality should be
performed.  It specifies a point at which the C# compiler can split the code into a continuation.
1. In a method deffnition, how do you create and run a Task and return a reference to the Task? What
is the type of such a method? What does the method return?

	-GenerateResult method./ The MessageDialog object displays the message and waits for the user to click the Close button that appears as part of this dialog box.
1. How do you define method calls in the implementation of an async method? Speciffcally, you must
define a task, you must run the task, you must implement the task, and you must await the task.
What is the syntax for doing this?

	-private async Task<int> calculateValueAsync(...)
{
// Invoke calculateValue using a Task
Task<int> generateResultTask = Task.Run(() => calculateValue(...));
await generateResultTask;
return generateResultTask.Result;
}
1. What is the difference between decomposing a series of method calls that do not return values, and
a series of method calls that return values? What is the Result property of a method that returns a
value? How do you use the await operator in this circumstance?

	-Asynchronous methods are based on tasks, and the await operator specifies the points at which a task can be used to perform asynchronous processing./ If you need to access asynchronous functionality exposed by types developed in earlier versions of the .NET Framework.
1. What is the difference between the await operator and the Wait method?

	-The Async and Await keywords in Visual Basic and the async and await keywords in C# are the heart of async programming. By using those two keywords, you can use resources in the .NET Framework or the Windows Runtime to create an asynchronous method almost as easily as you create a synchronous method. Asynchronous methods that you define by using async and await are referred to as async methods.