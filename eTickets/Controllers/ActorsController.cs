﻿using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
	public class ActorsController : Controller
	{
		private readonly AppDbContext _context;

		public ActorsController(AppDbContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			var result =await _context.Actors.ToListAsync();
			return View(result);
		}

		public IActionResult Test()
		{
			return View();
		}
	}
}
