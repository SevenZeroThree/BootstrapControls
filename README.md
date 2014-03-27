BootstrapControls
=================

A proof of concept for an ASP.NET control suite that utilizes Twitter Bootstrap

Automatically adds standard css classes and exposes properties to allow for easy additions of common bootstrap classes

Buttons
----------
Property  | Description
------------- | -------------
ButtonType  | Gets or sets the value for the kind of button. Corresponds directly to the standard [bootstrap button options](http://getbootstrap.com/css/#buttons-options)
ButtonSize  | Gets or sets the value for the size of the button. Corresponds to the [bootstrap button sizes](http://getbootstrap.com/css/#buttons-sizes)
``` html
<bootstrap:Button 
    ButtonType="Default|Primary|Success|Info|Warning|Danger|Link"
    ButtonSize="Default|Large|Small|ExtraSmall"></bootstrap:Button>
```
