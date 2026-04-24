using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Core.Requests.Customer;

public record CreateCustomerRequest(
 [Required(ErrorMessage = "Name is required")]
 string Name,
 [Required(ErrorMessage = "Email is required")]
 [EmailAddress(ErrorMessage = "Invalid Email Address")]
 string Email 
);