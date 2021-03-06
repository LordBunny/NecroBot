﻿using System.ComponentModel.DataAnnotations;

namespace PoGo.NecroBot.Logic.Model
{
    public class PokemonTimestamp
    {
        public int Id { get; set; }
        [Required]
        public long Timestamp { get; set; }
        public virtual Account Account { get; set; }
    }
}
