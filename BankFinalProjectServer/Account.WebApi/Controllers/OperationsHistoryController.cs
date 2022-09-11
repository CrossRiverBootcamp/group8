﻿namespace CustomerAccount.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OperationsHistoryController : ControllerBase
{
    private readonly IOperationsHistoryService _operationsHistoryService;
    public OperationsHistoryController(IOperationsHistoryService operationsHistoryService)
    {
        _operationsHistoryService = operationsHistoryService;
    }

    [HttpGet]
    [Route("GetOperationsHistories/{accountID}/{pageSize}/{page}")]
    public async Task<ActionResult<OperationDataListDTO>> GetOperationsHistories(int accountID, int pageSize, int page)
    {
        try
        {
            return Ok(await _operationsHistoryService.GetOperationsHistories(accountID, pageSize, page));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

}