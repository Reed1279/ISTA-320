# Course: ISTA-320
## Lesson Plan: 04
### Name: Tyler Reed
#### Date: 01 December 2017

1. What is the purpose of the Universal Windows Platform? What was the name of the predecessor to
UWP?

	-To help develop universal apps that run on both Windows 10 and Windows 10 Mobile without the need to be re-written for each./ XAML
1. Describe in detail how the lifetime of a UWP app differs from a traditional desktop application.

	-The lifetime of a UWP app is somewhat different from that of a traditional desktop app. You should design apps that can run on devices such as smartphones to suspend execution when the user switches focus to another app and then to resume running when the focus returns. This approach can help to conserve resources and battery life on a constrained device. Windows might actually decide to close a suspended app if it determines that it needs to release system resources such as memory. When the app next runs, it should be able to resume where it left off. This means that you need to be prepared to manage app state information in your code, save it to hard disk, and restore it at the appropriate juncture.
1. Describe two ways you can set and modify the properties of controls.

	-XAML Pain and the properties windown
1. Describe the two layout schemes of UWP apps that we constructed in class.

	-Tubular and Grid layouts
1. Describe three ways you can use the Visual State Manager to adapt the layout of UWP apps

	-You can create several versions of the MainPage.xaml file, one for each device family./ You can use the Visual State Manager to modify the layout of the page at run time./ You can use the Visual State Manager to switch between views based on the height and width of the window.
1. Describe how you can modify multiple properties of multiple controls with one document. How do you
connect this modfication document with your UWP application?

	-data binding/ x:bind 