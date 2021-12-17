using E_health.Data;
using E_health.Services.Dependencies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_health.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _db;

        private readonly IPostService _postService;
        private readonly ICommentService _commentService;

        public PostController(ApplicationDbContext db, IPostService postService, ICommentService commentService
            )
        {
            _db = db;
            _postService = postService;
            _commentService = commentService;
        }

        [HttpGet]
        public string Test()
        {
            return "chcahcah";
        }
    }
}
