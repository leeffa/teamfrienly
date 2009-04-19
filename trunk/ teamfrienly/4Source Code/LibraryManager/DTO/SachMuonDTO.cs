using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
  public  class SachMuonDTO
    {
      private int stt;
        private int mamuonsach;
      public int MaMuonSach
      {
          get { return mamuonsach; }
          set { mamuonsach = value; }
      }
      public int STT
      {
          get { return stt; }
          set { stt = value; }
      }
        public SachMuonDTO()
        {
            mamuonsach = 0;
            stt = 0;
        }

    }
}
