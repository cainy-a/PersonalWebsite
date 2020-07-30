﻿using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;
using System.Collections.Generic;

namespace PersonalWebsite.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult VectorGallery()
        {
            var artworks = new List<Artwork>
            {
                new Artwork("Main Avatar", "/abstract_art/vector/avatar/avatar.svg", "/abstract_art/bitmap/avatar/avatar.png", 2000, 2000),
                new Artwork("Dark Avatar", "/abstract_art/vector/avatar/avatar_dark.svg", "/abstract_art/bitmap/avatar/avatar_dark.png", 2000, 2000),
                new Artwork("High Contrast Avatar", "/abstract_art/vector/avatar/avatar_contrast.svg", "/abstract_art/bitmap/avatar/avatar_contrast.png", 2000, 2000),
                new Artwork("Abstract 1", "/abstract_art/vector/abstract-1.svg", "/abstract_art/bitmap/abstract-1.png", 2000, 2000),
                new Artwork("Abstract 2", "/abstract_art/vector/abstract-2.svg", "/abstract_art/bitmap/abstract-2.png", 2000, 2000),
                new Artwork("Abstract 3", "/abstract_art/vector/abstract-3.svg", "/abstract_art/bitmap/abstract-3.png", 2000, 2000),
                new Artwork("Mashup: Chaos", "/abstract_art/vector/mashups/chaos.svg", "/abstract_art/bitmap/mashups/chaos.png", 4000, 4000)
            };

            var vm = new VectorGalleryViewModel { Artworks = artworks };

            return View(vm);
        }
    }
}
