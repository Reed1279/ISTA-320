# Course: ISTA-320
## Lesson Plan: 05
### Name: Tyler Reed
#### Date: 04 December 2017

1. Describe the three concerns that the Model-View-ViewModel design pattern addresses.

	-
2. Describe in detail how the MVVM design pattern works.

	-
3. Describe in detail how data binding works with respect to controls and models.

	-
4. Describe the three methods that the ICommand interface dfines. What is the purpose of each method?

	-CanExecute This method returns a Boolean value indicating whether the command can run./ Execute This method runs when the command is invoked./ CanExecuteChanged This event is triggered when the state of the ViewModel changes.
5. What is a data context? Why do we need a data context? What does it do?

	-You set the DataContext property of the form, so the same data binding automatically applies to all the controls on the form. You can also set the DataContext property for individual controls if you need to bind specific controls to different objects.