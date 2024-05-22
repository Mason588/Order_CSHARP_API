using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Order.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        //用方法去CRUD
        [HttpPost]
        public IActionResult CreateOrder([FromBody] Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // 模擬保存訂單 (實際應該保存到數據庫)
                int orderId = SaveOrderToDatabase(order);

                return CreatedAtAction(nameof(GetOrder), new { id = orderId }, new { orderId });
            }
            catch (Exception ex)
            {
                // 捕捉異常並返回錯誤信息
                return StatusCode(500, new { error = ex.Message });
            }
        }

        // 假設有一個GetOrder方法來獲取訂單詳情
        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            // 獲取訂單邏輯
            return Ok();
        }

        private int SaveOrderToDatabase(Order order)
        {
            // 模擬保存到數據庫並返回新訂單的ID
            // 實際實現會涉及到數據庫操作
            return 1;
        }

    }
}