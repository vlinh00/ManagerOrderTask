using AT.Server.Data;
using AT.Share.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AT.Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchOrderController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpClientFactory _httpClientFactory;
        string ApiKey = "S4AwIQJXCnwjdsFYNkdmhjZopBubDQ";
        public SearchOrderController(ApplicationDbContext context, IHttpClientFactory httpClientFactory)
        {
            _context = context;
            _httpClientFactory = httpClientFactory;
        }

        private async Task<Order> GetOrderByCodeDetails(string orderCode)
        {
            var apiUrlOrder = $"https://atpro.getflycrm.com/api/v3/orders?order_type=2";

            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("X-API-KEY", ApiKey); // Thêm header API-Key vào yêu cầu

            var response = await client.GetAsync(apiUrlOrder);

            if (response.IsSuccessStatusCode)
            {
                // Đọc dữ liệu từ phản hồi
                var jsonResponse = await response.Content.ReadAsStringAsync();
                // Chuyển đổi chuỗi JSON thành OrderResponse
                var orderResponse = JsonSerializer.Deserialize<OrderResponse>(jsonResponse, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true // Để không phân biệt chữ hoa chữ thường
                });
                var result = orderResponse.Records.Where(order => order.OrderCode == orderCode).ToList();

                if (result.Count > 0)
                {
                    return result[0];
                }
                return null;             
            }
            else
            {
                return null;
            }
        }

        // GET: api/<SearchOrderController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SearchOrderController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderByCode(string id)
        {
            var result = await GetOrderByCodeDetails(id);

            if (result == null)
            {
                return NotFound($"No orders found with OrderId: {id}");
            }

            return Ok(result);
        }
        // POST api/<SearchOrderController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SearchOrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SearchOrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
