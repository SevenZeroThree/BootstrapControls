BootstrapControls
=================

A proof of concept for an ASP.NET control suite that utilizes Twitter Bootstrap

Automatically adds standard css classes and exposes properties to allow for easy additions of common bootstrap classes

MVC
===
Button
---
``` html
@Html.BootstrapButton("Default")
@Html.BootstrapButton("Danger", ButtonType.Danger)
@Html.BootstrapButton("PLUS", Glyphicon.PLUS)
```

Web Forms
=======

Button
----------
Property  | Description
------------- | -------------
ButtonType  | Gets or sets the value for the kind of button. Corresponds directly to the standard [bootstrap button options](http://getbootstrap.com/css/#buttons-options)
ButtonSize  | Gets or sets the value for the size of the button. Corresponds to the [bootstrap button sizes](http://getbootstrap.com/css/#buttons-sizes)

``` html
<bootstrap:Button 
    ButtonType="Default|Primary|Success|Info|Warning|Danger|Link"
    ButtonSize="Default|Large|Small|ExtraSmall">
</bootstrap:Button>
```

Table
----------
Property  | Description
------------- | -------------
Striped  | Gets or sets the value for whether the table has the striped style. Corresponds to the [*table-striped*](http://getbootstrap.com/css/#tables-striped) CSS class
Bordered  | Gets or sets the value for whether the table has the bordered style. Corresponds to the [*table-bordered*](http://getbootstrap.com/css/#tables-bordered) CSS class
HoverRows  | Gets or sets the value for whether the table rows have a hover state. Corresponds to the [*table-hover*](http://getbootstrap.com/css/#tables-hover-rows) CSS class
Condensed  | Gets or sets the value for whether the table rows are compacted. Corresponds to the [*table-condensed*](http://getbootstrap.com/css/#tables-condensed) CSS class

``` html
<bootstrap:Table
    Striped="True|False" 
    HoverRows="True|False" 
    Condensed="True|False" 
    Bordered="True|False">
</bootstrap:Table>
```

GridView
--------
Property  | Description
------------- | -------------
Striped  | Gets or sets the value for whether the table has the striped style. Corresponds to the [*table-striped*](http://getbootstrap.com/css/#tables-striped) CSS class
Bordered  | Gets or sets the value for whether the table has the bordered style. Corresponds to the [*table-bordered*](http://getbootstrap.com/css/#tables-bordered) CSS class
HoverRows  | Gets or sets the value for whether the table rows have a hover state. Corresponds to the [*table-hover*](http://getbootstrap.com/css/#tables-hover-rows) CSS class
Condensed  | Gets or sets the value for whether the table rows are compacted. Corresponds to the [*table-condensed*](http://getbootstrap.com/css/#tables-condensed) CSS class

``` html
<bootstrap:GridView
    Striped="True|False" 
    HoverRows="True|False"
    Bordered="True|False"
    Condensed="True|False">
</bootstrap:GridView>
```
