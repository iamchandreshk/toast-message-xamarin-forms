# Toast-Message-Xamarin-Forms

DependencyService in Xamarin.Forms: Step by Step guidance

Xamarin is cross-platform mobile application development tool. Xamarin has two types of mobile application development category, Xamarin Native and Xamarin.Forms. Both are having pros and cons. In this blog, we are going to introduce how to use DependencyService in Xamarin.Forms.

DependencyService is used to interact with the Native Android, iPhone and Windows Phone features in Xamarin.Forms. With the help of DependencyService, we can use native features like Toast Message in Android, Play a music, Background Activity etc.

In this example, we are going to populate toast notification using Dependency Service.

Step 1: Create new Xamarin.Forms (Portable) project.

Step 2: Create Interface in a Portable project and declare a name of a method that you want to use.

Step 3: Register a blank constructor with DependencyService in your Android, iPhone and Windows Class.

Step 4: Create a blank constructor that will be used by DependencyService.

Step 5: Assign Interface in Native code.

Step 6: Write a code that you want to perform in Native (In my case, I want to use Toast Notification.)

Step 7: Call DependencyService in your Portable code (In my case, where I want Toast Notification)

It’s done!!
