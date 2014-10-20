using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TentaOOADClassLibrary
{
    public class Utryckning
    {
        private TopCrimeSystem mediator;
        public Utryckning(TopCrimeSystem mediator)
        {
            this.mediator = mediator;
            this.mediator.RegisterUtryckning(this);
        }

        public object ReadTopCrime()
        {
            IScreenscraping utryckning = new Scraping.Utryckning();
            string headLine = utryckning.Get();
            mediator.TopCrime(headLine);
            return headLine;
        }
    }
}
