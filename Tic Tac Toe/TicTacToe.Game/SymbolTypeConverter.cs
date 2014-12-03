using System.Collections.Generic;
using System.Configuration;

namespace TicTacToe.Game
{
    public class SymbolTypeConverter
    {
        private readonly Dictionary<SymbolType, string> stringSymbols;

        public SymbolTypeConverter()
        {
            stringSymbols = new Dictionary<SymbolType, string>
                                {
                                    {SymbolType.Cross, ConfigurationManager.AppSettings["CrossSymbol"]},
                                    {SymbolType.Nought, ConfigurationManager.AppSettings["NoughtSymbol"]},                                    
                                    {SymbolType.Uninitialized, string.Empty}
                                };
        }

        public string GetString(SymbolType symbol)
        {
            return stringSymbols[symbol];
        }
    }
}
