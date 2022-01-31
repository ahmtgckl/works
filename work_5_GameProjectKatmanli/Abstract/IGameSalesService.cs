using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_5_GameProjectKatmanli.Entity;

namespace work_5_GameProjectKatmanli.Abstract
{
    internal interface IGameSalesService
    {
        void Sales(Game game);
        void CampaignSales(Game game);
    }
}
