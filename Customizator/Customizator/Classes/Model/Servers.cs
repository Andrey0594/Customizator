using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customizator.Classes.Model
{
    /// <summary>
    /// Класс Сервер. Таблица в БД-Servers
    /// </summary>
    [Table("Servers")]
    public class Servers
    {
        /// <summary>
        /// ID сервера БД
        /// </summary>
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// Адрес сервера БД
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// ID типа БД
        /// </summary>

        public int? DbTypeID { get; set; }       
        /// <summary>
        /// Порт для подключения к БД
        /// </summary>
        public string Port { get; set; }
        /// <summary>
        /// Имя пользователя для подключения к БД
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// Пароль для подключения к БД
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Название БД
        /// </summary>
        public string DbName { get; set; }
        /// <summary>
        /// Является ли сервер текущим
        /// </summary>
        [Column("IsCurrent")]
        public string IsCurrent { get; set; }

        /// <summary>
        /// Тип базы данных
        /// </summary>
        [ForeignKey("DbTypeID")]
        public DbTypes DbType { get; set; }
    }
}
