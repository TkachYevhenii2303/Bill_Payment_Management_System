using Bill_Payment_System_BLL.Business_Services.Interfaces;
using Bill_Payment_System_DTO.Data_transfer_objects.Request_Result_DTO;
using Bill_Payment_System_DTO.Data_transfer_objects.Response_Result_DTO;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Bill_Payment_System_API.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersServices _CustomerServices;

        public CustomersController(ICustomersServices customerServices)
        {
            _CustomerServices = customerServices;
        }

        [HttpGet, Route("Get_all_Customers")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<GetCustomersDTO>>> GetAllCustomersAsync()
        {
            try
            {
                var result = await _CustomerServices.GetAllCustomersAsync();
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpGet, Route("Get_the_Customers_ID")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetCustomersDTO>> GetCustomerByIDAsync(Guid ID)
        {
            try
            {
                var result = await _CustomerServices.GetCustomersByIdAsync(ID);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpPost, Route("Insert_the_Customers")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetCustomersDTO>> InsertCustomersAsync(InsertCustomersDTO newCustomers)
        {
            try
            {
                var result = await _CustomerServices.InsertCustomerAsync(newCustomers);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpPut, Route("Update_the_Customers")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetCustomersDTO>> UpdateCustomersAsync(UpdateCustomersDTO updateCustomers)
        {
            try
            {
                var result = await _CustomerServices.UpdateCustomerAsync(updateCustomers);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpDelete, Route("Delete_the_Customers_ID")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetCustomersDTO>> DeleteCustomerByIdAsync(Guid ID)
        {
            try
            {
                var result = await _CustomerServices.DeleteCustomersAsync(ID);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpGet, Route("Get_the_Customers_with_all_Informations_ID")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetCustomerWithAllInformation>> GetCustomerWithAllInformationByIdAsync(Guid ID)
        {
            try
            {
                var result = await _CustomerServices.GetCustomerWithAllInformationByIdAsync(ID);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }
    }
}
