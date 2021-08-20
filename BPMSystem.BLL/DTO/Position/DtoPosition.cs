﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMSystem.BLL.DTO.Position
{
    /// <summary>
    /// DTO модель для получения должностей
    /// </summary>
    public class DtoPosition
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// Наименование должности
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Title { get; set; }
    }
}
