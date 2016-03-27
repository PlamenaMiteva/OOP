using System;
using System.Linq;

namespace CompanyHierarchy.Models
{
    using System.Collections.Generic;
    using System.Text;
    using CompanyHierarchy.Interfaces;

    public class Developer : Employee, IDeveloper
    {
        private List<Project> projects;

        public Developer(int id, string fname, string lname, decimal salary, Department department)
            : base(id, fname, lname, salary, department)
        {
            this.projects = new List<Project>();
        }

        public IEnumerable<Project> Projects
        {
            get { return this.projects; }
        }

        public void AddProject(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException("Project cannot be null.");
            }
            if (this.projects.Any(p=>p.ProjectName==project.ProjectName))
            {
                throw new ArgumentException("Project already exists in developer's projects.");
            }
            this.projects.Add(project);
        }

        public void CloseProject(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException("Project cannot be null.");
            }
            if (project.State=="Closed")
            {
                throw new ArgumentException("This project is already closed.");
            }
            project.State = "Closed";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Department + " Department - " + this.Id + " - " + this.FirstName + " " + this.LastName + " - " + this.Salary + " BGN" + System.Environment.NewLine);
            if (this.Projects.Any())
            {
                result.Append("Projects:" + System.Environment.NewLine);
                foreach (var project in this.Projects)
                {
                    result.Append(project.ProjectName + " - " + project.StartDate + " - " + project.Details + " - " + project.State + System.Environment.NewLine);
                }
            }
            else
            {
                result.Append("No Projects");
            }
            return result.ToString();
        }
    }
}
