﻿using GameStore.BL.Interfaces;
using GameStore.DL.Interfaces;
using GameStore.DL.Repositories;
using GameStore.Models.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.BL.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public void Add(Genre genre)
        {
            _genreRepository.Add(genre);
        }

        

        public List<Genre> GetAll()
        {
            return _genreRepository.GetAll();
        }

        public Genre GetById(int id)
        {
            return _genreRepository.GetById(id);
        }

        public void Update(Genre genre)
        {
            _genreRepository.Update(genre);
        }
        public void Remove(int id)
        {
            _genreRepository.Remove(id);
        }

       
    }
}
