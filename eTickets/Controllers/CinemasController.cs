﻿using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
	public class CinemasController : Controller
	{
		private readonly AppDbContext _context;

		public CinemasController(AppDbContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			var allCinemas =await _context.Cinemas.ToListAsync();
			return View(allCinemas);
		}
	}
}
