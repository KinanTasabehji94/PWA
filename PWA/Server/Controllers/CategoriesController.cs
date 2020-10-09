﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PWA.Server.Models;
using PWA.Shared.Entities;

namespace PWA.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CategoriesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return await context.Category.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(int id)
        {
            var category = await context.Category.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null) { return NotFound(); }
            return category;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Category category)
        {
            context.Add(category);
            await context.SaveChangesAsync();
            return category.Id;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Category category)
        {
            context.Attach(category).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var category = await context.Category.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            context.Remove(category);
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
