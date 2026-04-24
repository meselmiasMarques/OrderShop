using OrderManagement.Core.Domain;
using OrderManagement.Core.Requests.Customer;
using OrderManagement.Core.Responses;

namespace OrderManagement.Core.Handlers;

public interface ICustomerHandlers
{
    Task<Response<T>> GetByIdCustomer<T>(GetByIdCustomerRequest request);
    Task<Response<T>> CreateCustomer<T>(CreateCustomerRequest request);
    Task<Response<T>> UpdateCustomer<T>(int id,UpdateCustomerRequest request);
    Task<Response<T>> DeleteCustomer<T>(DeleteCustomerRequest request);
    Task<Response<List<Customer>>> GetAllCustomers();
}