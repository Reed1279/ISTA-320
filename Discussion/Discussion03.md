# Course: ISTA-320
## Lesson Plan: 03
### Name: Tyler Reed
#### Date: 30 October 2017

1. What are the two scenarios in which you can use PLINQ to speed up operations? Why does using
PLINQ in these scenarios speed up processing?

	-Parallelization & Sequential modes./ It executes the query delegates in parallel on multi-core computers. 
1. How doesAsParallel qualify as an extension method? First, explain what an extension method is and
how you define entension methods, and them explain why AsParallel qualifies as an extension method.

	-An extension method is a method added to an object after the original object was compiled. The modified object is often a class, a prototype or a type./ The AsParallel method returns a ParallelQuery object that acts in a similar manner to the original enumerable object, except that it provides parallel implementations of many of the LINQ operators, such as join and where. 
1. How do you cancel a PLINQ query before it finishes? Be specific with respect to the variables and
methods used for the cancellation operation, and how the variables abd methods are used.

	-You specify a CancellationToken object from a CancellationTokenSource and use the WithCancellation extension method of the ParallelQuery.
1. Why is it important to synchronize concurrent access to a server? Give an example of a specific
condition that will cause an error in your application if concurrent access is not synchronized.

	-2 transactions that need the same lock begin at once. They both begin their transactions "simultaneously" before either obtains the lock or modifies any rows. Their snapshots look exactly the same because no data has been modified yet. Next, one transaction obtains the lock and proceeds to make its changes while the other is blocked. This transaction commits fine because it was first and so the snapshot it refers to still matches the data in memory. The other transaction obtains the lock now, but it's snapshot is invalid (however it doesn't know this yet). It proceeds to execute and at the end realizes its snapshot is invalid so it throws you an error.
1. What does the lock statement do?

	-Attempts to obtain a mutual-exclusion lock over the specified object, and it blocks if this same object is currently locked by another thread.
1. This is not in the book. Define mutex, define semaphore, and explain the diference between them.

	-A program object that allows multiple program threads to share the same resource, such as file access, but not simultaneously./ A variable or abstract data type used to control access to a common resource by multiple processes in a concurrent system such as a multiprogramming operating system./ That a semaphore is the structure proposed by Hoare many years ago as a general mechanism structure whereas a mutex is a special case of a mutual exclusion lock. You can make a mutex from a semaphore but not a semaphore from a mutex.
1. What does it mean to say that some collection classes are not thread safe? Explain how not being
thread safe may lead one of these collection classes to produce a malfunction in the program.

	-If a piece of code fails to function correctly during simultaneous execution by multiple threads./ It must satisfy the need for multiple threads to access the same shared data, and the need for a shared piece of data to be accessed by only one thread at any given time.
1. Explain how thread safe collection classes are made thread safe.

	-A piece of code is thread-safe if it functions correctly during simultaneous execution by multiple threads.
1. Why are thread safe cclasses slower than non-thread safe classes? Be specific.

	-Adding thread safety to the methods in a collection class imposes additional run-time overhead, so these classes are not as fast as the regular collection classes. You need to keep this fact in mind when deciding whether to parallelize a set of operations that requires access to a shared collection.