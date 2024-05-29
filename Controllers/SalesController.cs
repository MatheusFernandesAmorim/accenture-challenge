using AccentureChallenge.UI.CQRS.Models;
using AccentureChallenge.UI.CQRS.Resources.Command;
using AccentureChallenge.UI.CQRS.Resources.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AccentureChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SalesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region Task 1: Api Development
        /// <summary>
        /// Method that returns all sales
        /// </summary>
        /// <returns>A list of all sales stored</returns>
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Sales>>> GetAll()
        {
            try
            {
                var command = new GetAllQuery();
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Method that returns a specific sale based on the Id
        /// </summary>
        /// <param name="id">Parameter that represent the id must be removed</param>
        /// <returns>A specific sale</returns>
        [HttpGet]
        [Route("GetById")]
        public async Task<ActionResult<Sales>> GetById([FromQuery, Required, NotNull] int id)
        {
            try
            {
                var command = new GetByIdQuery { Id = id };
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Method that add a sale
        /// </summary>
        /// <param name="command">Parameter that represents a sale must be inserted</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult<Sales>> Add([FromBody] AddCommand command)
        {
            try
            {
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Method that update a sale
        /// </summary>
        /// <param name="command">Parameter that represents a sale must be updated</param>
        /// <returns></returns>
        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<Sales>> Update([FromBody] UpdateCommand command)
        {
            try
            {
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Method that remove a sale
        /// </summary>
        /// <param name="id">Parameter that represent the id must be removed</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult<Sales>> Delete([FromQuery, Required, NotNull] int id)
        {
            try
            {
                var command = new DeleteCommand { Id = id };
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
    }
}
