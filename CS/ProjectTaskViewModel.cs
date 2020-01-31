using System;
using System.Collections.ObjectModel;
using DevExpress.Mvvm.Gantt;

namespace DXGridSample {
    public class ProjectTaskViewModel {
        public ObservableCollection<GanttTask> Tasks { get; set; }
        public ProjectTaskViewModel() {
            Tasks = new ObservableCollection<GanttTask> {
                new GanttTask() {
                    Id = 0,
                    Name = "Add a new feature",
                    StartDate = DateTime.Now.AddDays(-1),
                    FinishDate = DateTime.Now.AddDays(6)
                },
                new GanttTask() {
                    Id =1,
                    ParentId = 0,
                    Name = "Write the code",
                    StartDate = DateTime.Now.AddDays(-1),
                    FinishDate = DateTime.Now.AddDays(2)
                },
                new GanttTask() {
                    Id = 2,
                    ParentId = 0,
                    Name = "Write the docs",
                    StartDate = DateTime.Now.AddDays(2),
                    FinishDate = DateTime.Now.AddDays(5)
                },
                new GanttTask() {
                    Id = 3,
                    ParentId = 0,
                    Name = "Test the new feature",
                    StartDate = DateTime.Now.AddDays(2),
                    FinishDate = DateTime.Now.AddDays(5)
                },
                new GanttTask() {
                    Id = 4,
                    ParentId = 0,
                    Name = "Release the new feature",
                    StartDate = DateTime.Now.AddDays(5),
                    FinishDate = DateTime.Now.AddDays(6),
                }
            };
        }
    }
}