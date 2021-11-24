using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCell
{
    // TODO this might be a good spot of the shuffle function - will need to decide how we use this class better, already an improvement.
    public static class CardPannels
    {
        private static List<GamePanel> cardPanels = new List<GamePanel>(); //Store tableau panels
        private static List<FreeCellCardPanel> freecellCardPanels = new List<FreeCellCardPanel>(); //Store freecell panels
        private static List<HomeCellCardPanel> homecellCardPanels = new List<HomeCellCardPanel>(); //Store homecell panels
        private static int EmptyFreeCells = 4;
        private static int CompletedHomecells = 0;

        public static int GetEmtpyFreecells
        {
            get { return EmptyFreeCells; }
        }

        public static int GetCompletedHomecells
        {
            get { return CompletedHomecells;  }
        }
       
        public static List<GamePanel> GetListOfCardPannels
        {
            get { return cardPanels; }
        }

        public static List<FreeCellCardPanel> GetListOfFreeCellPannels
        {
            get { return freecellCardPanels; }
        }

        public static List<HomeCellCardPanel> GetListOfHomeCellPannels
        {
            get { return homecellCardPanels; }
        }

    }
}
