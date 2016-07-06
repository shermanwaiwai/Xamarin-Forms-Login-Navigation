**Xamarin Forms Login Navigation**
======
 I have had some trouble understanding navigation in Xamarin Forms. Part of the reason is that I just never really sat down to take the time, but the one scenario that seemed tricky to me was the idea of a login screen.   How would you take a user to a Login screen, then after successfully logging in, take them to the home screen, and then not letting them navigate back to the Login screen?

You can't use Login screen as a Navigation Page because the back button would appear in subsequent screens.  So, after doing some research, one solution I came up with was to actually go directly to my Home screen as a NavigationPage. When the user reaches the Home screen, they will be immediately redirected to the Login screen if not already logged in.  The Login screen would be pushed modally, and after successful login, would just be popped off of the stack taking the user to the Home screen and normal engagement.  If the user wanted to logout for instance, the Login screen could be pushed modally again, and the idea continues.  

All in all, this sample follows that idea to allow the user to login, then navigate to the home screen.  You can see the flow in the screenshots below.

## **How to Use**

Clone the sample with the following command.

```$ git clone https://github.com/jamesqquick/Xamarin-Forms-Login-Navigation.git ```

Then, open up the solution file in either Visual Studio or Xamarin Studio to run the sample.

## **Technology**

 1. Xamarin
 2. Xamarin Forms
 2. Visual Studio
 3. Xamarin Studio
 4. Android, IOS, and Windows

## **Screenshots**


Login               |  Home               |   Settings
:-------------------------:|:-------------------------:|:-------------------------:
![](https://raw.githubusercontent.com/jamesqquick/Xamarin-Forms-Login-Navigation/master/Screenshots/Screen%20Shot%202016-07-06%20at%201.25.04%20PM.png)  |  ![](https://raw.githubusercontent.com/jamesqquick/Xamarin-Forms-Login-Navigation/master/Screenshots/Screen%20Shot%202016-07-06%20at%201.25.14%20PM.png)  |  ![ ](https://raw.githubusercontent.com/jamesqquick/Xamarin-Forms-Login-Navigation/master/Screenshots/Screen%20Shot%202016-07-06%20at%201.25.17%20PM.png) 
 

## **Contact** ##
* **Website: http://jamesqquick.com**
* **Twitter: [@jamesqquick](https:**//**twitter.com/jamesqquick)**
