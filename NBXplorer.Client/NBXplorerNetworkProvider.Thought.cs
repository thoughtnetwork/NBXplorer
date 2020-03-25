using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitThought(NetworkType networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Thought.Instance, networkType)
			{
				MinRPCVersion = 180000,
				CoinType = networkType == NetworkType.Mainnet ? new KeyPath("502'") : new KeyPath("1'")
			});
		}

		public NBXplorerNetwork GetThought()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.Thought.Instance.CryptoCode);
		}
	}
}
