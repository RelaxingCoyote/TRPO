using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApp.Models
{
    public class Journal
    {
        // ID журнала
        public int Id { get; set; }
        // название журнала
        public string Name { get; set; }
        // издатель журнала
        public string Publisher { get; set; }
        // выпуск
        public string Issue { get; set; }
        // дата
        public DateTime PubDate { get; set; }
    }
}