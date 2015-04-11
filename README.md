# GridView Like Facebook

To keep it simple I wanted a Gridview that did the samething as the one in the application facebook did.  What i mean by this is that when the user scrolls down the top navigation menu hides its self and when the user scrolls up the menu shows it self again and if the users scrolls down it hides it self again.

I did not find any toolkits that already had this feature so naturally being a developer I built one.
This code only works for Windows Phone 8.1 WinRT apps. 

##App1
the converter that allows you to modifiy the margin of the top bar is called ScrollToMarginConverter, in app1 you will find that you will be able to ease in and ease out the top navigation bar.  However that is not what I wanted to do at first!

So I created App2

##App2

This app is a Simple app that has the same list as App1 and has 2 bottom buttons that are linked to Storyboards animations that will show and hide the top bar navigation.

here is the Storyboard code n the XAML page:

```
<Storyboard x:Name="HideTopNavStoryboard">
    <DoubleAnimation Duration="0:0:0.3"
                     To="-140"
                     Storyboard.TargetProperty="(UIElement.RenderTransform).(CompositeTransform.TranslateY)" 
                     Storyboard.TargetName="NavStackPanel" 
                     d:IsOptimized="True"/>
    <DoubleAnimation Duration="0:0:0.3"
                     To="0"
                     Storyboard.TargetProperty="Opacity" 
                     Storyboard.TargetName="NavStackPanel" 
                     d:IsOptimized="True"/>
</Storyboard>
<Storyboard x:Name="ShowTopNavStoryboard">
    <DoubleAnimation Duration="0:0:0.3" 
                     To="0" 
                     Storyboard.TargetProperty="(UIElement.RenderTransform).(CompositeTransform.TranslateY)" 
                     Storyboard.TargetName="NavStackPanel" 
                     d:IsOptimized="True"/>
    <DoubleAnimation Duration="0:0:0.3"
                     To="1"
                     Storyboard.TargetProperty="Opacity" 
                     Storyboard.TargetName="NavStackPanel" 
                     d:IsOptimized="True"/>
</Storyboard>
```

well this App is again not what I wanted, because having to click on a button to hide or show my nav is not very practical...  So I create App3.

## App3
is ungoing
