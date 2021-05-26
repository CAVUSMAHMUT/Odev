using Odev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Odev.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaings campaing);
        void Delete(Campaings campaing);
        void Update(Campaings campaing);
    }
}
