# TransparentModal
How to do a transparent modal in Xamarin.iOS


![Alt Text](https://github.com/kraigspear/TransparentModal/blob/master/TransparentBackground.gif)

### Steps

1. When presenting a UIViewController the ModalPresentationStyle is set to UIModalPresentationStyle.OverCurrentContext

```c#

 partial void ShowDetailAction(UIButton sender)
 {
    var detailViewController = Storyboard.InstantiateViewController("DetailView");
   //This is what makes presenting over another VC possible. 
   detailViewController.ModalPresentationStyle = UIModalPresentationStyle.OverCurrentContext;
   PresentViewController(detailViewController, true, null);
 }
 
```

https://developer.apple.com/documentation/uikit/uiviewcontroller/1621355-modalpresentationstyle

2. Set the background of the modal view to be semi transparent / Set the View Opaque property to false

```c#
public override void ViewDidLoad()
{
    base.ViewDidLoad();
    View.BackgroundColor = UIColor.Black.ColorWithAlpha(0.5f);
    View.Opaque = false;
}
```


3. Include another non-transparent view, or embedded a container UIViewController to hold the focused content
https://developer.apple.com/library/content/featuredarticles/ViewControllerPGforiPhoneOS/ImplementingaContainerViewController.html

Keep in mind that adds a little complexity and may or may not be needed. It is not shown in this example.

4. Add a tap gesture recognizer to close the view.
* Go to the toolbox select Tap Gesture
* Drag it to the view
* Add an event handler
* Close the ModalViewController using the DismissViewController method

```c#
partial void TapAction(UITapGestureRecognizer sender)
{
    DismissViewController(true, null);
}
```





