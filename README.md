# How to perform long press operation in .NET MAUI SfDataGrid SfDataGrid
You can execute long-press operations in the [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) by subscribing to the [SfDataGrid.CellLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellLongPress) event.

Please refer to the code example below, where the `SfDataGrid` is loaded, and the `CellLongPress` event is hooked.

##### xaml:
 ```XML
 <syncfusion:SfDataGrid DefaultColumnWidth="153"
                       AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding Employees}">

    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="EmployeeID"
                                       HeaderText="Employee ID" />
        <syncfusion:DataGridTextColumn MappingName="Name"
                                       HeaderText="Name" />
        <syncfusion:DataGridTextColumn MappingName="IDNumber"
                                       HeaderText="ID Number" />
    </syncfusion:SfDataGrid.Columns>

    <syncfusion:SfDataGrid.Behaviors>
        <behaviors:DataGridBehavior />
    </syncfusion:SfDataGrid.Behaviors>

</syncfusion:SfDataGrid>
 ```
 

##### behavior:
 
 ```XML
protected override void OnAttachedTo(SfDataGrid dataGrid)
{
    dataGrid.CellLongPress += DataGrid_CellLongPress;
    base.OnAttachedTo(dataGrid);
}

private void DataGrid_CellLongPress(object? sender, DataGridCellLongPressEventArgs e)
{
    Page currentPage = GetParentPage((View)sender);
    currentPage.DisplayAlert("Notification","Cell Long Pressed", "Cancel");
}

protected override void OnDetachingFrom(SfDataGrid dataGrid)
{
    dataGrid.CellLongPress -= DataGrid_CellLongPress;
    base.OnDetachingFrom(dataGrid);
}
private Page GetParentPage(View view)
{
    Element parent = view.Parent;

    while (parent != null)
    {
        if (parent is Page page)
        {
            return page;
        }
        parent = parent.Parent;
    }
    return null;
}
 ```
 

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-perform-long-press-operation-in-.NET-MAUI-SfDataGrid-SfDataGrid/tree/master)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

##### Conclusion

I hope you enjoyed learning about How to perform long press operation in .NET MAUI SfDataGrid (SfDataGrid).

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components. 

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!
