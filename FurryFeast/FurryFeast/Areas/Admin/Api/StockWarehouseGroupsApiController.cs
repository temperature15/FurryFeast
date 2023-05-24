﻿using FurryFeast.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FurryFeast.Areas.Admin.Api {
	[Route("api/StockWarehouseGroupsApiController/[action]")]
	[ApiController]
	public class StockWarehouseGroupsApiController : ControllerBase {
		private db_a989fb_furryfeastContext _context;

		public StockWarehouseGroupsApiController(db_a989fb_furryfeastContext context) {
			_context = context
		}

		[HttpGet]
		public async Task<object> GetAll() {
			if (_context.StockWarehouseGroups == null) {
				return NotFound();
			} else {

			}
		}
	}
}
