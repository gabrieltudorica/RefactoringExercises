using System.Collections.Generic;
using System.Configuration;

namespace TicTacToe.Game
{
    public class SymbolTypeConverter
    {
        private readonly Dictionary<SymbolTypes, string> stringSymbols;

        public SymbolTypeConverter()
        {
            stringSymbols = new Dictionary<SymbolTypes, string>
                                {
                                    {SymbolTypes.Cross, ConfigurationManager.AppSettings["NoughtSymbol"]},
                                    {SymbolTypes.Nought, ConfigurationManager.AppSettings["CrossSymbol"]},
                                    {SymbolTypes.Uninitialized, string.Empty}
                                };
        }

        public string GetString(SymbolTypes symbol)
        {
            return stringSymbols[symbol];
        }
    }
}
