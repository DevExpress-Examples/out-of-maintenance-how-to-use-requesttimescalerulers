Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm.Gantt

Namespace DXGridSample

    Public Class ProjectTaskViewModel

        Public Property Tasks As ObservableCollection(Of GanttTask)

        Public Sub New()
            Tasks = New ObservableCollection(Of GanttTask) From {New GanttTask() With {.Id = 0, .Name = "Add a new feature", .StartDate = Date.Now.AddDays(-1), .FinishDate = Date.Now.AddDays(6)}, New GanttTask() With {.Id = 1, .ParentId = 0, .Name = "Write the code", .StartDate = Date.Now.AddDays(-1), .FinishDate = Date.Now.AddDays(2)}, New GanttTask() With {.Id = 2, .ParentId = 0, .Name = "Write the docs", .StartDate = Date.Now.AddDays(2), .FinishDate = Date.Now.AddDays(5)}, New GanttTask() With {.Id = 3, .ParentId = 0, .Name = "Test the new feature", .StartDate = Date.Now.AddDays(2), .FinishDate = Date.Now.AddDays(5)}, New GanttTask() With {.Id = 4, .ParentId = 0, .Name = "Release the new feature", .StartDate = Date.Now.AddDays(5), .FinishDate = Date.Now.AddDays(6)}}
        End Sub
    End Class
End Namespace
