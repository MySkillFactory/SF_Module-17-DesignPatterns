using System;
namespace ObserverRealExample
{
    /// <summary>
    /// Модель данных, которые наблюдатели могли бы получать с биржи. 
    /// курс доллара и евро в рублях
	/// </summary>
	class StockData
    {
        public int USD { get; set; }
        public int Euro { get; set; }
    }
}

