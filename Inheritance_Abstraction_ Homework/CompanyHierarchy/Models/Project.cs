namespace CompanyHierarchy.Models
{
    using System;

    public class Project
    {
        private string projectName;
        private DateTime startDate;
        private string details;

        public Project(string projectName, DateTime startDate, string details)
        {
            this.ProjectName = projectName;
            this.Details = details;
            this.StartDate = startDate;
            this.State = "Open";
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The project name field cannot be empty.");
                }
                else
                {
                    this.projectName = value;
                }

            }
        }

        public DateTime StartDate { get; set; }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The details field cannot be empty.");
                }
                else
                {
                    this.details = value;
                }

            }
        }

        public string State { get; set; }

        public void CloseProject()
        {
            this.State = "Closed";
        }
    }
}
