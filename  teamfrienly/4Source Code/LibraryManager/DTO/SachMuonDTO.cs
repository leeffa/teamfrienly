using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
  public  class SachMuonDTO
    {
        private int mamuonsach;
        public int MaMuonSach
        {
            get { return mamuonsach; }
            set { mamuonsach = value; }
        }
        public SachMuonDTO()
        {
            mamuonsach = 0;
        }
    }
}
