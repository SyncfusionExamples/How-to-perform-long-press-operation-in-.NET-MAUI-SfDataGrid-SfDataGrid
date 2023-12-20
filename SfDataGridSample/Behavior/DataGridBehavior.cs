using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample.Behaviors
{
    public class DataGridBehavior : Behavior<SfDataGrid>
    {
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
    }
}
