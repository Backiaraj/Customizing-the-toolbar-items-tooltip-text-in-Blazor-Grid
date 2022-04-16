using System;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace ServerApp.Data
{
    public class ContactAgenda
    {
        public ContactAgenda()
        {

        }

        public ContactAgenda(int id, string contactId, string agendaDescription, ContactAgendaType type, ContactAgendaCategory category, string value, int order)
        {
            Id = id;
            ContactId = contactId;
            AgendaDescription = agendaDescription;
            Type = type;
            Category = category;
            Value = value;
            Order = order;
        }

        public int Id { get; set; }
        public string ContactId { get; set; }
        public string AgendaDescription { get; set; }
        public ContactAgendaType Type { get; set; }
        public ContactAgendaCategory Category { get; set; }
        public string Value { get; set; }
        public int Order { get; set; }
    }


    public class ContactAgendaType
    {
        public ContactAgendaType()
        {

        }

        public ContactAgendaType(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; set; }
        public string Description { get; set; }
    }


    public class ContactAgendaCategory
    {
        public ContactAgendaCategory()
        {

        }

        public ContactAgendaCategory(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; set; }
        public string Description { get; set; }
    }
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class Order
    {
        public int? EmployeeID { get; set; }
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public double Freight { get; set; }
    }

    public class AppUser : IdentityUser
    {
        public int? OrderID { get; set; }
        /// <summary>    
        /// Gets or sets a FirstName for the user.    
        /// </summary>    
        [ProtectedPersonalData]
        [Display(Name = "Имя")]
        public virtual string FirstName { get; set; }

        /// <summary>    
        /// Gets or sets a LastName for the user.    
        /// </summary>      
        [ProtectedPersonalData]
        [Display(Name = "Фамилия")]
        public virtual string LastName { get; set; }
        public AppUser() { }
    }
    public class Training
    {
        /// <summary>
        /// The Guid of the Training
        /// </summary>
        [Display(Name = "Guid")]
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// The department/organization that is hosting the program/training
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string Host { get; set; } = "ATS";

        /// <summary>
        /// The name of the program/training
        /// </summary>
        [Required(ErrorMessage = "Program name is required")]
        [MaxLength(150)]
        [Display(Name = "Program")]
        public string Name { get; set; }

        /// <summary>
        /// The start date of the program/training
        /// </summary>
        [Required(ErrorMessage = "Start date is required")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; } = DateTime.Today;

        /// <summary>
        /// The start date of the program/training
        /// </summary>
        [Required(ErrorMessage = "End date is required")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; } = DateTime.Today;

        /// <summary>
        /// The name of the facilitator of the program/training
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string Facillitator { get; set; } = "Unknown";

        /// <summary>
        /// The stipend amount that will be given to the
        /// training/program participant upon completion
        /// </summary>
        [Required]
        [Range(0, 10000, ErrorMessage = "Stipend value entered should between 0 and 10000")]
        [Display(Name = "Stipend One")]
        public int StipendAmountOne { get; set; } = 0;

        /// <summary>
        /// Additional optional stipend
        /// </summary>
        [Range(0, 10000, ErrorMessage = "Stipend value entered should between 0 and 10000")]
        [Display(Name = "Stipend Two")]
        public int StipendAmountTwo { get; set; } = 0;

        /// <summary>
        /// Additional optional stipend
        /// </summary>
        [Range(0, 10000, ErrorMessage = "Stipend value entered should between 0 and 10000")]
        [Display(Name = "Stipend Three")]
        public int StipendAmountThree { get; set; } = 0;

    }
}
