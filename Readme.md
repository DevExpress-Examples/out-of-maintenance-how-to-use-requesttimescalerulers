<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/237431245/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T859828)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to create custom timescale rulers with captions that depend on the current zoom level


**GanttView** provides the [RequestTimescaleRulers](https://docs.devexpress.com/WPF/DevExpress.Xpf.Gantt.GanttView.RequestTimescaleRulers) event where you can specify custom timescale rulers. In this example, we used a custom [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider) implementation to format captions depending on the current zoom level.
