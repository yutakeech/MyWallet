using System;
using System.Collections.Generic;

namespace Data
{
    public class CurrencyList
    {
        public IList<Currency> List { get; set; }
        
        public CurrencyList(params string[] names)
        {
            foreach (var name in names)
            {
                var currency = new Currency() {Name = name, ExchangeRate = 0};
                this.List.Add(currency);
            }
        }
        
        // Добавляем индексактор, чтобы иметь возможность обратиться к конкретной валюте
        public Currency this[int index] => this.List[index];
        // Поиск по названию
        public Currency this[string name] => this.FindCurrencyByName(name);

        public Currency FindCurrencyByName(string currencyName)
        {
            foreach (var currency in this.List)
            {
                if (String.Equals(currency.Name, currencyName))
                {
                    return currency;
                }
            }

            return null;
        }
    }
}