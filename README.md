# Xamarin Switch (SfSwitch) 

The Switch control for Xamarin.Forms provides an efficient way to select between the states based on the toggled value.

For know more details about Switch: https://www.syncfusion.com/xamarin-ui-controls/xamarin-switch

Switch user guide documentation: https://help.syncfusion.com/xamarin/switch/gettingstarted

## Getting Started with Xamarin Switch (SfSwitch)
This section explains you the steps to add the SfSwitch control with basic functionalities in Xamarin.Forms.

## Assembly deployment
After installing Essential Studio for Xamarin, you can find all the required assemblies in the installation folders, {Syncfusion Essential Studio Installed location} \Essential Studio\{Version #}\Xamarin\lib.

## Adding SfSwitch reference
You can add SfSwitch reference using one of the below methods.

## Method 1: Adding SfSwitch reference from nuget.org

Syncfusion Xamarin components are available in nuget.org. To add SfSwitch to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Xamarin.Core, and then install it.

## Method 2: Adding SfSwitch reference from toolbox

Syncfusion provides Xamarin Toolbox. Using this toolbox, you can drag the SfSwitch control to the XAML page. It will automatically install the required NuGet packages and add the namespace to the page. To install Syncfusion Xamarin Toolbox, refer to Toolbox.

## Method 3: Adding SfSwitch assemblies manually from the installed location

If you prefer to manually reference the assemblies instead referencing from NuGet, add the following assemblies in respective projects.

Location: {Installed location}/{version}/Xamarin/lib

## Initializing SfSwitch
Import the Button namespace as shown below in your respective Page,

**[XAML]**
```
xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Buttons;assembly=Syncfusion.Buttons.XForms"
```
Then initialize the switch control as shown below using the code example.

**[XAML]**
```
<syncfusion:SfSwitch />
```
## Performing an action based on state
You can switch between the states. When the state is changed the StateChanging and StateChanged event will be triggered where you can perform an action based on the current state.The StateChanging event allows you to cancel moving to a new state.

The following code example displays a message box when switched to off state when work is completed.

**[XAML]**
```
<syncfusion:SfSwitch StateChanged="SfSwitch_StateChanged" />
```
**[C#]**
```
private void SfSwitch_StateChanged(object sender, SwitchStateChangedEventArgs e)
{
     DisplayAlert("Message", "SUCCESS", "OK");
}
```

## How to run this application?

To run this application, you need to first clone the xamarin-forms-sfswitch repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.